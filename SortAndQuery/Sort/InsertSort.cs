using System;
using System.Collections;

namespace SortFun.Sort
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public class InsertSort : SortBase
    {
        protected override void ToSort(int[] list)
        {
            int insertValue;
            int index;
            int count = list.Length;
            for (int i = 1; i < count; i++)
            {
                insertValue = list[i];
                index = i - 1;
                Console.WriteLine($"插入值及下标：{insertValue}【{i}】，比较值及下标：{list[index]}【{index}】，list: {ArrayHelper.ArrayToString(list)}");
                while (index >= 0 && list[index] >= insertValue)
                {
                    list[index + 1] = list[index];
                    index--;
                    Console.WriteLine($"插入值<比较值，下标前移至【{index}】，list: {ArrayHelper.ArrayToString(list)}");
                }
                list[index + 1] = insertValue;
                Console.WriteLine($"插入值>=比较值，插入值插入到比较值之后，list: {ArrayHelper.ArrayToString(list)}");
            }
        }
    }
}