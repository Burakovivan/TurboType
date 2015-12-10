using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TurboType.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {   
        /// <summary>
        /// Логин пользователя.
        /// </summary>
        [Column]
        [Required]
        public string Login { set; get; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Column]
        public string FirstName { set; get; }

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        [Column]
        public string LastName { set; get; }

        /// <summary>
        /// Отчество пользователя.
        /// </summary>
        [Column]
        public string Patronymic { set; get; }

        /// <summary>
        /// Уровень пользователя
        /// </summary>
        [NotMapped]
        public int Level { get { return Rating / 200; } }


        /// <summary>
        /// Адресс фотографии
        /// </summary>
        [Column]
        public string Photo { set; get; }

        /// <summary>
        /// Очки рейтинга пользователя
        /// </summary>
        [Column]
        public int Rating { set; get; }



        /// <summary>
        /// Оставленные коментарии 
        /// </summary>
        public virtual ICollection<Comment> Сomments { set; get; }

       
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {

            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class TTContext : IdentityDbContext<ApplicationUser>
    {
        public TTContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TTContext Create()
        {
            return new TTContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //объявляем ключи
            modelBuilder.Entity<PassedStage>().HasKey(t => new { t.StageId, t.UserId });
            modelBuilder.Entity<Comment>().HasKey(t => t.CommentId);
            modelBuilder.Entity<Like>().HasKey(t => t.LikeId);
            modelBuilder.Entity<IdentityUserLogin>().HasKey(t => t.UserId);
            modelBuilder.Entity<IdentityUserRole>().HasKey(t => t.RoleId);
        }
        public DbSet<Like> Likes { get; set; }
        public DbSet<PassedStage> PassedStages { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}