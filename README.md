# Client Persistence WebApp

Este é um serviço web ASP.NET MVC desenvolvido para gerenciar clientes e seus respectivos logradouros. Ele utiliza tecnologias como .NET 8, HTML, CSS, JavaScript e jQuery. As requisições são autenticadas e autorizadas via JWT a uma API REST.

## Instalação

Siga estas etapas para configurar e executar o projeto localmente:

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Git](https://git-scm.com/)

### Clonando o repositório

```bash
git clone https://github.com/Luiz-F-L-P-JR/Client.Persistence.WebApp.git
```

### Configuração

1. Navegue até o diretório do projeto:

```bash
cd Client.Persistence.WebApp
```

2. Abra o arquivo `launchSettings.json` e atualize as configurações conforme necessário, incluindo a configuração do JWT para autenticação com a API REST.


3. Verifique também a configuração da rota (ROUTE) para a API que irá requisitar, ao executar o projeto sua rota pode ser diferente.

### Instalando dependências

1. Abra um terminal na pasta raiz do projeto e execute o comando:

```bash
dotnet restore
```

### Executando o projeto

1. Na pasta raiz do projeto execute:

```bash
dotnet run
```

2. O projeto estará acessível nas rotas indicadas no arquivo `launchSettings.json`, utilize `http://localhost:` e a número da porta.

## Contribuindo

Sinta-se à vontade para contribuir com melhorias, correções de bugs ou novos recursos. Basta seguir estas etapas:

1. Faça um fork do repositório.
2. Crie uma nova branch com a sua feature (`git checkout -b feature/nova-feature`).
3. Faça commit das suas alterações (`git commit -am 'Adiciona nova feature'`).
4. Faça push para a branch (`git push origin feature/nova-feature`).
5. Crie um novo Pull Request.

## Contato

Para mais informações, entrem em contato com Luizfernandojr1998@gmail.com.

---
