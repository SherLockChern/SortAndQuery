using System;

namespace SortFun.Sort
{
    /// <summary>
    /// 选择排序
    /// </summary>
    public class SelectionSort : SortBase
    {
        protected override void ToSort(int[] list)
        {
            int count = list.Length;
            int mixNum;
            int index;
            int temp;
            for (int i = 0; i < count - 1; i++)
            {
                Console.WriteLine($"第{i}轮");
                mixNum = list[i];
                index = i;
                for (int j = i; j < count; j++)
                {
                    if (list[j] < mixNum)
                    {
                        mixNum = list[j];
                        index = j;
                    }
                }
                Console.WriteLine($"最小值：{mixNum}， 最小值索引：{index}");
                temp = list[i];
                list[i] = list[index];
                list[index] = temp;
            }
        }
    }
}