using Microsoft.AspNetCore.Components;

namespace MyBlazorWebAssembly.Components;

public partial class AdditionalInfo
{
    [CascadingParameter (Name = "Info")]
    public string Info { get; set; }
    [CascadingParameter (Name = "Title")]
    public string Title { get; set; }
}
