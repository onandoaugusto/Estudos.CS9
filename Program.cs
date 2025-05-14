//    Tópico 1: Sintaxe Moderna do C# 9

/*
    1. Records (record)
    records são tipos imutáveis por padrão, ideais para DTOs (Data Transfer Objects) e modelos de dados.
    Podem ser declarados como record class (referência) ou record struct (valor).
    Suportam igualdade estrutural (comparam valores, não referências).
*/
// EstudosCS9.M1.SintaxeCS9.RecordExample();

/*
    2. Init-only Setters (init)
    Permitem que propriedades sejam definidas apenas na inicialização (útil para imutabilidade).
*/
// EstudosCS9.M1.SintaxeCS9.InitOnlyExample();

/*
    3. Pattern Matching Avançado
    Simplifica verificações condicionais com is, switch e when.
*/
//EstudosCS9.M1.SintaxeCS9.PatternMatchingExample();

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
var Circulo = new EstudosCS9.M1.ExerciciosPraticosCS9.Circulo(21);
var Quadrado = new EstudosCS9.M1.ExerciciosPraticosCS9.Retangulo(5, 10);

EstudosCS9.M1.ExerciciosPraticosCS9.GeometricFormsClassifier(Circulo);
EstudosCS9.M1.ExerciciosPraticosCS9.GeometricFormsClassifier(Quadrado);

/******************************************************************************************
    2. Usando 'is' e 'when'
    Filtre uma lista misturando tipos    
*/
EstudosCS9.M1.ExerciciosPraticosCS9.DataFilter();

/******************************************************************************************
    3. Validador de Senha com 'switch'/'when'
    Verificar graus de segurança de uma string
*/

//Forte, Média e Fraca
EstudosCS9.M1.ExerciciosPraticosCS9.PasswordStrengh("abc#1234Fn");
EstudosCS9.M1.ExerciciosPraticosCS9.PasswordStrengh("fkria&nn");
EstudosCS9.M1.ExerciciosPraticosCS9.PasswordStrengh("2");

/******************************************************************************************
    4. Classificador de Triângulos    
*/
var Triangulo = new EstudosCS9.M1.ExerciciosPraticosCS9.Triangulo(3, 4, 5);
EstudosCS9.M1.ExerciciosPraticosCS9.TriangleTypeClassifier(Triangulo);