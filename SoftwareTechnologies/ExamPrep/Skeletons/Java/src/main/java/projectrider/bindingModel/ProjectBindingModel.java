package projectrider.bindingModel;

public class ProjectBindingModel {

    private String title;

    private String description;

    private int budget;

    public ProjectBindingModel(){

    }

    public ProjectBindingModel(String title, String description, int budget) {
        this.title = title;
        this.description = description;
        this.budget = budget;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public int getBudget() {
        return budget;
    }

    public void setBudget(int budget) { this.budget = budget;

    }
}
