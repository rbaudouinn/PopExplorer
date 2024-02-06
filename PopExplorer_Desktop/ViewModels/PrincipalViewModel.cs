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
        public IBaseViewModel selectedViewModel = new PopViewModel();

        [ObservableProperty]
        private List<IRanNetworkElement> ranNetworkElements = AppData.RanNetworkElements;

        [ObservableProperty]
        private string title = $"Pop Explorer {AppData.AppVersionInfo.Version}";

        [ObservableProperty]
        private IRanNetworkElement currentRanNetworkElement;

        [ObservableProperty]
        private string ranNetworkElementToSearch = "";
        #endregion

        #region Comandos
        [RelayCommand]
        void BuscarRanNetworkElement()
        {
            FiltrarListaRanNetworkElement();
        }

        [RelayCommand]
        void LimpiarRanNetworkElementToSearch()
        {
            RanNetworkElementToSearch = String.Empty;
            FiltrarListaRanNetworkElement();
        }

        [RelayCommand]
        void GetAboutInfo()
        {
            ShowAboutInfoView();
        }

        [RelayCommand]
        void ActualizarSelectedViewModel()
        {
            DefinirViewModel();
        }

        #endregion

        #region Metodos

        void DefinirViewModel()
        {
            if (CurrentRanNetworkElement is Pop pop)
            {
                SelectedViewModel = new PopViewModel();
                ((PopViewModel) SelectedViewModel).Inicializar(CurrentRanNetworkElement);
            }
            else if (CurrentRanNetworkElement is SitioBajaAltura sitioBajaAltura)
            {
                SelectedViewModel = new SitioBajaAlturaViewModel();
                ((SitioBajaAlturaViewModel) SelectedViewModel).CurrentSitioBajaAltura = sitioBajaAltura;
            }
            else if (CurrentRanNetworkElement is SmallCell smallCell)
            {
                SelectedViewModel = new SmallCellViewModel();
                ((SmallCellViewModel) SelectedViewModel).CurrentSmallCell = smallCell;
            }
        }

        void FiltrarListaRanNetworkElement()
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

            RanNetworkElements = ranNetworkElementsFiltered;
        }

        void ShowAboutInfoView()
        {
            AboutView aboutView = new AboutView();
            aboutView.Show();
        }

        #endregion

    }
}
