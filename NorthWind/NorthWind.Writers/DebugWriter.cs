using System.Diagnostics;
using NorthWind.Entities.Interfafaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Writers
{
   public class DebugWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Debug.WriteLine("ConsoleWriter: {0}, {1}, {2}",
               action.CreateDateTime, action.User, action.Dercription);
        }
    }
}
