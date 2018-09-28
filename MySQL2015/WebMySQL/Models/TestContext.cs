using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMySQL.Models
{
    public class TestContext : DbContext
    {

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }
        public DbSet<TestModel> TestModels { get; set; }
    }
}
