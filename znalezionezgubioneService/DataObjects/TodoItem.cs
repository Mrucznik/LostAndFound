using Microsoft.Azure.Mobile.Server;

namespace znalezionezgubioneService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}