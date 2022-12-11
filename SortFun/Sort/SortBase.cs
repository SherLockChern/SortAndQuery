using System;

namespace SortFun.Sort
{
    public abstract class SortBase : ISort
    {
        public void Sort(int[] list)
        {
            Console.WriteLine("排序前：" + ArrayHelper.ArrayToString(list));
            Console.WriteLine($"数组总数：{list.Length}");
            ToSort(list);
            Console.WriteLine("排序后：" + ArrayHelper.ArrayToString(list));
        }

        protected abstract void ToSort(int[] list);
    }
}