using CleanArchTodoApp.Application.interfaces;
using CleanArchTodoApp.Application.Interfaces;
using CleanArchTodoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchTodoApp.Application.services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<IEnumerable<TodoItem>> GetTodosAsync()
        {
            return await _todoRepository.GetTodosAsync();
        }
    }
}

