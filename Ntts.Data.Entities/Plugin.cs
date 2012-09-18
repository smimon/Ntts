sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class PluPlugin : IdentityEntityBase
    {d]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual ICollection<Action> Actions { get; set; }

        #endregion
    }
}
