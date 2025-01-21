namespace CrudDapper.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }
        public string CPF { get; set; }
        public  double Situation { get; set; } // 1- Active ; 0 - Inactive
        public string Password { get; set; }
    }
}
