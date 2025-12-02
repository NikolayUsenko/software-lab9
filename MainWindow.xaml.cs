using System.Windows;

namespace software_lab9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TextX.Text);
            double y = Convert.ToDouble(TextY.Text);
            int n = Convert.ToInt32(ComboN.Text);
            int k = Convert.ToInt32(ComboK.Text);
            double res = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    res += (i * Math.Pow(x, i) + j * Math.Pow(y, j)) / (i * j);
                }
            }
            this.Title = "Ответ: " + res.ToString("F");
        }
    }
}
