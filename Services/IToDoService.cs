using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Services
{

    public interface IToDoService
    {
        public List<TodoItem> getToDos();
    }
}

