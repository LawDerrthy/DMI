using EcoAppODS.Pages;

namespace EcoAppODS;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Si más adelante usara rutas personalizadas agregar:
        // Routing.RegisterRoute(nameof(ReportePage), typ eof(ReportePage));
        // Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
    }
}
