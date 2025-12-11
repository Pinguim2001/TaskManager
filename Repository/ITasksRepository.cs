using TaskManager.Models;

namespace TaskManager.Repository
{
    public interface ITasksRepository
    {
        Tasks Add(Tasks _task);
        List<Tasks> GetAll();
        Tasks GetById(int id);
        Tasks Update(Tasks _task);
        bool Delete(int id);
        Tasks ToggleComplete(int id, bool isCompleted);

    }
}
