using System;
using Microsoft.VisualStudioUI.Options;
using Microsoft.VisualStudioUI.Options.Models;

namespace Microsoft.VisualStudioUI.VSMac.Options
{
    public class OptionFactoryVSMac : OptionFactoryPlatform
    {
        public OptionFactoryVSMac()
        {
        }

        public override OptionCardPlatform CreateOptionCardPlatform(OptionCard optionCard) =>
            new OptionCardVSMac(optionCard);

        public override OptionCardsPlatform CreateOptionCardsPlatform(OptionCards optionCards) =>
            new OptionCardsVSMac(optionCards);

        public override OptionPlatform CreateTextOptionPlatform(TextOption textOption) =>
            new TextOptionVSMac(textOption);

        public override OptionPlatform CreateComboBoxOptionPlatform<TItem>(ComboBoxOption<TItem> comboBoxOption) =>
            new ComboBoxOptionVSMac<TItem>(comboBoxOption);

        public override OptionPlatform CreateEditableComboBoxOptionPlatform(EditableComboBoxOption editableComboBoxOption) =>
            new EditableComboBoxOptionVSMac(editableComboBoxOption);

        public override OptionPlatform CreateDocButtonOptionPlatform(DocButtonOption docButtonOption) =>
            new DocButtonOptionVSMac(docButtonOption);

        public override OptionPlatform CreateSeparatorOptionPlatform(SeparatorOption separatorOption) =>
            new SeparatorOptionVSMac(separatorOption);

        public override OptionPlatform CreateSwitchOptionPlatform(SwitchOption switchOption) =>
            new SwitchOptionVSMac(switchOption);

        public override OptionPlatform CreateStringListOptionPlatform(StringListOption stringListOption) =>
            new StringListOptionVSMac(stringListOption);

        public override OptionPlatform CreateImageViewOptionPlatform(ScaledImageFileOption imageFileOption) =>
            new ScaledImageFileOptionVSMac(imageFileOption);

        public override OptionPlatform CreateButtonOptionPlatform(ButtonOption buttonOption) =>
            new ButtonOptionVSMac(buttonOption);

        public override OptionPlatform CreateCheckBoxOptionPlatform(CheckBoxOption checkBoxOption) =>
            new CheckBoxOptionVSMac(checkBoxOption);

        public override OptionPlatform CreateRadioButtonOptionPlatform(RadioButtonOption radioButtonOption) =>
            new RadioButtonOptionVSMac(radioButtonOption);

        public override OptionPlatform CreateCheckBoxListOptionPlatform(CheckBoxListOption checkBoxListOption) =>
            new CheckBoxListOptionVSMac(checkBoxListOption);

        public override OptionPlatform CreateLabelOptionPlatform(LabelOption labelOption) =>
            new LabelOptionVSMac(labelOption);

        public override OptionPlatform CreateStepperOptionPlatform(StepperOption stepperOption) =>
            new StepperOptionVSMac(stepperOption);

        public override OptionPlatform CreateProgressIndicatorOptionPlatform(ProgressIndicatorOption progressIndicatorOption) =>
            new ProgressIndicatorOptionVSMac(progressIndicatorOption);

        public override OptionPlatform CreateCreateFileChooseOptionlatform(FileChooseOption fileChooseOption) =>
            new FileChooseOptionVSMac(fileChooseOption);

    }
}
