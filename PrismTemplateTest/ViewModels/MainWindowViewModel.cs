using Prism.Mvvm;
using Prism.Regions;
using Infrastructure;
using PrismTemplateTest.Views;

namespace PrismTemplateTest.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        // Properties of window
        private string _title = "Prism Application - Navigation";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            // STEP 2. Register all regions that we have in APP
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion(Regions.ContentRegion, typeof(MainPage));
            _regionManager.RegisterViewWithRegion(Regions.LeftMenuRegion, typeof(LeftMenu));
            _regionManager.RegisterViewWithRegion(Regions.RightMenuRegion, typeof(RightMenu));
            _regionManager.RegisterViewWithRegion(Regions.LeftMenuContentRegion, typeof(LeftMenuContent));
            _regionManager.RegisterViewWithRegion(Regions.RightMenuContentRegion, typeof(RightMenuContent));
        }
    }
}
