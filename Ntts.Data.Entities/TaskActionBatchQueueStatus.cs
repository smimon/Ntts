sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usinpace Ntts.Data.Entities
{
    public class TaskActionBatchQueueStatus
    {
   : IdentityEntityBase      [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual ICollection<TaskActionBatchQueue> TaskActionBatchQueues { get; set; }

        #endregion
    }
}

        public enum TaskActionBatchQueueStatusEnum
        {
            Queued = 1,
            InProgress = 2,
            Complete = 3,
            Error = 4
        }
    }
}
