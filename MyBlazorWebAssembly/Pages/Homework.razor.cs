using Microsoft.AspNetCore.Components;

namespace MyBlazorWebAssembly.Pages;

public partial class Homework
{
    [Parameter]
    public string Title { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private void GoToIndex()
    {
        NavigationManager.NavigateTo("/");
    }
}
