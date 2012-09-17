using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class Action
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ActionTypeId { get; set; }

        public int FeedId { get; set; }

        public int PluginId { get; set; }

        #region Naivgation Properties

        public virtual ActionType ActionType { get; set; }

        public virtual Feed Feed { get; set; }

        public virtual Plugin Plugin { get; set; }

        public virtual ICollection<TaskActionBatchQueue> TaskActionBatchQueues { get; set; }

        public virtual ICollection<TaskAction> TaskActions { get; set; }

        #endregion
    }
}
