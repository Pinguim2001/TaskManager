using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Repository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly AppDbContext _dbContext;
        public TasksRepository(AppDbContext dbContext) 
        {
           _dbContext = dbContext;
        }

        public bool Delete(int id)
        {
            Tasks tasks = GetById(id);

            if (tasks == null)
            {
                throw new Exception("A Tarefa não existe!!");
            }

            
            _dbContext.Tasks.Remove(tasks);
            _dbContext.SaveChanges();
            return true;
        }

        public Tasks GetById(int id)
        {
            return _dbContext.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public Tasks ToggleComplete(int id, bool isCompleted)
        {
            Tasks tasks = GetById(id);
            if (tasks == null)
            {
                throw new Exception("A Tarefa não existe!!");
            }

            tasks.IsCompleted = isCompleted;
            _dbContext.Tasks.Update(tasks);
            _dbContext.SaveChanges();

            return tasks;
        }

        public Tasks Update(Tasks _task)
        {
            Tasks tasks = GetById(_task.Id);

            if (tasks == null)
            {
                throw new Exception("A Tarefa não existe!!");
            }

            tasks.Title = _task.Title;
            tasks.Description = _task.Description;
            tasks.DueDate = _task.DueDate;
            tasks.IsCompleted = _task.IsCompleted;

            _dbContext.Tasks.Update(tasks);
            _dbContext.SaveChanges();

            return tasks;
        }

        Tasks ITasksRepository.Add(Tasks task)
        {
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
            return task;
        }

        List<Tasks> ITasksRepository.GetAll()
        {
            return _dbContext.Tasks.ToList();
        }


    }
}
