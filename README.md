Curso de Pós-Graduação em Engenharia de Software da PUC-MG

Projeto para trabalho final de Projeto Integrado de Software ✔

Integrantes:

Carlos Cesar Inácio
Carlos Rodrigues de Moura Junior
Mateus Belli
Renan Rocha Silva

# Escopo

Criação de algoritmo em .net para cálculo de IMC e macronutrientes a partir de dados iniciais do usuário.
# Funcionalidades

# Lista de Tecnologias:

- Framework ⚙

  - [.NET 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

- Testing 📋

  - [XUnit.net](https://xunit.net/)

- Distribuição 

  - [NuGet](https://www.nuget.org/)


## Regras Gerais

Cálculo de IMC:

IMC é calculado através do Peso (em kg) dividido pela altura (em centímetros) ao quadrado ( peso/altura²)

A partir do valor obtido, é determinada uma classificação de índice de massa corporal, conforme abaixo:

- < que 18.5 - Abaixo do peso
- 18.5 >= e <= 24.9 - Peso normal
- >= 25.0 e <= 29.9 - Pré-obesidade
-  >= 30.0 e <= 34.9 - Obesidade Grau 1
- >= 35.0 <= 39.9 - Obesidade Grau 2
- > 40 - Obesidade Grau 3

## A recomendação de Macronutrientes é feita a partir do objetivo do usuário, que pode ser:

- Objetivo:

  -Aumento de Peso; 💪

Recomendação macros:


   - Proteína: 2g por Kg do usuário
   - Gordura: 2g por Kg do usuário
   - Carboidrato: 4g por Kg do usuário


  - Redução de Peso; 🏃‍♂️

Recomendação macros:

    - Proteína: 2g por Kg do usuário
    - Gordura: 1g por Kg do usuário
    - Carboidrato: 2g por Kg do usuário


  - Manutenção do Peso atual; 🧘‍♂️

Recomendação macros:

    - Proteína: 2g por Kg do usuário
    - Gordura: 1g por Kg do usuário
    - Carboidrato: 5g por Kg do usuário



