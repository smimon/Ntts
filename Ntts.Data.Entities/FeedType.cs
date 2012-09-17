sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class FeedType : IdentityEntityBas       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual ICollection<Feed> Feeds { get; set; }

        #endregion
    }
}

        public enum FeedTypeEnum
        {
            Scrape = 1
        }
    }
}
