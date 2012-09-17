using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ntts.Data.Entities
{
    public class User : IdentityEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int Id { get; set; }
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }

        #region Naivgation Properties

        public virtual ICollection<Portfolio> Portfolios { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public virtual ICollection<TaskActionBatch> TaskActionBatches { get; set; }

        #endregion
    }
}

}
