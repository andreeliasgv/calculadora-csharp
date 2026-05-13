# 🧮 Calculadora CLI em C#

Projeto de uma **calculadora via terminal (CLI)** desenvolvida em **C#**, capaz de realizar operações matemáticas básicas e avançadas diretamente pelo console.

O sistema permite ao usuário selecionar operações matemáticas através de um menu interativo e executar cálculos em tempo real.

---

# 📌 Funcionalidades

A calculadora possui suporte para as seguintes operações:

| Operação      | Descrição                      |
| ------------- | ------------------------------ |
| Adição        | Soma entre dois números        |
| Subtração     | Diferença entre dois números   |
| Multiplicação | Produto entre dois números     |
| Divisão       | Divisão entre dois números     |
| Potenciação   | Potência matemática            |
| Radiciação    | Cálculo de raiz                |
| Logaritmo     | Logaritmo em qualquer base     |
| Seno          | Função trigonométrica seno     |
| Cosseno       | Função trigonométrica cosseno  |
| Tangente      | Função trigonométrica tangente |

---

# 🛠 Tecnologias Utilizadas

* **C#**
* **.NET**
* Console Application (CLI)

---

# 📂 Estrutura do Projeto

```text id="t0z4qq"
.
└── Program.cs
```

| Arquivo      | Descrição                                               |
| ------------ | ------------------------------------------------------- |
| `Program.cs` | Arquivo principal contendo toda a lógica da calculadora |

---

# ▶️ Como Executar

## ✅ Pré-requisitos

* .NET SDK instalado
* Visual Studio, VS Code ou terminal com suporte ao .NET

---

## 🔧 Compilação e Execução

### Via terminal

```bash id="i7jlj5"
dotnet run
```

Ou:

```bash id="9ftfwa"
csc Program.cs
Program.exe
```

---

# 🖥️ Exemplo de Uso

## Entrada

```text id="efp5dj"
CALCULADORA CLI
Escolha a operação:
1 - Adição
2 - Subtração
3 - Multiplicação
4 - Divisão
5 - Potenciação
6 - Radiciação
7 - Logaritmo
8 - Seno
9 - Cosseno
10 - Tangente

> 1

Digite o primeiro número:
> 10

Digite o segundo número:
> 5
```

---

## Saída

```text id="t0v4h8"
Calculando...

10 + 5 = 15
```

---

# 📐 Operações Matemáticas

## ➕ Adição

```text id="5fy4lc"
a + b
```

---

## ➖ Subtração

```text id="ynjjtw"
a - b
```

---

## ✖️ Multiplicação

```text id="b8rkgk"
a * b
```

---

## ➗ Divisão

O sistema verifica automaticamente divisão por zero.

```text id="8g6xyh"
Erro: Divisão por zero não é permitida.
```

---

## 🔺 Potenciação

Utiliza:

```csharp id="k3r87z"
Math.Pow(numero1, numero2)
```

---

## √ Radiciação

Calcula raízes utilizando potência fracionária.

Exemplo:

```text id="kqjlwm"
³√27 = 3
```

O sistema impede índice zero:

```text id="03icm7"
Erro: O índice da raiz não pode ser zero.
```

---

## 📘 Logaritmo

Utiliza:

```csharp id="o9o8d8"
Math.Log(numero1, numero2)
```

Com validações matemáticas:

* Número > 0
* Base > 0
* Base ≠ 1

---

## 📐 Funções Trigonométricas

As operações de seno, cosseno e tangente convertem automaticamente os valores de graus para radianos.

Exemplo:

```csharp id="rmgd6e"
double senoRadiano = numero1 * Math.PI / 180;
```

---

# ⚠️ Tratamento de Erros

O sistema possui validações para:

* Divisão por zero
* Índice de raiz igual a zero
* Valores inválidos para logaritmos
* Operações inexistentes

---

# 🎯 Objetivo do Projeto

Este projeto foi desenvolvido com fins de estudo para praticar:

* Estruturas condicionais
* Estruturas de repetição
* Entrada e saída de dados
* Operações matemáticas em C#
* Uso da classe `Math`
* Desenvolvimento de aplicações CLI

---

# 📚 Conceitos Trabalhados

* `switch case`
* Conversão de tipos
* Operadores matemáticos
* Métodos matemáticos
* Validação de dados
* Manipulação de entrada do usuário

---

# 👨‍💻 Autor

Projeto desenvolvido para prática de lógica de programação e desenvolvimento em **C#**.
