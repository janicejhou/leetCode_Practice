using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*@author : janice_chou
*@date : 2021/11/1 下午 05:16:32
**/
namespace leetCode_Practice.E20_ValidParentheses
{
    class ValidParenthesesClass
    {
        public bool IsValid ( string s )
        {
            // 將字串逐一走訪，若有找到相對應的括弧，則從原先的字串移除，剩下若沒有找到的則為false
            var sAry = s.Select (a => a.ToString ()).ToArray ();
            string temp = "";
            for ( int i = 0 ; i < sAry.Length ; i++ )
            {
                if ( i > 0 )
                {
                    temp = temp + sAry [ i ];
                    if ( temp.Contains ("()") ) 
                        temp = temp.Replace ("()" , "");
                    if( temp.Contains ("[]") )
                        temp = temp.Replace ("[]" , "");
                    if ( temp.Contains ("{}") )
                        temp = temp.Replace ("{}" , "");
                }
                else
                    temp = temp + sAry [ i ];
            }
            return temp == "" ? true : false;  

        }
    }
}
