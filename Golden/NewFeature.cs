using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golden
{
    public class NewFeature
    {
        /// <summary>
        /// out 参数
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int ParseInt(string obj)
        {
            //out 参数
            if (!int.TryParse(obj, out var result))
            {
                return 0;
            }
            return result;
        }

        public static (string First,string Second) GetName(IEnumerable<string> strings)
        {
            return (strings.ToList()[0], strings.ToList<string>()[strings.Count() - 1]);
        }


        public static ref int Find(int[,] matrix,Func<int,bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (predicate(matrix[i,j]))
                    {
                        return ref matrix[i, j];
                    }
                }
            }
            throw new InvalidOperationException("not found");
        }
    }
}
