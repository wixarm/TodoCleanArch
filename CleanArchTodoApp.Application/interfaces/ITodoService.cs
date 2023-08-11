using CleanArchTodoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchTodoApp.Application.Interfaces
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoItem>> GetTodosAsync();
    }
}

