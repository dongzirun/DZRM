using DZRM.Domain.OrderAggergateBoot;
using DZRM.Domain.UserAggergateBoot;
using DZRM.Infrastructure.EntityConfigurations;
using DZRM.Infrastucture.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Infrastructure
{
    public class DomainContext : EFContext
    {
        public DomainContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 注册领域模型与数据库的映射关系
            modelBuilder.ApplyConfiguration(new OrderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
