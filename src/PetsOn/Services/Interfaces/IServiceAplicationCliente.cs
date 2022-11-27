using PetsOn.Domain.Entities;
using PetsOn.Models;
using System.Web.Mvc;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationCliente
    {
        void Cadastrar(ClienteViewModel cliente);
        int RetornarClienteId(string CPF);
        IEnumerable<SelectListItem> ListaClientesDropDownList();
        IEnumerable<ClienteViewModel> Listagem();
        ClienteViewModel CarregarRegistro(int codigoCliente);
        void Excluir(int id);

    }
}
