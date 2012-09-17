using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class TaskActionBatchQueue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TaskActionBatchId { get; set; }

        [Required]
        public int ActionId { get; set; }

        [Required]
        public DateTime RunDateTime { get; set; }

        [Required]
        public int TaskActionBatchQueueStatusId { get; set; }

        #region Naivgation Properties

        public virtual TaskActionBatch TaskActionBatch { get; set; }

        public virtual Action Action { get; set; }

        public virtual TaskActionBatchQueueStatus TaskActionBatchQueueStatus { get; set; }

        #endregion
    }
}
