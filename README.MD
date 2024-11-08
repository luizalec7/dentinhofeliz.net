# Dentinho Feliz

## Objetivo do Projeto

O aplicativo **Dentinho Feliz** tem como objetivo educar e conscientizar crianças de até 14 anos sobre a importância da higiene bucal. Ele oferece quizzes interativos, informações educativas e recompensas para incentivar bons hábitos e promover a saúde bucal desde a infância.

## Escopo

O escopo do projeto inclui o desenvolvimento de uma API back-end em .NET que suporte funcionalidades como:
- Gerenciamento de quizzes sobre higiene bucal
- Sistema de pontuação baseado nas respostas dos quizzes
- Premiação baseada na progressão de pontos
- Exibição de informações educativas sobre higiene bucal

Esta API servirá como suporte para um aplicativo móvel que será utilizado pelas crianças, permitindo uma experiência interativa e educativa.

## Requisitos Funcionais

- **Gerenciamento de quizzes**: Sistema que permite a criação, edição e remoção de quizzes sobre higiene bucal.
- **Sistema de pontuação**: Atribuição de pontos baseados nas respostas corretas dos quizzes, incentivando a participação.
- **Premiação por progressão**: Recompensas são liberadas conforme o usuário acumula pontos, incentivando o progresso contínuo.
- **Exibição de informações educativas**: Prover conteúdo educacional sobre a importância da higiene bucal.

## Requisitos Não Funcionais

- **Escalabilidade**: A aplicação deve ser capaz de suportar múltiplos usuários simultaneamente.
- **Segurança**: Implementação de práticas de segurança para proteger os dados dos usuários.

## Membros do Projeto

- **Guilherme Augusto de Oliveira** – RM554176
- **Luiz Alecsander Viana** - RM553034
- **Lucas Martinez Lopes** - RM553816

## Estrutura do Projeto

O projeto está estruturado de acordo com as melhores práticas de desenvolvimento com ASP.NET Core. Ele inclui as seguintes camadas:

- **API (DentinhoFeliz.Api)**: Camada de controle que gerencia as rotas e endpoints da aplicação.
- **Application**: Contém serviços de aplicação e ViewModels para transferência de dados.
- **Domain**: Contém entidades e interfaces de domínio, representando a lógica de negócios.
- **Infrastructure**: Camada de infraestrutura com implementações de repositórios e contexto de banco de dados.

## Instruções de Instalação e Configuração

### Pré-requisitos

- .NET SDK (versão 6.0 ou superior)
- SQL Server (ou outro banco de dados compatível)
- Visual Studio ou Visual Studio Code (recomendado)

### Passos de Instalação

1. **Clone o Repositório**:
   bash
   git clone https://github.com/luizalec7/dentinhofeliz.net.git
   cd DentinhoFeliz
