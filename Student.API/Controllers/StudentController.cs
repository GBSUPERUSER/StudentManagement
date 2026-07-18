using Microsoft.AspNetCore.Mvc;
using Student.API.Models;
using Student.API.Interfaces;

namespace Student.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{

private readonly IStudentService _studentService;

public StudentController(IStudentService studentService)
{
    _studentService = studentService;
}
[HttpGet]
public List<StudentModel> Get()
{
    return _studentService.GetAll();
}

[HttpGet("{id}")]
public StudentModel? GetById(int id)
{
 return _studentService.GetById(id);
}

[HttpPost]
public StudentModel Create(StudentModel student)
{
  return _studentService.Create(student);
}
[HttpPut("{id}")]
public StudentModel Update(int id, StudentModel student)
{
    return _studentService.Update(id, student);
}
[HttpDelete("{id}")]
public bool Delete(int id)
{
    return _studentService.Delete(id);
}
}