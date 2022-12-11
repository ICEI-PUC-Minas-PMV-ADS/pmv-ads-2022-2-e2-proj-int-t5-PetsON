using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Helpers;
using PetsOn.Models;
using PetsOn.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetsOn.Services
{
    public class ServiceAplicationAnimal : IServiceAplicationAnimal
    {
        protected IHttpContextAccessor HttpContextAcessor;
        public readonly IServiceAnimal ServiceAnimal;

        public ServiceAplicationAnimal(
            IServiceAnimal serviceAnimal,
            IHttpContextAccessor httpContextAcessor)
        {
            ServiceAnimal = serviceAnimal;
            HttpContextAcessor = httpContextAcessor;
        }

        public void Cadastrar(AnimalViewModel animal)
        {
            Animal item = new()
            {
                Id = animal.Codigo_Animal,
                Id_Cliente = animal.Codigo_Cliente,
                Nome_Animal = animal.Nome_Animal,
                Idade = animal.Idade,
                Raca = animal.Raca,
                Observacao = animal.Observacao
            };

            ServiceAnimal.Cadastrar(item);
            //animal.id = RetornarClienteId(int id);
            //ServiceAplicationUsuario.Cadastrar(animal);
        }

        public AnimalViewModel CarregarRegistro(int codigoAnimal)
        {
            var registro = ServiceAnimal.CarregarRegistro(codigoAnimal);

            AnimalViewModel animal = new AnimalViewModel()
            {
                Codigo_Animal = registro.Id,
                Codigo_Cliente = registro.Id_Cliente,
                Nome_Animal = registro.Nome_Animal,
                Idade = registro.Idade,
                Raca = registro.Raca,
                Observacao = registro.Observacao,
            };

            return animal;
        }

        public void Excluir(int id)
        {
            ServiceAnimal.Excluir(id);
        }

        public IEnumerable<SelectListItem> ListaAnimaisDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();
            var lista = ServiceAnimal.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_CLIENTE));

            foreach (var item in lista)
            {
                SelectListItem animal = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Nome_Animal
                };
                retorno.Add(animal);
            }
            return retorno;
        }

        public IEnumerable<AnimalViewModel> Listagem(int? IdPetShop)
        {
            //var lista = ServiceAnimal.Listagem(null).OrderBy(x=>x.Id_Cliente);
            var lista = ServiceAnimal.Listagem(IdPetShop);
            List<AnimalViewModel> listaAnimal = new List<AnimalViewModel>();

            foreach (var item in lista)
            {
                AnimalViewModel animal = new AnimalViewModel() // REFATORAR DEPOIS REPETIÇÕES...
                {
                    Codigo_Animal = item.Id,
                    Nome_Animal = item.Nome_Animal,
                    Nome_Cliente = item.Cliente.Nome,
                    Idade = item.Idade,
                    Raca = item.Raca,
                    Observacao = item.Observacao
                };
                listaAnimal.Add(animal);
            }

            return listaAnimal;
        }

        public IEnumerable<AnimalViewModel> ListagemPetsCliente(int CodigoCliente)
        {
            var lista = ServiceAnimal.ListagemPetsCliente(CodigoCliente);
            List<AnimalViewModel> listaAnimal = new List<AnimalViewModel>();

            foreach (var item in lista)
            {
                AnimalViewModel animal = new AnimalViewModel() // REFATORAR DEPOIS REPETIÇÕES...
                {
                    Codigo_Animal = item.Id,
                    Nome_Animal = item.Nome_Animal,
                    Idade = item.Idade,
                    Raca = item.Raca,
                    Observacao = item.Observacao
                };
                listaAnimal.Add(animal);
            }

            return listaAnimal;
        }
    }
}