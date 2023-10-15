namespace Builder
{
    public class ExternalEmployee : EmployerBuilder
    {

        public override void SetMail(string emailAddress)
        {
            Employee.Email = emailAddress.Split('@') + "@worldline.com.tr";
        }

        public override void SetName(string name)
        {
            var arr = name.Split(new[] { ' ', '_', '.' });

            Employee.FullName = arr[0] + "fuat";

        }
    }
}
