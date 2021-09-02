using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;
using TodoApi.Services;
using System.Linq;

namespace ToDoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {

        private readonly IToDoService _toDoService;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public ToDoController(ILogger<WeatherForecastController> logger, IToDoService toDoService)
        {
            _logger = logger;
            _toDoService = toDoService;
        }



        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            var todos = this._toDoService.getToDos();
            var alltodos = from tds in todos where true select tds;
            return alltodos;
        }
    }
}
