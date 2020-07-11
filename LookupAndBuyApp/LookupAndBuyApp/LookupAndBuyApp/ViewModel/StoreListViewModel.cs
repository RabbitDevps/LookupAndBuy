using LookupAndBuyApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LookupAndBuyApp.ViewModel
{
    public class StoreListViewModel : NotificationObject
    {
        private ObservableCollection<Store> stores;

        public ObservableCollection<Store> Stores
        {
            get { return stores; }
            set { stores = value; OnPropertyChanged("Stores"); }
        }

        public StoreListViewModel()
        {
            this.stores = new ObservableCollection<Store>();
            this.Full();
        }

        private void Full()
        {
            this.Stores.Add(new Store { Name="Mas por menos", Description="Supermarket", Location="Heredia"});
            this.Stores.Add(new Store { Name="Viquiz", Description="Supermarket", Location="Santa Barbara"});
            this.Stores.Add(new Store { Name="La Guacamaya", Description= "Car parts replacement", Location="Tibas"});
            this.Stores.Add(new Store { Name="Musmani", Description="Supermarket", Location="Barva"});
        }



    }
}
