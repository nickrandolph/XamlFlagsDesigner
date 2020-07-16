using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace XamlFlagsDesigner.OptimisedXaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; } = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
        }

        public static Visibility ToVisbility(bool isVisible) => isVisible ? Visibility.Visible : Visibility.Collapsed;

        public static Brush SelectedOrEnabledBackgroundColor(bool isEnabled, bool isSelected) => new SolidColorBrush(isEnabled ? (isSelected ? Colors.DarkBlue : Colors.White) : Colors.DarkGray);

        public static Brush SelectedOrEnabledForegroundColor(bool isEnabled, bool isSelected) => new SolidColorBrush(isEnabled ? (isSelected ? Colors.White : Colors.Black) : Colors.LightGray);

    }
}
