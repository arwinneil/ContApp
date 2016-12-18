using ContApp.Models;
using ContApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ContApp.Views
{
    public partial class MainView : ContentPage
    {
        private MainViewModel _viewModel;

        public MainView()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(Navigation);

            BindingContext = _viewModel;
        }


        public void NavigateToContact (Object O ,SelectedItemChangedEventArgs s)
    {

            var Choice = s.SelectedItem as Contact;
            _viewModel.Open(Choice);




    }


    }


    



}