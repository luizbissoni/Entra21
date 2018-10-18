using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMercado
{
    public class Utils 
    {
        public static int ReturnPressKeyIntCode(object value)
        {
            int valueReturn = 0; 

            int.TryParse(value.ToString(),out valueReturn);

            return valueReturn;
        }
       
    }
}
