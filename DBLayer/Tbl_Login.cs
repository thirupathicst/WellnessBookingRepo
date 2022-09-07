using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class Tbl_Login
    {
        [Key]
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
    }
}
