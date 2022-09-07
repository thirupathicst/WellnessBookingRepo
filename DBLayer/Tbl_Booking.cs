using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class Tbl_Booking
    {
        [Key]
        public int Id { get; set; }
        public int WellnessTypeId { get; set; }
        public string Location { get; set; }
        public string ProposedDateTime { get; set; }
    }
}
