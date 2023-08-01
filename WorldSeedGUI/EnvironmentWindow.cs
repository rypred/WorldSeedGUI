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
            this.Hide();

            string selectedMonth = this.comboBoxMonth.SelectedItem.ToString();
            string dayInput = this.comboBoxDay.SelectedItem.ToString();
            int selectedDay = int.Parse(dayInput);

            string seasonAssign = "";

            Random rnd = new Random();
            int weather = rnd.Next(1, 100);

            // passes combobox inputs into SeasonUtility to determine season.Then assigns the appropriate ranges for the season by passing that season to the RangeTable. Finally, it calls on randomize weather to determine what the weather is and displays that value in a new window.
            if (seasonUtil.isFall(selectedMonth, selectedDay, out seasonAssign))
            {

                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "thunderstorming.", "rainy.", "partially cloudy.", "totally clear.", "windy.", "scorchingly hot!", "raining ash.");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Fall and the weather is {trueWeather}";
            }
            else if (seasonUtil.isWinter(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "blizzarding!", "snowy.", "freezing cold.", "overcast.", "partially cloudy.", "totally clear.", "beautiful at night. You can see the sky illuminated with dancing blue and green lights.");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Winter and the weather is {trueWeather}";
            }
            else if (seasonUtil.isSpring(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "thunderstorming.", "raining hard.", "sprinkling.", "overcast.", "partly cloudy.", "totally clear.", "storming ferociously. You feel as though it's out to get you, as lightning seems to strike near only you.");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Spring and the weather is {trueWeather}";
            }
            else if (seasonUtil.isSummer(selectedMonth, selectedDay, out seasonAssign))
            {
                RangeTable.AssignRange(seasonAssign);
                string trueWeather = WeatherUtil.randomizeWeather(weather, "raining.", "humid.", "partly cloudy.", "totally clear.", "windy", "scorchingly hot!", "lovely. The air is clear and the sky is full of stars. As you look up, you see a meteor shower raining down into the atmosphere.");
                ShopWindow.welcomeMessage.Text = $"The day is {selectedMonth}, {selectedDay}. It's Summer and the weather is {trueWeather}";
            }
            else
            {
                Console.WriteLine($"Encountered Unexpected Season for {selectedMonth} {selectedDay}");
            }



        }

        private void EnvironmentWindow_Load(object sender, EventArgs e)
        {

        }
    }

}


