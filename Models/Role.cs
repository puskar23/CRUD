using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ekbana.Models
{
    public class Role
    {
        [Key]
        [Column(TypeName = "int")]
        [DisplayName("RoleID")]
        public int RoleID { get; set; }
    }
}
