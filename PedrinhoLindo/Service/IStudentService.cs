using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedrinhoLindo.Models;

namespace PedrinhoLindo.Service
{
    public interface IStudentService
    {
        Task<StudentModel> GetStudentById(int studentId);
        Task<int> AddStudent(StudentModel studentModel);
        Task<int> DeleteStudent(StudentModel studentModel);
        Task<List<StudentModel>> GetAllStudents();
        Task<int> UpdateStudent(StudentModel studentModel);
    }
}
