sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class TasTaskAction : IdentityEntityBase
    {d]
        public int TaskId { get; set; }

        [Required]
        public int ActionId { get; set; }

        #region Naivgation Properties

        public virtual ICollection<Task> Tasks { get; set; }

        public virtual ICollection<Action> Actions { get; set; }

        #endregion
    }
}
