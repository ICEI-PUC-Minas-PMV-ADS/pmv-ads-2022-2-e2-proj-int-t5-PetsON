# Registro de Testes de Software

**CT-01 – Cadastrar Usuário e PetShop**

<img src="https://user-images.githubusercontent.com/86859418/204162288-f68ecb1c-8ba5-41c2-9bc7-b3f620c8d777.png">

**O formulário valida os dados com o intuito de evitar inserções fora do padrão.**

<img src="https://user-images.githubusercontent.com/86859418/204163037-4b6be7bb-99e4-4078-a34b-3fa207c7b7a5.png">

**Os dados do usuário e da petshop devem ser preenchidos, para obterem um acesso ao sistema.**

<img src="https://user-images.githubusercontent.com/86859418/204162820-73722040-f41e-4a59-add4-ae5c5341d181.png">

**Resultado CT-01 - Dados enviados ao Data Base.**

<img src="https://user-images.githubusercontent.com/86859418/204163246-de20ad49-ab43-487f-91f7-c8dc7466176e.png">

**CT-02 – Efetuar login**

<img src="https://user-images.githubusercontent.com/86859418/204162487-a18adb08-a4ad-4f34-903f-25b98f2ad89f.png">

**O formulário valida os dados de login e senha se estão corretos, ou campos vazios que é o caso em anexo.**

<img src="https://user-images.githubusercontent.com/86859418/204162561-a7590e2f-95a3-425b-8390-713ea8048396.png">

**O usuário e senha acima também foi cadastrado anteriormente replicando o **caso de teste CT-01** para validar a conformidade dos dados que devem ser mostrados apenas para o usuário da sessão atual.**

**Resultado CT-02 - O login foi realizado com sucesso.**

<img src="https://user-images.githubusercontent.com/86859418/204156615-9ff47c13-a46d-4f05-9d20-797b2e1cd69c.png">

**CT-03 – Cadastrar, visualizar seus clientes e pets**

<img src="https://user-images.githubusercontent.com/86859418/204163419-7a2a41d4-ced3-46d4-98ec-45b216932478.png">

**O usuário ao clicar no botão no menu lateral Cliente, o sistema abrirá a lista de clientes, para visualizar a lista de pets do cliente ou efetuar o cadastro de um novo pet de um cliente na coluna editar temos dois botões (ícones) para editar os dados do cliente e seus pets ou adicionar novos pets.**

<img src="https://user-images.githubusercontent.com/86859418/204163669-fad213b2-4107-405b-9c6c-10af4365ae13.png">

**O formulário valida os dados de cadastro de clientes se estão corretos, ou campos vazios que é o caso do anexo.**

<img src="https://user-images.githubusercontent.com/86859418/204163859-7ddee24e-ea45-4db5-aa4c-beb850f7056e.png">

**Com os dados preenchidos corretamente, inclusive o campo CPF o qual para ele temos uma classe no sistema responsável por validar apenas "CPF's válidos, observe na amba do navegador que geramos um CPF no site (4DEVS), então agora podemos efetuar o cadastro que os dados vão passar nas validações do sistema."**

**Resultado CT-03 - Cadastro realizado com sucesso.**

<img src="https://user-images.githubusercontent.com/86859418/204164052-f61b84fb-5a3d-4162-9f46-306e7a1ded48.png">

**Observe que o último registro incluido já está na lista de clientes, com o cód. 31, para demonstramos com perfeição o teste, iremos cadastrar um pet para este usuário clicando no botão verde com o ícone de um pet na coluna editar, iremos ser redirecionados para a lista de pets do usuário cadastrado.**

<img src="https://user-images.githubusercontent.com/86859418/204164212-f1405057-27db-4c38-a7d0-f8ff73c581c2.png">

**Observe que o novo usuário não possui nenhum pet registrado, na URL podemos ver ao final "path" o código do usuário**

<img src="https://user-images.githubusercontent.com/86859418/204164415-5bf01f83-8b5f-442c-a6b8-5800ba76c339.png">

**O formulário valida os dados de cadastro de pets se estão corretos, ou campos vazios que é o caso do anexo.**

<img src="https://user-images.githubusercontent.com/86859418/204164536-aec2769d-7205-426b-ba3e-8726b2588f9b.png">

**Com os dados preenchidos corretamente, iremos cadastrar o primeiro pet do "cliente Bernardo cod. 31".**

<img src="https://user-images.githubusercontent.com/86859418/204164694-5af33dd6-9faa-4cac-8170-c8667b44c6cb.png">

Então o primeiro pet do "cliente Bernardo cod. 31" foi registrado e exibido na lista de Pets dos CLientes com o cód. 18, o usuário do sistema pode também carregar a lista dos pets do "cliente cod. 31" clicando no botão Clientes no menu lateral e ao clicar no botão verde(pet) poderá ver os pets do cliente como abaixo em anexo. 

<img src="https://user-images.githubusercontent.com/86859418/204164846-217f1326-0164-47e2-ab88-33a703e452da.png">

**CT-04 – Agendar, realizar atendimento e envio de comprovante para o cliente selecionado**

<img src="">

**Resultado CT-04 - Comprovante enviado para o cliente...

<img src="">


**CT-05 – Visualizar o histórico de atendimentos feitos aos clientes.**

<img src="">

**Resultado CT-05 - Visualização do relatório de forma organizada referente aos atendimentos agendados e realizados.

<img src="">

**CT-06 – Consultar na agenda as datas e horários disponíveis, para agendar ou efetuar o registro de um atendimento.**

<img src="">

**Resultado CT-06 - Visualização das datas disponíveis diferenciando dos atendimentos agendados e realizados.

<img src="">

**CT-07 – Editar o registro dos clientes e pets**

<img src="https://user-images.githubusercontent.com/86859418/204165355-ae9ca87a-fb4a-4de5-a122-0967dffa08b0.png">
<img src="https://user-images.githubusercontent.com/86859418/204165419-18d01dc7-67ba-48ab-b8d7-8d2418b0a76f.png">

**Realizando atualização dos registro do pet "Sam" cod.18 do Cliente Bernardo cod. 31 já feitos cadastrados anteriormente conforme visto no caso de teste CT-03**

**Resultado CT-07 - Verificar se a edição foi realizada com sucesso, ao submeter a edição a lista irá atualizar com o dados ajustado.**

<img src="">

**CT-08 – O site deve permitir que o usuário mude para modo dark (escuro)**

<img src="">

**Resultado CT-08 - Verificar ocorre a mudança de tema.

<img src="">
