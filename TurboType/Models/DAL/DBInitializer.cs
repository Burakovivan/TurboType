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
            db.Stages.Add(new Stage { StageId = 0, Advice = "Тут совет", Complexity = 3, StageName = "Имя урока", TextToType = "ав вваава вавав вававав вавваав вавваав", ThemeId = 0, MaximalMistakes=2, MinimalSpeed=100 });
            db.SaveChanges();
            base.Seed(db);
        }
    }
}