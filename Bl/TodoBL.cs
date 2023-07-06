using Dal;
using Entities;
using Entities.OptionsConfig;
using Entities.Request;
using Entities.response;
using Microsoft.Extensions.Options;

namespace Bl
{
    public class TodoBL : ITodo
    {
        private readonly TodoDbContext _db;
        private readonly NameConfig _nameConfig;

        public TodoBL(TodoDbContext db, IOptions<NameConfig> nameConfig)
        {
            _db = db;
            _nameConfig = nameConfig.Value;
        }

       
        public UiResponse Add(TodoRequest todo)
        {
            try
            {
                _db.Add(todo.ConvertToTodoDbEntity());
                _db.SaveChanges();
                return Utils.GenerateSuccessResponse();
            }
            catch (Exception)
            {
                return Utils.GenerateErrorResponse();
            }
        }
    }
}