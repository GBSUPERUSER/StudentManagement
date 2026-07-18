using Student.API.Models;

namespace Student.API.Interfaces;

public interface IStudentRepository
{
    List<StudentModel> GetAll();

    StudentModel? GetById(int id);

    StudentModel Create(StudentModel student);

    StudentModel? Update(int id, StudentModel student);

    bool Delete(int id);
}