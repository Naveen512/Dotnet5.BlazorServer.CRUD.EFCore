using Dotnet5.BlazorServer.CRUD.EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dotnet5.BlazorServer.CRUD.EFCore.Data
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {

        }
        public DbSet<Gadgets> Gadgets { get; set; }
    }
}