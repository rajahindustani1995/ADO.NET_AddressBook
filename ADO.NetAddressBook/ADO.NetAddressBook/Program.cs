namespace ADO.NetAddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Create AddrssBookServiceDatabase");
            Console.WriteLine("2.Create AddressBook Table in the database");

            Console.WriteLine("3.Add Contact Details in the table");

            int choice = Convert.ToInt16(Console.ReadLine());
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel model = new AddressBookModel();

            switch (choice) 
            {
                case 1:
                    addressBookRepo.CreateDatabase();
                    break;
                case 2:
                    addressBookRepo.CreateTable();
                    break;

                case 3:
                    model.FirstName = "Raj";
                    model.LastName = "Tiwari";
                    model.Address = "Vashi";
                    model.City = "Navi Mumbai";
                    model.State = "Mharashtra";
                    model.Zip = "400079";
                    model.PhoneNumber = "9844739883";
                    model.Email = "raj.tiwari@gmail.com";
                    addressBookRepo.AddContactDetails(model);
                    break;


            }
        }
    }
}