using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurboType.Models
{
    public class PassedStage
    {
       

        /// <summary>
        /// Id пользователя.
        /// </summary>
        public string UserId { set; get; }

        /// <summary>
        /// Id этапа.
        /// </summary>
        public string StageId { set; get; }

        /// <summary>
        /// Id этапа.
        /// </summary>
        public byte Rating { set; get; }

        /// <summary>
        /// Время прохождения
        /// </summary>
        public DateTime TimeOfPassage { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Stage Stage { get; set; }

    }
}