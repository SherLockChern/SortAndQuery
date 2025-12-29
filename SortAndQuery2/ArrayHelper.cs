using System.Text;

namespace SortFun
{
    public static class ArrayHelper
    {
        public static string ArrayToString(int[] list)
        {
            StringBuilder ret = new StringBuilder();
            int count = list.Length;
            ret.Append("{");
            for (int i = 0; i < count; i++)
            {
                ret.Append(i == count - 1
                    ? list[i].ToString() + $"[{i}]"
                    : list[i].ToString() + $"[{i}]" + ", ");
            }

            ret.Append("}");
            return ret.ToString();
        }
    }
}