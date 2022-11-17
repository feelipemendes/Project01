namespace Projeto01.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction(); 

        #region Repositorios

        public IContatoRepository ContatoRepository { get; }

        #endregion
    }
}
