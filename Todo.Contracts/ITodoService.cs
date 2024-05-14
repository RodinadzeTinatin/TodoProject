using Todo.Models;

namespace Todo.Contracts
{
    public interface ITodoService
    {
        Task<List<TodoForGettingDto>> GetAllTodosAsync();
        Task<TodoForGettingDto> GetSingleTodoAsync(int id);
        Task AddTodoAsync(TodoForCreatingDto model);
        Task UpdateTodoAsync(TodoForUpdatingDto model);
        Task DeleteTodoAsync(int id);
        Task<List<TodoForGettingDto>> GetUserTodos(string userId);
        Task<TodoForGettingDto> GetUserSingleTodoAsync(string userId,int id);

        Task AddTodoToUserAsync(TodoForCreatingDto model);

        Task DeleteUsersTodoAsync(int id);


    }
}
