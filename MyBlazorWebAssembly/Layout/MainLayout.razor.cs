using Microsoft.AspNetCore.Components.Web;

namespace MyBlazorWebAssembly.Layout;

public partial class MainLayout
{
    private ErrorBoundary _errorBoundary;
    public static object TopSection = new();

    protected override void OnParametersSet()
    {
        _errorBoundary?.Recover();
    }
}
