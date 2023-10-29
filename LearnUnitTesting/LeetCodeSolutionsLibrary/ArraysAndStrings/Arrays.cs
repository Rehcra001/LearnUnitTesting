using LeetCodeSolutionsLibrary.SortingAlgorithms;

namespace LeetCodeSolutionsLibrary.ArraysAndStrings
{
    public static class Arrays
    {
        public static int ArrayPairSum(int[] nums)
        {
            Sort<int>.QuickSort(nums, 0, nums.Length - 1);

            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }

            return sum;
        }
        //Given a 1-indexed array of integers numbers that is already sorted
        //in non-decreasing order, find two numbers such that they add up to
        //a specific target number.Let these two numbers be numbers[index1]
        //and numbers[index2] where 1 <= index1<index2<numbers.length.
        //Return the indices of the two numbers, index1 and index2, added by
        //one as an integer array[index1, index2] of length 2.
        //The tests are generated such that there is exactly one solution.
        //You may not use the same element twice.
        //Your solution must use only constant extra space.
        //Constraints:
        //2 <= numbers.length <= 3 * 10^4
        //-1000 <= numbers[i] <= 1000 
        //numbers is sorted in non-decreasing order.
        //-1000 <= target <= 1000
        //The tests are generated such that there is exactly one solution.
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            int left = 0;
            int right = numbers.Length - 1;

            while (numbers[left] + numbers[right] > target)
            {
                right--;
            }

            while (left < right && numbers[left] + numbers[right] != target)
            {
                if (numbers[left] + numbers[right] < target)
                {
                    //increment left to get closer to target
                    left++;
                }
                else if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
            }
            result[0] = left + 1;
            result[1] = right + 1;
            return result;
        }
        //Given an integer array nums and an integer val, remove all occurrences
        //of val in nums in-place.The order of the elements may be changed.
        //Then return the number of elements in nums which are not equal to val.
        //Consider the number of elements in nums which are not equal to val be k,
        //to get accepted, you need to do the following things:
        //Change the array nums such that the first k elements of nums contain
        //the elements which are not equal to val.The remaining elements of nums
        //are not important as well as the size of nums.
        //Return k.

        //Constraints:
        //0 <= nums.length <= 100
        //0 <= nums[i] <= 50
        //0 <= val <= 100
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums is null || nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1 && nums[0] != val)
            {
                return 1;
            }

            int k = 0;
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                while (left <= nums.Length - 1 && nums[left] != val && left <= right)
                {
                    k++;
                    left++;

                }

                while (right >= 0 && nums[right] == val && right >= left)
                {
                    right--;
                }

                if (right > 0 && left < nums.Length - 1)
                {
                    //swap
                    nums[left] = nums[right];
                    //decrement
                    right--;
                }

            }

            return k;
        }

        public static int RemoveElement2(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        //Given a binary array nums, return the maximum number
        //of consecutive 1's in the array.

        //Constraints:
        //1 <= nums.length <= 10^5
        //nums[i] is either 0 or 1.

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxOnes = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > maxOnes)
                {
                    maxOnes = count;
                }
            }
            return maxOnes;
        }

        //Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

        //Constraints:
        //1 <= nums.length <= 10^5
        //-2^31 <= nums[i] <= 2^31 - 1
        //0 <= k <= 105
        public static void Rotate(int[] nums, int k)
        {
            //check k
            if (k > nums.Length)
            {
                k = k % nums.Length;
            }
            else if (k == nums.Length)
            {
                return; // No rotaion needed
            }

            int len = nums.Length;

            //Partition and reverse each partition
            int left = 0;
            int right = len - 1;
            int partition = len - k;

            ReversePartition(nums, left, partition - 1);
            ReversePartition(nums, partition, right);
            ReversePartition(nums, left, right);
        }

        private static void ReversePartition(int[] arr, int left, int right)
        {
            while (left < right)
            {
                //swap
                (arr[left], arr[right]) = (arr[right], arr[left]);
                //move left
                left++;
                //move right
                right--;
            }
        }

        public static void Rotate2(int[] nums, int k)
        {
            //check k
            if (k > nums.Length)
            {
                k = k % nums.Length;
            }
            else if (k == nums.Length)
            {
                return; // No rotaion needed
            }

            int len = nums.Length;
            int startIndex = len - k;
            int[] result = new int[len];

            for (int i = startIndex; i < len; i++)
            {
                result[i - startIndex] = nums[i];
            }

            for (int i = 0; i < startIndex; i++)
            {
                result[i + k] = nums[i];
            }

            for (int i = 0; i < len; i++)
            {
                nums[i] = result[i];
            }
        }

        public static void Rotate3(int[] nums, int k)
        {
            //check k
            if (k > nums.Length)
            {
                k = k % nums.Length;
            }
            else if (k == nums.Length)
            {
                return; // No rotaion needed
            }
            RotateByOne(nums, k);
        }

        private static void RotateByOne(int[] nums, int k)
        {
            //Base case
            if (k == 0)
            {
                return;
            }

            //K > 0 
            RotateByOne(nums, k - 1);

            int len = nums.Length;
            int last = nums[len - 1];

            for (int i = len - 1; i >= 1; i--)
            {
                nums[i] = nums[i - 1];
            }

            nums[0] = last;
        }

        //Given an integer array nums sorted in non-decreasing order, remove the
        //duplicates in-place such that each unique element appears only once.
        //The relative order of the elements should be kept the same.Then return
        //the number of unique elements in nums.
        //Consider the number of unique elements of nums to be k, to get accepted,
        //you need to do the following things:
        //Change the array nums such that the first k elements of nums contain the
        //unique elements in the order they were present in nums initially.
        //The remaining elements of nums are not important as well as the size of nums.
        //Return k.

        //Constraints:
        //1 <= nums.length <= 3 * 10^4
        //-100 <= nums[i] <= 100
        //nums is sorted in non-decreasing order.
        public static int RemoveDuplicates(int[] nums)
        {
            int length = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    //move
                    nums[length] = nums[i];
                    length++;
                }
            }
            return length;
        }

        //Given an integer array nums, move all 0's to the end of it while maintaining
        //the relative order of the non-zero elements.
        //Note that you must do this in-place without making a copy of the array.

        //Example
        //Input: nums = [0,1,0,3,12]
        //Output: [1,3,12,0,0]

        //Constraints:
        //1 <= nums.length <= 104
        //-2^31 <= nums[i] <= 2^31 - 1
    }
}
