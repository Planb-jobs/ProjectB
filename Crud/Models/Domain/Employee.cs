namespace Crud.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Tarun { get; set; }

        public string Email { get; set; }
        public string Salary { get; set; }

        public DateTime DOB { get; set; }
        public string Department { get; set; }
    }
}
