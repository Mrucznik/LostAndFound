using System;

namespace lostandfoundapp.Classes
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
        public DateTime Date { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}