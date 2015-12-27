using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurboType.Models
{
    public class Stage
    {

        [Key]
        public int StageId { get; set; }

        [Required]
        public string StageName { get; set; }
        
        [Required]
        public string TextToType { get; set; }
        
        [Required]
        public byte Complexity { get; set; }

        [Required]
        public int MaximalMistakes { get; set; }

        [Required]
        public int MinimalSpeed { get; set; }

        [Required]
        public int ThemeId { get; set; }
        public string Advice { get; set; }

        public virtual Theme Theme { get; set; }
    }
}