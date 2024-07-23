using MyBlazorWebAssembly.Models;

namespace MyBlazorWebAssembly.Services;

public interface IStudentRepo
{
    List<Student> Get();
    void Add();
}
