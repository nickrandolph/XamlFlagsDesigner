using Windows.UI.Xaml;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlFlagsDesigner
{
    public class DualBooleanDataTrigger : StateTriggerBase
    {
        public DualBooleanDataTrigger():base()
        {

        }
        #region DataValue
        public static bool GetDataValue(DependencyObject obj)
        {
            return (bool)obj.GetValue(DataValueProperty);
        }
        public static void SetDataValue(DependencyObject obj, bool value)
        {
            obj.SetValue(DataValueProperty, value);
        }
        public static readonly DependencyProperty DataValueProperty =
            DependencyProperty.RegisterAttached("DataValue", typeof(bool),
                typeof(DualBooleanDataTrigger), new PropertyMetadata(false, DataValueChanged));

        public static bool GetSecondDataValue(DependencyObject obj)
        {
            return (bool)obj.GetValue(SecondDataValueProperty);
        }
        public static void SetSecondDataValue(DependencyObject obj, bool value)
        {
            obj.SetValue(SecondDataValueProperty, value);
        }
        public static readonly DependencyProperty SecondDataValueProperty =
            DependencyProperty.RegisterAttached("SecondDataValue", typeof(bool),
                typeof(DualBooleanDataTrigger), new PropertyMetadata(false, DataValueChanged));

        private static void DataValueChanged(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            TriggerStateCheck(target);
        }
        #endregion

        #region TriggerValue
        public static bool GetTriggerValue(DependencyObject obj)
        {
            return (bool)obj.GetValue(TriggerValueProperty);
        }
        public static void SetTriggerValue(DependencyObject obj, bool value)
        {
            obj.SetValue(TriggerValueProperty, value);
        }
        // Using a DependencyProperty as the backing store for TriggerValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TriggerValueProperty =
            DependencyProperty.RegisterAttached("TriggerValue", typeof(bool),
                typeof(DualBooleanDataTrigger), new PropertyMetadata(false, TriggerValueChanged));

        public static bool GetSecondTriggerValue(DependencyObject obj)
        {
            return (bool)obj.GetValue(SecondTriggerValueProperty);
        }
        public static void SetSecondTriggerValue(DependencyObject obj, bool value)
        {
            obj.SetValue(SecondTriggerValueProperty, value);
        }
        // Using a DependencyProperty as the backing store for TriggerValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondTriggerValueProperty =
            DependencyProperty.RegisterAttached("SecondTriggerValue", typeof(bool),
                typeof(DualBooleanDataTrigger), new PropertyMetadata(false, TriggerValueChanged));


        private static void TriggerValueChanged(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            TriggerStateCheck(target);
        }
        #endregion

        private static void TriggerStateCheck(DependencyObject target)
        {

            var trigger = target as DualBooleanDataTrigger;
            bool dataValue = (bool)target.GetValue(DualBooleanDataTrigger.DataValueProperty);
            bool triggerValue = (bool)target.GetValue(DualBooleanDataTrigger.TriggerValueProperty);
            bool secondDataValue = (bool)target.GetValue(DualBooleanDataTrigger.SecondDataValueProperty);
            bool secondTriggerValue = (bool)target.GetValue(DualBooleanDataTrigger.SecondTriggerValueProperty);

            if (trigger == null) return;
            trigger.SetActive(triggerValue == dataValue && secondDataValue==secondTriggerValue);
        }

    }
}
