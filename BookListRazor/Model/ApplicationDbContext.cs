using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class ApplicationDbContext:DbContext
    {
     //constructor. (press ctor+tab(twice))
     //constructor parameter is needed for dependency injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //add book model that was added to the database
        public DbSet<Book> Book { get; set; }
    }
}
