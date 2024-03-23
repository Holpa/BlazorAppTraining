using BlazorAppTraining.Class;

namespace BlazorAppTraining.Interface
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetTodoItemsAsync();
        Task AddTodoItemAsync(TodoItem item);
        Task UpdateTodoItemAsync(TodoItem item);
        Task DeleteTodoItemAsync(int id);
    }
}
