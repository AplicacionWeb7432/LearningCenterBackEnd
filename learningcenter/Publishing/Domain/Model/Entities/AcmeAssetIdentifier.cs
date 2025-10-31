namespace learningcenter.Publishing.Domain.Model.Entities;

public record AcmeAssetIdentifier(Guid Idenfier)
{

    public AcmeAssetIdentifier() : this(Guid.NewGuid())
    {
        
    }
}