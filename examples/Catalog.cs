public sealed record DemoCourse(string Code, string Title);

public interface ICourseCatalog
{
    Task<DemoCourse?> FindAsync(string code, CancellationToken cancellationToken);
}
