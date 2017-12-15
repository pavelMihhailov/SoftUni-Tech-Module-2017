package todolist.entity;

import javax.persistence.*;

@Entity
@Table(name = "tasks")
public class Task {
	private Integer Id;

	private String Title;

	private String Comments;

    public Task() {
    }

    public Task(String title, String comments) {
        Title = title;
        Comments = comments;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return Id;
    }

    public void setId(Integer id) {
        Id = id;
    }

    @Column(nullable = false)
    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    @Column(nullable = false)
    public String getComments() {
        return Comments;
    }

    public void setComments(String comments) {
        Comments = comments;
    }
}
