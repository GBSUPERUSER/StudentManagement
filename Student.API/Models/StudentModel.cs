namespace Student.API.Models;

public class StudentModel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public string Email { get; set; } = string.Empty;
}