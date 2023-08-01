using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeedGUI.Environment
{
    public class SeasonUtility
    {
        public bool isFall(string selectedMonth, int selectedDay, out string seasonAssign)
        {
            bool isMiddleOfFall = selectedMonth == "month1" || selectedMonth == "month2" || selectedMonth == "month3";
            bool isEndOfFall = selectedMonth == "month4" && selectedDay <= 16;
            seasonAssign = "Fall";
            return isMiddleOfFall || isEndOfFall;
        }
        public bool isWinter(string selectedMonth, int selectedDay, out string seasonAssign)
        {
            bool isMiddleOfWinter = selectedMonth == "month5" || selectedMonth == "month6";
            bool isEndOfWinter = selectedMonth == "month4" && selectedDay >= 17;
            bool isLastDayOfWinter = selectedMonth == "month 7" && selectedDay != 35;
            seasonAssign = "Winter";
            return isMiddleOfWinter || isEndOfWinter || isLastDayOfWinter;
        }
        public bool isSpring(string selectedMonth, int selectedDay, out string seasonAssign)
        {
            bool isMiddleOfSpring = selectedMonth == "month8" || selectedMonth == "month9" || selectedMonth == "month10";
            bool isStartOfSpring = selectedMonth == "month7" && selectedDay == 35;
            bool isEndOfSpring = selectedMonth == "month11" && selectedDay <= 16;
            seasonAssign = "Spring";
            return isMiddleOfSpring || isStartOfSpring || isEndOfSpring;
        }
        public bool isSummer(string selectedMonth, int selectedDay, out string seasonAssign)
        {
            bool isMiddleOfSummer = selectedMonth == "month12" || selectedMonth == "month13" || selectedMonth == "month14";
            bool isStartOfSummer = selectedMonth == "month11" && selectedDay >= 17;
            seasonAssign = "Summer";
            return isMiddleOfSummer || isStartOfSummer;
        }
    }
}
