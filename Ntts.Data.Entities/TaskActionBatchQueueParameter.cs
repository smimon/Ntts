using System.ComponentModel.DataAnnotations;

namespace Ntts.Data.Entities
{
    public class TaskActionBatchQueueParameter : IdentityEntityBase
    {
        [Required]
        public int TaskActionBatchQueueId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        #region Naivgation Properties

        public virtual TaskActionBatchQueue TaskActionBatchQueue { get; set; }

        #endregion
    }
}
