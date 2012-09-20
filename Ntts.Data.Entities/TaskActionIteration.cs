using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ntts.Data.Entities
{
    public class TaskActionIteration : IdentityEntityBase
    {
        [Required]
        public int TaskActionId { get; set; }

        [Required]
        public int IterationNumber { get; set; }

        #region Naivgation Properties

        public virtual TaskAction TaskAction { get; set; }

        public virtual ICollection<TaskActionIterationParameter> TaskActionIterationParameters { get; set; }

        #endregion
    }
}
