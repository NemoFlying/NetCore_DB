using Demo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.EFCore
{
    public class DemoDbInitial
    {
        public static void Initial(DbContext dbContext)
        {
            //简单粗暴创建数据库
            //删除数据库后从新创建数据库
            //如果删除报错，就手动去数据库删除
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();

            //程式自动检测有没有新的迁移没有反应到数据，有则更新数据库
            if(dbContext.Database.GetPendingMigrations().ToList().Count()>0)
            {
                dbContext.Database.Migrate();
            }
            
            //根据某一个表是否有数据来判断是否需要注入初始数据
            if(!dbContext.Set<Student>().Any())
            {
                var student = new Student()
                {
                    UserId = "C3700408",
                    Name = "Nemo"
                };
                dbContext.Set<Student>().Add(student);
                dbContext.SaveChanges();
            }


        }
    }
}
