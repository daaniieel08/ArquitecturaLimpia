using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.Interfafaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Writers
{
    public class FileWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            File.AppendAllText("AppLogs.txt",
                string.Format("FileWriter: {0}, {1}, {2}",
                action.CreateDateTime, action.User, action.Dercription));
        }
    }
}
