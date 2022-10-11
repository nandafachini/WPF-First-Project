using CRUDProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace CRUDProject
{
    public class MainWindowVM : INotifyPropertyChanged
    {

        public ObservableCollection<Acai> listaAcais { get; set; }

        public ObservableCollection<Usuario> listaUsuarios { get; set; }

        public String nickname { get; set;}

        public ICommand Add { get; private set; }

        public ICommand Remove { get; private set; }

        public Acai AcaiSelecionado { get; set; }

        public ICommand AddUsuario { get; set; }

        public ICommand UpdateAcai { get; set; }
        
        public ICommand SearchAcai { get; set; }

        public ICommand ShowAcais { get; set; }

        public ICommand SaveNickname { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainWindowVM()
        {
            listaAcais = new ObservableCollection<Acai>()
            {
                
            };

            listaUsuarios = new ObservableCollection<Usuario>();

            IniciaComandos();
        }

        public void IniciaComandos()
        {
            Add = new RelayCommand((object param) =>
            {
                Acai yourAcai = new Acai();


                CadastroAcai telaCadastro = new CadastroAcai();
                telaCadastro.DataContext = yourAcai;
                telaCadastro.ShowDialog();

                listaAcais.Add(yourAcai);

               
            });

            Remove = new RelayCommand((object param) =>
            {
                listaAcais.Remove(AcaiSelecionado);
            });

            AddUsuario = new RelayCommand((object param) =>
            {
                Usuario userCadastro = new Usuario();

                CadastroUsuario telaCadastroUsuario = new CadastroUsuario();
                telaCadastroUsuario.DataContext = userCadastro;
                telaCadastroUsuario.ShowDialog();

                listaUsuarios.Add(userCadastro);
            });

            UpdateAcai = new RelayCommand((object param) =>
            {

                if (AcaiSelecionado != null)
                {
                    CadastroAcai telaCadastro = new CadastroAcai();
                    telaCadastro.DataContext = AcaiSelecionado;
                    telaCadastro.ShowDialog();
                } 

            });

            SearchAcai = new RelayCommand((object param) =>
            {

                if (AcaiSelecionado.Tamanho != null)
                {
                    CadastroAcai telaCadastro = new CadastroAcai();
                    telaCadastro.DataContext = AcaiSelecionado.Tamanho;
                    telaCadastro.ShowDialog();
                }

            });

            ShowAcais = new RelayCommand((object param) =>
            {
                VerPedidoTotal telaPedido = new VerPedidoTotal();
                telaPedido.DataContext = listaAcais;
                telaPedido.ShowDialog();
            });

            SaveNickname = new RelayCommand((object param) =>
            {
                
                
            });

        }

    }
}
