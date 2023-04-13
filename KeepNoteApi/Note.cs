using System.ComponentModel.DataAnnotations;

namespace KeepNoteApi
{
    public class Note
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
