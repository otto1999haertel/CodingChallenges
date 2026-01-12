namespace AoC6;

internal class SemanticChecker{
    internal bool CheckSemantics(TaskModel taskModel)
    {
        // Implementation goes here
         foreach(var row in taskModel.Data)
        {
            if(row.Count != taskModel.Operators.Count)
            {
                return false;
            }
        }
        return true;
    }
}