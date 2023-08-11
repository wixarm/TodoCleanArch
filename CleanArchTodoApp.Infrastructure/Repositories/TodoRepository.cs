using CleanArchTodoApp.Application;
using CleanArchTodoApp.Application.interfaces;
using CleanArchTodoApp.Application.Interfaces;
using CleanArchTodoApp.Domain;
using CleanArchTodoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchTodoApp.Infrastructure.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TodoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TodoItem>> GetTodosAsync()
        {
            return await _dbContext.Todos.ToListAsync();
        }

    }
}
