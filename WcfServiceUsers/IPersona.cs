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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPersona
    {
        [OperationContract]
        List<ListUserView> Getall();

        [OperationContract]
        void newtUser(CreateUser model);


        [OperationContract]
        UpdateUser Getuser(int id);


        [OperationContract]
        void EditUser(UpdateUser user);


        [OperationContract]
        void DeleteUser(int id);

         
    }
}
