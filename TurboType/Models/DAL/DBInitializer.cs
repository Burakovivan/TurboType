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
            db.Stages.Add(new Stage { StageId = 1, Advice = "Совет:  используйте указательные пальцы для букв «а» и «о», средние – для «в» и «л»,  а для пробела – какой-то из больших. Обратите внимание, что на клавишах «а» и «о» есть специальные выступы для удобства определения правильного положения пальцев.", Complexity = 1, StageName = "Урок 1", TextToType = "Аааа оооо вввв лллл вваа оолл ллоо лава овал лов", ThemeId = 0, MaximalMistakes=4, MinimalSpeed=50 });
            db.Stages.Add(new Stage { StageId = 2, Advice = "Совет: не забывайте использовать правила из предыдущего урока. Для букв «ы» и  «д» используйте безымянные пальцы, а для «ф» и «ж» - мизинцы. ", Complexity = 1, StageName = "Урок 2", TextToType = "ыыыы дддд ыывв ддлл вывы вода жало лыжа лафа", ThemeId = 0, MaximalMistakes = 3, MinimalSpeed = 50 });
            db.Stages.Add(new Stage { StageId = 3, Advice = "Совет: для букв «п» и «р» используйте указательные пальцы.", Complexity = 3, StageName = "Урок 3", TextToType = "Пппп рррр аппа повар пар ров дыра жара плов выдра", ThemeId = 0, MaximalMistakes = 2, MinimalSpeed = 100 });
            db.Stages.Add(new Stage { StageId = 4, Advice = "Совет: для букв «у» и «к» используйте указательные пальцы,  а для «у» и «ш» - средние.", Complexity = 3, StageName = "Урок 4", TextToType = "Укук шгшг куку гшгш курага рывок рога шкаф фрак", ThemeId = 0, MaximalMistakes = 2, MinimalSpeed = 100 });
            db.Stages.Add(new Stage { StageId = 4, Advice = "Совет: для букв «м» и «ь» используйте указательные пальцы,  а для «с» и «б» - средние.", Complexity = 3, StageName = "Урок 5", TextToType = "сс мм ьь лото сова мост стол жолудь борсук форсаж", ThemeId = 0, MaximalMistakes = 2, MinimalSpeed = 100 });

            db.SaveChanges();
            base.Seed(db);
        }
    }
}