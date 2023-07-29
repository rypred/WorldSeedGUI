using System.Text.Unicode;

namespace WorldSeedGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool isFall(string selectedMonth, int selectedDay) 
        {
            if (selectedMonth == "month1" || selectedMonth == "month2" || selectedMonth == "month3")
                return true;
            else if (selectedMonth == "month4" && selectedDay <= 16)
                return true;
            else
                return false;
        }
        private bool isWinter(string selectedMonth, int selectedDay)
        {
            if (selectedMonth == "month5" || selectedMonth == "month6")
                return true;
            else if (selectedMonth == "month4" && selectedDay >= 17)
                return true;
            else if (selectedMonth == "month 7" && selectedDay !=35)
                return true;
            else
                return false;
        }
        private bool isSpring(string selectedMonth, int selectedDay)
        {
            if (selectedMonth == "month8" || selectedMonth == "month9" || selectedMonth == "month10")
                return true;
            else if (selectedMonth == "month7" && selectedDay == 35)
                return true;
            else if (selectedMonth == "month11" && selectedDay <= 16)
                return true;
            else
                return false;
        }
        private bool isSummer(string selectedMonth, int selectedDay)
        {
            if (selectedMonth == "month12" || selectedMonth == "month13" || selectedMonth == "month14")
                return true;
            else if (selectedMonth == "month11" && selectedDay >= 17)
                return true;
            else
                return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedMonth = this.comboBoxMonth.SelectedItem.ToString();
            string dayInput = this.comboBoxDay.SelectedItem.ToString();
            int selectedDay = int.Parse(dayInput);
            string seasonAssign = "";

            if (isFall(selectedMonth, selectedDay)) 
            {
                RangeTable.AssignRange(seasonAssign = "Fall");           
            }
            else if (isWinter(selectedMonth, selectedDay))
            {
                RangeTable.AssignRange(seasonAssign = "Winter");
            }
            else if (isSpring(selectedMonth, selectedDay))
            {
                RangeTable.AssignRange(seasonAssign = "Spring");
            }
            else if (isSummer(selectedMonth, selectedDay))
            {
                RangeTable.AssignRange(seasonAssign = "Summer");
            }
            else
            {
                Console.WriteLine($"Encountered Unexpected Season for {selectedMonth} {selectedDay}");
            }


            Random rnd = new Random();
            int weather = rnd.Next(1, 100);

            switch (seasonAssign)
            {
                case "Winter":
                    randomizeWeather(weather, "Blizzard", "Snow/Rain", "Freezing Cold", "Heavy Clouds", "Light Clouds", "Clear Skies", "Strange Phenomena");
                    break;
                case "Summer":
                    randomizeWeather(weather, "Thunderstorm", "Rain", "Light Clouds", "Clear Skies", "High Winds", "Scorching Heat", "Strange Phenomena");
                    break;
                case "Fall":
                    randomizeWeather(weather, "Thunderstorm", "Snow/Rain", "Heavy Clouds", "Light Clouds", "Clear Skies", "High Winds", "Strange Phenomena");
                    break;
                case "Spring":
                    randomizeWeather(weather, "Thunderstorm", "Heavy Rain", "Rain", "Light Clouds", "Clear Skies", "High Winds", "Strange Phenomena");
                    break;
            }

            void randomizeWeather(int weatherNum, string weatherType1, string weatherType2, string weatherType3, string weatherType4, string weatherType5, string weatherType6, string weatherType7)
            {
                switch (weatherNum)
                {
                    case int i when i < RangeTable.rangeArray[0]:
                        label1.Text = weatherType1;
                        break;
                    case int i when i >= RangeTable.rangeArray[0] && i <= RangeTable.rangeArray[1]:
                        label1.Text = weatherType2;
                        break;
                    case int i when i >= RangeTable.rangeArray[2] && i <= RangeTable.rangeArray[3]:
                        label1.Text = weatherType3;
                        break;
                    case int i when i >= RangeTable.rangeArray[4] && i <= RangeTable.rangeArray[5]:
                        label1.Text = weatherType4;
                        break;
                    case int i when i >= RangeTable.rangeArray[6] && i <= RangeTable.rangeArray[7]:
                        label1.Text = weatherType5;
                        break;
                    case int i when i >= RangeTable.rangeArray[8] && i <= RangeTable.rangeArray[9]:
                        label1.Text = weatherType6;
                        break;
                    case int i when i == 100:
                        label1.Text = weatherType7;
                        break;
                }
            }

        }

    }   
}

