namespace ApiDemo.Models
{
    public class Contact
    {
        public Guid id
        {
            get;
            set;
        }
        public string? Name
        {
            get;
            set;
        }
        public string? Email
        {
            get;
            set;
        }
        public long Phone
        {
            get;
            set;
        }
        public string? Address
        {
            get;
            set;
        }
    }
}
