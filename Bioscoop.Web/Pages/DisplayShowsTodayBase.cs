﻿using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class DisplayShowsTodayBase : ComponentBase
    {
        [Parameter]
#pragma warning disable CS8618 // Non-nullable property 'Shows' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public IEnumerable<ShowDto> Shows { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Shows' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}