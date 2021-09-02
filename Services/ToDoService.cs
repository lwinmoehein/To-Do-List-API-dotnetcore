using System.Threading.Tasks;
using TodoApi.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace TodoApi.Services
{

    public class ToDoService : IToDoService
    {
        protected readonly TodoContext _dbContext;
        public ToDoService(TodoContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<TodoItem> getToDos()
        {
            return this._dbContext.TodoItems.ToList<TodoItem>();
        }
    }
}

