using System.ComponentModel;
using System.Text;

namespace AoC6;

public class Calculator
{
    public Calculator()
    {

    }

    public int Calculate(string FilePath)
    {
        // Implementation goes here
        Parser parser = new Parser(FilePath);
        TaskModel taskModel = parser.Parse();
        SemanticChecker semanticChecker = new SemanticChecker();
        if(!semanticChecker.CheckSemantics(taskModel))
        {
            throw new ArgumentException("Semantic check failed for the provided task model.");
        }
        SyntaxChecker syntaxChecker = new SyntaxChecker();
        if(!syntaxChecker.CheckSytntax(taskModel))
        {
            throw new ArgumentException("Syntax check failed for the provided task model.");
        }
        Task adder = new Adder(taskModel);
        return adder.Calculate();
    }
}
