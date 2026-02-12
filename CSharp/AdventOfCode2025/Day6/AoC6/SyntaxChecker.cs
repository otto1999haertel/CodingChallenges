namespace AoC6;

internal class SyntaxChecker{
    internal bool CheckSytntax(TaskModel taskModel)
    {
        // Implementation goes here
        if(taskModel.Operators.Any(op => op.Value != "+" && op.Value != "*" && op.Value != "-" && op.Value != "/"))
        {
            return false;
        }
        return true;
    }
}