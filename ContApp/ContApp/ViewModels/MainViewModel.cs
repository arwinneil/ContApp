using ContApp.Models;
using ContApp.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ContApp.ViewModels
{
    public class MainViewModel
    {
        private INavigation _navigator;

        public MainViewModel(INavigation Navigator)
        {
            _navigator = Navigator;
            ContactList = new ObservableCollection<Contact>();

            for (int i = 0; i < 10; i++)
            {
                Contact C = new Contact
                {
                    ContactImageURL = "/Resources/drawable/a" + i + ".jpg",
                    ContactName = "Derp Doggo " + i,
                    ContactNumber = Convert.ToString(71234000 + i)
                };

                ContactList.Add(C);
            }
        }

        #region OBSERVABLE COLLECTION

        private ObservableCollection<Contact> _contactList;

        public ObservableCollection<Contact> ContactList
        {
            get { return _contactList; }
            set { _contactList = value; }
        }

        #endregion OBSERVABLE COLLECTION

        public async void Open(Contact C)
        {
            await _navigator.PushAsync(new ContactView());
        }
    }
}