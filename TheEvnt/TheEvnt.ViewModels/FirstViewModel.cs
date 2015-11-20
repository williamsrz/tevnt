using Cirrious.MvvmCross.ViewModels;

namespace TheEvnt.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        private string _hello = "Hello MvvmCross";

        public string Hello
        { 
            get { return _hello; }
            set
            {
                _hello = value;
                RaisePropertyChanged(() => Hello);
            }
        }
    }
}