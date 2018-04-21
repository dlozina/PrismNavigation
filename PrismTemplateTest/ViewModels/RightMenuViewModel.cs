using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;
using Infrastructure;
using Prism.Commands;

namespace PrismTemplateTest.ViewModels
{
    class RightMenuViewModel : BindableBase
    {
        // Properties of window
        public ICommand NavigateRightContent { get; private set; }

        private readonly IRegionManager _regionManager;

        public RightMenuViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateRightContent = new DelegateCommand(() => NavigateTo("RightMenuContent"));
        }

        private void NavigateTo(string url)
        {
            // Here we define window that we chnage
            _regionManager.RequestNavigate(Regions.ContentRegion, url);
        }
    }
}