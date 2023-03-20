using Jwt_Web_Token.Models;

namespace Jwt_Web_Token.Constans
{
    public class ProductConstants
    {
        public static List<ProductModel> Products = new List<ProductModel>()
        {
            new ProductModel(){Name="Coca Cola",Description= "Bebida con gas"},
            new ProductModel(){Name="Agua Villavicencia",Description= "Agua mineral de 2L"}
        };
    }
}
