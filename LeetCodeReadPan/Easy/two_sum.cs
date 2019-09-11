using System.Collections.Generic;

namespace LeetCodeReadPan.Easy
{
    /**
    给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

    你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

    示例:

    给定 nums = [2, 7, 11, 15], target = 9

    因为 nums[0] + nums[1] = 2 + 7 = 9
    所以返回 [0, 1]

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/two-sum
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    public class two_sum
    {
        //最笨的写法, 耗时
        public int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }

            return null;
        }

        //使用哈希表存储已经验证过的值和索引信息, 在后面的运算中比较接下来迭代的值, 如果目标数-当前迭代数所的得到的值,
        //存在于哈希表中, 就可以直接获得相应索引
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i]; //目标数-当前数=另一个目标数
                if (dictionary.ContainsKey(complement))
                {
                    return new[] {dictionary[complement], i};
                }

                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i], i);
            }

            return null;
        }
    }
}