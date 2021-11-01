using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*@author : janice_chou
*@date : 2021/10/31 下午 08:47:54
**/
namespace leetCode_Practice.E14_LongestCommonPrefix
{
    class LongestCommonPrefixClass
    {
        /// <summary>
        /// 找共有的最長前綴字符串
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix ( string [ ] strs )
        {
            List<string [ ]> eachStrPrefix = new List<string [ ]> ();
            for ( int i = 0 ; i < strs.Length ; i++ )
            {
                var eachstr = strs [ i ].Select (s => s.ToString ()).ToArray ();
                eachStrPrefix.Add (eachstr);
            }

            string [ ] sTemp = new string [ eachStrPrefix.Count ];
            List<string> samePrefixs = new List<string> ();
            string samePrefix = "";

            // 從所有組字串中，以字串數量最少的為主
            var min = eachStrPrefix.Select (s => s.Length).Min ();

            for ( int j = 0 ; j < min ; j++ )
            {

                // 走訪各組字串，從第一組字串的第一個開始 ~ 最後一組的第一個字串
                for ( int i = 0 ; i < eachStrPrefix.Count ; i++ )
                    sTemp.SetValue (( string ) eachStrPrefix [ i ].GetValue (j) , i);

                // 判斷是否皆為相同的字串
                string first = sTemp [ 0 ];
                for ( int i = 1 ; i < sTemp.Length ; i++ )
                {
                    if ( sTemp [ i ] != sTemp [ 0 ] )
                    {
                        if ( samePrefix != null)
                            return samePrefix;
                        else
                            return samePrefix = "";
                    }
                    else
                        continue;
                }
                samePrefix = samePrefix + first;

            }

            return samePrefix;
        }

    }
}
