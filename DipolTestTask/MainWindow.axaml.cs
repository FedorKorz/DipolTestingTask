using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Interactivity;
using static DipolTestTask.Utils.Utils;

namespace DipolTestTask;

public partial class MainWindow : Window
{
    private readonly TextBox? _textBox;
    private readonly TextBlock? _errorTextBlock;

    public MainWindow()
    {
        InitializeComponent();
        var button = this.FindControl<Button>("MyButton");
        _textBox = this.FindControl<TextBox>("MyTextBox");
        _errorTextBlock = this.FindControl<TextBlock>("ErrorTextBlock");

        if (button != null) button.Click += OnButtonClick;
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {
        var colorFromTextBox = _textBox?.Text;

        if (IsValidColorCode(colorFromTextBox))
            try
            {
                _textBox.Background = new SolidColorBrush(Color.Parse(colorFromTextBox));
                _errorTextBlock.Text = string.Empty;
            }
            catch
            {
                _errorTextBlock.Text = "Invalid color code.";
            }
        else
            _errorTextBlock.Text = "Неверный цветовой код. Используйте #RRGGBB формат.";
    }
}