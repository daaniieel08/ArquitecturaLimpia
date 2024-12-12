using NorthWind.Entities.ValueObjects;

namespace NorthWind.Entities.Interfafaces
{
    public interface IUserActionWriter
    {
        void Write(UserAction action);
    }
}
