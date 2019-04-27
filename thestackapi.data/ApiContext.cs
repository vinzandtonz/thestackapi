using System;
using Microsoft.EntityFrameworkCore;
using thestackapi.domain;

namespace thestackapi.data
{
    public class ApiContext: DbContext
    {
        public ApiContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer('');
            base.OnConfiguring(optionsBuilder);
        }

    }
}
