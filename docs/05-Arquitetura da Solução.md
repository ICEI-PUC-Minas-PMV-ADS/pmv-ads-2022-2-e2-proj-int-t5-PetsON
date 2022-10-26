# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

<img src="https://user-images.githubusercontent.com/103230282/198024557-386e42c3-668f-4a27-9a7c-b0a1ba2dc21a.png">


## Modelo ER (Projeto Conceitual)
O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

<img src="https://user-images.githubusercontent.com/54327906/193430249-db5e3348-9ae6-46d4-97d3-edbb060516f9.jpeg">

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade, o diagrama a seguir pode ser gerado no próprio SQL Server após o projeto da base de dados já criada.
 
<img src="https://user-images.githubusercontent.com/86859418/197303649-1c005879-89ef-4acb-a6e7-30025d0f322a.jpg">

## Tecnologias Utilizadas

Linguagens de progamação utilizadas:

C#: Linguagem de progamação utilizada para desenvolvimento do backend da solução.
Javascript: Linguagem de programação utilizada no frontend para a implementação de certas funcionalidades.
Frameworks utilizados:

ASP.NET Core MVC: Framework implementando o padrão Model-View-Controller, será utilizado como base para desenvolvimento da solução.
Entity Framework Core: Framework de mapeamento objeto-relacional (técnica utilizada para resolver o problema da impedância entre o modelo orientado a objetos e o modelo relacional) para a plataforma .NET, será utilizado para facilitar a manipulação e consulta do banco de dados relacional utilizado aplicação.
Bibliotecas utilizadas:

bcrypt.net-next: Biblioteca que permite criptografar senhas utilizando o método "bcrypt". Será utilizada para criptografar as senhas de usuário do sistema.
X.PagedList: Biblioteca que adiciona suporte a paginação. Permite converter IQueryables/IEnumerables para "PagedLists" nos controllers, que podem ser passadas para as views de forma a mostrar apenas o conteúdo presente na página atualmente selecionada;
jquery-ajax-unobtrusive: Biblioteca que permite adicionar atributos "data-" customizados ao HTML que permitem adicionar funções AJAX do JQuery a eles. É utilizada neste projeto para a realização de updates parciais nas páginas, sem necessitar recarregar a página inteira para alterar um único elemento (por exemplo, para atualizar o número presente no contador de novas mensagens sem precisar recarregar a página inteira).
APIs utilizadas:

ASP.NET Core Identity: API que dá suporte a funcionalidade de login da interface do usuário. Será utilizado para implementar a função de login e autenticação do usuário, além da separação das contas por tipos de usuários.
FluentEmail: API do .NET Core que permite o envio de emails dentro da aplicação;
IDE utilizada: Visual Studio Community 2022, escolhido pela integração com o Framework ASP.NET e outras ferramentas utilizadas no projeto como o SQL Server.

Sistema gerenciador de banco de dados: SQL Server, escolhido por sua boa integração com o editor de código e para facilitar a migração do banco de dados para o serviço de hospedagem nas fases mais avançadas do projeto.

Outras tecnologias:

HTML: Linguagem de marcação utilizada para a construção das páginas web.
CSS: Linguagem de folhas de estilos utilizada para aplicar estilos nos elementos HTML.
Razor: Sintaxe de marcação que permite inserir código baseado em .NET em páginas web junto ao HTML.
A figura abaixo demonstra como as tecnologias empregadas se relacionam dentro do sistema e como ocorre a interação do usuário com o sistema até que ele retorne uma resposta ao usuário.

<img src="https://user-images.githubusercontent.com/86859418/193428792-5496b90b-37b4-49c0-9c5f-47b071ac489d.png">

## Hospedagem
A hospedagem da solução foi realizada no serviço de hospedagem da SmarterASP.NET. Após o desenvolvimento local da aplicação, o projeto foi conectado a uma base de dados MSSQL remota criada no próprio SmarterASP.NET, onde as tabelas do projeto foram criadas utilizando-se o comando update-database do Entity Framework Core (utilizando o AppllicationDbContext.cs e as migrations desenvolvidas na criação do projeto). Após a migração da base de dados, o projeto foi publicado através da função Publish do Visual Studio Community 2022 utilizando as configurações do arquivo .XML fornecido pela própria SmarterASP.net para a página da aplicação.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
