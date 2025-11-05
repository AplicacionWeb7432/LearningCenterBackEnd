namespace learningcenter.Publishing.Domain.Model.Entities;

public class Category
{
    public string Name { get; set; }
    public int Id { get; set; }
    
    public Category(string name)
    {
        Name = name;
    }

    public Category()
    {
        Name = string.Empty;
    }

}