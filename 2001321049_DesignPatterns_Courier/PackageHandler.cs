public abstract class PackageHandler : IPackageHandler
{
    private IPackageHandler _nextHandler;
    public IPackageHandler SetNext(IPackageHandler handler)
    {
        _nextHandler = handler; return handler;
    }
    public virtual string Handle(Package package)
    {
        if (_nextHandler == null)
        {
            return $"Package for {package.Destination} not processed";
        }
        return _nextHandler.Handle(package);
    }
}
public class PlovdivPackageHandler : PackageHandler
{
    public override string Handle(Package package)
    {
        Console.WriteLine($"Processing package in {nameof(PlovdivPackageHandler)}");
        if (package == InvalidPackage.Instance)
        {
            return "Invalid Package - will not process";
        }
        if (package?.Destination == Package.Destinations.Plovdiv)
        {
            return $"Processing package for {Package.Destinations.Plovdiv}";
        }
        return base.Handle(package);
    }
}
public class BulgariaPackageHandler : PackageHandler
{
    public override string Handle(Package package)
    {
        Console.WriteLine($"Processing package in {nameof(BulgariaPackageHandler)}");
        if (package == InvalidPackage.Instance)
        {
            return "Invalid Package - will not process";
        }
        if (package?.Destination == Package.Destinations.Bulgaria)
        {
            return $"Processing package for {Package.Destinations.Bulgaria}";
        }
        return base.Handle(package);
    }
}
public class ExportPackageHandler : PackageHandler
{
    public override string Handle(Package package)
    {
        Console.WriteLine($"Processing package in {nameof(ExportPackageHandler)}");
        if (package == InvalidPackage.Instance)
        {
            return "Invalid Package - will not process";
        }
        if (package?.Destination == Package.Destinations.Export)
        {
            return $"Processing package for {Package.Destinations.Export}";
        }
        return base.Handle(package);
    }
}