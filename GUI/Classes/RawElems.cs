using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSTemplate.Classes
{
    public class RawElems
    {
        public string ID;
        public string ValueHex;
        public string ValueDec => HexToDec(ID, ValueHex);

        private string HexToDec(string ID, string valueHex)
        {


            if (valueHex != "-")
            {
                valueHex = valueHex.Remove(0, 2); // removes the "0x" from the hex value
                int decValue = int.Parse(valueHex, System.Globalization.NumberStyles.HexNumber);
                return decValue.ToString();
            }
            else return "-";
            
        }
        
    }
}
