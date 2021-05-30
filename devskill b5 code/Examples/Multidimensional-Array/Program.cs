using System;

namespace Multidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            int[,] array = new int[4, 2];
            array[2, 1] = 5;
            int x = array[2, 1];
            #endregion

            #region Example 2
            int[,,] array1 = new int[4, 2, 3];
            array1[1, 1, 1] = 9;

            #endregion

            #region Example 3
            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] 
            { 
                { 
                    { 1, 2, 3 }, { 4, 5, 6 } 
                },
                                 
                { 
                    { 7, 8, 9 }, { 10, 11, 12 } 
                } 
            };
            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            #endregion
        }
    }
}
