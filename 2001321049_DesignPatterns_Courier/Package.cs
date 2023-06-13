public class Package
{
    public string? Destination { get; set; }
    public Package() { }
    public Package(string? destination)
    {
        Destination = destination;
    }
    public static class Destinations
    {
        public const string Plovdiv = "Plovdiv";
        public const string Bulgaria = "Bulgaria";
        public const string Export = "Export";
    }
}
public sealed class InvalidPackage : Package
{
    private static readonly InvalidPackage instance = new InvalidPackage { Destination = null };
    static InvalidPackage() { }
    private InvalidPackage() { }
    public static InvalidPackage Instance => instance;
}