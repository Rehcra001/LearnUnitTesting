namespace LeetCodeSolutionsLibrary.SortingAlgorithms
{
    public static class Sort<T> where T : IComparable
    {
        private static T[]? _tempArray = null;

        public static void MergeSort(T[] arr, int leftIndex, int rightIndex)
        {
            //To be used in the merge phase
            if (_tempArray == null)
            {
                _tempArray = new T[arr.Length];
            }

            //Make sure partition is greater than one
            if (leftIndex < rightIndex)
            {
                //Set partition index
                int midIndex = (leftIndex + rightIndex) / 2;

                //create left subpartiton
                MergeSort(arr, leftIndex, midIndex);

                //create right subpartition
                MergeSort(arr, midIndex + 1, rightIndex);

                //Merge the two subpartitions
                Merge(arr, leftIndex, midIndex, rightIndex);
            }
        }

        private static void Merge(T[] arr, int leftIndex, int midIndex, int rightIndex)
        {
            //Start on the left side partiton
            //between leftIndex and rightIndex
            int tempIndex = leftIndex;
            int leftSidePointer = leftIndex;
            int rightSidePointer = midIndex + 1;

            //compare the left side partition of element at leftSidePointer
            //to right side partiton of element at rightSidePointer
            while (leftSidePointer <= midIndex && rightSidePointer <= rightIndex)
            {
                if (arr[leftSidePointer].CompareTo(arr[rightSidePointer]) <= 0)
                {
                    //Copy reference to _tempArray at index tempIndex
                    _tempArray![tempIndex] = arr[leftSidePointer];
                    //increment
                    leftSidePointer++;
                    tempIndex++;
                }
                else
                {
                    //The element in the right partion is smaller
                    //Copy this element to _tempArray
                    _tempArray![tempIndex] = arr[rightSidePointer];
                    //increment
                    rightSidePointer++;
                    tempIndex++;
                }
            }

            //At this point either the left or the right partition
            //will still have elements not copied over to _tempArray
            if (leftSidePointer <= midIndex)
            {
                //left partition has elements not copied
                while (leftSidePointer <= midIndex)
                {
                    _tempArray![tempIndex] = arr[leftSidePointer];
                    //increment
                    leftSidePointer++;
                    tempIndex++;
                }
            }
            else
            {
                //The right partition still has elements not
                //copied to _tempArray
                while (rightSidePointer <= rightIndex)
                {
                    _tempArray![tempIndex] = arr[rightSidePointer];
                    //Increment
                    rightSidePointer++;
                    tempIndex++;
                }
            }

            //The ordered elements in the leftIndex to rightIndex partition
            //of _tempArray to be copied into the same partion of arr
            tempIndex = leftIndex;
            while (tempIndex <= rightIndex)
            {
                arr[tempIndex] = _tempArray![tempIndex];
                //increment
                tempIndex++;
            }
        }

        private static int Partion(T[] arr, int left, int pivot)
        {
            //use the last index as a pivot
            int right;

            for (right = left; right < pivot; right++)
            {
                if (arr[right].CompareTo(arr[pivot]) < 0)
                {
                    //swap with left index
                    (arr[right], arr[left]) = (arr[left], arr[right]);
                    left++;
                }
            }

            //swap element at pivot with left +1
            (arr[left], arr[pivot]) = (arr[pivot], arr[left]);

            //array should now be partitioned
            return left; //Pivot end position
        }

        public static void QuickSort(T[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = Partion(arr, left, right);

            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
        }
    }
}
