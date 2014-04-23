using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Entities;
using DAL.Persistence;
using BLL.Model;

namespace BLL.Business
{
    public class AgendaBll
    {
        /// <summary>
        /// Método para gerar Datatable Relatorio populada com os dados de contato
        /// </summary>
        /// <returns>Datatable</returns>
        public DataTable relatorioContato()
        {
            try
            {
                using (ContatoDal contato = new ContatoDal())
                {
                    var dados = contato.listarTodosContatos();

                    DSContato dsContato = new DSContato();
                    DataTable dt = dsContato.Tables["Relatorio"];

                    foreach (var item in dados)
                    {
                        DataRow registro = dt.NewRow();
                        registro["NomeContato"] = item.NomeContato;
                        registro["EmailContato"] = item.EmailContato;
                        registro["Telefone"] = item.Telefone;

                        dt.Rows.Add(registro);
                    }

                    return dt;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter dados: " + e.Message);
            }
        }

        public DataTable relatorioCompromisso()
        {
            try
            {
                using (CompromissoDal compromisso = new CompromissoDal())
                {
                    var dados = compromisso.listaTodosCompromissos();

                    DSCompromisso dsCompromisso = new DSCompromisso();
                    DataTable dt = dsCompromisso.Tables["Relatorio"];

                    foreach (var item in dados)
                    {
                        DataRow registro = dt.NewRow();
                        registro["Titulo"] = item.Titulo;
                        registro["Descricao"] = item.Descricao;
                        registro["Data"] = item.Data;

                        dt.Rows.Add(registro);
                    }

                    return dt;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter dados: " + e.Message);
            }
        }
    }
}
