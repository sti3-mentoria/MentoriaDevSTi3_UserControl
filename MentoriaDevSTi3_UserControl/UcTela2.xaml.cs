using System.Windows;
using System.Windows.Controls;

namespace MentoriaDevSTi3_UserControl
{
    /// <summary>
    /// Interaction logic for UcTela2.xaml
    /// </summary>
    public partial class UcTela2 : UserControl
    {
        public UcTela2()
        {
            InitializeComponent();
        }

        private void BtnTrocarTela_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Main.Navegar(nameof(UcTela1));
        }
    }
}
