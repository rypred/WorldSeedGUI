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
        private void button1_Click_1(object sender, EventArgs e)
        {

            //string selectedSeason = this.comboBox1.SelectedItem.ToString();
            string selectedMonth = this.comboBoxMonth.SelectedItem.ToString();
            string dayInput = this.comboBoxDay.SelectedItem.ToString();
            int selectedDay = int.Parse(dayInput);
            string seasonAssign = "";

            switch (selectedMonth)
            {
                case "month1" or "month2" or "month3":
                    seasonAssign = "Fall";
                    Console.WriteLine(seasonAssign);
                    break;
                case "month4" when selectedDay <= 16:
                    seasonAssign = "Fall";
                    Console.WriteLine(seasonAssign);
                    break;
                //I dont like that 4 sits here without specifying >= 17 but I guess it works
                case "month4" or "month5" or "month6":
                    seasonAssign = "Winter";
                    Console.WriteLine(seasonAssign);
                    break;
                case "month7" when selectedDay != 35:
                    seasonAssign = "Winter";
                    Console.WriteLine(seasonAssign);
                    break;
                case "month7" when selectedDay == 35:
                    seasonAssign = "Spring";
                    Console.WriteLine(seasonAssign);
                    break;
                case "month8" or "month9" or "month10":
                    seasonAssign = "Spring";
                    Console.WriteLine(seasonAssign);
                    break;
                case "month11" when selectedDay <= 16:
                    seasonAssign = "Spring";
                    Console.WriteLine(seasonAssign);
                    break;
                case "month11" or "month12" or "month13" or "month14":
                    seasonAssign = "Summer";
                    Console.WriteLine(seasonAssign);
                    break;
            }
            //switch (selectedMonth)
            //{
            //    case "1" or "2" or "3":
            //        seasonAssign = "Fall";
            //        break;
            //    case "4" or "5" or "6":
            //        seasonAssign = "Winter";
            //        break;
            //    case "7" or "8" or "9":
            //        seasonAssign = "Spring";
            //        break;
            //    case "10" or "11" or "12":
            //        seasonAssign = "Summer";
            //        break;
            //}


            // I don't like that I have the random in under every case? can I make this cleaner


            switch (seasonAssign)
            {
                case "Winter":
                    Random rnd1 = new Random();
                    int weather1 = rnd1.Next(1, 100);
                    randomizeWeather(weather1, "Blizzard", "Snow/Rain", "Freezing Cold", "Heavy Clouds", "Light Clouds", "Clear Skies", "Strange Phenomena");
                    break;
                case "Summer":
                    Random rnd2 = new Random();
                    int weather2 = rnd2.Next(1, 100);
                    randomizeWeather(weather2, "Thunderstorm", "Rain", "Light Clouds", "Clear Skies", "High Winds", "Scorching Heat", "Strange Phenomena");
                    break;
                case "Fall":
                    Random rnd3 = new Random();
                    int weather3 = rnd3.Next(1, 100);
                    randomizeWeather(weather3, "Thunderstorm", "Snow/Rain", "Heavy Clouds", "Light Clouds", "Clear Skies", "High Winds", "Strange Phenomena");
                    break;
                case "Spring":
                    Random rnd4 = new Random();
                    int weather4 = rnd4.Next(1, 100);
                    randomizeWeather(weather4, "Thunderstorm", "Heavy Rain", "Rain", "Light Clouds", "Clear Skies", "High Winds", "Strange Phenomena");
                    break;
            }
        }

        void randomizeWeather(int weatherNum, string weatherType1, string weatherType2, string weatherType3, string weatherType4, string weatherType5, string weatherType6, string weatherType7)
        {
            //Console.WriteLine("Called the Randomize Weather Function");
            switch (weatherNum)
            {
                case int i when i < 2:
                    label1.Text = weatherType1;
                    break;
                case int i when i >= 3 && i <= 20:
                    label1.Text = weatherType2;
                    break;
                case int i when i >= 21 && i <= 30:
                    label1.Text = weatherType3;
                    break;
                case int i when i >= 31 && i <= 40:
                    label1.Text = weatherType4;
                    break;
                case int i when i >= 41 && i <= 60:
                    label1.Text = weatherType5;
                    break;
                case int i when i >= 61 && i <= 99:
                    label1.Text = weatherType6;
                    break;
                case int i when i == 100:
                    label1.Text = weatherType7;
                    break;
            }
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

