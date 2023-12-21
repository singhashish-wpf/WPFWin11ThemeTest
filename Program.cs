using FlaUI.UIA3;

var app = FlaUI.Core.Application.Launch(@"D:\\repos\\Dec2023\\Win11ThemeSampleApp\\bin\\x64\\Debug\\net9.0-windows\\win-x64\\Win11ThemeSampleApp.exe");
using (var automation = new UIA3Automation())
{
    var window = app.GetMainWindow(automation);
    Console.WriteLine(window.Title);
}