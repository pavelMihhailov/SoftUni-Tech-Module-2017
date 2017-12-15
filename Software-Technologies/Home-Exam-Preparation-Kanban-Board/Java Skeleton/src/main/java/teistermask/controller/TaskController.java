package teistermask.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import teistermask.bindingModel.TaskBindingModel;
import teistermask.entity.Task;
import teistermask.repository.TaskRepository;

import java.util.List;
import java.util.stream.Collectors;

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

		List<Task> openTasks = tasks.stream()
				.filter(t -> t.getStatus()
						.equals("Open"))
				.collect(Collectors.toList());

		List<Task> inProgressTasks = tasks.stream()
				.filter(t -> t.getStatus()
						.equals("In Progress"))
				.collect(Collectors.toList());

		List<Task> finishedTasks = tasks.stream()
				.filter(t -> t.getStatus()
						.equals("Finished"))
				.collect(Collectors.toList());

		model.addAttribute("openTasks", openTasks);
		model.addAttribute("inProgressTasks", inProgressTasks);
		model.addAttribute("finishedTasks", finishedTasks);
		model.addAttribute("view", "task/index");
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
				taskBindingModel.getStatus()
		);
		this.taskRepository.saveAndFlush(taskEntity);

		return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		Task taskEntity = this.taskRepository.findOne(id);

		if (taskEntity == null) return "redirect:/";

		model.addAttribute("view", "task/edit");
		model.addAttribute("task", taskEntity);

		return "base-layout";
	}

	@PostMapping("/edit/{id}")
	public String editProcess(@PathVariable int id, TaskBindingModel taskBindingModel) {
		Task taskEntity = this.taskRepository.findOne(id);

		if (taskEntity == null) return "redirect:/";

		taskEntity.setTitle(taskBindingModel.getTitle());
		taskEntity.setStatus(taskBindingModel.getStatus());

		this.taskRepository.saveAndFlush(taskEntity);

		return "redirect:/";
	}
}
