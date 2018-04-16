package projectrider.entity;

import javax.persistence.*;

@Entity
@Table(name = "projects")
public class Project {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    private String title;

    private String description;

    private int budget;

    public Project() {

    }

    public Project(String title, String description, int budget) {
        this.title = title;
        this.description = description;
        this.budget = budget;
    }

    @Column(nullable = false)
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    @Column(nullable = false)
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    @Column(nullable = false)
    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }


    public int getBudget() {
        return budget;
    }

    public void setBudget(int budget) {
        this.budget = budget;
    }
}
