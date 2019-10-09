using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDHW3._0.Data
{
    public class Manufactures
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MID { get; set; }

        [Display(Name ="Manufacture Name")]
        public string MName { get; set; }

        [Display(Name="Year Name")]
        public int YearMade { get; set; }
    }
}
