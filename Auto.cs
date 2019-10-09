using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDHW3._0.Data
{
    public class Auto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AID { get; set; }

        public string AName { get; set; }

        public int MID { get; set; }

        [ForeignKey("MID")]
        public Manufactures ManID { get; set; }
    }
}
