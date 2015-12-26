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
            db.Stages.Add(new Stage { StageId = 0, Advice = "Тут совет", Complexity = 3, StageName = "Имя урока", TextToType = "йцу йцу йцууцй уц й ьялыф", ThemeId = 0 });
            db.SaveChanges();
            base.Seed(db);
        }
    }
}