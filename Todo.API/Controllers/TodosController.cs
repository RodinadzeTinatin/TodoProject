using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Todo.Contracts;
using Todo.Models;
using Todo.Service.Exceptions;

namespace Todo.API.Controllers
{
    [Route("api/todos")]
    [ApiController]
    [Authorize]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        private readonly IAuthService _authService;
        private ApiResponse _response;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
            _response = new();

        }

        //TODO შექმენით endpoint რომელიც ბაზაში დაამატებს ახალ საქმეს რომელიმე კონკრეტული user - ისთვის (გაითვალისწინეთ რომ დაადოთ შემდეგი ვალიდაცია: user  - მა საქმის წაშლა უნდა მოახერხოს მხოლოდ საკუთარი თავისთვის თუ ის არ არის ადმინი)
        //TODO შექმენით endpoint რომელიც ბაზიდან წაშლის უკვე არსებულ საქმეს რომელიც გაწერილია რომელიმე user - ზე (გაითვალისწინეთ რომ დაადოთ შემდეგი ვალიდაცია: user  - მა საქმის წაშლა უნდა მოახერხოს მხოლოდ საკუთარი თავისთვის თუ ის არ არის ადმინი)


        [HttpGet]
        public async Task<IActionResult> AllTodos()
        {
            try
            {
                var result = await _todoService.GetAllTodosAsync();
                _response.IsSuccess = true;
                _response.Result = result;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }

            return StatusCode(_response.StatusCode, _response);
        }


        [HttpGet("{userId}/todos")]
        public async Task<IActionResult> UserTodos(string userId)
        {
            try
            {
                var result = await _todoService.GetUserTodos(userId);
                _response.IsSuccess = true;
                _response.Result = result;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (ArgumentException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch (TodoNotFoundException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }

            return StatusCode(_response.StatusCode, _response);
        }

        [HttpGet("{userId}/todos/{id}")]
        public async Task<IActionResult> UserSingleTodo(string userId, int id)
        {
            try
            {
                var result = await _todoService.GetUserSingleTodoAsync(userId, id);
                _response.IsSuccess = true;
                _response.Result = result;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch(ArgumentException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }
            return StatusCode(_response.StatusCode, _response);

        }
        [HttpPost("add")]
        public async Task<IActionResult> AddTodoToUser([FromForm] TodoForCreatingDto model)
        {
            try
            {
                await _todoService.AddTodoToUserAsync(model);
                _response.IsSuccess = true;
                _response.Result = model;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Todo added to user successfully";
            }
            catch(ArgumentNullException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch(UnauthorizedAccessException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.Unauthorized);
                _response.Message = ex.Message;
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }
            return StatusCode(_response.StatusCode, _response);

        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUsersTodo(int id)
        {
            try
            {
                await _todoService.DeleteUsersTodoAsync(id);
                _response.IsSuccess = true;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Todo deleted successfully";
            }
            catch (ArgumentNullException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch(TodoNotFoundException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (UnauthorizedAccessException ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.Unauthorized);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }
            return StatusCode(_response.StatusCode, _response);
        }
    }

}

