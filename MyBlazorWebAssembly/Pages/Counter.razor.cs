using Microsoft.AspNetCore.Components;
using MyBlazorWebAssembly.Services;

namespace MyBlazorWebAssembly.Pages;

public partial class Counter
{
    private int currentCount = 0;
    [Parameter]
    public bool? IsDeleted { get; set; }

    [Parameter]
    public int Header { get; set; }

    [SupplyParameterFromQuery(Name = "Header2")]
    public string Header2 { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IStudentRepo StudentRepo { get; set; }

    private void IncrementCount()
    {
        try
        {
            //throw new Exception("Error 123");

            StudentRepo.Add();
            currentCount++;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    private void GoToIndex()
    {
        NavigationManager.NavigateTo("/counter-par/999/true?header2=mój nagłowek");
    }
}
