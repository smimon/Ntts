using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class ActionParameter : IdentityEntityBase
    {
        [Required]
        public int ActionId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int DataTypeId { get; set; }

        #region Naivgation Properties

        public virtual Action Action { get; set; }
        
        public virtual DataType DataType { get; set; }

        public virtual ICollection<TaskActionIterationParameter> TaskActionIterationParameters { get; set; }

        #endregion
    }
}
