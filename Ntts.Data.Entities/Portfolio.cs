﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class Portfolio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]        
        public int UserId { get; set; }
        
        [Required]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual User User { get; set; }

        public virtual ICollection<PortfolioStock> PortfolioStocks { get; set; }

        #endregion
    }
}