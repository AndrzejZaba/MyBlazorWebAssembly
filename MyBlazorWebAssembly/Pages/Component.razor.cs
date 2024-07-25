using Microsoft.AspNetCore.Components;
using MyBlazorWebAssembly.Models;

namespace MyBlazorWebAssembly.Pages;

public partial class Component
{
    private string _info = "123";
    private string _title = "Tytuł";
    private string _btnText = "Więcej";

    private Dictionary<string, object> _cardAtributes = new()
    {
        {"BtnClass", "btn btn-success"},
        {"BtnTitle", "Więcej"},
        {"BtnDisabled", false},
        {"Style", ""}
    };
    
    private Dictionary<string, object> _cardBtnAtributes = new()
    {
        {"class", "btn btn-success"},
        {"title", "Więcej"},
        {"disabled", false},
        {"type", "button"}
    };

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private List<CardModel> _authors = new();

    protected override async Task OnInitializedAsync()
    {
        _authors = new List<CardModel>
    {
        new CardModel
        {
            Title="Jan Kowalski",
            Content = "Programista C# .NET z 20-letnim doświadczeniem. Specjalizacje: Blazor i ASP .NET Core",
            Image = "/files/kowalski.png",
            BtnText = "Więcej"
        },
        new CardModel
        {
            Title="Anna Nowak",
            Content = "Programistka C# .NET z 10-letnim doświadczeniem. Specjalizacje: Blazor i ASP .NET Core",
            Image = "/files/nowak.png",
            BtnText = "Więcej"
        },
        new CardModel
        {
            Title="Błażej Kwiatkowski",
            Content = "Programista C# .NET z 5-letnim doświadczeniem. Specjalizacje: Blazor i ASP .NET Core",
            Image = "/files/kwiatkowski.png",
            BtnText = "Więcej"
        },
    };


        await base.OnInitializedAsync();
    }

    private void ClickMore()
    {
        NavigationManager.NavigateTo($"/");
    }

    private void ChangeBtnText()
    {
        _btnText = "Więcej ......";
    }

}
