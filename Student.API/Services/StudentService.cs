using Student.API.Interfaces;
using Student.API.Models;


namespace Student.API.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository; //added

    //private static List<StudentModel> students = new List<StudentModel>(); //Earlier for practise hardcode data

    public StudentService(IStudentRepository studentRepository)
{
    _studentRepository = studentRepository;
}

    public List<StudentModel> GetAll()
    {
       // return students;
       return _studentRepository.GetAll(); //added
    }

    public StudentModel? GetById(int id)
    {
        //return students.FirstOrDefault(s => s.Id == id);
        return _studentRepository.GetById(id);
    }

    public StudentModel Create(StudentModel student)
    {
        //students.Add(student);
        //return student;
        return _studentRepository.Create(student); //added
    }

    public StudentModel? Update(int id, StudentModel updatedStudent)
    {
        return _studentRepository.Update(id, updatedStudent);
        //StudentModel? student = students.FirstOrDefault(s => s.Id == id);

        //if (student == null)
          //  return null;

       // student.Name = updatedStudent.Name;
       // student.Age = updatedStudent.Age;
       // student.Email = updatedStudent.Email;

       // return student;
    }

    public bool Delete(int id)
    {
        return _studentRepository.Delete(id);
    }
}