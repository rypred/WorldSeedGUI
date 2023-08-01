using System.Text.Unicode;
using WorldSeedGUI.Environment;

namespace WorldSeedGUI
{
    public partial class EnvironmentWindow : Form
    {
        private SeasonUtility seasonUtil = new SeasonUtility();
        public EnvironmentWindow()
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
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.Show();

            string selectedMonth = this.comboBoxMonth.SelectedItem.ToString();
            string dayInput = this.comboBoxDay.SelectedItem.ToString();
            int selectedDay = int.Parse(dayInput);

            string seasonAssign = "";

            Random rnd = new Random();
            int weather = rnd.Next(1, 100);

            // determines season based on dates from the combobox input and then assigns the appropriate weather for the season
            if (seasonUtil.isFall(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "Blizzard", "Snow/Rain", "Freezing Cold", "Heavy Clouds", "Light Clouds", "Clear Skies", "Strange Phenomena");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Fall and the weather is: {trueWeather}.";
            }
            else if (seasonUtil.isWinter(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "Thunderstorm", "Rain", "Light Clouds", "Clear Skies", "High Winds", "Scorching Heat", "Strange Phenomena");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Winter and the weather is: {trueWeather}.";
            }
            else if (seasonUtil.isSpring(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "Thunderstorm", "Snow/Rain", "Heavy Clouds", "Light Clouds", "Clear Skies", "High Winds", "Strange Phenomena");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Spring and the weather is: {trueWeather}.";
            }
            else if (seasonUtil.isSummer(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "Thunderstorm", "Rain", "Light Clouds", "Clear Skies", "High Wind", "Scorching Heat", "Strange Phenomena");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Summer and the weather is: {trueWeather}.";
            }
            else
            {
                Console.WriteLine($"Encountered Unexpected Season for {selectedMonth} {selectedDay}");
            }

            

        }

    }

}


