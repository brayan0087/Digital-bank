using Project.users.bll;
using Project.users.dal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceUsers
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PersonaService : IPersona
    {
         /// <summary>
        /// trae la Lista de todos los usuarios
        /// get list all users
        /// </summary>
        /// <returns></returns>
        public List<ListUserView> Getall()
        {
            List<ListUserView> lista = new List<ListUserView>();
            CrudUsers crud = new CrudUsers();
            lista = crud.Getall();
            return lista;
        }

        /// <summary>
        /// Crea un nuevo usuario
        /// Create in new user
        /// </summary>
        /// <param name="model"></param>
        public void newtUser(CreateUser model)
        {
           CrudUsers crud = new CrudUsers();
           crud.newtUser(model);
        }

        /// <summary>
        /// busca un ussuario por id
        /// Search user for id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UpdateUser Getuser(int id)
        {
            UpdateUser user = new UpdateUser();
            CrudUsers crud = new CrudUsers();
            user = crud.Getuser(id);
            return user;
        }


        /// <summary>
        /// edita el usuario
        /// edit user in database
        /// </summary>
        /// <param name="user"></param>
        public void EditUser(UpdateUser user)
        {
            CrudUsers crud = new CrudUsers();
            crud.EditUser(user);
        }


        /// <summary>
        /// Elimina el usuario
        /// Delete user
        /// </summary>
        /// <param name="id"></param>

        public void DeleteUser(int id)
        {
            CrudUsers crud = new CrudUsers();
            crud.DeleteUser(id);
        }


    
    }
}
