using System.ComponentModel.DataAnnotations;

namespace ExamNet104.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float rating { get; set; }
    }
}
