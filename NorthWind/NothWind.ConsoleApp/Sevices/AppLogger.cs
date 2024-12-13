using NorthWind.Entities.Interfafaces;
using NorthWind.Entities.ValueObjects;


namespace NothWind.ConsoleApp.Sevices
{
    internal class AppLogger(IUserActionWriter writer)
    {
        public void Writelog(string message)
        {
            UserAction Log = new UserAction("System", message);
            writer.Write(Log);
        }
    }
}
