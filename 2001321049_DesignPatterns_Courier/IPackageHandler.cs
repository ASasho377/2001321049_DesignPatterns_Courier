public interface IPackageHandler
{
    IPackageHandler SetNext(IPackageHandler handler);
    string Handle(Package package);
}

