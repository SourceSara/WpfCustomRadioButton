using System.Diagnostics;
using System.Windows.Input;

namespace CustomRadioButtonDemo
{
    public partial class MainWindow
    {
        public MainWindow()
           => InitializeComponent();

        private void OnAmRoLogoPreviewMouseDown(object sender, MouseButtonEventArgs e)
            => Process.Start(new ProcessStartInfo("https://github.com/AmRo045") { UseShellExecute = true });
    }
}
