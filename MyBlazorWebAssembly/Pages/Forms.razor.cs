using Microsoft.AspNetCore.Components;
using MyBlazorWebAssembly.Models;
using MyBlazorWebAssembly.Services;
using Newtonsoft.Json;

namespace MyBlazorWebAssembly.Pages;

public partial class Forms
{
    private bool _isLoading = false;
    private Employee _employee = new Employee
    {
        DateOfEmployment = DateTime.Now
    };

    private IEnumerable<Position> _positions = new List<Position>
    {
        new Position{Id = 1, Name = "IT"},
        new Position{Id = 2, Name = "Magazynier"},
        new Position{Id = 3, Name = "Kierowca"}
    };

    [Inject]
    public ToastrService ToastrService { get; set; }

    private async Task Save()
    {

        try
        {
            _isLoading = true;
            await Task.Delay(3000);

            var json = JsonConvert.SerializeObject(_employee);
            await ToastrService.ShowInfoMessage($"Dane zostały zapisane. Użytkownik: {json}");

            _employee = new Employee
            {
                DateOfEmployment = DateTime.Now
            };

        }
        finally
        {
            _isLoading = false;
        }

    }
}
