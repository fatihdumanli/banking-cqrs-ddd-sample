namespace Customers.Domain.Commands
{
    public class Create : SeedWork.ICommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string PassportNo { get; set; }
    }
}