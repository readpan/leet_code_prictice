using System;
using System.Collections.Generic;

namespace LeetCodeReadPan.Easy
{
    /**
     给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
    示例 1:

    输入: 123
    输出: 321
     示例 2:

    输入: -123
    输出: -321
    示例 3:

    输入: 120
    输出: 21
    注意:

    假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/reverse-integer
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    public class reverse_integer
    {
        /**
         * 自己想的方法
         * 将数字转换成字符, 然后进行倒置
         * 时间和空间复杂度都是O(n)
         */
        public int Reverse1(int x)
        {
            try
            {
                int result = 0;
                string s = x.ToString();
                if (x >= 0)
                {
                    char[] cs = new char[s.Length];
                    for (int i = 0; i < s.Length; i++)
                    {
                        cs[cs.Length - i - 1] = s[i];
                    }

                    result = int.Parse(new string(cs));
                }
                else
                {
                    char[] cs = new char[s.Length - 1];
                    for (int i = 1; i < s.Length; i++)
                    {
                        cs[cs.Length - i] = s[i];
                    }

                    result = -int.Parse(new string(cs));
                }

                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        /**
         * 使用数学方法进行倒置
         * https://leetcode-cn.com/problems/reverse-integer/solution/zheng-shu-fan-zhuan-by-leetcode/
         */
        public int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                //是正数情况
                //当前值如果大于int最大值/10, 说明无论接下来加几都会溢出
                //如果等于最大值, 则要看pop是否大于7(7是int最大值的最后一位)
                int pop = x % 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7))
                    return 0;
                //负数的情况相同, 只是判断不同
                if (rev < int.MinValue / 10 || (rev == int.MinValue && pop < -8))
                    return 0;

                x /= 10;
                rev = rev * 10 + pop;
            }

            return rev;
        }
    }
}