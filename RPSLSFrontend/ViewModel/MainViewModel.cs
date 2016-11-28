using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using RPSLSFrontend.RPSLS;

namespace RPSLSFrontend.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _selectedSymbol;

        public string SelectedSymbol
        {
            get
            {
                return _selectedSymbol;
            }
            set
            {
                ComputerSymbol = "";
                Winner = "";
                _selectedSymbol = value;
                base.RaisePropertyChanged();
            }
        }

        private string _computerSymbol;

        public string ComputerSymbol
        {
            get
            {
                return _computerSymbol;
            }
            set
            {
                _computerSymbol = value;
                base.RaisePropertyChanged();
            }
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                base.RaisePropertyChanged();
            }
        }

        private string _winner;

        public string Winner
        {
            get
            {
                return _winner;
            }
            set
            {
                _winner = value;
                base.RaisePropertyChanged();
            }
        }

        public ICommand DoPlayCommand { get; set; }
        public ObservableCollection<string> Symbols { get; set; }

        private RPSLS.IService service;
        public MainViewModel()
        {
            Symbols = new ObservableCollection<string>()
            {
                "Rock",
                "Paper",
                "Scissor",
                "Lizard",
                "Spock"
            };
            DoPlayCommand = new RelayCommand(DoPlay);
            string endpointName = "BasicHttpsBinding_IService";
            service = new RPSLS.ServiceClient(endpointName);
        }
        private bool CanPlay()
        {
            if (string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_selectedSymbol))
                return false;
            return true;
        }
        private void DoPlay()
        {
            PlayAttempt attempt = new PlayAttempt();
            attempt.PlayerName = _name;
            attempt.PlayerSymbol = SelectedSymbol;
            PlayAttempt result = service.DoPlay(attempt);
            ComputerSymbol = result.ComputerSymbol;
            if (result.Winner.Equals("Player"))
                Winner = _name;
            else
                Winner = result.Winner;
        }
    }
}