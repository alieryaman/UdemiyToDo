using CYSKProje.UdemiyToDo.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using YSKProje.UdemiyToDo.DataAccsess.Concrate.EntityFramworkCore.Mapping;

namespace YSKProje.UdemiyToDo.DataAccsess.Concrate.EntityFramworkCore.Context
{
    public    class TodoContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-NV0GSA0\SQLEXPRESS; Database = UdemiyBlogToDo; Trusted_Connection = True; MultipleActiveResultSets = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new CalismaMap());

        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }
    }
}
