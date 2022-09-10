# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidadas com a participação dos **usuários** em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de ***personas e histórias de usuários***.

## Personas

As ***personas*** levantadas durante o processo de entendimento do problema são apresentadas na tabelas que seguem:

| `USUÁRIO` |`MOTIVAÇÕES`| `FRUSTRAÇÕES` | `HOBBIES / HISTÓRIA` |
|----------------------|--------------------|--------------------|------------------------|
| <Img src="https://user-images.githubusercontent.com/86859418/188523233-399be60d-ff74-4add-a147-0b14db9eb48c.jpeg">  **Eliana Sanches** ***(Padrinho ou Voluntário)***, **31** anos,  Assistente Social e formada em pedagogia | Vivenciar experiências em ***serviços sociais***, ser empática é sua maior qualidade. | Querer ***ajudar*** e descobrir que as pessoas não quererem ajuda.  |Gosta de ***atividades interativas*** que sejam ao ar livre, ela vem de família simples, mas como foi bem instruída buscou se graduar em pedagogia.
| <Img src="https://user-images.githubusercontent.com/86859418/188523328-57766bc3-08fa-49a7-83bb-161137f32401.jpeg">   **João da Silva** ***(Padrinho ou Voluntário)***, **45** anos, Empresário do ramo imobiliário | Ser criativo, buscar crescimento pessoal, ***ser um líder*** e sempre com vontade de superar metas e continuar ***lutar contra a possibilidade de recaída as drogas***.  | Ter perdido cinco anos de sua vida com o ***uso de drogas*** e não ter sido capaz de se lembrar dos detalhes. | Gosta de construir móveis artesanais de madeira, viajar ao interior e curtir atividades em meio a natureza. Vem de família tradicional sendo criado pelos pais no interior de São Paulo aos 16 anos se envolveu com o mundo das drogas, ***se recuperou*** aos 22 anos, com isso conseguiu trabalhar e se formar aos 32 anos, buscou investir no ramo imobiliário onde obteve sucesso. |
| <Img src="https://user-images.githubusercontent.com/86859418/188523365-01f0e9f7-3c7e-48f6-9b65-a04099235bd0.jpeg">  **Carlos Gomes** ***(Dependente Químico)***, **35** anos, Técnico em Eletrônica | Viver em família, frequentar a igreja, ***aprender mais*** sobre eletrônica e tecnologia.  | ***Ter usado drogas pela primeira vez*** o que acarretou ao seu vício.|Tem seu trabalho como Hobbie, mas gosta também de fazer trilha e andar de moto. ***Criado apenas pela mãe teve um pai ausente***, onde teve de começar a trabalhar cedo, logo após uns anos se casou e teve seu segundo filho, certo tempo após teve seu primeiro contato com as drogas. |


## Histórias de Usuários
 
A partir da compreensão do dia a dia das **personas** identificadas para o projeto, foram registradas as seguintes ***histórias de usuários***. 

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|**Eduardo Martins** ***(Gestor)***|Relatório de fluxo de caixas e estoques, ver o controle dos clientes|Para ter controle do que precisa e do que utiliza dentro do pet shop|
|**Gabriela França** ***(Recepcionista)***|Fácil agendamento de horários, fácil acesso para os clientes, um controle de alteração de agendas que possa excluir ou alterar pessoas||Para ter controle de horários|
|**Katryn Ribeiro** ***(Tosadora)***|Fluxo de estoque e visualização da agenda||Dar baixa no sistema quando utilizar algum produto e saber o horário dos atendimentos|

## Requisitos

As tabelas que se seguem apresentam os ***requisitos funcionais*** e ***não funcionais*** que detalham o escopo do projeto.

### Requisitos Funcionais

|**ID**     | **Descrição do Requisito**  | **Prioridade** |
|-------|-----------------------------------------|----|
|**RF-01**|O sistema Pet'sOn deve permitir o cadastro de Pet's Shop's, recolhendo os dados do administrador e da empresa, desse modo o gestor possuirá um login e senha para acessar ao sistema.|**ALTA**| 
|**RF-02**|O sistema deve permitir o login da Pet Shop cadastrada no sistema, com funcionalidade esqueci minha senha. |**ALTA**| 
|**RF-03**|A Pet shop cadastrada no sistema, poderá cadastrar seus clientes e seus Pet's. |**ALTA**| 
|**RF-04**|A Pet shop cadastrada no sistema, poderá agendar ou dar entrada ao atendimento do cliente aos seu Pet's, enviando e-mail como comprovante do agendamento ou atendimento.|**ALTA**| 
|**RF-05**|A Pet shop cadastrada no sistema, poderá visualizar o histórico de atendimentos feitos aos clientes. |**MÉDIA**|
|**RF-06**|A Pet shop cadastrada no sistema, poderá consultar na agenda as datas e horários disponíveis, para agendar ou efetuar o registro de um atendimento.|**ALTA**|
|**RF-07**|A Pet shop cadastrada no sistema, poderá aplicar descontos aos clientes, baseados em quantidades de atendimentos ou valor gasto no período de 1 mês.|**MÉDIA**|
|**RF-08**|O site deve permitir que o usuário mude para modo dark (escuro);|**BAIXA**|


### Requisitos não Funcionais

|**ID**     | **Descrição do Requisito**  |**Prioridade** |
|-------|-------------------------|----|
|**RNF-01**|O site deve ser publicado em um ambiente acessível **publicamente na Internet** ***(GitHub Pages)***.|**ALTA**| 
|**RNF-02**|O site deverá ser responsivo permitindo a ***visualização em um celular de forma adequada***.|**ALTA**| 
|**RNF-03**|O site deve ter bom nível de contraste entre os ***elementos da tela em conformidade***.|**MÉDIA**| 
|**RNF-04**|O site deve ser compatível com os principais **navegadores do mercado** ***(Google Chrome, Firefox, Microsoft Edge)***.|**ALTA**
|**RNF-05**|O site não apresentará aos usuários quaisquer dados de cunho privativo. |**MÉDIA**|
|**RNF-06**|O site deve usar.... |**MÉDIA**|
 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como 
obrigações claras para o ***desenvolvimento do projeto*** em questão são apresentadas 
na tabela a seguir.


|**ID**|                                           **Restrição**                                                   |
|--|-------------------------------------------------------------------------------------------------------|
|**01**| O projeto deverá ser entregue no final do semestre letivo,  não podendo extrapolar a data de: ***26/06/22***.  |
|**02**| O aplicativo deve se restringir às ***tecnologias básicas da web no frontend***.                          |
|**03**| A equipe não pode subcontratar o desenvolvimento do projeto.                                         |
