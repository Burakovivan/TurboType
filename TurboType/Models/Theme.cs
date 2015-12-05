using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurboType.Models
{
    public class Theme
    {
        [Key]
        public int ThemeId { get; set; }

        public string ThemeName { get; set; }

        public virtual ICollection<Stage> Stages { get; set; }
    }
}