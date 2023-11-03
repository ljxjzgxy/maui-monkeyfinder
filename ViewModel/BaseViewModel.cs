namespace MonkeyFinder.ViewModel;

//[INotifyPropertyChanged]
public partial class BaseViewModel : ObservableObject  //: INotifyPropertyChanged
{
    public BaseViewModel()
    {
        //SetProperty(ref _isBusy,true)
        
    }
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;

    //public bool IsBusy
    //{
    //    get { return _isBusy; }
    //    set
    //    {
    //        if (_isBusy == value) return;
    //        _isBusy = value;
    //        OnPropertyChanged();
    //        OnPropertyChanged(nameof(IsNotBusy));
    //    }

    //}
    //public string Title { 
    //get => _title;
    //    set
    //    {
    //        if(_title == value) return;
    //        _title = value;
    //        OnPropertyChanged();
    //    }
    //}

    //public bool IsNotBusy => !IsBusy;

    //public event PropertyChangedEventHandler PropertyChanged;

    //public void OnPropertyChanged([CallerMemberName]string name=null)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //}
}
