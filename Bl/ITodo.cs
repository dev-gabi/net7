using Entities.Request;
using Entities.response;

namespace Bl
{
    public interface ITodo
    {
        public UiResponse Add(TodoRequest todo);
    }
}
