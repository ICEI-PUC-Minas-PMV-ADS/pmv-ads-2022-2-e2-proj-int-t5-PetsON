namespace Domain.Interfaces
{
    public interface IServiceCRUD<TEntidade>
        where TEntidade: class
    {
        IEnumerable<TEntidade> Listagem();
        int Cadastrar(TEntidade entidade);
        TEntidade CarregarRegistro(int id);
        void Excluir(int id);
    }
}
