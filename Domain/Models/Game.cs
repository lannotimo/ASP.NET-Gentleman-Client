﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Game : BaseEntity
    {
        public int GameId { get; set; }

        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        [MinLength(3, ErrorMessageResourceName = "FieldMinLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [MaxLength(12, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [Display(Name = nameof(Resources.Domain.GameName), ResourceType = typeof(Resources.Domain))]
        public string GameName { get; set; }

        [Display(Name = nameof(Resources.Domain.StartedAt), ResourceType = typeof(Resources.Domain))]
        public DateTime StartedAt { get; set; }

        [Display(Name = nameof(Resources.Domain.StoppedAt), ResourceType = typeof(Resources.Domain))]
        public DateTime? StoppedAt { get; set; }



        #region Foreign Keys

        public int GameTypeId { get; set; }
        public virtual GameType GameType { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public virtual ICollection<GameRow> GameRows { get; set; }

        #endregion
    }
}