using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;
using Infrastructure;
using Prism.Commands;

namespace PrismTemplateTest.ViewModels
{
    class LeftMenuViewModel : BindableBase
    {
        // Properties of window
        public ICommand NavigateLeftContent { get; private set; }

        private readonly IRegionManager _regionManager;

        public LeftMenuViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateLeftContent = new DelegateCommand(() => NavigateTo("LeftMenuContent"));
        }

        private void NavigateTo(string url)
        {
            // Here we define window that we chnage
            _regionManager.RequestNavigate(Regions.ContentRegion, url);
        }
    }
    
}
