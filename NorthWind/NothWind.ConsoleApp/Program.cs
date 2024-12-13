
using NorthWind.Entities.Interfafaces;
using NorthWind.Writers;
using NothWind.ConsoleApp.Sevices;

IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.Writelog("Aplication started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");
