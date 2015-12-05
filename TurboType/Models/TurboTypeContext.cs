using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TurboType.Models
{
    public class TurboTypeContext:DbContext
    {
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //объявляем ключи
            modelBuilder.Entity<PassedStage>().HasKey(t => new { t.StageId, t.UserId });
            modelBuilder.Entity<Comment>().HasKey(t => t.CommentId);
        }
    }
}