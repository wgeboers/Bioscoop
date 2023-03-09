//aanpassing  IShowService


    //get alle shows
    List<ShowDto> GetAllShows();  

    // get show met minst beschikbare stoelen.
        ShowDto GetShowWithLeastAvailableSeats()




//aanpassingen ITicketService

    // get alle tickets
           List<TicketDto> GetAllTickets();
   int GetTicketCountByShowId(int showId);


// toevoeging ShowService

   int minSeats = GetAllShows()
    .Where(s => GetTicketsByShowId(s.Id).Count() > 0)
    .Select(s => s.RoomSeats - GetTicketsByShowId(s.Id).Count())
    .Where(seats => seats > 0)
    .Min();


// toevoeging TicketService
    
int showId = GetAllShows()
    .Where(s => GetTicketsByShowId(s.Id).Count() > 0)
    .Where(s => s.RoomSeats - GetTicketsByShowId(s.Id).Count() == minSeats)
    .Select(s => s.Id)
    .FirstOrDefault();



    // aanmaken LeastAvailableSeatsModel class

    public class LeastAvailableSeatsModel : PageModel
{
    private readonly IShowService _showService;
    private readonly ITicketService _ticketService;

    public int ShowId { get; set; }

    public LeastAvailableSeatsModel(IShowService showService, ITicketService ticketService)
    {
        _showService = showService;
        _ticketService = ticketService;
    }

    public void OnGet()
    {
        int minSeats = _showService.GetAllShows()
            .Where(s => _ticketService.GetTicketsByShowId(s.Id).Count() > 0)
            .Select(s => s.RoomSeats - _ticketService.GetTicketsByShowId(s.Id).Count())
            .Where(seats => seats > 0)
            .Min();
        
        ShowId = _showService.GetAllShows()
            .Where(s => _ticketService.GetTicketsByShowId(s.Id).Count() > 0)
            .Where(s => s.RoomSeats - _ticketService.GetTicketsByShowId(s.Id).Count() == minSeats)
            .Select(s => s.Id)
            .FirstOrDefault();
    }
}


// en eventueel nog een  .cshtml pagina met 



@page
@model LeastAvailableSeatsModel

<h1>Show ID with the least available seats: @Model.ShowId</h1>
