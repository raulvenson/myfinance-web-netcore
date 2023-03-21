# MyFinance

MyFinance - Projeto do Curso de Pós-Graduação em Engenharia de Software da PUC-MG que visa ajudar os usuários a gerenciarem suas finanças pessoais por meio do registro de receitas e despesas.

## Funcionalidades

### Início
Menu superior disponível em todas as telas com acesso as funcionalidades descritas na sequência.
<img src='docs/home.PNG' alt='Tela de início'/>
### Plano de Contas

Inserir, editar, excluir e visualizar planos de contas, informando uma descrição e o tipo (Receita ou Despesa):
<img src='docs/planoContas.PNG' alt='Tela de Plano de Contas'/>

### Transações

Inserir, editar, excluir e visualizar transações, informando uma data, valor, histórico e relacionar a um Plano de Contas:
<img src='docs/transacoes.PNG' alt='Tela de Transações'/>

### Relatório de Transações
Permite visualizar registros de transações filtrando por um intervalo de datas.
<img src='docs/relatorio.PNG' alt='Tela de Transações'/>

## Arquitetura
Foi utilizado a arquitetura MVC (Model-View-Controller) é um padrão de projeto de software que separa a aplicação em três componentes principais: o Model (Modelo), que representa os dados e regras de negócio; a View (Visão), que apresenta a interface gráfica ao usuário; e o Controller (Controlador), que gerencia as solicitações do usuário e as respostas do servidor.
<img src='docs/mvc.png' alt='Tela de Transações'/>

## DER - Diagrama de Entidades e Relacionamento

<img src='docs/diagrama.PNG' alt='DER - Diagrama de Entidades e Relacionamento'/>

## Tecnologias

O projeto foi desenvolvido utilizando as seguintes tecnologias:

<p align="left" style="'margin':'50px'">
    <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/" targer="_blank"><img src="https://cdn-icons-png.flaticon.com/512/6132/6132221.png" width="40" height="40"> </a>
    <a href="https://dotnet.microsoft.com/pt-br/" targer="_blank"><img src="https://cdn.iconscout.com/icon/free/png-256/microsoft-dot-net-1-1175179.png" width="50" height="50"></a>
    <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-2022" targer="_blank"><img src="https://cdn-icons-png.flaticon.com/512/5968/5968364.png" width="50" height="50"></a>
</p>

## Instalação
#### Requisitos
- <a href="https://dotnet.microsoft.com/en-us/download" target="_blank">.NET CORE SDK 6.0</a>
- Criar banco de dados a partir do seguinte [script](/docs/SQLQuery1.sql)

Clone o projeto
```bash
  git clone https://github.com/raulvenson/myfinance-web-netcore
```

 Configurar acesso ao banco de dados no arquivo [MyFinanceDbContext.cs](/src/myfinance-web-netcore/MyFinanceDbContext.cs)
 
Acessar diretório do projeto
```bash
  cd .\myfinance-web-netcore\src\myfinance-web-netcore\ 
```
Executar a aplicação
```bash
  dotnet run 
```
