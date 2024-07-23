using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace MyBlazorWebAssembly.Pages;

public partial class Javascript
{
    [Inject]
    public IJSRuntime JSRuntime { get; set; }
    private async Task DisplayAlert()
    {
        await JSRuntime.InvokeVoidAsync("alert", "Przykładowa wiadomość");
    }
}
