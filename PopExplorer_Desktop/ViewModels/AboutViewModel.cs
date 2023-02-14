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
    public partial class AboutViewModel : ObservableValidator
    {
        #region propiedades
        [ObservableProperty]
        private AuthorInfo authorInfo = AppData.AuthorInfo;
        [ObservableProperty]
        private AppVersionInfo appVersionInfo = AppData.AppVersionInfo;
        #endregion

        #region Comandos
        
        #endregion

        #region Metodos
        
        #endregion
    }
}
