using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenNet
{
    public class ChangeString
    {


        public string Build(string Cadena)
        {
            string CadenaFinal = string.Empty;
            for (int i = 0; i < Cadena.Length; i++)
            {
                CadenaFinal = CadenaFinal + IsAbcd(Cadena[i]);
            }
            return CadenaFinal;
        }



        private string IsAbcd(char value)
        {
            char rChar = value;
            int n;
            bool isNumeric = int.TryParse(value.ToString(), out n);
            if (!isNumeric)
            {


                switch (value.ToString().ToLower())
                {
                    case "a":
                        rChar = ChangeUpperLower(value, 'b');
                        break;
                    case "b":
                        rChar = ChangeUpperLower(value, 'c'); break;
                    case "c":
                        rChar = ChangeUpperLower(value, 'd'); break;
                    case "d":
                        rChar = ChangeUpperLower(value, 'e'); break;
                    case "e":
                        rChar = ChangeUpperLower(value, 'f'); break;
                    case "f":
                        rChar = ChangeUpperLower(value, 'g'); break;
                    case "g":
                        rChar = ChangeUpperLower(value, 'h'); break;
                    case "h":
                        rChar = ChangeUpperLower(value, 'i'); break;
                    case "i":
                        rChar = ChangeUpperLower(value, 'j'); break;
                    case "j":
                        rChar = ChangeUpperLower(value, 'k'); break;
                    case "k":
                        rChar = ChangeUpperLower(value, 'l'); break;
                    case "l":
                        rChar = ChangeUpperLower(value, 'm'); break;
                    case "m":
                        rChar = ChangeUpperLower(value, 'n'); break;
                    case "n":
                        rChar = ChangeUpperLower(value, 'ñ'); break;
                    case "ñ":
                        rChar = ChangeUpperLower(value, 'o'); break;
                    case "o":
                        rChar = ChangeUpperLower(value, 'p'); break;
                    case "p":
                        rChar = ChangeUpperLower(value, 'q'); break;
                    case "q":
                        rChar = ChangeUpperLower(value, 'r'); break;
                    case "r":
                        rChar = ChangeUpperLower(value, 's'); break;
                    case "s":
                        rChar = ChangeUpperLower(value, 't'); break;
                    case "t":
                        rChar = ChangeUpperLower(value, 'u'); break;
                    case "u":
                        rChar = ChangeUpperLower(value, 'v'); break;
                    case "v":
                        rChar = ChangeUpperLower(value, 'w'); break;
                    case "w":
                        rChar = ChangeUpperLower(value, 'x'); break;
                    case "x":
                        rChar = ChangeUpperLower(value, 'y'); break;
                    case "y":
                        rChar = ChangeUpperLower(value, 'z'); break;
                    case "z":
                        rChar = ChangeUpperLower(value, 'a'); break;
                    default:
                        rChar = value; break;
                }

            }
            return rChar.ToString();


        }


        private char ChangeUpperLower(char value, char change)
        {
            if (char.IsLower(value))
            {
                return change;
            }
            return change.ToString().ToUpper().ToCharArray()[0];
        }

    }


}
