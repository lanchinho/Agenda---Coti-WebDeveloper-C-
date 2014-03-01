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
        /// Método para buscar um contato dado o seu ID
        /// </summary>
        /// <param name="IdContato"></param>
        /// <returns>Retorna Contato</returns>
        public Contato buscaContatoPorId(int IdContato)
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
        public void Excluir(Contato c)
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
        /// Método responsável por fechar a conexão com o banco de dados.
        /// </summary>
        public void Dispose()
        {
            Con.Dispose();
        }
    }
}
