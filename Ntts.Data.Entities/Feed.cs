using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class Feed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int FeedTypeId { get; set; }

        [Required]
        public string Uri { get; set; }

        #region Naivgation Properties

        public virtual FeedType FeedType { get; set; }

        public virtual ICollection<Fact> Facts { get; set; }

        public virtual ICollection<Action> Actions { get; set; }

        #endregion
    }
}
