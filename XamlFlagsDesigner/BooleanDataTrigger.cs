﻿using System;
using Windows.UI.Xaml;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlFlagsDesigner
{
    public class BooleanDataTrigger : StateTriggerBase
    {
        #region DataValue
        public static Boolean GetDataValue(DependencyObject obj)
        {
            return (Boolean)obj.GetValue(DataValueProperty);
        }
        public static void SetDataValue(DependencyObject obj, Boolean value)
        {
            obj.SetValue(DataValueProperty, value);
        }
        public static readonly DependencyProperty DataValueProperty =
            DependencyProperty.RegisterAttached("DataValue", typeof(Boolean),
                typeof(BooleanDataTrigger), new PropertyMetadata(false, DataValueChanged));
        private static void DataValueChanged(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            Boolean triggerValue = (Boolean)target.GetValue(BooleanDataTrigger.TriggerValueProperty);
            TriggerStateCheck(target, (Boolean)e.NewValue, triggerValue);
        }
        #endregion
        #region TriggerValue
        public static Boolean GetTriggerValue(DependencyObject obj)
        {
            return (Boolean)obj.GetValue(TriggerValueProperty);
        }
        public static void SetTriggerValue(DependencyObject obj, Boolean value)
        {
            obj.SetValue(TriggerValueProperty, value);
        }
        // Using a DependencyProperty as the backing store for TriggerValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TriggerValueProperty =
            DependencyProperty.RegisterAttached("TriggerValue", typeof(Boolean),
                typeof(BooleanDataTrigger), new PropertyMetadata(false, TriggerValueChanged));


        private static void TriggerValueChanged(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            Boolean dataValue = (Boolean)target.GetValue(BooleanDataTrigger.DataValueProperty);
            TriggerStateCheck(target, dataValue, (Boolean)e.NewValue);
        }
        #endregion

        private static void TriggerStateCheck(DependencyObject target, Boolean dataValue, Boolean triggerValue)
        {
            BooleanDataTrigger trigger = target as BooleanDataTrigger;
            if (trigger == null) return;
            trigger.SetActive(triggerValue == dataValue);
        }

    }
}
