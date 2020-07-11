using LookupAndBuyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LookupAndBuyApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoreListView : ContentPage
    {
        StoreListViewModel context = new StoreListViewModel();
        public StoreListView()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}