
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;
using Infrastructure;
using Prism.Commands;

namespace PrismTemplateTest.ViewModels
{
    class RightMenuContentViewModel : BindableBase
    {
        public ICommand NavigateToMainPage { get; private set; }

        private readonly IRegionManager _regionManager;

        public RightMenuContentViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateToMainPage = new DelegateCommand(() => NavigateTo("MainPage"));
        }

        private void NavigateTo(string url)
        {
            _regionManager.RequestNavigate(Regions.ContentRegion, url);
        }
    }
}
