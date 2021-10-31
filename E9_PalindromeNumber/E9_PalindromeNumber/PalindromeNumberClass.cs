﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*@author : janice_chou
*@date : 2021/10/31 下午 02:50:13
**/
namespace E9_PalindromeNumber
{
    class PalindromeNumberClass
    {
        public bool IsPalindrome ( int x )
        {
            if ( x < 0 )
                return  false;
            else 
            {
                string nums = x.ToString ();
                string [] numAray = nums.Select (s => s.ToString ()).ToArray ();
                string [ ] reverseNumAry = numAray.Reverse ().ToArray();
                return Enumerable.SequenceEqual(numAray, reverseNumAry);

            }

        }
    }
}