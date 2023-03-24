namespace Evaluator.Logic
{
    public class MyEvaluator
    {
        public static double Evaluate(string infix)
        {
            var postfix = ToPostfix(infix);
            return Calculate(postfix);
        }

        private static double Calculate(string postfix)
        {
            throw new NotImplementedException();
        }

        private static string ToPostfix(string infix)
        {
            throw new NotImplementedException();
        }

        private int PriorityInExpression(char @operator)
        {
            switch (@operator)
            {
                case '^': return 4;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 5;
                default: throw new Exception("Not valid operator");
              }
        }

        private int PriorityInStack(char @operator)
        {
            switch (@operator)
            {
                case '^': return 3;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 0;
                default: throw new Exception("Not valid operator");
            }
        }
    }
}