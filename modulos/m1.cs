namespace EstudosCS9.M1
{
    public class M1
    {
        public static void Run()
        {
            Topico1();
            Topico2();
        }
        //TÓPICO 1: Sintaxe Moderna do C# 9
        private static void Topico1()
        {
            /*
                1. Records (record)
                records são tipos imutáveis por padrão, ideais para DTOs (Data Transfer Objects) e modelos de dados.
                Podem ser declarados como record class (referência) ou record struct (valor).
                Suportam igualdade estrutural (comparam valores, não referências).
            */
            SintaxeCS9.RecordExample();

            /*
                2. Init-only Setters (init)
                Permitem que propriedades sejam definidas apenas na inicialização (útil para imutabilidade).
            */
            SintaxeCS9.InitOnlyExample();

            /*
                3. Pattern Matching Avançado
                Simplifica verificações condicionais com is, switch e when.
            */
            SintaxeCS9.PatternMatchingExample();

            /*
                4. Top-Level Statements
                Permitem escrever programas sem boilerplate (ideal apra scripts e pequenos programas)
            */

            /*****************************************************************************************/
            //Exercícios Práticos
            Console.WriteLine("*****************************************************************************************");
            /*****************************************************************************************/


            /******************************************************************************************
                1. Classificador de formas geométricas
                Use 'switch' para retornar a área de diferentes formas 
            */
            var Circulo = new ExerciciosPraticosCS9.Circulo(21);
            var Quadrado = new ExerciciosPraticosCS9.Retangulo(5, 10);

            ExerciciosPraticosCS9.GeometricFormsClassifier(Circulo);
            ExerciciosPraticosCS9.GeometricFormsClassifier(Quadrado);

            /******************************************************************************************
                2. Usando 'is' e 'when'
                Filtre uma lista misturando tipos    
            */
            ExerciciosPraticosCS9.DataFilter();

            /******************************************************************************************
                3. Validador de Senha com 'switch'/'when'
                Verificar graus de segurança de uma string
            */

            //Forte, Média e Fraca
            ExerciciosPraticosCS9.PasswordStrengh("abc#1234Fn");
            ExerciciosPraticosCS9.PasswordStrengh("fkria&nn");
            ExerciciosPraticosCS9.PasswordStrengh("2");

            /******************************************************************************************
                4. Classificador de Triângulos    
            */
            var Triangulo = new ExerciciosPraticosCS9.Triangulo(3, 4, 5);
            ExerciciosPraticosCS9.TriangleTypeClassifier(Triangulo);
        }
        //TÓPICO 2: Garbage Collector (GC) em .NET
        private static void Topico2()
        {
            /*
                1. Como o GC funciona (gerações 0, 1, 2)
            */
            GC.HowItWorks();

            /*
                2. 'IDisposable' e 'using' para gerenciamento de recursos
            */       
            GC.ResourceManagement();

            /*
                3. Evitando Vazamentos de Memória/Memory leaks
            */
            GC.AvoidingMemoryLeaks();
        }
    }
}