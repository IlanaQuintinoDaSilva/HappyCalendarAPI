namespace HappyCalendarAPI.Models
{
    public class ReturnModel
    {
        public ReturnModel()
        {
            Success = false;
            Description = "";
            Data = null;
            ErrorCode = 0;
        }

        public object Data { get; set; }

        public bool Success { get; set; }

        public string Description { get; set; }

        public int ErrorCode { get; set; }
    }
}