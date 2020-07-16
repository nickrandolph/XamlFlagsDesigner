using System;

namespace XamlFlagsDesigner.OptimisedXaml
{
    public class OptionViewModel : BindableBase
    {
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
}
