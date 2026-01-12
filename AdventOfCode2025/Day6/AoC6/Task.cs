namespace AoC6;

internal abstract class Task
{
    protected TaskModel taskModel;

    internal Task(TaskModel TaskModel){
        taskModel = TaskModel;
    }

    internal abstract int Calculate();
}