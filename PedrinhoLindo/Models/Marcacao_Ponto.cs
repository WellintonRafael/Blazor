using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedrinhoLindo.Models
{
	internal class Marcacao_Ponto
	{
		public int Id { get; set; }
		public string Cod_funcionario { get; set;}
		public string Nome { get; set; }
		public DateTime Data { get; set; }
		public string Entrada { get; set; }
		public string Sai_almoco { get; set;}
		public string Ent_Almoco { get; set;}
		public string Saida { get; set; }
	}
}
