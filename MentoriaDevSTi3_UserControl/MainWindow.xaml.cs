using System.Windows;

namespace MentoriaDevSTi3_UserControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static MainWindow Main;

        public MainWindow()
        {
            InitializeComponent();

            Main = this;

            Navegar("");
        }

        public void Navegar(string tela)
        {
            switch (tela)
            {
                case nameof(UcTela2):
                    Conteudo.Content = new UcTela2();
                    break;
                default:
                    Conteudo.Content = new UcTela1();
                    break;
            }
        }
    }
}
