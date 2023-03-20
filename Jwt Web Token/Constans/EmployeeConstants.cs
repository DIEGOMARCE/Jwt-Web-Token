using Jwt_Web_Token.Models;

namespace Jwt_Web_Token.Constans
{
    public class EmployeeConstants
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>()
        {
            new EmployeeModel () { FirstName = "Diego", LastName = "Sanhueza",  Email = "diego@gmail.com" },
            new EmployeeModel () { FirstName = "Camilo", LastName = "Saavedra",  Email = "marco@gmail.com" }
        };
    }
}
