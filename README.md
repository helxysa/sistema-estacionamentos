# Sistema de Estacionamento

## Descrição
Sistema de gerenciamento de estacionamento desenvolvido em C# para controle de veículos, cálculo de tarifas e operações administrativas.

## Funcionalidades

### Operações Principais
- **Cadastrar Veículo**: Registra a entrada de um veículo no estacionamento
- **Remover Veículo**: Processa a saída e calcula o valor total a ser cobrado
- **Listar Veículos**: Exibe todos os veículos atualmente estacionados
- **Encerrar Sistema**: Finaliza a execução do programa

### Características Técnicas
- Interface de console interativa e intuitiva
- Validação robusta de entrada de dados
- Tratamento de exceções para valores inválidos
- Cálculo automático de tarifas baseado no tempo de permanência
- Persistência de dados durante a sessão

## Arquitetura

### Classe Estacionamento
A classe principal contém:

- **precoInicial** (decimal): Tarifa fixa para entrada no estacionamento
- **precoPorHora** (decimal): Valor cobrado por hora de permanência
- **veiculos** (List<string>): Coleção de placas dos veículos estacionados

### Métodos Implementados
- `AdicionarVeiculo()`: Registra novo veículo na lista
- `RemoverVeiculo()`: Remove veículo e calcula tarifa total
- `ListarVeiculos()`: Exibe todos os veículos estacionados

## Como Executar

### Pré-requisitos
- .NET 6.0 ou superior
- Sistema operacional compatível (Windows, macOS, Linux)

### Comandos de Execução
```bash
# Compilar o projeto
dotnet build

# Executar o programa
dotnet run
```

## Fluxo de Uso

1. **Configuração Inicial**
   - Defina o preço inicial de entrada
   - Configure o valor por hora de permanência

2. **Menu Principal**
   - Navegue pelas opções numeradas (1-4)
   - Cada operação é confirmada antes de prosseguir

3. **Operações Disponíveis**
   - **Opção 1**: Cadastrar entrada de veículo
   - **Opção 2**: Processar saída e calcular tarifa
   - **Opção 3**: Visualizar veículos estacionados
   - **Opção 4**: Encerrar o sistema

## Tratamento de Erros

O sistema implementa validações robustas:
- Verificação de formato numérico para valores monetários
- Tratamento de overflow para valores muito grandes
- Mensagens de erro claras e orientativas
- Loop de validação até entrada correta

## Estrutura do Projeto

```
DesafioFundamentos/
├── Models/
│   └── Estacionamento.cs
├── Program.cs
└── README.md
```

## Tecnologias Utilizadas

- **C#**: Linguagem principal de desenvolvimento
- **.NET**: Framework de desenvolvimento
- **Console Application**: Interface de usuário via terminal
