using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace new_mvc.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = ("nvarchar(200)"))]
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }

        [Column(TypeName = ("nvarchar(200)"))]
        [Required(ErrorMessage = "Please enter Position")]
        public string Position { get; set; }

        [Column(TypeName = ("nvarchar(200)"))]
        [Required(ErrorMessage = "Please enter Mail")]
        public string Mail { get; set; }

        [Column(TypeName = ("nvarchar(200)"))]
        [Required(ErrorMessage = "Please enter TelePhone")]
        public string TelePhone { get; set; }
    }
}
