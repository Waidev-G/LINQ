using LinqIntro_Waidev;

namespace LinqIntro_Waidev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerData = new CustomerData(new CustomerService());
           

            var customers = customerData.getCusttomer();

           var Filteredcutomers= customers.Filter(x => x.Salary < 40000);
            var Filteredcutomers2 = customers.Filter(x => x.Salary > 40000);
            var Filteredcutomers3 = customers.Filter(x => x.DateOfBirth < DateTime.Now);
            var Filteredcutomers4 = customers.Filter(x => x.FullName.StartsWith("J"));
            customerData.Print(Filteredcutomers);
        }

       
    }
}
