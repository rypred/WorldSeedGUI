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
            int rangeVariable1 = 0;
            int rangeVariable2 = 0;
            int rangeVariable3 = 0;
            int rangeVariable4 = 0;
            int rangeVariable5 = 0;
            int rangeVariable6 = 0;
            int rangeVariable7 = 0;
            int rangeVariable8 = 0;
            int rangeVariable9 = 0;
            int rangeVariable10 = 0;
            int rangeVariable11 = 0;

            switch (selectedMonth)
            {
                case "month1" or "month2" or "month3":
                    AssignRange(seasonAssign = "Fall");
                    break;
                case "month4" when selectedDay <= 16:
                    AssignRange(seasonAssign = "Fall");
                    break;
                //I dont like that 4 sits here without specifying >= 17 but I guess it works
                case "month4" or "month5" or "month6":
                    AssignRange(seasonAssign = "Winter");
                    break;
                case "month7" when selectedDay != 35:
                    AssignRange(seasonAssign = "Winter");
                    break;
                case "month7" when selectedDay == 35:
                    AssignRange(seasonAssign = "Spring");
                    break;
                case "month8" or "month9" or "month10":
                    AssignRange(seasonAssign = "Spring");
                    break;
                case "month11" when selectedDay <= 16:
                    AssignRange(seasonAssign = "Spring");
                    break;
                case "month11" or "month12" or "month13" or "month14":
                    AssignRange(seasonAssign = "Spring");
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

            //forgive me for the sins I have committed below
            void AssignRange(string seasonAssign)
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

            void randomizeWeather(int weatherNum, string weatherType1, string weatherType2, string weatherType3, string weatherType4, string weatherType5, string weatherType6, string weatherType7)
            {
                switch (weatherNum)
                {
                    case int i when i < rangeVariable1:
                        label1.Text = weatherType1;
                        break;
                    case int i when i >= rangeVariable2 && i <= rangeVariable3:
                        label1.Text = weatherType2;
                        break;
                    case int i when i >= rangeVariable4 && i <= rangeVariable5:
                        label1.Text = weatherType3;
                        break;
                    case int i when i >= rangeVariable6 && i <= rangeVariable7:
                        label1.Text = weatherType4;
                        break;
                    case int i when i >= rangeVariable8 && i <= rangeVariable9:
                        label1.Text = weatherType5;
                        break;
                    case int i when i >= rangeVariable10 && i <= rangeVariable11:
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

