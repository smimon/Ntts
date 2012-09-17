using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usinpace Ntts.Data.Entities
{
    public class TaskActionBatch
    {
   : IdentityEntityBase      [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TaskId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime BatchDateTime { get; set; }

        #region Naivgation Properties

        public virtual Task Task { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<TaskActionBatchQueue> TaskActionBatchQueues { get; set; }

        #endregion
    }
}
