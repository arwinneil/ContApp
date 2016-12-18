using ContApp.Models;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContApp.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private string _input;

        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        private string _contactNumber;

        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;

                OnPropertyChanged("ContactNumber");
            }
        }

        private string _contactImageURL;

        public string ContactImageURL
        {
            get { return _contactImageURL; }
            set
            {
                _contactImageURL = value;

                OnPropertyChanged("_contactImageURL");
            }
        }

        public ContactViewModel(Contact C)
        {
            ContactNumber = C.ContactNumber;
            ContactImageURL = C.ContactImageURL;
        }

        public void Run()
        {
            if (Input != null)
            {
                ContactNumber = Input;
            }
        }

        public ICommand Update
        {
            get
            {
                return new Command(Run);
            }
        }
    }
}