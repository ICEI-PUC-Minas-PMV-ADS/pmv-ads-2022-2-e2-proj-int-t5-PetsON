using PetsOn.Domain.Entities;
using PetsOn.Models;
using System.Web.Mvc;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationServico
    {
        void Cadastrar(ServicoViewModel servico);
        IEnumerable<SelectListItem> ListaServicoDropDownList();
        IEnumerable<ServicoViewModel> Listagem();
        IEnumerable<ServicoViewModel> ListagemEdicao(int codigoServico);
        ServicoViewModel CarregarRegistro(int codigoServico);
        void Excluir(int id);

    }
}
