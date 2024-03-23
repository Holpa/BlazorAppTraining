using BlazorAppTraining.Interface;

namespace BlazorAppTraining.Class
{
    public class TodoService : ITodoService
    {
        private List<TodoItem> _todoItems = new List<TodoItem>();

        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            return await Task.FromResult(_todoItems);
        }

        public async Task AddTodoItemAsync(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public async Task UpdateTodoItemAsync(TodoItem item)
        {
            var existingItem = _todoItems.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Title = item.Title;
                existingItem.IsCompleted = item.IsCompleted;
            }
        }

        public async Task DeleteTodoItemAsync(int id)
        {
            var item = _todoItems.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _todoItems.Remove(item);
            }
        }
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
