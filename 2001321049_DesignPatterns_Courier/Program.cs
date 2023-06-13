var office = Office.Instance;

var desk1 = new PlovdivPackageHandler();
var desk2 = new BulgariaPackageHandler();
var desk3 = new ExportPackageHandler();

desk1.SetNext(desk2).SetNext(desk3);

var factory = new PackageFactory();

var package1 = factory.Create("Plovdiv");
var package2 = factory.Create("Sofia");
var package3 = factory.Create("Bulgaria");
var package4 = factory.Create("Export");
var package5 = factory.Create("");
var package6 = factory.Create(null);

office.AddPackage(package1);
office.AddPackage(package2);
office.AddPackage(package5);
office.AddPackage(package3);
office.AddPackage(package4);
office.AddPackage(package6);

office.ProcessPackages(desk1);