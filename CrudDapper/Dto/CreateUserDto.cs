namespace CrudDapper.Dto
{
    public class CreateUserDto
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }

        public string CPF { get; set; }

        public string Password { get; set; }
        public bool Situation { get; set; }
    }
}
