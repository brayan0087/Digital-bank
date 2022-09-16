using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.users.dal.ViewModels;
using Project.users.bll;

namespace Project.users.Controllers
{
    public class UsuarioConsultaController : Controller
    {
        CrudUsers admi = new CrudUsers();
       /// <summary>
       /// lista de usuarios
       /// list of users
       /// </summary>
       /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            List<ListUserView> lista = admi.Getall();
            return View(lista);

        }

        /// <summary>
        /// trae usuario por id
        /// get user for id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            UpdateUser user = admi.Getuser(id);
            return View(user);
        }


        /// <summary>
        /// post actualizacion usuario
        /// post update user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(UpdateUser user)
        {
            admi.EditUser(user);
            return RedirectToAction("Index");
        }


        /// <summary>
        /// trae usuario para eliminar 
        /// get user for delete
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Deleteget(int id)
        {
            UpdateUser user = admi.Getuser(id);
            return View(user);
        }

        /// <summary>
        /// post eliminar usuario
        /// post delete user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int id)
        {
            admi.DeleteUser(id);
            return RedirectToAction("Index");
        }


    }
}