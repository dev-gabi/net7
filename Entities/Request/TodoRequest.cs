namespace Entities.Request
{
    public class TodoRequest
    {
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        public Todo ConvertToTodoDbEntity()
        {
            return new Todo()
            {
                  IsComplete = IsComplete,
                   Name = Name
            };
        }
    }
}
