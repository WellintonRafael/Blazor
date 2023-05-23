using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedrinhoLindo.Models;
using SQLite;

namespace PedrinhoLindo.Service
{
    public class StudentService : IStudentService
    {
        private SQLiteAsyncConnection _dbConnection;

        public StudentService() 
        {
            SetUpDb();
        }

        public async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = "C:\\Users\\PC\\OneDrive\\Área de Trabalho\\Mentoria Maui\\Blazor\\PedrinhoLindo\\Student.db3";

				_dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<StudentModel>();
            }
        }

        public async Task<StudentModel> GetStudentById(int studentId)
        {
            var student = await _dbConnection.QueryAsync<StudentModel>($"Select * From {nameof(StudentModel)} Where Id = {studentId}");

            return student.FirstOrDefault();
        }

        public async Task<int> AddStudent(StudentModel studentModel)
        {
            return await _dbConnection.InsertAsync(studentModel);
        }


        public async Task<int> DeleteStudent(StudentModel studentModel)
        {
            return await _dbConnection.DeleteAsync(studentModel);
        }

        public async Task<List<StudentModel>> GetAllStudents()
        {
            return await _dbConnection.Table<StudentModel>().ToListAsync();
        }

        public async Task<int> UpdateStudent(StudentModel studentModel)
        {
            return await _dbConnection.UpdateAsync(studentModel);
        }
    }
}
