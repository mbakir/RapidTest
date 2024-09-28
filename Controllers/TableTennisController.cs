using Microsoft.AspNetCore.Mvc;

namespace RapidTest.Controllers;

[ApiController]
[Route("[controller]")]
public class TableTennisController : ControllerBase
{
    private readonly ILogger<TableTennisController> _logger;

    public TableTennisController(ILogger<TableTennisController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Ping")]
    public string Ping()
    {
     return "Pong";
    }
    
    [HttpPost(Name = "PingWithId")]
    public string PingWithId(string id)
    {
       return $"Pong {id}";
    }
}