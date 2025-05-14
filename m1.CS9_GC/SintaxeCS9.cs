namespace EstudosCS9.M1
{
    public class SintaxeCS9 
    {
        /*
            1. Records (record)

                records são tipos imutáveis por padrão, ideais para DTOs (Data Transfer Objects) e modelos de dados.
                Podem ser declarados como record class (referência) ou record struct (valor).
                Suportam igualdade estrutural (comparam valores, não referências).
        */
        public static void RecordExample(bool Iguais = true) {            
            
            decimal Preco2 = !Iguais ? 5001 : 5000;
            
            var produto1 = new Produto("Notebook", 5000);
            var produto2 = new Produto("Notebook", Preco2);

            Console.WriteLine(produto1 == produto2);
        }

        /*
            2. Init-only Setters (init)

                Permitem que propriedades sejam definidas apenas na inicialização (útil para imutabilidade).
        */
        public static void InitOnlyExample()
        {
            var cliente = new Cliente{ Nome = "Gritzerai", Idade = 18};
            Console.Write(cliente.Nome);
            
            // // Erro de Compilação: Não é possível modificar a propriedade Nome após a inicialização
            // cliente.Nome = "Gritzerai"; 
        }

        /*
            3. Pattern Matching Avançado

            Simplifica verificações condicionais com is, switch e when.
        */

        public static void PatternMatchingExample()
        {
            /*
                3.1 - Verificações com is (padrão declarativo)
                Permite testar e extrair valores em uma única operação
            */
            VerificacaoIsExample();

            /*
                3.2 Pattern Matching em 'switch'
                Mais poderoso que o switch tradicional, suportando padrões complexos.
            */
            PatternMatchingSwitchExample();

            /*
                3.3 Padrões em Propriedades (property pattern)
                Verifica propriedades de objetos diretamente no padrão.
            */
            PropertyPatternExample();

            /*
                3.4 Padrões Relacionais e Lógicos
                Suporta operadores como >, <, >=, <=, and, or, not
            */
            LogicalRelationalPatternExample();

            /*
                3.5 Padrões em Listas
                Disponível a partir do C# 11, mas útil para entender a evolução do pattern matching
            */
            ListPatternExample(null);
            //ListPatternExample(new [] {0, 1, 2, 3, 4});

            /*
                3.6 Pattern Matching em 'when'
                O operador 'when' é um dos recursos mais poderosos do pattern matching em c#, permitindo 
                adicionar condições extras às suas variações.
            */
            WhenPatternMatching();
        }

        /*
            3.1 - Verificações com is (padrão declarativo)
            Permite testar e extrair valores em uma única operação
        */
        #region Verificações Is
        private static void VerificacaoIsExample()
        {
            //Verificação Simples
            pmeVerificacaoIsSimples();

            //Combinando condições com 'and'/'or'
            pmeVerificacaoIsCombinandoAndOr();
        }

        //Verificação Simples
        private static void pmeVerificacaoIsSimples()
        {
            object valor = 42;
            if (valor is int inteiro) //verifica se é int e extrai o valor
            {
                Console.WriteLine($"É um inteiro: {inteiro}");
            }
        }

        //Combinando condições com 'and'/'or'
        private static void pmeVerificacaoIsCombinandoAndOr()
        {
            object valor = 15;
            if (valor is int inteiro and > 10 and < 100)            
            {
                Console.WriteLine($"Inteiro entre 10 e 100: {inteiro}");               
            }
        }
        #endregion
        /*
            3.2 Pattern Matching em 'switch'
            Mais poderoso que o switch tradicional, suportando padrões complexos.
        */
        #region Pattern Matching em 'switch'
        private static void PatternMatchingSwitchExample()
        {
            //Exemplo 1: Tipos e Condições
            SwitchExample1();

            //Exemplo 2: Padrões em Tuplas
            SwitchExample2();
        }
        
        //Exemplo 1: Tipos e Condições
        private static void SwitchExample1()
        {
            object obj = "texto";

            string resultado = obj switch
            {
                int i when i > 0 => $"Inteiro Positivo: {i}",
                string s => $"string: {s}",
                null => "Objeto Nulo",
                _ => "Tipo desconhecido" //Caso Padrão
            };

            Console.WriteLine(resultado);
        }

        //Exemplo 2: Padrões em Tuplas
        private static void SwitchExample2()
        {
            var ponto = (x: 10, y: 20);

            string quadrante = ponto switch
            {
                (0,0) => "Origem",
                (var x, var y) when x > 0 && y > 0 => "Quadrante 1",
                (var x, var y) when x < 0 && y > 0 => "Quadrante 2",
                _ => "Outro Quadrante"
            };

            Console.WriteLine(quadrante);
        }
        #endregion
        /*
            3.3 Padrões em Propriedades (property pattern)
            Verifica propriedades de objetos diretamente no padrão.
        */
        #region Padrões em Propriedades (property pattern)
        private static void PropertyPatternExample()
        {
            //Exemplo: Validação de Objetos
            var pessoa = new Pessoa("Ana", 25);

            if (pessoa is {Nome: "Ana", Idade: >= 18})
            {
                Console.WriteLine("Ana é adulta.");
            }
        }
        #endregion
        /*
            3.4 Padrões Relacionais e Lógicos
            Suporta operadores como >, <, >=, <=, and, or, not
        */
        #region Padrões Relacionais e Lógicos
        private static void LogicalRelationalPatternExample()
        {
            int idade = 17;
            string categoria = idade switch
            {
                < 13 => "Criança",
                >= 13 and <= 18 => "Adolescente",
                >= 18 and < 60 => "Adulto",
                >= 60 => "Idoso",
                //[ERRO DE SINTAXE] Outra expressão já resolveu o intervalo ou a condição é inalcançável
                //_ => "Inválido"  
            };

            Console.WriteLine(categoria);
        }
        #endregion
        /*
            3.5 Padrões em Listas
            Disponível a partir do C# 11, mas útil para entender a evolução do pattern matching
        */
        #region Padrões em Listas
        /*
            3.5 Padrões em Listas
            Disponível a partir do C# 11, mas útil para entender a evolução do pattern matching
        */
        private static void ListPatternExample(int[]? lista)
        {
            //Exemplo: Verificação de Sequências
            string resultado = lista switch
            {
                [1,2, ..] => "Começa com 1 e 2",
                [.., 3] => "Termina com 3",
                null => "Objeto Nulo",
                _ => $"Desconhecido; Começa com {lista.First()} e termina com {lista.Last()}"
            };

            Console.WriteLine(resultado);
        }
        #endregion
        /*
            3.6 Pattern Matching em 'when'
            O operador 'when' é um dos recursos mais poderosos do pattern matching em c#, permitindo 
            adicionar condições extras às suas variações.
        */
        #region Pattern Matching em 'when'
        private static void WhenPatternMatching()
        {
            /*
                3.6.1 WHEN SOMENTE COM SWITCH!
                //o when só pode ser usado em expressões switch.
            */
            BasicWhen();

            // 3.6.2 Uso Avançado de Expressões 'switch'
            AdvancedSwitchExpressions();

            //3.6.3 Erros Comuns e Boas Práticas
            //GoodPractices();
        }
        
        private static void BasicWhen()
        {
            object valor = 15;
            switch (valor)
            {
                case int inteiro when inteiro > 10:
                    Console.WriteLine($"Inteiro maior do que 10: {inteiro}");
                    break;
                case DateTime data when data.Year > 2020:
                    Console.WriteLine($"Data com ano superior a 2020: {data.ToShortDateString()}");
                    break;
            }

            //o when só pode ser usado em expressões switch. A instrução abaixo é um exemplo de não aplicabilidade/erro.:
            /*
                object valor = 15;
                if (valor is int inteiro when inteiro > 10)
                {
                    Console.WriteLine($"Inteiro maior do que 10: {inteiro}");
                }
            */
        }

        // 3.6.2 Uso Avançado de Expressões 'switch'
        //"Onde o 'when' realmente brilha é em expressões 'switch'!" - ia.deepseek em 14/05/2025
        private static void AdvancedSwitchExpressions()
        {
            //3.6.2.1 Validação Complexa
            ComplexValidation();

            //3.6.2.2 Filtro em listas
            ListFiltering();
        }

        //3.6.2.1 Validação Complexa
        private static void ComplexValidation()
        {
            var pessoa = new { Nome = "Gritzerai", Idade = 25, Estado = "RJ" };
            string mensagem = pessoa switch
            {
                {Idade: < 18} => "Menor de Idade",
                {Estado: "SP"} when pessoa.Idade >= 18 => "Paulista adulto",
                {Estado: not null } => $"Morador de {pessoa.Estado}",
                _ => "Dados Incompletos"
            };

            Console.WriteLine(mensagem);
        }
        //3.6.2.2 Filtro em listas
        private static void ListFiltering()
        {
            var numeros = new List<object> {-2, -1, 0, 1, 2, "3", 4, "5", "zero"};
            foreach (var num in numeros)
            {
                string mensagem = string.Empty;
                switch(num)
                {
                    case int n when n == 0:
                        mensagem = "zero";
                        break;

                    case int n when n > 0:
                        var isEven = NumberIsEven(n);
                        mensagem = isEven.Mensagem;
                        break;

                    case int n when n < 0:
                        var isNegativeEven = NumberIsEven(n * 1);
                        mensagem = $"{isNegativeEven.Mensagem} (negativo)";
                        break;

                    case string s when int.TryParse(s, out int sn):
                        mensagem = $"String numérica: {sn}";
                        break;

                    default:
                        mensagem = $"string genérica: {num}";
                        break;
                }

                Console.WriteLine(mensagem);
            }
        }

        private static IsEven NumberIsEven(int i)
        {
            bool _isEven = i % 2 == 0;
            return new IsEven(Inteiro: i, isEven: _isEven, Mensagem: $"{i} é {(_isEven ? "par" : "ímpar")}");
        }
        
        //3.6.3 Erros Comuns e Boas Práticas
        private static void GoodPractices()
        {
            //Problema 1: Ordem Importa
            gpOrderMatters(7);

            //Problema 2: performance
            gpPerformance(new Produto("Livro", 10, 42));
        }

        //Problema 1: Ordem Importa
        private static void gpOrderMatters(object valor)
        {
            var resultado = valor switch
            {
                //✅ Correto - padrões específicos primeiro
                int i when i > 10 => "Número maior que 10", //
                int i => "Número",
                //❌ Padrão Mais genérico primeiro - nunca alcançará o específico
                // Nunca será alcançado:
                //int i when i > 10 => "Número maior que 10",
                
                _ => "O)utro"
            };
        }
        //Problema 2: performance
        private static void gpPerformance(Produto produto)
        {
            //Evite condições complexas demais no 'when' - considere extrair para métodos
            bool IsProdutoValidado(Produto p) => p.Preco > 0 && p.Estoque >= 0;
            var status = produto switch
            {
                _ when !IsProdutoValidado(produto) => "Inválido",
                {Estoque: 0} => "Esgotado",
                _ => "Disponível"
            };
        }
        #endregion
    }
    #region Objetos de auxílio
    public record IsEven(int Inteiro, bool isEven, string Mensagem);
    public record Produto(string Nome, decimal Preco, decimal Estoque = 1);
    public record Pessoa(string Nome, int Idade);
    public class Cliente
    {
        public required string Nome { get; init; }
        public int Idade { get; init; }
    }
    #endregion
}