using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlFlagsDesigner.UserControl
{
    public class MainPageViewModel : BindableBase
    {
        public List<OptionViewModel> Options { get; } 
            
        public MainPageViewModel()
        {
           

            Options = new List<OptionViewModel>
                        {
                            new OptionViewModel { Value = "Option 1-A", Category = "1", Variety = "A", Select = OnSelectType},
                            new OptionViewModel { Value = "Option 1-B", Category = "1", Variety = "B", Select = OnSelectType },
                            new OptionViewModel { Value = "Option 2-A", Category = "2", Variety = "A", Select = OnSelectType },
                            new OptionViewModel { Value = "Option 2-B", Category = "2", Variety = "B", Select = OnSelectType },
                            new OptionViewModel { Value = "Option 3-A", Category = "3", Variety = "A" , Select = OnSelectType},
                            new OptionViewModel { Value = "Option 3-B", Category = "3", Variety = "B" , Select = OnSelectType},
            };
            
            OnSelectType(Options.First());
        }

        private void OnSelectType(OptionViewModel option)
        {
            if (option is null) return;

            // reset all options
            Options.ForEach(o => { o.IsEnabled = false; o.IsSelected = false; });

            // enable options of the same variety (ie. A,B)
            Options.Where(o => o.Variety == option.Variety)
                .Select(o => o.IsEnabled = true)
                .ToArray();

            // enable options of the same category (ie. 1,2,3)
            Options.Where(o => o.Category == option.Category)
                .Select(o => o.IsEnabled = true)
                .ToArray();

            // select the current option
            option.IsSelected = true;
        }
    }
}
