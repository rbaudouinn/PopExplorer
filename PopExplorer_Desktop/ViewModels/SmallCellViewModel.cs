using CommunityToolkit.Mvvm.ComponentModel;
using PopExplorer.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer_Desktop.ViewModels
{
    public partial class SmallCellViewModel : ObservableValidator, IBaseViewModel
    {
        [ObservableProperty]
        public SmallCell currentSmallCell;
    }
}
