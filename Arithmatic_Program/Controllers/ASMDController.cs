using Arithmatic_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arithmatic_Program.Controllers
{
    public class ASMDController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Arithmatic_Operation model, string command)
        {
            if(command == "add")
            {
                model.Result = model.A + model.B;
            }
            if(command == "sub")
            {
                model.Result = model.A - model.B;
            
            }
            if(command == "Mul")
            {
                model.Result = model.A * model.B;

            }
            if (command =="Div")
            {
                model.Result = model.A / model.B;
            }

            return View(model);
        }
    }
}