# Exercicio Salário Funcionário  

Este é um exercício de **Programação Orientada a Objetos (POO) em C#**, feito durante o curso de **POO da Udemy**.  
O objetivo é praticar conceitos como **classes, encapsulamento, listas, métodos e sobrescrita de `ToString()`**.  

## Funcionalidades  

- Cadastrar funcionários com:
  - **Id** (único, não pode se repetir)  
  - **Nome**  
  - **Salário**  

- Garantir que o **Id** não seja duplicado no cadastro.  
- Aplicar **aumento percentual** no salário de um funcionário específico.  
- Exibir a lista de funcionários com os dados atualizados.  

## Tecnologias  

- Linguagem: **C#**  
- Framework: **.NET 8.0**  

## Estrutura do Projeto  

ExercicioSalarioFuncionario/

├── Funcionario.cs # Classe que representa o funcionário

├── Program.cs # Programa principal (interação com usuário)

├── ExercicioSalarioFuncionario.csproj


## Como Executar  

1. Clone este repositório:  
    git clone https://github.com/seu-usuario/ExercicioSalarioFuncionario.git
Entre na pasta do projeto:

cd ExercicioSalarioFuncionario/ExercicioSalarioFuncionario
Execute o programa com:
dotnet run

 Exemplo de Uso
Quantas pessoas serão cadastradas? 2

Empregado Nº 1
Digite o Id do funcionário: 1
Digite o nome do funcionário: Maria
Digite o salário do funcionário: 3000.00

Empregado Nº 2
Digite o Id do funcionário: 2
Digite o nome do funcionário: João
Digite o salário do funcionário: 4000.00

Digite o Id do funcionário que você deseja aumentar o salário: 2
Digite quantos % você deseja aumentar o salário do funcionário João: 10
📋 Saída:

Id: 1, Nome: Maria, Salário: 3000.00

Id: 2, Nome: João, Salário: 4400.00

---
