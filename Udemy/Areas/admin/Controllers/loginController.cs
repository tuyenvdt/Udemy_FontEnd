using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy.Areas.admin.Code;
using Udemy.Areas.admin.Models;

namespace Udemy.Areas.admin.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /admin/Default1/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(LoginModel model)
        {

            var result = new AccountModel().Login(model.UserName, model.PassWord);
            if (result && ModelState.IsValid)
            {
                SectionHelper.SetSection(new UserSection()
                {
                    UserName = model.UserName
                });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tao đố mày biết tên đăng nhập hay mật khẩu sai :) ");
            }
            return View(model);
        }
	}
}