﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Udemy.Areas.admin.Models
{
    public class LoginModel
    {

        [Required]
        public string UserName { set; get; }
        public string PassWord { set; get; }
        public bool RememberMe { set; get; }

    }
}