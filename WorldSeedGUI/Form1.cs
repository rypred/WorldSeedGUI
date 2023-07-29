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
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
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

            switch (selectedMonth)
            {
                case "month1" or "month2" or "month3" or "month4" when selectedDay <= 16:
                    RangeTable.AssignRange(seasonAssign = "Fall");
                    break;
                case "month4" or "month5" or "month6" or "month7" when selectedDay !=35:
                    RangeTable.AssignRange(seasonAssign = "Winter");
                    break;
                case "month8" or "month9" or "month10" or "month11" or "month7" when selectedDay == 35:
                    RangeTable.AssignRange(seasonAssign = "Spring");
                    break;
                //case "month11" when selectedDay <= 16:
                //    RangeTable.AssignRange(seasonAssign = "Spring");
                    break;
                case "month11" or "month12" or "month13" or "month14" or "month11" when selectedDay >= 17:
                    RangeTable.AssignRange(seasonAssign = "Summer");
                    break;
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
                    case int i when i < RangeTable.rangeVariable1:
                        label1.Text = weatherType1;
                        break;
                    case int i when i >= RangeTable.rangeVariable2 && i <= RangeTable.rangeVariable3:
                        label1.Text = weatherType2;
                        break;
                    case int i when i >= RangeTable.rangeVariable4 && i <= RangeTable.rangeVariable5:
                        label1.Text = weatherType3;
                        break;
                    case int i when i >= RangeTable.rangeVariable6 && i <= RangeTable.rangeVariable7:
                        label1.Text = weatherType4;
                        break;
                    case int i when i >= RangeTable.rangeVariable8 && i <= RangeTable.rangeVariable9:
                        label1.Text = weatherType5;
                        break;
                    case int i when i >= RangeTable.rangeVariable10 && i <= RangeTable.rangeVariable11:
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

