using System;

namespace SortFun.Sort
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort : SortBase
    {
        protected override void ToSort(int[] list)
        {
            var count = list.Length;
            int temp = 0;
            bool flag = false;
            for (int i = 0; i < count - 1; i++)
            {
                Console.WriteLine($"第{i}轮, list: {ArrayHelper.ArrayToString(list)}");
                for (int j = 0; j < count - 1 - i; j++)
                {
                    Console.WriteLine($"j: {j}, j+1: {j + 1},  list[j]: {list[j]}, list[j + 1]: {list[j + 1]}, list: {ArrayHelper.ArrayToString(list)}");
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                        flag = true;
                    }
                }

                if (!flag)
                {
                    break;
                }
            }
        }
    }
}