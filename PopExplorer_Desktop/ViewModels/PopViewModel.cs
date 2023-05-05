using CommunityToolkit.Mvvm.ComponentModel;
using DocumentFormat.OpenXml.Drawing.Charts;
using PopExplorer.Lib.Interfaces;
using PopExplorer.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer_Desktop.ViewModels
{
    public partial class PopViewModel : ObservableValidator, IBaseViewModel
    {
        [ObservableProperty]
        public Pop currentPop = new Pop("Pop");
                
        public void Inicializar(IRanNetworkElement runNetworkElement)
        {
            CurrentPop = ((PopExplorer.Lib.Models.Pop)runNetworkElement);
        }
        
    }
}
