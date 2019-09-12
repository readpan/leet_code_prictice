namespace LeetCodeReadPan.Easy
{
    public class palindrome_number
    {
        public bool IsPalindrome(int x) {
            
            if (x < 0)
                return false;
            
            int rev = 0;
            int orign = x;
            while (x != 0)
            {
                //是正数情况
                //当前值如果大于int最大值/10, 说明无论接下来加几都会溢出
                //如果等于最大值, 则要看pop是否大于7(7是int最大值的最后一位)
                int pop = x % 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7))
                    return false;
                //负数的情况相同, 只是判断不同
                if (rev < int.MinValue / 10 || (rev == int.MinValue && pop < -8))
                    return false;

                x /= 10;
                rev = rev * 10 + pop;
            }

            return rev == orign;
        }
    }
}