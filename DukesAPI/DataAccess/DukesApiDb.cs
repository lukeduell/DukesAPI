using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using DukesAPI.Models;

namespace DukesAPI.DataAccess
{
    public class DukesApiDb : DbContext
    {
        public DukesApiDb(DbContextOptions<DukesApiDb> options): base(options)
        {

        }

        public DbSet<TeamDb> Teams { get; set; }

    }
}
