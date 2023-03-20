using Jwt_Web_Token.Models;

namespace Jwt_Web_Token.Constans
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
             new UserModel()  {Username="jperez", Password="admin123",Rol="Administrador",EmailAddress="jperez@gmail.com",FirstName="Juan",LastName="Perez"},
             new UserModel()  {Username="mgonzales", Password="admin123",Rol="Vendedor",EmailAddress="mgonzales@gmail.com",FirstName="Maria",LastName="Gonzales"},

        };  
    }
}
