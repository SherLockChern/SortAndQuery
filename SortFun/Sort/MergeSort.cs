using System;

namespace SortFun.Sort
{
    /// <summary>
    /// 归并排序
    /// </summary>
    public class MergeSort : SortBase
    {
        protected override void ToSort(int[] list)
        {
            int[] temp = new int[list.Length];
            _MergeSort(list, 0, list.Length - 1, temp);
        }

        private void _MergeSort(int[] list, int left, int right, int[] temp)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Console.WriteLine($"开始分左边 left: {left} mid: {mid} right: {right}, temp: {ArrayHelper.ArrayToString(temp)}");
                _MergeSort(list, left, mid, temp);
                
                Console.WriteLine($"开始分右边 left: {left} mid: {mid} right: {right}, temp: {ArrayHelper.ArrayToString(temp)}");
                _MergeSort(list, mid + 1, right, temp);
                
                Console.WriteLine($"开始治 left: {left} mid: {mid} right: {right}, temp: {ArrayHelper.ArrayToString(temp)}");
                _Sort(list, left, mid, right, temp);
            }
        }

        private void _Sort(int[] list, int left, int mid, int right, int[] temp)
        {
            int leftIdx = left;
            int rightIdx = mid + 1;
            int tempIdx = 0;
            Console.WriteLine($"治 left: {left} mid: {mid} right: {right}, temp: {ArrayHelper.ArrayToString(temp)}");
            while (leftIdx <= mid && rightIdx <= right)
            {
                Console.WriteLine($"leftIdx: {leftIdx} tempIdx: {tempIdx} rightIdx: {rightIdx}");
                if (list[leftIdx] < list[rightIdx])
                {
                    temp[tempIdx] = list[leftIdx];
                    leftIdx++;
                    tempIdx++;
                }
                else
                {
                    temp[tempIdx] = list[rightIdx];
                    rightIdx++;
                    tempIdx++;
                }
            }

            while (leftIdx <= mid)
            {
                temp[tempIdx] = list[leftIdx];
                leftIdx++;
                tempIdx++;
            }

            while (rightIdx <= right)
            {
                temp[tempIdx] = list[rightIdx];
                rightIdx++;
                tempIdx++;
            }

            tempIdx = 0;
            int leftIdx2 = left;
            while (leftIdx2 <= right)
            {
                list[leftIdx2] = temp[tempIdx];
                tempIdx++;
                leftIdx2++;
            }
        }
    }
}