using Domain.Interfaces;
using Domain.Service;
using PetsOn.Domain.Entities;
using PetsOn.Helpers;
using PetsOn.Models;
using PetsOn.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetsOn.Services
{
    public class ServiceAplicationCliente : IServiceAplicationCliente
    {
        protected IHttpContextAccessor HttpContextAcessor;
        public readonly IServiceCliente ServiceCliente;
        private readonly IServiceAplicationAnimal ServiceAplicationAnimal;

        public ServiceAplicationCliente(
            IServiceCliente serviceCliente,
            IServiceAplicationAnimal serviceAplicationAnimal,
            IHttpContextAccessor httpContext)
        {
            ServiceCliente = serviceCliente;
            ServiceAplicationAnimal = serviceAplicationAnimal;
            HttpContextAcessor = httpContext;
        }
        public void Cadastrar(ClienteViewModel cliente)
        {
            Cliente item = new()
            {
                Id = cliente.Codigo_Cliente,
                Nome = cliente.Nome,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
                Celular = cliente.Celular,
                Endereco = cliente.Endereco,
                Id_Petshop = (int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP)
            };

                ServiceCliente.Cadastrar(item);

            //cliente.Codigo_Cliente = RetornarClienteId(cliente.Cpf);
            //ServiceAplicationAnimal.Cadastrar(cliente);
        }

        public int RetornarClienteId(string CPF)
        {
            throw new NotImplementedException();
            //var Cliente = ServiceCliente.Listagem().Where(x => x.Cpf == CPF).FirstOrDefault();
            //return (int)Cliente.Id;
        }

        public ClienteViewModel CarregarRegistro(int codigoCliente)
        {
            var registro = ServiceCliente.CarregarRegistro(codigoCliente);

            ClienteViewModel cliente = new ClienteViewModel()
            {
                Codigo_Cliente = registro.Id,
                Nome = registro.Nome,
                Cpf = registro.Cpf,
                Celular = registro.Celular,
                Email = registro.Email,
                Endereco = registro.Endereco

            };

            return cliente;
        }
        public void Excluir(int id)
        {
            ServiceCliente.Excluir(id);
        }
        public IEnumerable<SelectListItem> ListaClientesDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();
            var lista = ServiceCliente.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP));

            foreach (var item in lista)
            {
                SelectListItem cliente = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Nome
                };
                retorno.Add(cliente);
            }
            return retorno;
        }

        public IEnumerable<ClienteViewModel> Listagem()
        {
            var lista = ServiceCliente.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP));
            List<ClienteViewModel> listaCliente = new List<ClienteViewModel>();

            foreach (var item in lista)
            {
                ClienteViewModel cliente = new ClienteViewModel() // REFATORAR DEPOIS REPETIÇÕES...
                {
                    Codigo_Cliente = item.Id,
                    Nome = item.Nome,
                    Cpf = item.Cpf,
                    Celular = item.Celular,
                    Email = item.Email,
                    Endereco = item.Endereco
                };
                listaCliente.Add(cliente);
            }

            return listaCliente;
        }

        public IEnumerable<ClienteViewModel> ListagemEdicao(int CodigoCliente)
        {
            var lista = ServiceCliente.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_CLIENTE));
            List<ClienteViewModel> listaCliente = new List<ClienteViewModel>();

            foreach (var item in lista)
            {
                ClienteViewModel cliente = new ClienteViewModel() // REFATORAR DEPOIS REPETIÇÕES...
                {
                    Codigo_Cliente = item.Id,
                    Nome = item.Nome,
                    Cpf = item.Cpf,
                    Celular = item.Celular,
                    Email = item.Email,
                    Endereco = item.Endereco
                };
                listaCliente.Add(cliente);
            }

            return listaCliente;
        }
    }
}
