/* Coder by KFY */
namespace CarWashingAutomation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Authority { get; set; } //user,manager,admin
        public int TechnicalSupportable { get; set; }
        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}