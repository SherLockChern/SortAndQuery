using SortFun.Sort;

namespace SortFun;

public class Start
{
    private ISort sortFun;

    public void OnStart()
    {
        int[] arr1 = new[] { -4, 12, 555, 24, 16, 24, -1, 11 };
        // ISort sortFun = new BubbleSort();
        // ISort sortFun = new SelectionSort();
        // ISort sortFun = new InsertSort();
        // ISort sortFun = new QuickSort();
        sortFun = new MergeSort();
        sortFun.Sort(arr1);
    }
}