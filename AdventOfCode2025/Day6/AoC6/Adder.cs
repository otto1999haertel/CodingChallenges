namespace AoC6;

internal class Adder : Task
{
    internal Adder(TaskModel taskModel) : base(taskModel)
    {
    }

    internal override int Calculate()
    {
        int result =0; 
        for(int i=0; i<taskModel.Operators.Count;i++)
        {
            List<int> column = taskModel.GetColumn(i);
            result += taskModel.Operators[i].Caulculate(column);
        }   
        return result;
    }


}