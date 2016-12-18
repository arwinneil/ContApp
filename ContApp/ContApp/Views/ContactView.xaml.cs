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
    public partial class ContactView : ContentPage
    {
        private ContactViewModel _viewModel;

        public ContactView(Contact C)
        {
            InitializeComponent();

            _viewModel = new ContactViewModel(C);
            BindingContext = _viewModel;
        }
    }
}