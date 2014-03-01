using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Persistence
{
    /// <summary>
    /// Classe responsável por toda a lógica que envolve um usuário no banco de dados
    /// </summary>
    public class UsuarioDal : IDisposable
    {
        private Conexao Con;

        public UsuarioDal()
        {
            Con = new Conexao();
        }

        /// <summary>
        /// Método responsável por cadastrar um usuário no banco de dados.
        /// </summary>
        /// <param name="u"></param>
        public void salvarUsuario(Usuario u)
        {
            try
            {
                Con.Usuario.Add(u);
                Con.SaveChanges();
            }
            catch (Exception e)
            {   
                throw new Exception("Erro ao cadastrar usuário: " + e.Message);
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
