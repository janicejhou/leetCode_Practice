using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*@author : janice_chou
*@date : 2021/10/31 下午 04:18:21
**/
namespace E13_RomanToInteger
{
    class RomanToIntegerClass
    {
        public int RomanToInt ( string s )
        {
            
            // 需依據羅馬字母順序大小做加總，若後一個順序大於前一個，則前一個為負數
            // MDC > 1000+500+100
            // MCD > 1000+(-500)+100
            // MCMXCIV > 1000+(-100)+1000+10+100+-(1)+5
          
            string [ ] sAry = s.Select (a => a.ToString ()).ToArray ();
            int temp = 0;
            for ( int i = 0 ; i < sAry.Length ; i++ )
            {
                if ( (sAry [ 0 ] == "I" && sAry [ 1 ] == "V") || sAry [ 0 ] == "I" && sAry [ 1 ] == "X"  || sAry [ 0 ] == "C" && sAry [ 1 ] == "M" )
                    temp = romanTransInt (sAry [ 1 ]) - romanTransInt (sAry [ 0 ]);
                else
                    temp = temp + romanTransInt (sAry [ i ]);

            }
            return temp;

            int romanTransInt ( string symbol )
            {
                switch ( symbol )
                {
                    case "I":
                        return 1;
                    case "V":
                        return 5;
                    case "X":
                        return 10;
                    case "L":
                        return 50;
                    case "C":
                        return 100;
                    case "D":
                        return 500;
                    case "M":
                        return 1000;
                    default:
                        return 0;
                }
            }

        }
    }
}
