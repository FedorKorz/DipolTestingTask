using System;
using Avalonia.Controls;
using Avalonia.Media;

namespace DipolTestTask;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var button = this.FindControl<Button>("MyButton");
        button.Click += OnButtonClick;
    }
    
    private void OnButtonClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var textBox = this.FindControl<TextBox>("MyTextBox");
        textBox.Text = "Button clicked!";
        textBox.Background = new SolidColorBrush(Colors.Red); // Изменить цвет фона
    }
}