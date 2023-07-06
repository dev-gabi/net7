using Bl;
using Entities.Request;
using Entities.response;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Todo : ControllerBase
    {
        private readonly ITodo _bl;

        public Todo(ITodo bl)
        {
            _bl = bl;
        }

        //public Todo()
        //{
        //    var nameConfig = new NameConfig()
        //    {
        //        First = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Name:First").Value,
        //        Last = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Name:Last").Value
        //    };
        //    IOptions<NameConfig> nameConfigOptions = Options.Create(nameConfig);
        //    _bl = new Bl.TodoBL(new TodoDbContext(new DbContextOptions<TodoDbContext>()), nameConfigOptions);
        //}

        [HttpPost]
        public  UiResponse Add(TodoRequest todoItem)
        {
            return _bl.Add(todoItem);
            
        }
    }
}
