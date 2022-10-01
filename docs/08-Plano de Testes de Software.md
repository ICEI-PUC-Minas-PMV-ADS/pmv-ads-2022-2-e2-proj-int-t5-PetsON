# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O sistema Pet'sOn deve permitir o cadastro de Pet's Shop's, recolhendo os dados do administrador e da empresa, desse modo o gestor possuirá um login e senha para acessar ao sistema.   |
| Objetivo do Teste 	| A Pet shop cadastrada no sistema, poderá agendar ou dar entrada ao atendimento do cliente aos seu Pet's, enviando e-mail como comprovante do agendamento ou atendimento.  |
| Passos 	| <li>A Pet shop cadastrada no sistema, poderá visualizar o histórico de atendimentos feitos aos clientes.</li>  <li>A Pet shop cadastrada no sistema, poderá consultar na agenda as datas e horários disponíveis, para agendar ou efetuar o registro de um atendimento.</li> |
|Critério de Êxito | - A Pet shop cadastrada no sistema, poderá aplicar descontos aos clientes, baseados em quantidades de atendimentos ou valor gasto no período de 1 mês. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-0	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail, senha e opção esqueci minha senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| <li>Acessar o navegador</li>  <li>Clicar no botão "Entrar"</li> <li>Preencher o campo de e-mail e senha</li> <li>Clicar em "Login"</li> |
|Critério de Êxito | - O login foi realizado com sucesso. |
