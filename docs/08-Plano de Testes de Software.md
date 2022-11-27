# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| # **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/Usuario/Cadastro <br> - Clicar em "Cadastra-se" <br> - Preencher os campos obrigatórios (nome, sobrenome, e-mail, senha, nome da empresa, Cnpj, Web site, desccrição da empresa) <br> - Aceitar os termos de uso <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-002	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/Login/Login<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
| Caso de Teste 	| CT-03 – Cadastrar, visualizar seus clientes e pets 	|
|Requisito Associado | RF-003	- A aplicação deve possuir opção de cadastros para clientes, pets e serviços e visualizar as listas com os dados cadastrados|
| Objetivo do Teste 	| Verificar se o usuário consegue realizar as operações de cadastro e visulização dos dados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/Menu/Menu<br> - No menu lateral para cadastrar temos dois botões "Cliente e Pets" ao selecionar uma das opções o sistema redirecionará para as listas, tendo opção de cadastrar ou editar os dados.|
|Critério de Êxito | - Cadastro realizado com sucesso. |
| Caso de Teste 	| CT-04 – Agendar, realizar atendimento e envio de comprovante para o cliente selecionado  |
|Requisito Associado | RF-004	- A aplicação deve possuir opção de agendar ou dar entrada ao atendimento do cliente aos seu pets, enviando e-mail como comprovante do agendamento ou atendimento.|
| Objetivo do Teste 	| Verificar se o usuário consegue realizar as operações de agendamento ou realizar atendimento e o envio do comprovante |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/x/x<br> - No menu lateral para Agendar ou realizar atendimento temos o botão "Agenda" ao selecionar uma das opções o sistema redirecionará para a agenda, tendo opção de Agendar e dar entrada em um atendimento enviando o comprovante após a efetivação.|
|Critério de Êxito | - Comprovante enviado para o cliente. |
| Caso de Teste 	| CT-05 – Visualizar o histórico de atendimentos feitos aos clientes.  |
|Requisito Associado | RF-005	- A aplicação deve possuir tela com a lista de atendimentos realizados |
| Objetivo do Teste 	| Verificar se o usuário consegue ver todos os atendimentos realizados e agendados |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/x/x<br> - No menu lateral para visualizar o relatório de atendimentos e agendamentos, no menu lateral procure o botão "ordem de serviço"|
|Critério de Êxito | - Visualização do relatório de forma organizada referente aos atendimentos agendados e realizados. |
| Caso de Teste 	| CT-06 – consultar na agenda as datas e horários disponíveis, para agendar ou efetuar o registro de um atendimento.  |
|Requisito Associado | RF-006	- A aplicação deve possibilitar na visão da agenda as datas disponivéis |
| Objetivo do Teste 	| Verificar se o usuário consegue ver as datas disponíveis diferenciando dos atendimentos realizados e agendados |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/x/x<br> - No menu lateral para visualizar datas disponíveis, Agendar ou realizar atendimento temos o botão "Agenda" ao selecionar uma das opções o sistema redirecionará para a agenda. |
|Critério de Êxito | - Visualização das datas disponíveis diferenciando dos atendimentos agendados e realizados. |
| Caso de Teste 	| CT-07 – Editar o registro dos clientes e pets  |
|Requisito Associado | RF-007	- A aplicação deve possibilitar a edição dos registros de clientes, animais e serviços |
| Objetivo do Teste 	| Verificar se o usuário consegue editar os registros |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/x/x<br> - No menu lateral para realizar a edição de algum registro navegue selecionando, CLiente, pets ou serviços nas listas temos a opção de editar o registro. |
|Critério de Êxito | - Verificar se a edição foi realizada com sucesso, ao submeter a edição a lista irá atualizar com o dados ajustado. |
| Caso de Teste 	| CT-08 – O site deve permitir que o usuário mude para modo dark (escuro);  |
|Requisito Associado | RF-008	- A aplicação deve possibilitar um interruptor no menu lateral para aplicar o modo dark (escuro) |
| Objetivo do Teste 	| Verificar se o usuário consegue mudar o tema no sistema |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://localhost:7240/x/x<br> - No menu lateral para realizar a mudança de tema vá próximo ao rodapé temos um interruptor que ao clicar muda o tema do sistema. |
|Critério de Êxito | - Verificar ocorre a mudança de tema. |






