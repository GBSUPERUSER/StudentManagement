using Student.API.Interfaces;
using Student.API.Models;
using Student.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Student.API.Repositories;

public class StudentRepository : IStudentRepository
{
   // private static List<StudentModel> students = new(); //commented for db used for static data
private readonly StudentDbContext _context;

public StudentRepository(StudentDbContext context)
{
    _context = context;
}
  
public List<StudentModel> GetAll()
{
    return _context.Students.ToList();
}
   public StudentModel? GetById(int id)
{
    return _context.Students.FirstOrDefault(s => s.Id == id);
}

    public StudentModel Create(StudentModel student)
{
    _context.Students.Add(student);
    _context.SaveChanges();
    return student;
}

  public StudentModel? Update(int id, StudentModel updatedStudent)
{
    StudentModel? student = _context.Students.FirstOrDefault(s => s.Id == id);

    if (student == null)
        return null;

    student.Name = updatedStudent.Name;
    student.Age = updatedStudent.Age;
    student.Email = updatedStudent.Email;

    _context.SaveChanges();

    return student;
}

  public bool Delete(int id)
{
    StudentModel? student = _context.Students.FirstOrDefault(s => s.Id == id);

    if (student == null)
        return false;

    _context.Students.Remove(student);
    _context.SaveChanges();

    return true;
}
}