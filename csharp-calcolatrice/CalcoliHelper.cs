using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        //-------------------------SOMMA--------------------------
        public static int Calculate2NumSum(int intNum1, int intNum2)
        {
            return intNum1 + intNum2;
        }
        public static double Calculate2NumSum(double decNum1, double decNum2)
        {
            return decNum1 + decNum2;
        }
        //-------------------------DIFFERENZA--------------------------
        public static int Calculate2NumDif(int intNum1, int intNum2) 
        {
            return intNum1 - intNum2;
        }
        public static double Calculate2NumDif(double decNum1, double decNum2)
        {
            return decNum1 - decNum2;
        }
        //-------------------------MOLTIPLICAZIONE--------------------------
        public static int Calculate2NumMoltipl(int intNum1, int intNum2)
        {
            return intNum1 * intNum2;
        }
        public static double Calculate2NumMoltipl(double decNum1, double decNum2)
        {
            return decNum1 * decNum2;
        }
        //-------------------------VALORE ASSOLUTO-------------------------------
        public static int CalculateAbsoluteIntNum(int intNum1)
        {
            if (intNum1 > 0)
            {
                return intNum1;
            } 
            else if (intNum1 < 0) 
            {
                return intNum1 * -1;
            }
            else { return 0; }
        }

        public static double CalculateAbsoluteDecNum(double decNum1)
        {
            if (decNum1 > 0)
            {
                return decNum1;
            }
            else if (decNum1 < 0)
            {
                return decNum1 * -1;
            }
            else { return 0; }
        }
        //-------------------------MINIMO-------------------------
        public static int CalculateMinBetween2Num(int intNum1, int intNum2)
        {
            if (intNum1 < intNum2)
            {
                return intNum1;
            } else
            {
                return intNum2;
            }
        }
        public static double CalculateMinBetween2Num(double decNum1, double decNum2)
        {
            if (decNum1 < decNum2)
            {
                return decNum1;
            } else
            {
                return decNum2;
            }
        }
        //-------------------------MASSIMO-------------------------
        public static int CalculateMaxBetween2Num(int intNum1, int intNum2)
        {
            if (intNum1 < intNum2)
            {
                return intNum2;
            } else
            {
                return intNum1;
            }
        }
        public static double CalculateMaxBetween2Num(double decNum1, double decNum2) 
        {
            if(decNum1 < decNum2)
            {
                return decNum2;
            } else
            {
                return decNum1;
            }
        }
        //-------------------------------------SOVRACCARICO------------------------------------

        //---------------------------------BONUS--------------------------------
        public static int  CalculateExponential(int intNum1, int intNum2)
        {
            if (intNum1 != 0 && intNum2 != 0) 
            {
                return (int)Math.Pow(intNum1, intNum2);
            }
            else 
            {
                return 1;
            }
        }
    }

}
