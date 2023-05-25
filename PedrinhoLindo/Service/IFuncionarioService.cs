using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedrinhoLindo.Service;
using PedrinhoLindo.Models;

namespace PedrinhoLindo.Service
{
	public interface IFuncionarioService
	{
		Task<TB_FUNCIONARIOS> GetFuncionarioByCod(string funcionarioModel);
		Task<int> AddFuncionario(TB_FUNCIONARIOS funcionarioModel);
		Task<int> DeleteFuncionario(TB_FUNCIONARIOS funcionarioModel);
		Task<List<TB_FUNCIONARIOS>> GetAllFuncionarios();
		Task<int> UpdateFuncionario(TB_FUNCIONARIOS funcionarioModel);
	}
}
