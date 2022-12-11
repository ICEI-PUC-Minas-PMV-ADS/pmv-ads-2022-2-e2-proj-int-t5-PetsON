using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Helpers;
using PetsOn.Models;
using PetsOn.Services.Interfaces;
using System.Web.Mvc;

namespace PetsOn.Services
{
    public class ServiceAplicationServico : IServiceAplicationServico
    {
        protected IHttpContextAccessor HttpContextAcessor;
        public readonly IServiceServico ServiceServico;

        public ServiceAplicationServico(
            IServiceServico serviceServico,
            IHttpContextAccessor httpContext)
        {
            ServiceServico = serviceServico;
            HttpContextAcessor = httpContext;
        }
        public void Cadastrar(ServicoViewModel servico)
        {
            Servico item = new()
            {
                Id = servico.Codigo_Servico,
                Tipo_Servico = servico.Tipo_Servico,
                Descricao = servico.Descricao,
                Preco = servico.Preco,
                Id_Petshop = (int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP)
            };

            ServiceServico.Cadastrar(item);

        }

        public ServicoViewModel CarregarRegistro(int codigoServico)
        {
            var registro = ServiceServico.CarregarRegistro(codigoServico);

            ServicoViewModel servico = new ServicoViewModel()
            {
                Codigo_Servico = registro.Id,
                Tipo_Servico = registro.Tipo_Servico,
                Descricao = registro.Descricao,
                Preco = registro.Preco

            };

            return servico;
        }
        public void Excluir(int id)
        {
            ServiceServico.Excluir(id);
        }
        public IEnumerable<SelectListItem> ListaServicoDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();
            var lista = ServiceServico.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_SERVICO));

            foreach (var item in lista)
            {
                SelectListItem servico = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Tipo_Servico
                };
                retorno.Add(servico);
            }
            return retorno;
        }

        public IEnumerable<ServicoViewModel> Listagem()
        {
            var lista = ServiceServico.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP));
            List<ServicoViewModel> listaServico = new List<ServicoViewModel>();

            foreach (var item in lista)
            {
                ServicoViewModel servico = new ServicoViewModel() // REFATORAR DEPOIS REPETIÇÕES...
                {
                    Codigo_Servico = item.Id,
                    Tipo_Servico = item.Tipo_Servico,
                    Descricao = item.Descricao,
                    Preco = item.Preco
                };
                listaServico.Add(servico);
            }

            return listaServico;
        }

        public IEnumerable<ServicoViewModel> ListagemEdicao(int codigoServico)
        {
            var lista = ServiceServico.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_SERVICO));
            List<ServicoViewModel> listaServico = new List<ServicoViewModel>();

            foreach (var item in lista)
            {
                ServicoViewModel servico = new ServicoViewModel() // REFATORAR DEPOIS REPETIÇÕES...
                {
                    Codigo_Servico = item.Id,
                    Tipo_Servico = item.Tipo_Servico,
                    Descricao = item.Descricao,
                    Preco = item.Preco
                };
                listaServico.Add(servico);
            }

            return listaServico;
        }
    }
}
