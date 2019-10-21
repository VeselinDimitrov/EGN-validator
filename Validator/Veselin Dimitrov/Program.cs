using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veselin_Dimitrov
{
    public class Program
    {
        static void Main(string[] args)
        {
            string egn;

            Console.Write("Enter EGN:");
            egn = Console.ReadLine();

            Console.WriteLine(CheckEGN(egn));

            Console.ReadKey();
        }

        public static bool CheckEGN(string egn)
        {
            try
            {
                var result = true;

                if (egn.Length != 10)
                {
                    return false;
                }

                var year = int.Parse(egn.Substring(0, 2));

                var month = int.Parse(egn.Substring(2, 2));

                var day = int.Parse(egn.Substring(4, 2));

                if (day > 31 || month > 52 || (month < 40 && month > 32) || (month < 21 && month > 12))
                {
                    return false;
                }

                var sum = (egn[0] - '0') * 2 + (egn[1] - '0') * 4 + (egn[2] - '0') * 8 + (egn[3] - '0') * 5 + (egn[4] - '0') * 10 + 
                    (egn[5] - '0') * 9 + (egn[6] - '0') * 7 + (egn[7] - '0') * 3 + (egn[8] - '0') * 6;

                var controlDigit = sum % 11;

                return ((egn[9] - '0') == controlDigit);
            }
            catch
            {
                return false;
            }
        }
    }
}
