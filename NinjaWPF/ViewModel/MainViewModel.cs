using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace NinjaWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        public RelayCommand OpenStoreWindow { get; set; }
        public RelayCommand OpenInventoryWindow { get; set; }
        public RelayCommand OpenNinjaWindow { get; set; }
        public MainViewModel()
        {
            OpenStoreWindow = new RelayCommand(OpenStore);
            OpenInventoryWindow = new RelayCommand(OpenInventory);
            OpenNinjaWindow = new RelayCommand(OpenNinja);
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public void OpenStore()
        {
            View.GearStore Store = new View.GearStore();
            Store.Show();
        }

        public void OpenInventory()
        {
            View.Inventory Inventory = new View.Inventory();
            Inventory.Show();
        }
        
        private void OpenNinja()
        {
            View.Ninjas Ninja = new View.Ninjas();
            Ninja.Show();
        }
        
    }
}