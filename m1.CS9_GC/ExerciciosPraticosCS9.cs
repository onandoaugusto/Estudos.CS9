namespace EstudosCS9.M1
{
    public class ExerciciosPraticosCS9
    {
        #region Classificador de formas geométricas
        public static void GeometricFormsClassifier(object forma)
        {
            string area = forma switch
            {
                Circulo c => $"Área do Círculo: {AreaCirculo(c.Raio)}",
                Retangulo r => $"Área do Retângulo: {AreaRetangulo(r.Altura, r.Largura)}",
                _ => "Forma desconhecida"
            };

            Console.WriteLine($"{area}");
        }

        private static double AreaCirculo(double r)
        {
            return Math.Round(Math.PI * r * r, 2);
        }

        private static double AreaRetangulo(double a, double l)
        {
            return Math.Round(a * l, 2);
        }
        #endregion

        #region Filtro de dados de 'is' e 'when'
        public static void DataFilter()
        {
            List<object> dados = new() { 10, 1, -21, -1, "Texto", Math.PI, DateTime.Now, Guid.NewGuid() };            
            Dictionary<string, int> cntTipoDados = new Dictionary<string, int>
            {
                { "InteiroNegativo", 0 },
                { "Double", 0 },
                { "Guid", 0 }
            };

            foreach(object d in dados)
            {
                switch (d)
                {
                    case int i when i < 0:
                        cntTipoDados["InteiroNegativo"]++;
                        break;

                    case double:
                        cntTipoDados["Double"]++;
                        break;

                    case Guid:  
                        cntTipoDados["Guid"]++;
                        break;

                    default: break;
                }
            }

            var inteiros = dados.OfType<int>().Where(x => x is > 5);
            var datas = dados.OfType<DateTime>().Where(x => x.Year > 2024);

            //Operações de quantitativos via Expressões 'Lambda'
            Console.WriteLine($"Inteiros: {inteiros.Count()}");
            Console.WriteLine($"Datas: {datas.Count()}");

            //Operações de quantitativos via 'loop' e 'switch'/'when'
            Console.WriteLine($"Inteiros Negativos: {cntTipoDados["InteiroNegativo"]}");
            Console.WriteLine($"Doubles: {cntTipoDados["Double"]}");
            Console.WriteLine($"Guids: {cntTipoDados["Guid"]}");
        }
        #endregion

        #region Validador de Senha
        public static void PasswordStrengh(string pwd)
        {
            var forca = pwd switch
            {
                null or "" => "Nula ou Vazia",
                string s when s.Length < 6 => "Fraca",
                string s when s.Length >= 8 
                    && s.Any(char.IsUpper)
                    && s.Any(char.IsLower)
                    && s.Any(char.IsDigit) => "Forte",
                _ => "Média"
            };

            Console.WriteLine(forca);
        }
        #endregion

        #region Classificador de Triângulos
        public static void TriangleTypeClassifier(Triangulo tri)
        {
            string tipo = tri switch
            {
                _ when tri.a == tri.b && tri.b == tri.c => "Equilátero",
                _ when tri.a == tri.b || tri.b == tri.c || tri.a == tri.c => "Isósceles",
                _ when Math.Pow(tri.a, 2) + Math.Pow(tri.b, 2) == Math.Pow(tri.c, 2) => "Retângulo",
                _ => "Escaleno"
            };

            Console.WriteLine($"Tipo do Triângulo: {tipo}");
        }
        #endregion
    public record Triangulo(int a, int b, int c);
    public record Retangulo(int Altura, int Largura);
    public record Circulo(int Raio);
    }
}