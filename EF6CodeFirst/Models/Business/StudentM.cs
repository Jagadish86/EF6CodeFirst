using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirst.Models.Business
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StudentMaster", Schema = "Admin")]
    public class StudentM
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}
