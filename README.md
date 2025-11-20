# Calculator

Pequena aplicação de console em C# que implementa uma calculadora simples (adição, subtração, multiplicação e divisão).

**Resumo:**
- **Projeto:** Aplicativo de console que lê dois números, pede uma operação (1-4) e exibe o resultado.
- **Idioma:** C# (.NET 9)

**Requisitos:**
- .NET SDK 9.0 ou superior. Verifique com `dotnet --version`.

**Build & Execução:**
- Abra um terminal na pasta do projeto (a mesma onde está o arquivo `Calculator.csproj`).
- Para compilar:

```
dotnet build
```

- Para executar diretamente:

```
dotnet run
```

ou, especificando o projeto explicitamente se estiver em outro diretório:

```
dotnet run --project Calculator.csproj
```

**Como usar (fluxo):**
- O programa solicita dois números (cada um em sua linha).
- Em seguida pede para escolher a operação:
  1 - Adição (+)
  2 - Subtração (-)
  3 - Multiplicação (*)
  4 - Divisão (/)
- Depois de mostrar o resultado, pergunta se você quer realizar outra operação: `Y` para sim, qualquer outra tecla para sair.

Exemplo de sessão rápida:

```
Enter two numbers to make your calculations:
5
3
--------------------------------
Choose an operation:
 1- Addition (+)
 2- Subtraction (-)
 3- Multiplication (*)
 4- Division (/)
--------------------------------
1
5 + 3 = 8
Do you want to perform another calculation? (Y/N)
N
Turning off the calculator. Goodbye!
```

**Observações:**
- A divisão por zero é tratada (o programa informa o erro e permite tentar novamente).
- Não há tratamento completo de entradas inválidas (por exemplo, texto onde se espera número) — insira números e opções válidas para evitar exceções.

**Contribuição:**
- Alterações simples são bem-vindas: validação de entrada, suporte a operações adicionais, formatação de saída.

**Licença:**
- Use conforme desejar. Adicione um arquivo `LICENSE` se quiser especificar uma licença.
