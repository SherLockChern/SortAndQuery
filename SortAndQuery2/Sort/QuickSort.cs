using System;

namespace SortFun.Sort
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class QuickSort : SortBase
    {
        protected override void ToSort(int[] list)
        {
            _ToSort(list, 0, list.Length - 1);
        }

        private void _ToSort(int[] list, int left, int right)
        {
            int l = left;
            int r = right;
            int midIdx = (left + right) / 2;
            int mid = list[midIdx];
            int temp;
            Console.WriteLine("");
            Console.WriteLine($"递归开始 left: {left}, right: {right}, midIdx: {midIdx}, midValue: {mid} list: {ArrayHelper.ArrayToString(list)}");
            while (l < r)
            {
                while (list[l] < mid)
                {
                    l++;
                }
                Console.WriteLine($"左值lIdx:{l} lValue: {list[l]} 大于等于中间值midIdx: {midIdx} midValue: {mid}");
                while (list[r] > mid)
                {
                    r--;
                }
                Console.WriteLine($"右值rIdx:{r} rValue: {list[r]} 小于等于中间值midIdx: {midIdx} midValue: {mid}");

                if (l >= r)
                {
                    Console.WriteLine($"左下标>=右下标 lIdx: {l}, rIdx: {r}, 结束本轮循环, list: {ArrayHelper.ArrayToString(list)}");
                    break;
                }
                Console.WriteLine($"左右数值交换 lIdx: {l} lValue: {list[l]}, rIdx: {r} rValue: {list[r]}");
                temp = list[l];
                list[l] = list[r];
                list[r] = temp;
                Console.WriteLine($"左右数值交换后 list: {ArrayHelper.ArrayToString(list)}");

                if (list[l] == mid)
                {
                    Console.WriteLine($"左下标已到中间值midValue: {mid} 暂停 右下标继续左移 当前lIdx: {l}, lValue: {list[l]} 当前rIdx: {r} rValue: {list[r]}, list: {ArrayHelper.ArrayToString(list)}");
                    r--;
                    Console.WriteLine($"左下标已到中间值midValue: {mid} 暂停 右下标继续左移 右下标左移至rIdx: {r}, list: {ArrayHelper.ArrayToString(list)}");
                }

                if (list[r] == mid)
                {
                    Console.WriteLine($"右下标已到中间值midValue: {mid} 暂停 左下标继续右移 当前lIdx: {l} lValue: {list[l]} 当前rIdx: {r} rValue: {list[r]}, list: {ArrayHelper.ArrayToString(list)}");
                    l++;
                    Console.WriteLine($"右下标已到中间值midValue: {mid} 暂停 左下标继续右移 左下标右移至lIdx: {l}, list: {ArrayHelper.ArrayToString(list)}");
                }
                
            }
            Console.WriteLine($"左下标 >= 右下标 while循环结束 当前左下标lIdx: {l}, 当前右下标rIdx: {r}, list: {ArrayHelper.ArrayToString(list)}");

            if (l == r)
            {
                Console.WriteLine($"左右下标相等 lIdx: {l}, rIdx: {r}, list: {ArrayHelper.ArrayToString(list)}");
                l++;
                r--;
                Console.WriteLine($"左下标++，右下标-- lIdx: {l}, rIdx: {r}, list: {ArrayHelper.ArrayToString(list)}");
            }

            if (left < r)
            {
                Console.WriteLine($"左初始下标 < 右下标 递归从左初始下标->右下标 left: {left}, rIdx: {r}, list: {ArrayHelper.ArrayToString(list)}");
                _ToSort(list, left, r);
                Console.WriteLine($"递归结束 当前lIdx: {l} left: {left} rIdx: {r} right: {right}");
            }

            if (right > l)
            {
                Console.WriteLine($"左下标 < 右初始下标 递归从左下标->右初始下标 lIdx: {l}, right: {right}, list: {ArrayHelper.ArrayToString(list)}");
                _ToSort(list, l, right);
                Console.WriteLine($"递归结束 当前lIdx: {l} left: {left} rIdx: {r} right: {right}");
            }
        }
    }
}