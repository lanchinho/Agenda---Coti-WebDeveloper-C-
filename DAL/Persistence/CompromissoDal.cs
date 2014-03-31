using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Persistence
{
    /// <summary>
    /// Classe responsável por todas as operações realizadas em Compromissos no banco de dados.
    /// </summary>
    public class CompromissoDal : IDisposable
    {
        private Conexao Con;

        public CompromissoDal()
        {
            Con = new Conexao();
        }

        /// <summary>
        /// Método responsável por salvar um compromisso
        /// </summary>
        /// <param name="c"></param>
        public void salvarCompromisso(Compromisso c)
        {
            try
            {
                Con.Compromisso.Add(c);
                Con.SaveChanges();
            }
            catch (Exception e)
            {

                throw new Exception("Não foi possível criar o compromisso:  " + e.Message);
            }
        }

        /// <summary>
        /// Método responsável por listar todos os compromissos
        /// </summary>
        /// <returns>Retorna uma lista de Compromissos</returns>
        public List<Compromisso> listaTodosCompromissos()
        {
            try
            {
                return Con.Compromisso.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar os compromisso: " + e.Message);
            }
        }

        public List<Compromisso> listaCompromissosDoUsuario(int idUsuario)
        {
            try
            {
                return Con.Compromisso.Where(comp => comp.IdUsuario == idUsuario).ToList();
            }
            catch (Exception e)
            {
                
                throw new Exception("Erro ao listar os compromissos do usuário: " + e.Message);
            }
        }

        /// <summary>
        /// Método responsável por obter um compromisso dado o seu ID
        /// </summary>
        /// <param name="IdCompromisso"></param>
        /// <returns>Compromisso</returns>

        public Compromisso obterCompromissoPeloId(int IdCompromisso)
        {
            try
            {
                return Con.Compromisso.Where(comp => comp.IdCompromisso == IdCompromisso).Single();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao retornar o compromisso: " + e.Message);
            }
        }

        /// <summary>
        /// Método responsável pela exclusão de um compromisso.
        /// </summary>
        /// <param name="c"></param>
        public void excluirCompromisso(Compromisso c)
        {
            try
            {
                Con.Compromisso.Remove(c);
                Con.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o compromisso: " + e.Message);
            }
        }

        /// <summary>
        /// Método responsável por atualizar informações de um compromisso.
        /// </summary>
        /// <param name="c"></param>
        public void atualizarCompromisso(Compromisso c)
        {
            try
            {
                Compromisso compromisso = obterCompromissoPeloId(c.IdCompromisso);

                compromisso.Titulo = c.Titulo;
                compromisso.Descricao = c.Descricao;
                compromisso.Data = c.Data;

                Con.SaveChanges();
            }
            catch (Exception e)
            {    
                throw new Exception("Erro ao atualizar o compromisso: " + e.Message);
            }
        }


        /// <summary>
        /// Método responsável por fechar a conexão com o banco de dados.
        /// </summary>
        public void Dispose()
        {
            Con.Dispose();
        }
    }
}
