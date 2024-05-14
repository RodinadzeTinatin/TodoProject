using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Todo.Contracts;
using Todo.Entities;
using Todo.Models;
using Todo.Service.Exceptions;

namespace Todo.Service.Implementations
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        public TodoService(ITodoRepository todoRepository, IAuthService authService)
        {
            _todoRepository = todoRepository;
            _mapper = MappingInitializer.Initialize();
            _authService = authService;
        }

        public async Task AddTodoAsync(TodoForCreatingDto model)
        {
            if (model is null)
                throw new ArgumentNullException("Invalid argument passed");

            var result = _mapper.Map<TodoEntity>(model);
            await _todoRepository.AddTodoAsync(result);
            await _todoRepository.Save();
        }

        

        public async Task DeleteTodoAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var result = await _todoRepository.GetSingleTodoAsync(x => x.Id == id);

            if (result == null)
                throw new TodoNotFoundException();

            _todoRepository.DeleteTodo(result);
            await _todoRepository.Save();
        }

        public async Task<List<TodoForGettingDto>> GetAllTodosAsync()
        {

            var raw = await _todoRepository.GetAllTodosAsync();

            if (raw.Count == 0)
                throw new TodoNotFoundException();

            var result = _mapper.Map<List<TodoForGettingDto>>(raw);
            return result;
        }

        

        public async Task<TodoForGettingDto> GetSingleTodoAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var raw = await _todoRepository.GetSingleTodoAsync(x => x.Id == id);

            if (raw == null)
                throw new TodoNotFoundException();

            var result = _mapper.Map<TodoForGettingDto>(raw);
            return result;
        }

        public async Task<TodoForGettingDto> GetUserSingleTodoAsync(string userId, int id)
        {
            if (id <= 0 || userId == null)
            {
                throw new ArgumentException("Invalid argument passed");
            }
            var raw = await _todoRepository.GetSingleTodoAsync(x=>x.Id == id && x.UserId == userId);

            if (raw == null)
                throw new TodoNotFoundException();

            var result = _mapper.Map<TodoForGettingDto>(raw);
            return result;
        }

        public async Task<List<TodoForGettingDto>> GetUserTodos(string userId)
        {
            if ( userId == null)
            {
                throw new ArgumentException("Invalid argument passed");
            }
            var raw = await _todoRepository.GetAllTodosAsync(x=>x.UserId == userId);

            if (raw.Count == 0)
            {
                throw new TodoNotFoundException();
            }

            var result = _mapper.Map<List<TodoForGettingDto>>(raw);

            return result;

        }

        public async Task UpdateTodoAsync(TodoForUpdatingDto model)
        {
            if (model is null)
                throw new ArgumentNullException("Invalid argument passed");

            var result = _mapper.Map<TodoEntity>(model);
            await _todoRepository.UpdateTodoAsync(result);
            await _todoRepository.Save();
        }


        public async Task AddTodoToUserAsync(TodoForCreatingDto model)
        {

            if (model is null)
                throw new ArgumentNullException("Invalid argument passed");

            var loggedUserId = _authService.GetAuthenticatedUserId();
            var loggedUserRole = _authService.GetAuthenticatedUserRole();
            if (loggedUserRole == "Admin")
            { 
                var result = _mapper.Map<TodoEntity>(model);
                await _todoRepository.AddTodoAsync(result);
                await _todoRepository.Save();
            }
            else if (loggedUserId == model.UserId)
            {
                //model.UserId = loggedUserId;
                var result = _mapper.Map<TodoEntity>(model);
                await _todoRepository.AddTodoAsync(result);
                await _todoRepository.Save();
            }
            else
            {
                throw new UnauthorizedAccessException("Users can add ToDos only to themselves. ");
            }
        }

        public async Task DeleteUsersTodoAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var result = await _todoRepository.GetSingleTodoAsync(x => x.Id == id);

            if (result == null)
                throw new TodoNotFoundException();

            var loggedUserId = _authService.GetAuthenticatedUserId();
            var loggedUserRole = _authService.GetAuthenticatedUserRole();

            if (loggedUserRole == "Admin" || loggedUserId == result.UserId)
            {
                _todoRepository.DeleteTodo(result);
                await _todoRepository.Save();
            }
            else
            {
                throw new UnauthorizedAccessException("Users can add ToDos only to themselves. ");
            }
        }
    }
}
