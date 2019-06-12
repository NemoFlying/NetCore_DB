using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Core.Entities
{
    [Table("STUDENT")]  //指定数据库对应表名
    public class Student
    {
        /// <summary>
        /// 学生学号
        /// </summary>
        [Key]  //主键
        [Column("USERID")] //指定数据库对应表栏位名称
        public string UserId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [MaxLength(10)]
        [Column("NAME")]
        public string Name { get; set; }
    }
}
