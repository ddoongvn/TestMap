using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TestMap.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            NavToSfMapCommand = new DelegateCommand(NavToSfMap);
        }

        private void NavToSfMap()
        {
            NavigationService.NavigateAsync("MapTest");
        }

        public ICommand NavToSfMapCommand { get; }
    }
}
