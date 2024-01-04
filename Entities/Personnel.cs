using System.ComponentModel.DataAnnotations;

namespace SCPFilesAPI.Entities
{
    public class Personnel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Classification { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
