using StudentInfo.Models;

namespace StudentInfo.Repository;

public class StudentRepository : IStudentRepository
{
    public List<StudentModel> getAllStudents()
    {
        return DataSource();
    }

    public StudentModel getStudentById(int  id)
    {
        return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
    }

    private List<StudentModel> DataSource()
    {
        return new List<StudentModel>
        {
            new StudentModel {rollNo = 1, Name = "Begun", Gender = "Male", Standard = 11},
            new StudentModel {rollNo = 2, Name = "Alu", Gender = "Female", Standard = 10},
            new StudentModel {rollNo = 3, Name = "Potol", Gender = "Male", Standard = 12},
            new StudentModel {rollNo = 4, Name = "Kumra", Gender = "Female", Standard = 7},
            new StudentModel {rollNo = 5, Name = "Pape", Gender = "Male", Standard = 9},
        };
    }
    
}