﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.Providers.MongoDb.Collections
{
	[BsonCollection("Fornecedor")]
	public class FornecedorCollection : Document
	{
        #region Propriedades
        public Guid CodigoId { get; set; }
        public string Nome { get;  set; }
		public string CNPJ { get;  set; }
		public string RazaoSocial { get;  set; }
		public DateTime DataCadastro { get;  set; }
		public bool Ativo { get;  set; }
		#endregion
	}
}
