using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProcessAutoTools.POCOS
{
    public class Project
    {
        public int ProjectID { get; set; }
        
        [Required]
        public string ProjectName { get; set; }
    }
}
