namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Contact contact = new Contact()
            {
                FirstName = "Pankaj",
                LastName = "kumar",
                Address = "Banglore",
                City = "Whitefield",
                State = "Karnatika",
                Zip = 560048,
                PhoneNumber = "8825178849",
                Email = "pankajroman187@gmail.com"
            };
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.Email);
        }
    }
}

        
    
