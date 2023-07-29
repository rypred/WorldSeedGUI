using System.Text.Unicode;

namespace WorldSeedGUI
{
    public partial class Form1 : Form
    {
        private SeasonUtility seasonUtil = new SeasonUtility();
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
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedMonth = this.comboBoxMonth.SelectedItem.ToString();
            string dayInput = this.comboBoxDay.SelectedItem.ToString();
            int selectedDay = int.Parse(dayInput);
            string seasonAssign = "";
            
            if (seasonUtil.isFall(selectedMonth, selectedDay,out seasonAssign)) 
            {
                RangeTable.AssignRange(seasonAssign);           
            }
            else if (seasonUtil.isWinter(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
            }
            else if (seasonUtil.isSpring(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
            }
            else if (seasonUtil.isSummer(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
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

