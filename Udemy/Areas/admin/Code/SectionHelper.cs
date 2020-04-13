using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Udemy.Areas.admin.Code
{
    public class SectionHelper
    {
        public static void SetSection(UserSection section)
        {
            HttpContext.Current.Session["loginSection"] = section;
        }
        public static UserSection GetSection()
        {
            var section = HttpContext.Current.Session["loginSection"];
            if (section == null)
                return null;
            else
            {
                return section as UserSection;
            }
        }
    }
}