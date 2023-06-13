public class PackageFactory
{
    public Package Create(string destination)
    {
        if (string.IsNullOrEmpty(destination))
        {
            return InvalidPackage.Instance;
        }
        return new Package
        {
            Destination = destination
        };
    }
}
