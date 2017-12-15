package todolist.bindingModel;

public class TaskBindingModel {

    private String Title;

    private String Comments;

    public TaskBindingModel() {
    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    public String getComments() {
        return Comments;
    }

    public void setComments(String comments) {
        Comments = comments;
    }
}
