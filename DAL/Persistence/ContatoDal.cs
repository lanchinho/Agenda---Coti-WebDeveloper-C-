using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;


namespace DAL.Persistence
{
    /// <summary>
    /// Classe reponsável por toda a loja que envolve um Contato no banco de dados.
    /// </summary>
    public class ContatoDal : IDisposable
    {
        Conexao Con;

        public ContatoDal()
        {
            Con = new Conexao();
        }

        /// <summary>
        /// Método responsável por salvar um Contato
        /// </summary>
        /// <param name="c"></param>
        public void salvarContato(Contato c)
        {
            try
            {
                Con.Contato.Add(c);
                Con.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar um contato: " + e.Message);
            }
        }

        /// <summary>
        /// Método para listar todos os contatos registrados no banco
        /// </summary>
        /// <returns>Lista contendo todos os contatos</returns>
        public List<Contato> listarTodos()
        {
            try
            {
                return Con.Contato.ToList();
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao listar contatos: " + e.Message);
            }
        }

        /// <summary>
        /// Método para listar todos os contatos de um Usuário
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Lista contendo todos os contatos de um dado Usuário</returns>
        public List<Contato> listarTodosDoUsuario(int id)
        {
            try
            {
                return Con.Contato.Where(c => c.IdUsuario == id).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao buscar os contatos do usuário: " + e.Message);
            }
        }

        /// <summary>
        /// Método para buscar um contato dado o seu ID
        /// </summary>
        /// <param name="IdContato"></param>
        /// <returns>Retorna Contato</returns>
        public Contato obterContatoPorId(int IdContato)
        {
            try
            {
                Contato contato;
                contato = Con.Contato.Where(c => c.IdContato == IdContato).Single();
                return contato;
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao buscar o contato: " + e.Message);
            }
        }

        /// <summary>
        /// Método para Exclusão de Contato
        /// </summary>
        /// <param name="c"></param>
        public void excluirContato(Contato c)
        {
            try
            {
                Con.Contato.Remove(c);
                Con.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o contato " + e.Message);
            }
        }

        /// <summary>
        /// Método responsável por atualizar as informações de um contato
        /// </summary>
        /// <param name="c"></param>
        public void atualizarContato(Contato c)
        {
            try
            {
                Contato contato = obterContatoPorId(c.IdContato);
                contato.NomeContato = c.NomeContato;
                contato.Telefone = c.Telefone;
                contato.EmailContato = c.EmailContato;

                Con.SaveChanges();
            }
            catch (Exception e)
            {

                throw new Exception("Não foi possível atualizar o contato." + e.Message);
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
