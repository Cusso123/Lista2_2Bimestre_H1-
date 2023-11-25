using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Entities
{
	public class Fornecedor : EntidadeBase
	{
		#region Construtor

		public Fornecedor(string nome, string cnpj, string razaosocial, DateTime datacadastro, bool ativo)
		{
			Nome = nome;
			CNPJ = cnpj;
			RazaoSocial = razaosocial;
			DataCadastro = datacadastro;
			Ativo = ativo;
		}
        public Fornecedor(Guid codigoID,string nome, string cnpj, string razaosocial, DateTime datacadastro, bool ativo)
        {
            CodigoID = codigoID;
            Nome = nome;
            CNPJ = cnpj;
            RazaoSocial = razaosocial;
            DataCadastro = datacadastro;
            Ativo = ativo;
        }

        #endregion

        #region propriedades

        public Guid CodigoID { get; private set; }
        public string Nome { get; private set; }
		public string CNPJ { get; private set; }
		public string RazaoSocial { get; private set; }
		public DateTime DataCadastro { get; private set; }
		public bool Ativo { get; private set; }


		#endregion

		#region comportamentos

		public void Ativar() => Ativo = true;

		public void Desativar() => Ativo = false;

		public void AlterarNome(string nome) => Nome = nome;
		public void AlterarRazaoSocial(string razaoSocial) => RazaoSocial = razaoSocial;
		public void AlterarCNPJ(string cnpj) => CNPJ = cnpj;

		#endregion
	}
}
