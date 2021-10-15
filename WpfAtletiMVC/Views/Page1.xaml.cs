using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAtletiMVC.Models;

namespace WpfAtletiMVC.Views
{
    /// <summary>
    /// Logica di interazione per Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Discipline model;

        public Page1()
        {
            InitializeComponent();
            model = new Discipline();
        }

        private void LeggiDiscipline_Click(object sender, RoutedEventArgs e)
        {
            List<Disciplina> aaa = model.getAll();
            int foo = 0;
        }

        private void AggiungiCalcio_Click(object sender, RoutedEventArgs e)
        {
            model.Add(new Disciplina(12, "Calcio"));
            List<Disciplina> aaa = model.getAll();
            int foo = 0;
        }
    }
}
