using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MyBlazorWebAssembly.Components;

public partial class ModalWindow
{
    [Parameter]
    public bool Show { get; set; }
    [Parameter]
    public RenderFragment Title { get; set; }
    [Parameter]
    public RenderFragment Body { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> OnCancel { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> OnAccept { get; set; }

    //private void OnCancel(MouseEventArgs e)
    //{
    //    Show = false;
    //}
    
    //private void OnCancel()
    //{
    //    Show = false;
    //}
}
