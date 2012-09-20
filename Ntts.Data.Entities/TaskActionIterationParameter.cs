using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class TaskActionIterationParameter : IdentityEntityBase
    {
        [Required]
        public int TaskActionIterationId { get; set; }

        [Required]
        public int ActionParameterId { get; set; }

        [Required]
        public object Value { get; set; }

        #region Naivgation Properties

        public virtual TaskActionIteration TaskActionIteration { get; set; }

        public virtual ActionParameter ActionParameter { get; set; }

        #endregion
    }
}
