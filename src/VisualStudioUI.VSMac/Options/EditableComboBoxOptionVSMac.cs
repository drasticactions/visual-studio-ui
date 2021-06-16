﻿using System;
using AppKit;
using Foundation;
using Microsoft.VisualStudioUI.Options;
using Microsoft.VisualStudioUI.Options.Models;

namespace Microsoft.VisualStudioUI.VSMac.Options
{
    public class EditableComboBoxOptionVSMac : OptionWithLeftLabelVSMac
    {
        NSComboBox _comboBox;

        public EditableComboBoxOptionVSMac(EditableComboBoxOption option) : base(option)
        {
        }

        public EditableComboBoxOption EditableComboBoxOption => ((EditableComboBoxOption) Option);

        protected override NSView Control
        {
            get
            {
                if (_comboBox == null)
                {
                    ViewModelProperty<string> property = EditableComboBoxOption.Property;
                    ViewModelProperty<string[]> itemsProperty = EditableComboBoxOption.ItemsProperty;

                    _comboBox = new AppKit.NSComboBox();
                    _comboBox.ControlSize = NSControlSize.Regular;
                    _comboBox.Font = AppKit.NSFont.SystemFontOfSize(AppKit.NSFont.SystemFontSize);
                    _comboBox.TranslatesAutoresizingMaskIntoConstraints = false;

                    _comboBox.WidthAnchor.ConstraintEqualToConstant(198f).Active = true;

                    _comboBox.SelectionChanged += UpdatePropertyFromSelection;
                    _comboBox.Changed += UpdatePropertyFromUIEdit;
                    EditableComboBoxOption.Property.PropertyChanged += UpdateUIFromProperty;

                    EditableComboBoxOption.ItemsProperty.PropertyChanged += delegate { UpdateItemChoices(); };

                    UpdateItemChoices();
                }

                return _comboBox;
            }
        }

        /*
        public override void Dispose ()
        {
            entryComBox.SelectionChanged -= UpdatePropertyValue;
            Property.PropertyChanged -= UpdateUIFromProperty;
            ItemsProperty.PropertyChanged -= LoadComBoxDataModel;
            entryComBox.Changed -= UpdatePropertyValue;

            base.Dispose ();
        }
        */

        void UpdatePropertyFromSelection(object sender, EventArgs e)
        {
            EditableComboBoxOption.Property.Value = _comboBox.SelectedValue.ToString();
        }

        void UpdatePropertyFromUIEdit(object sender, EventArgs e)
        {
            EditableComboBoxOption.Property.Value = _comboBox.StringValue;
        }

        void UpdateUIFromProperty(object sender, ViewModelPropertyChangedEventArgs e)
        {
            string value = EditableComboBoxOption.Property.Value;
            if (string.IsNullOrWhiteSpace(value))
                return;

            _comboBox.StringValue = value;
        }

        void UpdateItemChoices()
        {
            _comboBox.RemoveAll();

            string[] items = EditableComboBoxOption.ItemsProperty.Value;
            if (items != null)
            {
                foreach (string item in EditableComboBoxOption.ItemsProperty.Value)
                {
                    _comboBox.Add(new NSString(item));
                }
            }

            string value = EditableComboBoxOption.Property.Value;
            if (!string.IsNullOrWhiteSpace(value) &&
                Array.IndexOf(EditableComboBoxOption.ItemsProperty.Value, value) != -1)
            {
                _comboBox.StringValue = value;
            }
        }
    }
}