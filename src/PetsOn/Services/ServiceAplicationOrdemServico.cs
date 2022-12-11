using Domain.Interfaces;
using Domain.Service;
using PetsOn.Domain.Entities;
using PetsOn.Helpers;
using PetsOn.Models;
using PetsOn.Services.Interfaces;
using System.Web.Mvc;

namespace PetsOn.Services
{
    public class ServiceAplicationOrdemServico : IServiceAplicationOrdemServico
    {
        protected IHttpContextAccessor HttpContextAcessor;
        public readonly IServiceOrdemServico ServiceOrdemServico;

        public ServiceAplicationOrdemServico(
            IServiceOrdemServico serviceOrdemServico,
            IHttpContextAccessor httpContext)
        {
            ServiceOrdemServico = serviceOrdemServico;
            HttpContextAcessor = httpContext;
        }

        public void Cadastrar(OrdemServicoViewModel ordemServico)
        {
            OrdemServico item = new()
            {
                Id = ordemServico.Codigo_OrdemServico,
                Data = (DateTime)ordemServico.Data,
                Data_Realizacao = (DateTime)ordemServico.Data_Realizacao,
                Data_Agendamento = (DateTime)ordemServico.Data_Agendamento,
                Observacao = ordemServico.Observacao,
                Id_Cliente = (int)ordemServico.Codigo_Cliente,
                Id_Animal = (int)ordemServico.Codigo_Animal,
                Id_Petshop = (int)ordemServico.Codigo_Petshop

            };

            ServiceOrdemServico.Cadastrar(item);

        }
        public OrdemServicoViewModel CarregarRegistro(int codigoOrdemServico)
        {
            var registro = ServiceOrdemServico.CarregarRegistro(codigoOrdemServico);

            OrdemServicoViewModel servico = new OrdemServicoViewModel()
            {
                Codigo_OrdemServico = registro.Id,
                Data = registro.Data,
                Data_Realizacao = registro.Data_Realizacao,
                Data_Agendamento = registro.Data_Agendamento,
                Observacao = registro.Observacao,
                Codigo_Cliente = registro.Id_Cliente,
                Codigo_Animal = registro.Id_Animal,
                Codigo_Petshop = registro.Id_Petshop

            };

            return servico;
        }

        public IEnumerable<SelectListItem> ListaOrdemServicoDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();
            var lista = ServiceOrdemServico.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP));

            foreach (var item in lista)
            {
                SelectListItem servico = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Observacao
                };
                retorno.Add(servico);
            }
            return retorno;

            throw new NotImplementedException();
        }

        public IEnumerable<OrdemServicoViewModel> Listagem(int? IdPetShop)
        {
            var lista = ServiceOrdemServico.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP));
            List<OrdemServicoViewModel> listaOrdensServicos = new List<OrdemServicoViewModel>();

            foreach (var item in lista)
            {
                OrdemServicoViewModel ordensServicos = new OrdemServicoViewModel() // REFATORAR DEPOIS REPETIÇÕES...
                {
                    Codigo_OrdemServico = item.Id,
                    Data = item.Data,
                    Data_Realizacao = item.Data_Realizacao,
                    Data_Agendamento = item.Data_Agendamento,
                    Observacao = item.Observacao,
                    Codigo_Cliente = item.Id_Cliente,
                    Codigo_Animal = item.Id_Animal,
                    Codigo_Petshop = item.Id_Petshop

                };
                listaOrdensServicos.Add(ordensServicos);
            }

            return listaOrdensServicos;
        }


        public IEnumerable<OrdemServicoViewModel> ListagemEdicao(int CodigoOrdemServico)
        {
            throw new NotImplementedException();
        }
        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}
