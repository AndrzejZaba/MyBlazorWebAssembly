using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MyBlazorWebAssembly.Components;

public partial class Card
{
    private string _info = "Komunikat z CARD";
    [Parameter]
    public string Image { get; set; }
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public string Content { get; set; }
    [Parameter]
    public string BtnText { get; set; }

    [Parameter]
    public EventCallback OnClickMore { get; set; }

    private void ClickMore(MouseEventArgs e)
    {
        //logika - obsługa funckcji w tm miejscu

        //albo przekierowanie do funkcji w elemencie nadrzędnym (jak poniżej)
        OnClickMore.InvokeAsync();
    }
}
