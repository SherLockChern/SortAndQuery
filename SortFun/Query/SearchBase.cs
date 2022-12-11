using System;

namespace SortFun.Query
{
    public abstract class SearchBase : ISearch
    {
        public int Search(int[] list, int dest)
        {
            Console.WriteLine($"开始查找 {dest}, list: {ArrayHelper.ArrayToString(list)}");
            return ToSearch(list, dest);
        }

        protected abstract int ToSearch(int[] list, int dest);
    }
}