using Microsoft.AspNetCore.Components;

namespace MyBlazorWebAssembly.Pages;

public partial class Home
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    private void GoToHomework()
    {
        NavigationManager.NavigateTo("/homework/moje zadanie domowe");
    }
}
