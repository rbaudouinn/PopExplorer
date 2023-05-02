using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PopExplorer.Lib.Data;
using PopExplorer.Lib.Interfaces;
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
        //private List<Pop> pops = AppData.Pops;
        private List<IRanNetworkElement> ranNetworkElements = AppData.RanNetworkElements;

        [ObservableProperty]
        private IRanNetworkElement currentRanNetworkElement;

        [ObservableProperty]
        private string ranNetworkElementToSearch ="";
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
            ranNetworkElementToSearch = String.Empty;
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
            List<IRanNetworkElement> ranNetworkElementsFiltered;
            string auxiliar;

            // Condiciones iniciales
            auxiliar = ranNetworkElementToSearch.Trim();
            ranNetworkElementsFiltered = AppData.RanNetworkElements;

            // Se realiza el filtro
            if (auxiliar.Equals("") == false)
            {
                auxiliar = auxiliar.ToLower();
                ranNetworkElementsFiltered = ranNetworkElementsFiltered.FindAll(x => x.Nombre.ToLower().Contains(auxiliar));
            }

            ranNetworkElements = ranNetworkElementsFiltered;
        }

        void ShowAboutInfoView()
        {
            AboutView aboutView = new AboutView();
            aboutView.Show();
        }

        #endregion

    }
}
