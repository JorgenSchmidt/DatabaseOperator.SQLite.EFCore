using System.Collections.Generic;

using DataBaseOperator.Domain.Core;

namespace DatabaseOperator.API.Services
{
    public class WindowInteractor
    {

        // for every data base i use one static list 

        public static List<User> StaticUserList = new();
        public static List<Product> StaticProductList = new();

    }
}
