package teistermask.entity;

import com.sun.istack.internal.Nullable;

import javax.persistence.*;

@Entity
@Table(name = "tasks")
public class Task {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public int Id;

    public String title;

    public String status;

    public Task(){

    }

    public Task(String title, String status) {
        title = title;
        status = status;
    }

    public int getId() { return Id; }

    public void setId(int id) { Id = id; }

    @Column(nullable = false)
    public String getTitle() { return title; }

    public void setTitle(String title) { title = title; }

    @Column(nullable = false)
    public String getStatus() { return status; }

    public void setStatus(String status) {
        if (status.equals("Open") || status.equals("In Progress") || status.equals("Finished")){
            this.status = status;
        }
    }
}

