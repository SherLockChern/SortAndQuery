// namespace SortFun.Algorithm
// {
//     //背包问题
//     public class KnapsackProblem
//     {
//         public void DoWork()
//         {
//             int[] w = {1, 4, 3};//物品的重量
//             int[] val = {1500, 3000, 2000}; //物品的价格
//             int m = 4; //总重量
//             int n = val.Length; //价格的种类
//
//             //创建二维数组
//             //v[i][j] 表示在的i个物品中能够装入容量为j的背包中的最大价值
//             int[,] v = new int[n+1, m+1];
//             //辅助二维数组
//             int[,] path = new int[n+1, m+1];
//
//             //初始化第一行和第一列
//             for (int i = 0; i < v.Length; i++) 
//             {
//                 v[i][0] = 0;
//             }
//             for (int i=0; i < v[0].Length; i++) 
//             {
//                 v[0][i] = 0;
//             }
//
//             for (int i = 1; i < v.Length; i++) 
//             { 
//                 for(int j = 1; j < v[0].Length; j++) 
//                 {
//                     if(w[i-1] > j) 
//                     {
//                         v[i][j] = v[i-1][j];
//                     } 
//                     else 
//                     {
//                         if(v[i - 1][j] < val[i - 1] + v[i - 1][j - w[i - 1]]) {
//                             v[i][j] = val[i - 1] + v[i - 1][j - w[i - 1]];
//                             path[i][j] = 1;
//                         } else {
//                             v[i][j] = v[i - 1][j];
//                         }
//                     }
//                 }
//             }
//
//             //价格表
//             for (int i =0; i < v.Length;i++) 
//             {
//                 for (int j = 0; j < v[i].Length;j++) 
//                 {
//                     Console.WriteLine(v[i][j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//
//             Console.WriteLine("============================");
//
//             int i1 = path.Length - 1;
//             int j1 = path[0].Length - 1;
//             while(i1 > 0 && j1 > 0 ) {
//                 if(path[i1][j1] == 1) {
//                     Console.WriteLine("第%d个商品放入背包\n", i1); 
//                     j1 -= w[i1-1];
//                 }
//                 i1--;
//             }
//         }
//     }
// }
