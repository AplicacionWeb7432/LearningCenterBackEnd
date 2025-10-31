namespace learningcenter.Publishing.Domain.Model.Aggregate;

public partial class Tutorial
{
    public Tutorial(string title, string summary, int categoryId) : this()
    {
        Title = title;
        summary = summary;
        CategoryId = categoryId;
    }

    public int Id { get; }
    public string Title { get; private set; }
    
    public string Summary { get; private set; }

    public int CategoryId { get; private set; }

}