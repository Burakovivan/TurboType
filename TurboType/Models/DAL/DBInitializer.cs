using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TurboType.Models.DAL
{
    public class DBInitializer: DropCreateDatabaseAlways<TTContext>
    {
        protected override void Seed(TTContext db)
        {
            db.Themes.Add(new Theme { ThemeId = 0, ThemeName = "tema" });
            db.SaveChanges();
            base.Seed(db);
        }
    }
}