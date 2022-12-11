using PetsOn.Domain.Entities;
using PetsOn.Models;
using System.Web.Mvc;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationOrdemServico
    {
        void Cadastrar(OrdemServicoViewModel servico);
        IEnumerable<SelectListItem> ListaOrdemServicoDropDownList();
        IEnumerable<OrdemServicoViewModel> Listagem(int? IdPetShop);
        IEnumerable<OrdemServicoViewModel> ListagemEdicao(int codigoOrdemServico);
        OrdemServicoViewModel CarregarRegistro(int codigoOrdemServico);
        void Excluir(int id);

    }
}
