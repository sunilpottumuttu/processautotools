﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProcessAutoTools.POCOS
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}
