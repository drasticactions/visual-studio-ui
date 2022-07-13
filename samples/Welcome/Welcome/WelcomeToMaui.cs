using System.ComponentModel;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Shapes;

namespace Welcome
{
    [StandardControl]
    public interface IWelcomeToMaui : IStandardControl
    {
        Color SampleProperty { get; set; }
    }

    public class WelcomeToMauiImplementation : StandardControlImplementation<IWelcomeToMaui>
    {
        public WelcomeToMauiImplementation(IWelcomeToMaui control) : base(control)
        {
        }

        public override IUIElement Build() =>
            VerticalStack().Children(
                TextBlock()
                    .Text("Learn .NET MAUI")
                    .FontSize(30)
                    .Foreground(SolidColorBrush(Colors.Purple)),

                TextBlock()
                    .Text("Learn about the .NET platform, create your first application, and deploy it to your device")
                    .FontSize(14)
                    .Foreground(SolidColorBrush(Colors.Gray)),

                Grid()
                    .ColumnDefinitions(
                        ColumnDefinition(),
                        ColumnDefinition(),
                        ColumnDefinition()
                    )
                    .RowDefinitions(
                        RowDefinition(),
                        RowDefinition(),
                        RowDefinition()
                    )._(
                        Rectangle().Width(50).Height(50).Fill(Colors.Red).GridCell(0, 0),
                        Rectangle().Width(50).Height(50).Fill(Colors.Green).GridCell(0, 1),
                        Rectangle().Width(50).Height(50).Fill(Colors.Yellow).GridCell(0, 2),

                        TextBlock()
                            .Width(50)
                            .Text("Learn")
                            .Foreground(SolidColorBrush(Colors.Blue))
                            .GridCell(1, 0),

                        TextBlock()
                            .Width(50)
                            .Text("Build")
                            .Foreground(SolidColorBrush(Colors.Blue))
                            .GridCell(1, 1),

                        TextBlock()
                            .Width(50)
                            .Text("Deploy")
                            .Foreground(SolidColorBrush(Colors.Blue))
                            .GridCell(1, 2)
                    )
            );
    }
}
