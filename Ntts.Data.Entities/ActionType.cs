sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class ActionType : IdentityEntityBas       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual ICollection<Action> Actions { get; set; }

        #endregion
    }
}

        public enum ActionTypeEnum
        {
            Feed = 1,
            Plugin = 2
        }
    }
}
