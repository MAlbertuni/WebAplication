using WebApi.DataBase;
using WebApi.Models;

namespace WebApi.Services
{
    public class PessoaService
    {
        /// <summary>
        /// Conexão com o banco de dados
        /// </summary>
        private readonly ConexaoSQLite _conexao;

        public PessoaService(ConexaoSQLite conexao)
        {
            _conexao = conexao;
        }

        /// <summary>
        /// Método que retorna uma lista com todas as pessoas cadastradas
        /// </summary>
        /// <returns>Lista com todas as pessoas</returns>
        public List<Pessoa> ObterTodos() => [.. _conexao.Pessoa];

        /// <summary>
        /// Método que retorna a pessoa pelo Id
        /// </summary>
        /// <param name="Id">Id do registro</param>
        /// <returns>Pessoa</returns>
        public Pessoa ObterPorId(int Id) => _conexao.Pessoa.Find(Id);

        /// <summary>
        /// Método que adiciona uma pessoa na tabela
        /// </summary>
        /// <param name="pessoa">Objeto com a pessoa a ser inserida</param>
        /// <returns>True se inseriu com sucesso</returns>
        public bool Adicionar(Pessoa pessoa)
        {
            _conexao.Pessoa.Add(pessoa);
            return _conexao.SaveChanges() > 0;
        }

        /// <summary>
        /// Método que atualiza um registro
        /// </summary>
        /// <param name="pessoa">Objeto que substituirá</param>
        /// <returns>True se atualizou com sucesso</returns>
        public bool Atualizar(Pessoa pessoa)
        {
            if (ObterPorId(pessoa.Id) is not null)
            {
                _conexao.Pessoa.Update(pessoa);
                return _conexao.SaveChanges() > 0;
            }
            return false;
        }

        /// <summary>
        /// Método que deleta um registro
        /// </summary>
        /// <param name="id">Id do registro a ser deletado</param>
        /// <returns>True se deletou</returns>
        public bool Deletar(int id)
        {
            Pessoa? pessoa = ObterPorId(id);
            if (pessoa != null)
            {
                _conexao.Pessoa.Remove(pessoa);
                return _conexao.SaveChanges() > 0;
            }
            return false;
        }
    }
}
