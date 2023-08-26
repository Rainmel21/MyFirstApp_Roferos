namespace MyFirstApp_Roferos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} stop the car";
          
            else
                CounterBtn.Text = $"Clicked {count} tama na";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}