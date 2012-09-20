sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class FacDataType : IdentityEntityBase
    {d]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual ICollection<Fact> Facts { get; set; }

        #endregion
    }
}

        public enum FactDataTypeEnum
    {
            String = 1,
            Integer = 2,
            Decimal = 3,
            Boolean = 4,
            DateTime = 5
        }
    }
}
