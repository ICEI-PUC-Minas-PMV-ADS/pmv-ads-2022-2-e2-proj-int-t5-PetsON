using PetsOn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationCliente
    {
        void Cadastrar(ClienteViewModel cliente);
        int RetornarClienteId(string CPF);
        IEnumerable<SelectListItem> ListaClientesDropDownList();
        IEnumerable<ClienteViewModel> Listagem();
        IEnumerable<ClienteViewModel> ListagemEdicao(int CodigoCliente);
        ClienteViewModel CarregarRegistro(int codigoCliente);
        void Excluir(int id);

    }
}
