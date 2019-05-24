using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfMVVMBasic.Models
{

    #region "What is INotifyPropertyChanged"
    /* INotifyPropertyChanged  : Notifys clients that a property value has changed.
     * Typically binding clients(UI)
     * For example, consider a Customer object with a property called FirstName. To Provide generic property change notification, the 
     * Customer type (class) implements the INotifyPropertyChanged interface and raise a PeopertyChanged event whrn FirstName value is changed.
     * 
     * For change notification to occur in a binding between a bound client and a data source, bound type (Customer class) should implement
     * INotifyPropertyChanged interface
     */
    #endregion

    public class Customer : INotifyPropertyChanged
    {
               
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;               
                OnPropertyChanged();
            }
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

   

        public Customer(string customerName)
        {
            Name = customerName;
        }

    }

    #region "Evolution of INotifyPropertyChanged"

    ////// https://jeremybytes.blogspot.com/2016/01/the-evolution-of-inotifypropertychanged.html
    ///// https://github.com/dotnet/roslyn/wiki/New-Language-Features-in-C%23-6

    #region "01 Before .NET 4.5"
    //public event PropertyChangedEventHandler PropertyChanged;
    //private string _name;
    //public string Name
    //{
    //    get { return _name; }
    //    set
    //    {
    //        _name = value;
    //        OnPropertyChanged("Name");
    //    }
    //}

    //private void OnPropertyChanged(string propertyName)
    //{

    //    if (PropertyChanged != null)
    //    {
    //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

    #endregion

    #region "02 .NET 4.5 Way"
    //public event PropertyChangedEventHandler PropertyChanged;
    //private string _name;
    //public string Name
    //{
    //    get { return _name; }
    //    set
    //    {
    //        _name = value;
    //        OnPropertyChanged();
    //    }
    //}

    //private void OnPropertyChanged([CallerMemberName] string propertyName=null)
    //{
    //    PropertyChangedEventHandler handler = PropertyChanged;
    //    if (handler != null)
    //    {
    //        handler(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

    #endregion

    #region "03 .NET 4.6 Way"
    //public event PropertyChangedEventHandler PropertyChanged;
    //private string _name;
    //public string Name
    //{
    //    get { return _name; }
    //    set
    //    {
    //        _name = value;
    //        //OnPropertyChanged();
    //        OnPropertyChanged("Name");
    //    }
    //}

    //private void OnPropertyChanged(string propertyName)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}

    ////private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    ////{
    ////    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    ////}

    #endregion

    #endregion
}
