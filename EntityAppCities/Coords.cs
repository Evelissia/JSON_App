using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAppCities
{
    internal class Coords
    {
        [Key]
        [ForeignKey("City")]
        public int Id { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
    }
}
