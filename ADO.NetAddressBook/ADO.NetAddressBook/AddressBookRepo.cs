using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetAddressBook
{
    public class AddressBookRepo
    {
        public void CreateDatabase() 
        {
            try
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True;");
                Connection.Open();
                SqlCommand command = new SqlCommand("Create Database AddressBook_ADO;", Connection);
                command.ExecuteNonQuery();
                Console.WriteLine("AddressbookService Database created successfully!");
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void CreateTable()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddressBook_ADO;Integrated Security=True;");
                Connection.Open();
                SqlCommand command = new SqlCommand("Create table AddressBook(id int identity(1,1)primary key,FirstName varchar(200),LastName varchar(200),Address varchar(200), City varchar(200), State varchar(200), Zip varchar(200), PhoneNumber varchar(50), Email varchar(200)); ", Connection);
                command.ExecuteNonQuery();
                Console.WriteLine("AddressBook table has been  created successfully!");
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
