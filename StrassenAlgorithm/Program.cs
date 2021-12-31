using System;
/// <summary>
/// 21.12.31 수정중...
/// </summary>

namespace StrassenAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] testA = new int[2,2] { { 1, 2 }, { 3, 4 } };
            //int[,] testB = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            //int[,] testC = new int[2,2];

            //testC = Square_Matrix_Multiply(testA, testB);
            //Console.WriteLine("{0} {1} {2} {3}", testC[0, 0], testC[0, 1], testC[1, 0], testC[1, 1]);
            int[] testArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        
        
        }

        static void testArray(int[][] A)
        {
            int n = 4;
            int[][] B = new int[n][n];


            for(int i=0;i<;i++)
            {
                A11[i] = A[i];
            }

        }

        //static int[] Square_Matrix_Multiply_Recursive(int[] A,int[] B ,int Ai,int Aj,int Bi,int Bj)
        //{
        //    int n = (int)Math.Sqrt(A.Length);
        //    int[] C = new int[A.Length];

        //    if(n ==1)
        //    {
        //        C[0] = A[0] * B[0];
        //    }
        //    else
        //    {
        //        n = n / 2;

        //        C[0] = A[0]

        //    }


        //    return C
        //}

        //static int[,] Square_Matrix_Multiply_Recursive(int[,] A,int[,] B)
        //{
        //    int n = A.GetLength(0);
        //    int[,] C = new int[n, n];
        //    if( n ==1)
        //    {
        //        C[n, n] = A[n, n] * B[n, n];
        //    }
        //    else
        //    {
        //        n = n / 2;
        //        C[0, 0] = Square_Matrix_Multiply_Recursive(A[0, 0], B[0, 0]) + Square_Matrix_Multiply_Recursive(A[0, 1], B[1, 0]);


        //    }
        //    return C;

        //}

        /// <summary>
        /// 복잡도 O(N^3)
        /// methoed when i don't use StrassenAlgorithm 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static  int[,] Square_Matrix_Multiply(int[,] A,int[,] B)
        {
            int n = A.GetLength(0);
            // C는 n X n 정방 행렬
            int[,] C = new int[n,n];
            
            for(int i=0; i<n;i ++)
            {
                for(int j=0;j<n;j++)
                {
                    C[i,j] = 0;
                    for(int  k=0;k<n;k++)
                    {
                        C[i,j] = C[i,j] + A[i,k] * B[k,j];
                    }
                }
            }
            return C;
        }
    }
}
