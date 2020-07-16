// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace XamlFlagsDesigner.ContainerStyle
{
    public class IsEnabledListView : ListView
    {
        protected override void PrepareContainerForItemOverride(Windows.UI.Xaml.DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);
            // ...
            ListViewItem listItem = element as ListViewItem;
            Binding binding = new Binding();
            binding.Mode = BindingMode.TwoWay;
            binding.Source = item;
            binding.Path = new PropertyPath("IsEnabled");
            listItem.SetBinding(ListViewItem.IsEnabledProperty, binding);
        }
    }
}
