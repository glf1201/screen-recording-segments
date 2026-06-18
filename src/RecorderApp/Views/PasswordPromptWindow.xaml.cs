using System.Windows.Input;
using System.Windows.Threading;

namespace RecorderApp.Views;

public partial class PasswordPromptWindow : Window
{
    public PasswordPromptWindow()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    public string Password => PasswordInput.Password;

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        // On some Win10 machines, a modal dialog opened from a hidden tray window
        // does not receive keyboard focus reliably unless activation is deferred once.
        Dispatcher.BeginInvoke(() =>
        {
            Activate();
            Topmost = true;
            Topmost = false;
            PasswordInput.Focus();
            Keyboard.Focus(PasswordInput);
            PasswordInput.SelectAll();
        }, DispatcherPriority.Input);
    }
}
