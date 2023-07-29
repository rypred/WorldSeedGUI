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
        public static int rangeVariable1 = 0;
        public static int rangeVariable2 = 0;
        public static int rangeVariable3 = 0;
        public static int rangeVariable4 = 0;
        public static int rangeVariable5 = 0;
        public static int rangeVariable6 = 0;
        public static int rangeVariable7 = 0;
        public static int rangeVariable8 = 0;
        public static int rangeVariable9 = 0;
        public static int rangeVariable10 = 0;
        public static int rangeVariable11 = 0;

        public static void AssignRange(string seasonAssign)
        {
            switch (seasonAssign)
            {
                case "Spring":
                    rangeVariable1 = 3;
                    rangeVariable2 = 3;
                    rangeVariable3 = 5;
                    rangeVariable4 = 6;
                    rangeVariable5 = 20;
                    rangeVariable6 = 21;
                    rangeVariable7 = 50;
                    rangeVariable8 = 51;
                    rangeVariable9 = 80;
                    rangeVariable10 = 81;
                    rangeVariable11 = 99;
                    break;
                case "Summer":
                    rangeVariable1 = 2;
                    rangeVariable2 = 2;
                    rangeVariable3 = 5;
                    rangeVariable4 = 6;
                    rangeVariable5 = 30;
                    rangeVariable6 = 31;
                    rangeVariable7 = 70;
                    rangeVariable8 = 71;
                    rangeVariable9 = 75;
                    rangeVariable10 = 76;
                    rangeVariable11 = 99;
                    break;
                case "Fall":
                    rangeVariable1 = 3;
                    rangeVariable2 = 3;
                    rangeVariable3 = 10;
                    rangeVariable4 = 11;
                    rangeVariable5 = 20;
                    rangeVariable6 = 21;
                    rangeVariable7 = 52;
                    rangeVariable8 = 53;
                    rangeVariable9 = 75;
                    rangeVariable10 = 76;
                    rangeVariable11 = 99;
                    break;
                case "Winter":
                    rangeVariable1 = 2;
                    rangeVariable2 = 2;
                    rangeVariable3 = 20;
                    rangeVariable4 = 21;
                    rangeVariable5 = 30;
                    rangeVariable6 = 31;
                    rangeVariable7 = 40;
                    rangeVariable8 = 41;
                    rangeVariable9 = 60;
                    rangeVariable10 = 61;
                    rangeVariable11 = 99;
                    break;
            }
        }
    }
}
