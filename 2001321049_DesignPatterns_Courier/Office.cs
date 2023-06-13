sealed class Office
{
    private readonly Queue<Package> _packages;
    private static readonly Lazy<Office> officeLazy = new Lazy<Office>(() => new Office());
    public static Office Instance { get { return officeLazy.Value; } }
    private Office()
    {
        _packages = new Queue<Package>();
    }
    public void AddPackage(Package package) => _packages.Enqueue(package);
    public void ProcessPackages(PackageHandler handler)
    {
        while (_packages.Count >= 1)
        {
            var package = _packages.Dequeue();
            Console.WriteLine($"Package to {package.Destination} send for processing to {handler.GetType().FullName}");
            var result = handler.Handle(package);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
