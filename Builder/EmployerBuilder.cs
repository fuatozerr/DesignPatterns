namespace Builder
{
    public abstract class EmployerBuilder
    {
        protected Employee Employee { get; set; }
        public EmployerBuilder()
        {
            Employee = new Employee();
        }

        public abstract void SetName(string name);
        public abstract void SetMail(string emailAddress);
        public Employee BuildEmployee() => Employee;

    }
}
