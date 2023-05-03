using CommunityToolkit.Mvvm.ComponentModel;
using PopExplorer.Lib.Interfaces;
using PopExplorer.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer_Desktop.ViewModels
{
    public partial class SitioBajaAlturaViewModel : ObservableValidator
    {
        [ObservableProperty]
        public SitioBajaAltura sitioBajaAltura;

        public void Inicializar(IRanNetworkElement runNetworkElement)
        {
            sitioBajaAltura = ((PopExplorer.Lib.Models.SitioBajaAltura)runNetworkElement);
        }
    }
}
