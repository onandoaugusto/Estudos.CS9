# **Roteiro de Estudos para C# 9**  
*Aplicando Garbage Collector, Métodos Assíncronos, Padrões REST e Princípios SOLID*  

Este roteiro está organizado em módulos progressivos, com conceitos teóricos e exercícios práticos.  

---  

## **Módulo 1: Fundamentos do C# 9 e Garbage Collector (GC)**  
**Objetivo:** Entender a sintaxe moderna do C# 9 e como o Garbage Collector gerencia a memória.  

### **Tópicos:**  
1. **Sintaxe Moderna do C# 9**  
   - Records (`record class`, `record struct`)  
   - Init-only setters (`init`)  
   - Pattern matching avançado (`is`, `switch`)  
   - Top-level statements  

2. **Garbage Collector (GC) em .NET**  
   - Como o GC funciona (gerações: 0, 1, 2)  
   - `IDisposable` e `using` para gerenciamento de recursos  
   - Boas práticas para evitar memory leaks  

### **Exercícios Práticos:**  
1. Crie um `record` para representar um `Produto` com propriedades imutáveis.  
2. Implemente `IDisposable` em uma classe que manipula arquivos.  
3. Compare o desempenho de alocação de objetos com e sem `GC.Collect()`.  

---  

## **Módulo 2: Métodos Assíncronos (Async/Await)**  
**Objetivo:** Dominar programação assíncrona para melhorar desempenho em operações I/O.  

### **Tópicos:**  
1. **Async/Await em C#**  
   - Diferença entre `Task`, `ValueTask` e `void`  
   - Tratamento de erros em métodos assíncronos  
   - `ConfigureAwait(false)` e deadlocks  

2. **Padrões Avançados**  
   - `IAsyncEnumerable` para streams assíncronos  
   - `CancellationToken` para cancelamento de tarefas  

### **Exercícios Práticos:**  
1. Crie uma API que consulte dados de um serviço externo (ex: HTTP) de forma assíncrona.  
2. Implemente um método que processe uma lista grande de dados usando `IAsyncEnumerable`.  
3. Use `CancellationToken` para cancelar uma operação demorada.  

---  

## **Módulo 3: Padrões REST com ASP.NET Core**  
**Objetivo:** Aprender a construir APIs RESTful seguindo boas práticas.  

### **Tópicos:**  
1. **Princípios REST**  
   - Verbos HTTP (`GET`, `POST`, `PUT`, `DELETE`, `PATCH`)  
   - Status codes semânticos (200, 201, 400, 404, 500)  
   - HATEOAS (opcional)  

2. **ASP.NET Core Web API**  
   - Rotas, controllers e action results  
   - Model binding e validação com `DataAnnotations`  
   - Documentação com Swagger/OpenAPI  

### **Exercícios Práticos:**  
1. Crie uma API REST para um sistema de tarefas (`Todo`), com CRUD completo.  
2. Implemente versionamento de API (`/v1/todos`, `/v2/todos`).  
3. Adicione autenticação JWT à API.  

---  

## **Módulo 4: Princípios SOLID em C#**  
**Objetivo:** Aplicar SOLID para escrever código limpo e sustentável.  

### **Tópicos:**  
1. **SOLID Explicado**  
   - **S**ingle Responsibility Principle (SRP)  
   - **O**pen/Closed Principle (OCP)  
   - **L**iskov Substitution Principle (LSP)  
   - **I**nterface Segregation Principle (ISP)  
   - **D**ependency Inversion Principle (DIP)  

2. **Aplicação Prática**  
   - Injeção de Dependência (DI) em ASP.NET Core  
   - Uso de interfaces para desacoplamento  

### **Exercícios Práticos:**  
1. Refatore um código monolítico aplicando SRP e DI.  
2. Crie um sistema de notificações seguindo OCP (aberto para extensão, fechado para modificação).  
3. Implemente um repositório genérico (`IRepository<T>`) aplicando DIP.  

---  

## **Módulo 5: Projeto Integrador**  
**Objetivo:** Aplicar todos os conceitos em um projeto real.  

### **Sugestão de Projeto:**  
**Sistema de Gerenciamento de Biblioteca**  
- API RESTful com ASP.NET Core  
- Operações assíncronas para consulta de livros  
- Uso de `record` para entidades imutáveis  
- Princípios SOLID na arquitetura  
- Gerenciamento de recursos (arquivos, conexões) com `IDisposable`  

---  

## **Cronograma Sugerido**  
| Módulo       | Duração  |  
|--------------|---------|  
| 1 (C# 9 + GC)| 1 semana|  
| 2 (Async)    | 1 semana|  
| 3 (REST)     | 2 semanas|  
| 4 (SOLID)    | 1 semana|  
| 5 (Projeto)  | 2 semanas|  

---  

## **Recursos Recomendados**  
- Livro: *C# 9 and .NET 5 – Modern Cross-Platform Development* (Mark J. Price)  
- Documentação: [Microsoft Docs (C#)](https://docs.microsoft.com/pt-br/dotnet/csharp/)  
- Cursos: [Pluralsight](https://www.pluralsight.com/), [Udemy](https://udemy.com)  

Bons estudos! 🚀