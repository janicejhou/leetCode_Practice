using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*@author : janice_chou
*@date : 2021/10/31 下午 08:12:09
**/
namespace leetCode_Practice.E9_PalindromeNumber
{
    class PalindromeNumberClass
    {
        public bool IsPalindrome ( int x )
        {
            //if ( x < 0 )
            //    return  false;
            //else 
            //{
            //    string nums = x.ToString ();
            //    string [] numAray = nums.Select (s => s.ToString ()).ToArray ();
            //    string [ ] reverseNumAry = numAray.Reverse ().ToArray();
            //    return Enumerable.SequenceEqual(numAray, reverseNumAry);

            //}

            return x < 0 ? false : Enumerable.SequenceEqual (x.ToString ().Select (s => s.ToString ()).ToArray () ,
                x.ToString ().Select (s => s.ToString ()).Reverse ().ToArray ());

            //if ( x < 0 )
            //{
            //    return false;
            //}
            //int CalculationTemp = x;
            //int temp = 0;
            //while ( CalculationTemp > 0 )
            //{
            //    temp = temp * 10 + CalculationTemp % 10;
            //    CalculationTemp /= 10;
            //}
            //return x == temp;

        }
    }
}
