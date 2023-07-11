namespace ToDoDragAndDrop.Data
{
    public class ToDo
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        public string Details { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
