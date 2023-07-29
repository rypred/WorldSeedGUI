using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeedGUI
{
    public class RangeTable
    {
        public static int[] rangeArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] springRangeArray = { 3, 5, 6, 20, 21, 50, 51, 80, 81, 99 };
        public static int[] summerRangeArray = { 2, 5, 6, 30, 31, 70, 71, 75, 76, 99 };
        public static int[] fallRangeArray = { 3, 10, 11, 20, 21, 52, 53, 75, 76, 99 };
        public static int[] winterRangeArray = { 2, 20, 21, 30, 31, 40, 41, 60, 61, 99 };
        public static void AssignRange(string seasonAssign)
        {
            switch (seasonAssign)
            {
                case "Spring":
                    rangeArray = springRangeArray;
                    break;
                case "Summer":
                    rangeArray = summerRangeArray;
                    break;
                case "Fall":
                    rangeArray = fallRangeArray;
                    break;
                case "Winter":
                    rangeArray = winterRangeArray;
                    break;
            }
        }
    }
}
