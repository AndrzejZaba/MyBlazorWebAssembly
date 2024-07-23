using MyBlazorWebAssembly.Models;

namespace MyBlazorWebAssembly.Services;

public class StudentRepo : IStudentRepo
{
    private List<Student> _students = new List<Student>();
    public void Add()
    {
        _students.Add(new Student { Name = Guid.NewGuid().ToString()});
    }

    public List<Student> Get()
    {
        return _students;
    }
}
