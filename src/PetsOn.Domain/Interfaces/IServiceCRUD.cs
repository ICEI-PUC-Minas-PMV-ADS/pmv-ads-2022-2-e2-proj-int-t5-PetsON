namespace Domain.Interfaces
{
    public interface IServiceCRUD<TEntidade>
        where TEntidade: class
    {
        IEnumerable<TEntidade> Listagem();
        void Cadastrar(TEntidade categoria);
        TEntidade CarregarRegistro(int id);
        void Excluir(int id);
    }
}
