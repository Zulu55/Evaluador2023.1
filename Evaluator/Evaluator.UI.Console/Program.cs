using Evaluator.Logic;

Console.WriteLine("Expresions Evaluator");
var expresion = "4*5/(4+6)";
Console.WriteLine($"{expresion} = {MyEvaluator.Evaluate(expresion)}");
