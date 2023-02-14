using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PopExplorer.Lib.Data;
using PopExplorer.Lib.Models;
using PopExplorer_Desktop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer_Desktop.ViewModels
{
    public partial class PrincipalViewModel : ObservableValidator
    {
        #region propiedades
        [ObservableProperty]
        private List<Pop> pops = AppData.Pops;

        [ObservableProperty]
        private Pop currentPop;

        [ObservableProperty]
        private string popToSearch ="";
        #endregion

        #region Comandos
        [RelayCommand]
        void BuscarPop()
        {
            FiltrarListaPop();
        }

        [RelayCommand]
        void LimpiarPopToSeearch()
        { 
            PopToSearch = String.Empty;
            FiltrarListaPop();
        }

        [RelayCommand]
        void GetAboutInfo()
        {
            ShowAboutInfoView();
        }

        #endregion

        #region Metodos
        void FiltrarListaPop()
        {
            // Definición de variables
            List<Pop> popsFiltered;
            string auxiliar;

            // Condiciones iniciales
            auxiliar = PopToSearch.Trim();
            popsFiltered = AppData.Pops;

            // Se realiza el filtro
            if (auxiliar.Equals("") == false)
            {
                auxiliar = auxiliar.ToLower();
                popsFiltered = popsFiltered.FindAll(x => x.Nombre.ToLower().Contains(auxiliar));
            }

            Pops = popsFiltered;
        }

        void ShowAboutInfoView()
        {
            AboutView aboutView = new AboutView();
            aboutView.Show();
        }

        #endregion

    }
}
