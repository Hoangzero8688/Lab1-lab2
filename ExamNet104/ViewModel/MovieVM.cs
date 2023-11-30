namespace ExamNet104.ViewModel
{
    public class MovieVM
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float rating { get; set; }

        public string RatingDescription
        {
            get
            {
                return (rating >= 1 && rating < 3) ? "Bad" :
                       (rating >= 3 && rating < 4) ? "Average" :
                       (rating >= 4 && rating <= 5) ? "Good" :
                       "Unknown";
            }
        }

    }
}
