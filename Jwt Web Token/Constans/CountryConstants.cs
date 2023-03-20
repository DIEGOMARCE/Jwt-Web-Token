using Jwt_Web_Token.Models;

namespace Jwt_Web_Token.Constans
{
    public class CountryConstants
    {
        public static List<CountryModel> Countrys = new List<CountryModel>()
        {
            new CountryModel()  {Name ="Argentina"},
             new CountryModel()  {Name ="Peru"},
              new CountryModel()  {Name ="Mexico"},
        };
    }
}
