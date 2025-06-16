using EmployeeManagement.Models;

namespace EmployeeManagement.Repository;

public interface IStudentRepository
{
    List<StudentModel>  getAllStudents();
    StudentModel getStudentById(int id);
}