﻿using Bioscoop.Api.Extensions;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly IShowRepository showRepository;

        public ShowController(IShowRepository showRepository)
        {
            this.showRepository = showRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShowDto>>> GetShows()
        {
            try
            {
                var shows = await this.showRepository.GetShows();

                if (shows == null)
                {
                    return NotFound();
                }
                else
                {
                    var showDtos = shows.ConvertToDto();
                    return Ok(showDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ShowDto>> GetShow(int id)
        {
            try
            {
                var show = await this.showRepository.GetShow(id);

                if (show == null)
                {
                    return BadRequest();
                }
                else
                {
                    var showDto = show.ConvertToDto();
                    return Ok(showDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
