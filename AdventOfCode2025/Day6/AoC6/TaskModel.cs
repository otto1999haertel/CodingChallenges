namespace AoC6;

internal class TaskModel
{
    internal List<List<int>> Data { get; set; }
    internal List<Operator> Operators { get; set; }

    internal TaskModel(List<List<int>> data, List<Operator> operators)
    {
        Data = data;
        Operators = operators;
    }

    internal List<int> GetColumn(int columnIndex)
    {
        List<int> column = new List<int>();
        foreach(var row in Data)
        {
            column.Add(row[columnIndex]);
        }
        return column;
    } 
}