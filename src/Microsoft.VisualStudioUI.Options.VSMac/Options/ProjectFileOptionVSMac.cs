﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System;
using System.IO;
using AppKit;
using Microsoft.VisualStudioUI.Options;
using Microsoft.VisualStudioUI.Options.Models;
using Microsoft.VisualStudioUI.VSMac.Properties;

namespace Microsoft.VisualStudioUI.VSMac.Options
{
    public class ProjectFileOptionVSMac : OptionWithLeftLabelVSMac
    {
        private NSStackView? _controlView;
        private NSTextField? _textField;
        private NSButton? _button;

        public ProjectFileOptionVSMac(ProjectFileOption option) : base(option)
        {
        }

        public ProjectFileOption ProjectFileOption => ((ProjectFileOption)Option);

        protected override NSView ControlView
        {
            get
            {
                if (_controlView == null)
                {
                    _controlView = new NSStackView();
                    _controlView.Orientation = NSUserInterfaceLayoutOrientation.Horizontal;
                    _controlView.TranslatesAutoresizingMaskIntoConstraints = false;

                    ViewModelProperty<string> property = ProjectFileOption.Property;

                    _textField = new NSTextField
                    {
                        Font = NSFont.SystemFontOfSize(NSFont.SmallSystemFontSize),
                        StringValue = property.Value ?? string.Empty,
                        TranslatesAutoresizingMaskIntoConstraints = false,
                        Editable = true,
                        Bordered = true,
                        DrawsBackground = true,
                        LineBreakMode = NSLineBreakMode.TruncatingTail
                    };

                    SetAccessibilityTitleToLabel(_textField);

                    _controlView.AddArrangedSubview(_textField);

                    property.PropertyChanged += delegate
                    {
                        var fullPath = property.Value ?? "";
                        if (string.IsNullOrEmpty(fullPath))
                        {
                            _textField.StringValue = "";
                            return;
                        }

                        int i = fullPath.LastIndexOf(@"/")+1;
                        _textField.StringValue = fullPath[i..];
                    };

                    _textField.Changed += delegate { property.Value = _textField.StringValue; };

                    _button = new NSButton
                    {
                        BezelStyle = NSBezelStyle.RoundRect,
                        Bordered = true,
                        LineBreakMode = NSLineBreakMode.TruncatingTail
                    };
                    if (ProjectFileOption.Name != null)
                    {
                        _button.Title = ProjectFileOption.Name;
                    }
                    else
                    {
                        _button.Title = "···";
                        _button.AccessibilityTitle = Resources.BrowseFilesButtonLabel;
                    }

                    _button.Activated += (s, e) =>
                    {
                        var openPanel = new NSOpenPanel();
                        openPanel.CanChooseDirectories = false;
                        openPanel.CanChooseFiles = true;
                        openPanel.AllowedFileTypes =new string[] { "plist"};
                        var response = openPanel.RunModal();
                        if (response == 1 && openPanel.Url != null)
                        {
                            property.Value = openPanel.Filename;
                        }
                    };

                    _controlView.AddArrangedSubview(_button);
                    _controlView.HeightAnchor.ConstraintEqualTo(21f).Active = true;

                    _textField.WidthAnchor.ConstraintEqualTo(196f).Active = true;
                    _textField.HeightAnchor.ConstraintEqualTo(21).Active = true;
                    _textField.LeadingAnchor.ConstraintEqualTo(_controlView.LeadingAnchor).Active = true;
                    _textField.TopAnchor.ConstraintEqualTo(_controlView.TopAnchor).Active = true;
                    _button.HeightAnchor.ConstraintEqualTo(21).Active = true;
                    _button.WidthAnchor.ConstraintEqualTo(24).Active = true;
                    _button.TrailingAnchor.ConstraintEqualTo(_controlView.TrailingAnchor).Active = true;
                }
                return _controlView;
            }
        }

        public override void OnEnableChanged(bool enabled)
        {
            base.OnEnableChanged(enabled);

            _textField!.Enabled = enabled;

            _button!.Enabled = enabled;
        }
    }
}
