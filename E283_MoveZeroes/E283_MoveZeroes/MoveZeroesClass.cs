using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E283_MoveZeroes
{
    public class MoveZeroesClass
    {
        public void MoveZeroes ( int [ ] nums )
        {
            Object [ ] saveZeros = new Object [ nums.Length ];
            Object [ ] saveNotZeros = new Object [ nums.Length ];
            for ( int i = 0 ; i < nums.Length ; i++ )
            {
                // 將有0的元素與非0的元素提出，分開儲存
                if ( nums [ i ] == 0 )
                {
                    for ( int j = 0 ; j < saveZeros.Length ; j++ )
                    {
                        if ( saveZeros [ j ] == null )
                        {
                            saveZeros [ j ] = nums [ i ];
                            break;
                        }
                    }

                }
                else
                {
                    for ( int j = 0 ; j < saveNotZeros.Length ; j++ )
                    {
                        if ( saveNotZeros [ j ] == null )
                        {
                            saveNotZeros [ j ] = nums [ i ];
                            break;
                        }
                    }
                }

            }

            // 先將 nums清空
            Array.Clear (nums , 0 , nums.Length);

            // 若儲存非0的元素陣列不為空，依序將值儲存至nums
            if ( saveNotZeros.GetValue (0) != null )
            {
                for ( int i = 0 ; i < nums.Length ; i++ )
                {
                    // 若 saveNotZeros的值不為null
                    if ( saveNotZeros.GetValue (i) != null )
                        nums [ i ] = ( int ) saveNotZeros.GetValue (i);
                    else
                        continue;
                }
            }
            else
            {

                for ( int i = 0 ; i < nums.Length ; i++ )
                {
                    // 若 saveZeros的值不為null
                    if ( saveZeros.GetValue (i) != null )
                        nums [ i ] = ( int ) saveZeros.GetValue (i);
                    else
                        continue;
                }

            }
        }
    }
}
