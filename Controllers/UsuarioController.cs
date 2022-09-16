using Project.users.bll;
using Project.users.dal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.users.Controllers
{
    public class UsuarioController : Controller
    {
        CrudUsers admi = new CrudUsers();
        /// <summary>
        /// muestra formulario de creacion de usuario
        /// show user creation form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// post creacion de usuario
        /// post create of user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(CreateUser model)
        {
            admi.newtUser(model);
            return RedirectToAction("Index","UsuarioConsulta");
        }


    }
}