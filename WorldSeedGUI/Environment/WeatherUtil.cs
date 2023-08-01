using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeedGUI.Environment
{
    internal class WeatherUtil
    {
        public static string randomizeWeather(int weatherNum, string weatherType1, string weatherType2, string weatherType3, string weatherType4, string weatherType5, string weatherType6, string weatherType7)
        {
            switch (weatherNum)
            {
                case int i when i < RangeTable.rangeArray[0]:
                    return weatherType1;
                   
                case int i when i >= RangeTable.rangeArray[0] && i <= RangeTable.rangeArray[1]:
                    return weatherType2;
                    //EnvironmentWindow.label1.Text = weatherType2;
                    //break;
                case int i when i >= RangeTable.rangeArray[2] && i <= RangeTable.rangeArray[3]:
                    return weatherType3;
                    //EnvironmentWindow.label1.Text = weatherType3;
                    //break;
                case int i when i >= RangeTable.rangeArray[4] && i <= RangeTable.rangeArray[5]:
                    return weatherType4;
                    //EnvironmentWindow.label1.Text = weatherType4;
                    //break;
                case int i when i >= RangeTable.rangeArray[6] && i <= RangeTable.rangeArray[7]:
                    return weatherType5;
                    //EnvironmentWindow.label1.Text = weatherType5;
                    //break;
                case int i when i >= RangeTable.rangeArray[8] && i <= RangeTable.rangeArray[9]:
                    return weatherType6;
                    //EnvironmentWindow.label1.Text = weatherType6;
                    //break;
                case int i when i == 100:
                    return weatherType7;
                    //EnvironmentWindow.label1.Text = weatherType7;
                    //break;
                default
                    : return "Error in random number assignment";
            }
        }
    }
}
