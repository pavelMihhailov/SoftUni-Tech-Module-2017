package todolist.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import todolist.bindingModel.TaskBindingModel;
import todolist.entity.Task;
import todolist.repository.TaskRepository;

import java.util.List;

@Controller
public class TaskController {
    private final TaskRepository taskRepository;

    @Autowired
    public TaskController(TaskRepository taskRepository) {
        this.taskRepository = taskRepository;
    }

    @GetMapping("/")
    public String index(Model model) {
        List<Task> tasks = this.taskRepository.findAll();

        model.addAttribute("view", "task/index");
        model.addAttribute("tasks", tasks);

        return "base-layout";
    }

    @GetMapping("/create")
    public String create(Model model) {
        model.addAttribute("view", "task/create");

        return "base-layout";
    }

    @PostMapping("/create")
    public String createProcess(Model model, TaskBindingModel taskBindingModel) {
        Task taskEntity = new Task(
                taskBindingModel.getTitle(),
                taskBindingModel.getComments()
        );
        this.taskRepository.saveAndFlush(taskEntity);

        return "redirect:/";
    }

    @GetMapping("/delete/{id}")
    public String delete(Model model, @PathVariable int id) {
        Task taskEntity = this.taskRepository.findOne(id);

        if (taskEntity == null) return "redirect:/";

        model.addAttribute("view", "task/delete");
        model.addAttribute("task", taskEntity);

        return "base-layout";
    }

    @PostMapping("/delete/{id}")
    public String deleteProcess(Model model, @PathVariable int id) {
        Task taskEntity = this.taskRepository.findOne(id);

        if (taskEntity == null) return "redirect:/";

        this.taskRepository.delete(taskEntity);

        return "redirect:/";
    }
}
