using Liberis.Analyzer.Core.Entities;
using Liberis.Analyzer.SharedKernel;

namespace Liberis.Analyzer.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}