using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using WPFDesign.Model;
using WPFDesign.View;

namespace WPFDesign.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        private CollectionViewSource MenuItemsCollection;

        public ICollectionView SourceCollection => MenuItemsCollection.View;

        public NavigationViewModel()
        {
            ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>
            {
                new MenuItems{ MenuName ="Home",MenuImage=@"Assets/Home_Icon.png"},
                new MenuItems{MenuName="Desktop",MenuImage=@"Assets/Desktop_Icon.png"},
                new MenuItems{MenuName="Document",MenuImage=@"Assets/Document_Icon.png"},
                 new MenuItems{ MenuName ="Download",MenuImage=@"Assets/Download_Icon.png"},
                new MenuItems{MenuName="Picture",MenuImage=@"Assets/Picture_Icon.png"},
                new MenuItems{MenuName="Music",MenuImage=@"Assets/Music_Icon.png"},
                 new MenuItems{ MenuName ="Movies",MenuImage=@"Assets/Movies_Icon.png"},
                new MenuItems{MenuName="Trash",MenuImage=@"Assets/Trash_Icon.png"}
            };

            MenuItemsCollection = new CollectionViewSource { Source = menuItems };
            MenuItemsCollection.Filter += MenuItems_Fillter;
        }

        private string filterText;
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                MenuItemsCollection.View.Refresh();
                OpPropertyChanged("FilterText");
            }
        }

        private void MenuItems_Fillter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(filterText))
            {
                e.Accepted = true;
                return;
            }
            MenuItems _items = e.Item as MenuItems;

            if (_items.MenuName.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }

        }

        //select ViewModel
        private object _selectedViewModel;
        public object SelectedViewModel {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OpPropertyChanged("SelectedViewModel");
            }
        }

        //Switch Views
        public void SwitchViews(object parameter)
        {
            switch (parameter)
            {
                case "Home":
                    SelectedViewModel = new HomeViewModel();
                    break;
                case "Desktop":
                    SelectedViewModel = new DesktopViewModel();
                    break;
                case "Documents":
                    SelectedViewModel = new DocumentItems();
                    break;
                case "Downloads":
                    SelectedViewModel = new DownloadViewModel();
                    break;
                case "Pictures":
                    SelectedViewModel = new PictureViewModel();
                    break;
                case "Music":
                    SelectedViewModel = new MusicViewModel();
                    break;
                case "Movies":
                    SelectedViewModel = new MovieViewModel();
                    break;
                case "Trash":
                    SelectedViewModel = new TrashViewModel();
                    break;

                default:
                    SelectedViewModel = new HomeViewModel();
                    break;
            }

        }

        public void PCview()
        {
            SelectedViewModel=new PCViewModel();
        }

        //This PC button Command
        private ICommand _pccommand;
        public ICommand Thiscommand
        {
            get
            {
                if(_pccommand == null)
                {
                  //  _pccommand=new RelayCommand<object>(null,param=> PCView());  
                }
                return _pccommand;
            }
        }



    }
}
