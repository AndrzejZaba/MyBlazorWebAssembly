using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MyBlazorWebAssembly.Components;

public partial class Card
{
    private string _info = "Komunikat z CARD";
    private string _additionalCardClasses = "";
    [Parameter]
    public string Image { get; set; }
    [Parameter]
    public RenderFragment Title { get; set; }
    [Parameter]
    public RenderFragment Content { get; set; }
    [Parameter]
    public string BtnText { get; set; }
    [Parameter]
    public string Style { get; set; }
    [Parameter]
    public string BtnClass { get; set; } = "btn btn-danger";
    [Parameter]
    public bool BtnDisabled { get; set; }
    [Parameter]
    public string BtnTitle { get; set; }

    [Parameter]
    public EventCallback OnClickMore { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> BtnAttributes { get; set; } 

    private void ClickMore(MouseEventArgs e)
    {
        //logika - obsługa funckcji w tm miejscu

        //albo przekierowanie do funkcji w elemencie nadrzędnym (jak poniżej)
        OnClickMore.InvokeAsync();
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        Console.WriteLine("SetParametersAsync");
        await base.SetParametersAsync(parameters);
    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("OnInitializedAsync");
        await base.OnInitializedAsync();
    }

    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("OnParametersSetAsync");
        base.OnParametersSetAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
            Console.WriteLine("OnAfterRenderAsync - firstRender");
             

        Console.WriteLine("OnAfterRenderAsync");
        await base.OnAfterRenderAsync(firstRender);
    }

    public void AddCardBorder()
    {
        _additionalCardClasses = "border-3 border-success";
    }

}
