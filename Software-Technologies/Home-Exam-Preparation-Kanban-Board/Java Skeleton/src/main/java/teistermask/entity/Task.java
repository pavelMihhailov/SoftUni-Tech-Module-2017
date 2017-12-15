package teistermask.entity;

import javax.persistence.*;

@Entity
@Table(name = "tasks")
public class Task {

    private Integer Id;

    private String Title;

    private String Status;

    public Task() {
    }

    public Task(String title, String status) {
        Title = title;
        Status = status;
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
    public String getStatus() {
        return Status;
    }

    public void setStatus(String status) {
        Status = status;
    }
}
