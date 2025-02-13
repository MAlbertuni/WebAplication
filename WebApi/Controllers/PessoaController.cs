using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        /// <summary>
        /// Interface
        /// </summary>
        private readonly PessoaService _pessoa;

        public PessoaController(PessoaService pessoa)
        {
            _pessoa = pessoa;
        }

        /// <summary>
        /// Obter todas as pessoas cadastradas
        /// </summary>
        /// <returns>Lista com as pessoas</returns>
        [HttpGet]
        public List<Pessoa> ObterTodos() => _pessoa.ObterTodos();

        /// <summary>
        /// Método que retorna a pessoa pelo Id
        /// </summary>
        /// <param name="id">Id do registro</param>
        /// <returns>Pessoa</returns>
        [HttpGet("{id}")]
        public Pessoa ObterPorId(int id) => _pessoa.ObterPorId(id);

        /// <summary>
        /// Método que adiciona uma pessoa na tabela
        /// </summary>
        /// <param name="pessoa">Objeto com a pessoa a ser inserida</param>
        /// <returns>True se inseriu com sucesso</returns>
        [HttpPut]
        public bool Adicionar(Pessoa pessoa) => _pessoa.Adicionar(pessoa);

        /// <summary>
        /// Método que atualiza um registro
        /// </summary>
        /// <param name="pessoa">Objeto que substituirá</param>
        /// <returns>True se atualizou com sucesso</returns>
        [HttpPatch]
        public bool Atualizar(Pessoa pessoa) => _pessoa.Atualizar(pessoa);

        /// <summary>
        /// Método que deleta um registro
        /// </summary>
        /// <param name="id">Id do registro a ser deletado</param>
        /// <returns>True se deletou</returns>
        [HttpDelete("{id}")]
        public bool Deletar(int id) => _pessoa.Deletar(id);
    }
}
