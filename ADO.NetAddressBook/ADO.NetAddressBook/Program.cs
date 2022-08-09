namespace ADO.NetAddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook ADO.NET Program");
            Console.WriteLine("1.Create AddrssBookServiceDatabase");
            Console.WriteLine("2.Create AddressBook Table in the database");
            int choice = Convert.ToInt16(Console.ReadLine());
            AddressBookRepo addressBookRepo = new AddressBookRepo();

            switch (choice) 
            {
                case 1:
                    addressBookRepo.CreateDatabase();
                    break;
                case 2:
                    addressBookRepo.CreateTable();
                    break;

            }
        }
    }
}