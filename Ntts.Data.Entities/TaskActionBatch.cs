using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usinpace Ntts.Data.Entities
{
    public class TaskActioTaskActionBatch : IdentityEntityBase
    {ired]
        public int TaskId { get; set; }

        [Required]
        public int UserId { get; se{ get; set; }

        #region Naivgation Properties

        public virtual Task Task { get; set; }

        public virtual User User { get; set; }

    e> TaskActionBatchQueues { get; set; }

        #endregion
    }
}
