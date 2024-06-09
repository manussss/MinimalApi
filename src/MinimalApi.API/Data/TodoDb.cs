using Microsoft.EntityFrameworkCore;
using MinimalApi.API.Models;

namespace MinimalApi.API.Data
{
    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
