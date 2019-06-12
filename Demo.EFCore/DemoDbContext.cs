using Demo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.EFCore
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            :base(options)
        {

        }

        //该处定义你要映射到数据库中的表
        //格式固定
        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //判断当前数据库是Oracle 需要手动添加Schema(DBA提供的数据库账号名称)
            if(this.Database.IsOracle())
            {
                modelBuilder.HasDefaultSchema("NETCORE");
            }
            base.OnModelCreating(modelBuilder);
        }

    }
}
