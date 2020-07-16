using System;
using System.Windows.Input;
using Xamarin.Forms;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlFlagsDesigner.ContainerStyle
{
    public class OptionViewModel : BindableBase
    {
        public ICommand SelectCommand { get; } 

        public OptionViewModel()
        {
            SelectCommand = new Command(OnSelect);
        }

        public string Value { get; set; }
        public string Variety { get; set; }
        public string Category { get; set; }

        private bool _isEnabled;
        public bool IsEnabled { get => _isEnabled; set => SetProperty(ref _isEnabled, value); }

        private bool _isSelected;
        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public Action<OptionViewModel> Select { get; set; }

        public void OnSelect() => Select(this);
    }

    public class BasicCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
