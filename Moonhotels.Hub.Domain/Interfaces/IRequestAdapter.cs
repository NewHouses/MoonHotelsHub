namespace Moonhotels.Hub.Domain.Interfaces
{
    public interface IRequestAdapter
    {

        public IRequest Convert();

        public string ToJson();
    }
}
