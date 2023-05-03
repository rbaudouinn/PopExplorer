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
    public partial class PopViewModel : ObservableValidator
    {
        [ObservableProperty]
        public Pop pop;

        public void Inicializar(IRanNetworkElement runNetworkElement)
        {
            pop = ((PopExplorer.Lib.Models.Pop)runNetworkElement);
        }
    }
}
