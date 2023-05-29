using PedrinhoLindo.Models;
using SQLite;

namespace PedrinhoLindo.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private SQLiteAsyncConnection _dbConnection;

        public FuncionarioService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = "C:\\WellintonProjetos\\Ponto\\Blazor\\PedrinhoLindo\\database_ponto_digital.db3";

                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<TB_FUNCIONARIOS>();
            }
        }

        public async Task<TB_FUNCIONARIOS> GetFuncionarioByCod(string codFuncionario)
        {
            var funcionario = await _dbConnection.QueryAsync<TB_FUNCIONARIOS>($"Select * From {nameof(TB_FUNCIONARIOS)} Where Cod_funcionario = {codFuncionario}");

            return funcionario.FirstOrDefault();
        }


        public async Task<int> AddFuncionario(TB_FUNCIONARIOS funcionario)
        {
            return await _dbConnection.InsertAsync(funcionario);
        }

        public async Task<int> DeleteFuncionario(TB_FUNCIONARIOS funcionario)
        {
            return await _dbConnection.DeleteAsync(funcionario);
        }

        public async Task<List<TB_FUNCIONARIOS>> GetAllFuncionarios()
        {
            return await _dbConnection.Table<TB_FUNCIONARIOS>().ToListAsync();
        }

        public async Task<int> UpdateFuncionario(TB_FUNCIONARIOS funcionario)
        {
            return await _dbConnection.UpdateAsync(funcionario);
        }
    }
}
