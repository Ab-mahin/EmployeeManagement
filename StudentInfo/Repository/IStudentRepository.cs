using StudentInfo.Models;

namespace StudentInfo.Repository;

public interface IStudentRepository
{
    List<StudentModel>  getAllStudents();
    StudentModel getStudentById(int id);
}