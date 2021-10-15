using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Logica di interazione per ListaAtletiView.xaml
    /// </summary>
    public partial class ListaAtletiView : Page, INotifyPropertyChanged
    {
        Atleti model = new Atleti();
        Discipline model2 = new Discipline();

        private ObservableCollection<Atleta> _atleti;
        public ObservableCollection<Atleta> atleti
        {
            get 
            {
                return _atleti;
            }
            set 
            {
                _atleti = value;
                onPropertyChanged("atleti");
            }
        }

        private Atleta _atletaSelezionato;
        public Atleta atletaSelezionato
        {
            get
            {
                return _atletaSelezionato;
            }
            set
            {
                _atletaSelezionato = value;
                onPropertyChanged("atletaSelezionato");
            }
        }
        public ListaAtletiView()
        {
            InitializeComponent();
            atleti = new ObservableCollection<Atleta>( model.getAll() );
            this.DataContext = this;
        }

        private void Nuovo_Click(object sender, RoutedEventArgs e)
        {
            //Atleta nuovoAtleta = new Atleta(-1, "Jacobs", "Marcel", "JCBMRC...", new DateTime(1999, 01, 01), model2.getAll().First(d => d.Codice == 1));
            //Atleta nuovoAtleta = new Atleta(-1, "Jacobs", "Marcel", "JCBMRC...", new DateTime(1999, 01, 01), model2.getOne(1));
            //model.Add(nuovoAtleta);
            //atleti = new ObservableCollection<Atleta>(model.getAll());

            DettaglioAtletaView dettaglio = new DettaglioAtletaView();
            //to do
            dettaglio.ShowDialog();
            //to do
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Elimina_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
