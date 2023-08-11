using CleanArchTodoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchTodoApp.Application.interfaces
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoItem>> GetTodosAsync();
    }
}
