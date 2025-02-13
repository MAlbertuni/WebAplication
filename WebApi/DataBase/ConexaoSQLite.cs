namespace WebApi.DataBase
{
    public class ConexaoSQLite : DbContext
    {
        /// <summary>
        /// Tabela Pessoa
        /// </summary>
        public DbSet<Pessoa> Pessoa { get; set; }

        /// <summary>
        /// Método de configuração
        /// </summary>
        /// <param name="pOptions">Opções</param>
        protected override void OnConfiguring(DbContextOptionsBuilder pOptions)
        {
            pOptions.UseSqlite(@"Data Source=Chinook.db");
        }
    }
}
