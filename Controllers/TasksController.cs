using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManager.Models;
using TaskManager.Repository;

namespace TaskManager.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITasksRepository _tasksRepository;
        public TasksController(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<Tasks> tasks = _tasksRepository.GetAll();

            return View(tasks);
        }

        public IActionResult Update(int id)
        {
            return View();
        }

        public IActionResult DeleteConfirmation(int id)
        {
            Tasks tasks = _tasksRepository.GetById(id);
            return View(tasks);
        }

        public IActionResult Delete(int id)
        {
            _tasksRepository.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Tasks _tasks)
        {
            _tasksRepository.Update(_tasks);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Tasks tasks)
        {
            _tasksRepository.Add(tasks);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ToggleComplete(int id, bool isCompleted)
        {
            _tasksRepository.ToggleComplete(id, isCompleted);

            return RedirectToAction("Index");
        }

    }
}
