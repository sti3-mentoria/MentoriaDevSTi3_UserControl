using System.Windows;
using System.Windows.Controls;

namespace MentoriaDevSTi3_UserControl
{
    /// <summary>
    /// Interaction logic for UcTela1.xaml
    /// </summary>
    public partial class UcTela1 : UserControl
    {
        public UcTela1()
        {
            InitializeComponent();
        }

        private void BtnTrocarTela_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Main.Navegar(nameof(UcTela2));
        }
    }
}
