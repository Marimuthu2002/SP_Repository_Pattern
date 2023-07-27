using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DBModel
    {
        [Key]
        public int emp_Id { get; set; }
        public string emp_Name { get; set; }
        public int emp_Age { get; set; }
        public string emp_Dept { get; set; }
        public int? salary { get; set; }
    }
}
