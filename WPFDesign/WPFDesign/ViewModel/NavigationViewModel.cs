using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WPFDesign.Model;

namespace WPFDesign.ViewModel
{
    public class NavigationViewModel:ViewModelBase
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

            MenuItemsCollection = new CollectionViewSource {Source=menuItems };
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
            MenuItems _items=e.Item as MenuItems;

            if(_items.MenuName.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted= true;
            }
            else
            {
                e.Accepted=false;
            }

        }

    }
}
