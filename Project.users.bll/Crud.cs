using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.users.dal;
using Project.users.dal.Model;
using Project.users.dal.ViewModels;

namespace Project.users.bll
{
    public class CrudUsers
    {
        
        /// <summary>
        /// trae la Lista de todos los usuarios
        /// get list all users
        /// </summary>
        /// <returns></returns>
        public List<ListUserView> Getall()
        {
            List<ListUserView> lista = new List<ListUserView>();
            using (EntitiesUser db = new EntitiesUser())
            {
                lista = (from d in db.Usuario
                         select new ListUserView
                         {
                             Id = d.Id,
                             Nombre = d.Nombre,
                             FechaNacimiento = d.FechaNacimiento,
                             Sexo = d.Sexo
                         }).ToList();
            }

            return lista;
        }

        /// <summary>
        /// Crea un nuevo usuario
        /// Create in new user
        /// </summary>
        /// <param name="model"></param>
        public void newtUser(CreateUser model)
        {
            using (EntitiesUser db = new EntitiesUser())
            {
                if (model.Sexo == Sexo.Masculino)
                {
                    string mascu = "Masculino";
                    db.crearUsuario(model.Nombre, model.FechaNacimiento, mascu);
                }
                if (model.Sexo == Sexo.Femenino)
                {
                    string feme = "Femenino";
                    db.crearUsuario(model.Nombre, model.FechaNacimiento, feme);
                }
                if (model.Sexo == Sexo.NoDefnine)
                {
                    string not = "NoDefine";
                    db.crearUsuario(model.Nombre, model.FechaNacimiento, not);
                }
            }
        }

        /// <summary>
        /// busca un usuario por id
        /// Search user for id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UpdateUser Getuser(int id)
        {
            UpdateUser user = new UpdateUser(); 

            using (EntitiesUser db=new EntitiesUser())
            {
                user = (from d in db.Usuario
                         select new UpdateUser
                         {
                             Id = d.Id,
                             Nombre = d.Nombre,
                             FechaNacimiento = d.FechaNacimiento,
                             Sexo = d.Sexo

                         }).Where(x => x.Id == id).FirstOrDefault();

            }
            return user;
        }


        /// <summary>
        /// edita el usuario
        /// edit user in database
        /// </summary>
        /// <param name="user"></param>
        public void EditUser(UpdateUser user)
        {
            using (EntitiesUser db = new EntitiesUser())
            {
                db.EditarUsuario(user.Id, user.Nombre, user.FechaNacimiento, user.Sexo);
            }
        }


        /// <summary>
        /// Elimina el usuario
        /// Delete user
        /// </summary>
        /// <param name="id"></param>

        public void DeleteUser(int id)
        {
            using (EntitiesUser db = new EntitiesUser())
            {
                db.EliminarUsuario(id);
            }

        }


    }
}
