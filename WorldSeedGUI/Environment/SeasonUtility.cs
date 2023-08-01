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
            bool isMiddleOfFall = selectedMonth == "Ayles" || selectedMonth == "Attas" || selectedMonth == "Neldes";
            bool isEndOfFall = selectedMonth == "Elkes" && selectedDay <= 16;
            seasonAssign = "Fall";
            return isMiddleOfFall || isEndOfFall;
        }
        public bool isWinter(string selectedMonth, int selectedDay, out string seasonAssign)
        {
            bool isMiddleOfWinter = selectedMonth == "Levanus" || selectedMonth == "Cantas";
            bool isEndOfWinter = selectedMonth == "Elkes" && selectedDay >= 17;
            bool isLastDayOfWinter = selectedMonth == "Enques" && selectedDay != 35;
            seasonAssign = "Winter";
            return isMiddleOfWinter || isEndOfWinter || isLastDayOfWinter;
        }
        public bool isSpring(string selectedMonth, int selectedDay, out string seasonAssign)
        {
            bool isMiddleOfSpring = selectedMonth == "Kirrus" || selectedMonth == "Toltos" || selectedMonth == "Nertës";
            bool isStartOfSpring = selectedMonth == "Enques" && selectedDay == 35;
            bool isEndOfSpring = selectedMonth == "Selthas" && selectedDay <= 16;
            seasonAssign = "Spring";
            return isMiddleOfSpring || isStartOfSpring || isEndOfSpring;
        }
        public bool isSummer(string selectedMonth, int selectedDay, out string seasonAssign)
        {
            bool isMiddleOfSummer = selectedMonth == "Heldas" || selectedMonth == "Minquës" || selectedMonth == "Yunquës";
            bool isStartOfSummer = selectedMonth == "Selthas" && selectedDay >= 17;
            seasonAssign = "Summer";
            return isMiddleOfSummer || isStartOfSummer;
        }
    }
}
