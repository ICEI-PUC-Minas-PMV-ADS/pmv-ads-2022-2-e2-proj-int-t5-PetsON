# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidadas com a participação dos **usuários** em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de ***personas e histórias de usuários***.

## Personas

As ***personas*** levantadas durante o processo de entendimento do problema são apresentadas na tabelas que seguem:

| `USUÁRIO` |`MOTIVAÇÃO`| `ATIVIDADES/COMPORTAMENTOS` | ` NECESSIDADES ` |`FRUSTRAÇÕES`|
|----------------------|--------------------|--------------------|------------------------|------------------------|
| <Img src="https://user-images.githubusercontent.com/86859418/188523233-399be60d-ff74-4add-a147-0b14db9eb48c.jpeg">  **Eduardo Martins** ***(Gerente de Pet Shop)***, **38** anos,  Ensino Superior em **Administração** | “Semanalmente, tenho que entregar um relatório para o dono, mas o software não ajuda, perco horas e horas cadastrando e revisando” | - Analisar indicadores do software semanalmente<br/><br/>- Responsável pela equipe do pet shop<br/><br/>- Auxiliar o setor financeiro<br/><br/>- Gerenciar o estoque<br/><br/>- Acompanhar diariamente o funcionamento do pet shop|- Ações diárias sendo mostradas<br/><br/>-  Input de informação facilitado<br/><br/>- Dashboard claro e intuitivo<br/><br/>- Uma ferramenta de fácil utilização|- Tem problema para interpretar os dados<br/><br/>- Ainda utiliza planilhas para complementar<br/><br/>- Perder muito tempo com software<br/><br/>- Não sabe como engajar a equipe no software
| <Img src="https://user-images.githubusercontent.com/86859418/188523365-01f0e9f7-3c7e-48f6-9b65-a04099235bd0.jpeg">   **Katryn Ribeiro** ***(Recepcionista de Pet Shop)***, **33** anos, Ensino Médio Completo | “É verdade... meu dia é muito cheio, mas eu consigo dar conta de tudo. Já estou acostumada” |- Muitas coisas ao mesmo tempo e consegue dar conta de tudo<br/><br/>- Ela já sabe como as coisas funcionam, a rotina do Pet Shop e o perfil dos pacientes<br/><br/>- Mesmo estando muito atarefada, se interessa em ajudar as pessoas e nunca falta com educação.|- Executar suas tarefas de maneira mais eficiente possível<br/><br/>- Gerenciar uma grande quantidade de informações que recebe sem esquecer nada|- Executar manualmente muitas tarefas simples que poderiam ser automatizadas no software<br/><br/>- Enfrentar a resistência dos superiores para tornar digital alguns processos do Pet Shop<br/><br/>- Perder muito tempo com software
| <Img src="https://user-images.githubusercontent.com/86859418/188523328-57766bc3-08fa-49a7-83bb-161137f32401.jpeg">  **Gabriela França** ***(Proprietária de Pet Shop)***, **39** anos, Ensino Superior em **Marketing** | “Meu objetivo é abrir uma nova filial em outro bairro da cidade” |- Responsável pelo setor de contabilidade<br/><br/>- À frente das redes sociais e publicidade<br/><br/>- Tenta equilibrar melhor a vida pessoal e profissional |- Busca soluções que facilitem seu dia a dia como microempresária<br/><br/>- Possibilidade de enviar notificações para atuais clientes e divulgar promoções |- Aumento no número de clientes impactou em demora para retornar no WhatsApp e marcação de horários<br/><br/>- Dificuldade em fidelizar e atrair clientes 

## Histórias de Usuários
 
A partir da compreensão do dia a dia das **personas** identificadas para o projeto, foram registradas as seguintes ***histórias de usuários***. 

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|**Eduardo Martins** ***(Gestor)***|Relatório de fluxo de caixas e estoques, ver o controle dos clientes|Para ter controle do que precisa e do que utiliza dentro do pet shop|
|**Gabriela França** ***(Recepcionista)***|Fácil agendamento de horários, fácil acesso para os clientes, um controle de alteração de agendas que possa excluir ou alterar pessoas|Para ter controle de horários|
|**Katryn Ribeiro** ***(Tosadora)***|Fluxo de estoque e visualização da agenda|Dar baixa no sistema quando utilizar algum produto e saber o horário dos atendimentos|

## Requisitos

As tabelas que se seguem apresentam os ***requisitos funcionais*** e ***não funcionais*** que detalham o escopo do projeto.

### Requisitos Funcionais

|**ID**     | **Descrição do Requisito**  | **Prioridade** |
|-------|-----------------------------------------|----|
|**RF-01**|O sistema Pet'sOn deve permitir o cadastro de Pet's Shop's, recolhendo os dados do administrador e da empresa, desse modo o gestor possuirá um login e senha para acessar ao sistema.|**ALTA**| 
|**RF-02**|O sistema deve permitir o login da Pet Shop cadastrada no sistema, com funcionalidade esqueci minha senha. |**ALTA**| 
|**RF-03**|A Pet shop cadastrada no sistema poderá cadastrar seus clientes e seus Pet's. |**ALTA**| 
|**RF-04**|A Pet shop cadastrada no sistema poderá agendar ou dar entrada ao atendimento do cliente aos seu Pet's, enviando e-mail como comprovante do agendamento ou atendimento.|**ALTA**| 
|**RF-05**|A Pet shop cadastrada no sistema poderá visualizar o histórico de atendimentos feitos aos clientes. |**MÉDIA**|
|**RF-06**|A Pet shop cadastrada no sistema poderá consultar na agenda as datas e horários disponíveis, para agendar ou efetuar o registro de um atendimento.|**ALTA**|
|**RF-07**|A Pet shop cadastrada no sistema poderá aplicar descontos aos clientes, baseados em quantidades de atendimentos ou valor gasto no período de 1 mês.|**MÉDIA**|
|**RF-08**|O site deve permitir que o usuário mude para modo dark (escuro);|**BAIXA**|


### Requisitos não Funcionais

|**ID**     | **Descrição do Requisito**  |**Prioridade** |
|-------|-------------------------|----|
|**RNF-01**|O site deve ser publicado em um ambiente acessível **publicamente na Internet** ***(GitHub Pages)***.|**ALTA**| 
|**RNF-02**|O site deverá ser responsivo permitindo a ***visualização em um celular de forma adequada***.|**ALTA**| 
|**RNF-03**|O site deve ter bom nível de contraste entre os ***elementos da tela em conformidade***.|**MÉDIA**| 
|**RNF-04**|O site deve ser compatível com os principais **navegadores do mercado** ***(Google Chrome, Firefox, Microsoft Edge)***.|**ALTA**|
|**RNF-05**|O sistema deverá se comunicar com o banco SQL server |**ALTA**|
|**RNF-06**|O sistema deverá ser implementado na linguagem C#, linguagem HTML, CSS e JavaScript |**ALTA**|
|**RNF-07**|O site do sistema deve apresentar na página principal o login para acesso das empresas cadastradas | **ALTA** |
 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.
 
|**ID**|                                           **Restrição**                                                   |
|--|-------------------------------------------------------------------------------------------------------|
|**01**| O projeto deverá ser conduzido com os direcionamentos do professor orientador  |
|**02**| A equipe terá reuniões com o professor orientador às segundas-feiras às 20:30 horas |
|**03**| A equipe não pode subcontratar o desenvolvimento do projeto |
|**04**| O projeto deverá estar em conformidade com o escopo disponibilizado pela PUC Minas |
|**05**| O prazo para entrega final do projeto é 11/12/2022 |

 ## Diagrama de Casos de Uso
 
O diagrama de Casos de Uso auxilia no levantamento dos requisitos funcionais do sistema, descrevendo um conjunto de funcionalidades do sistema e suas interações com elementos externos e entre si.

Cenários: quando falamos de casos de uso, temos que ter em mente o conceito de cenários, que seriam instâncias de casos de uso.
Um cenário pode ser compreendido como uma sequência de passos que descreve uma interação entre um usuário e o sistema.
 
Os diagramas de caso de uso mostram o comportamento esperado do sistema. Eles não mostram a ordem na qual as etapas são executadas. 
 
 <img src="https://user-images.githubusercontent.com/86859418/193376457-15b42ba8-d1be-4abc-a8dc-1ac89090f4ff.jpg">
