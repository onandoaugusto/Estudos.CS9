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
            List<object> dados = new() { 10, "Texto", Math.PI, DateTime.Now, Guid.NewGuid() };

            var inteiros = dados.OfType<int>().Where(x => x is > 5);
            var datas = dados.OfType<DateTime>().Where(x => x.Year > 2024);


            Console.WriteLine($"Inteiros: {inteiros.Count()}");

            Console.WriteLine($"Datas: {datas.Count()}");
        }
        #endregion

    public record Retangulo(int Altura, int Largura);
    public record Circulo(int Raio);
    }
}