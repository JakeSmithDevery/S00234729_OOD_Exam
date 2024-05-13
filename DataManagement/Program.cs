using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S00234729_OOD_Exam;

namespace DataManagement
{
    internal class Program
    {
        //Script to make database Q1(g)
        static void Main(string[] args)
        {
            Customer c1 = new Customer() { Name = "Tom Jones", ContactNumber = "086-123 4567" };
            Customer c2 = new Customer() { Name = "Mary Smith", ContactNumber = "086 546 3214" };
            Customer c3 = new Customer() { Name = "Jo Doyle", ContactNumber = "087 1221 222" };

            // Database creation
            try
            {
                using (var context = new RestarauntData("OODExam_JakeSmithDevery"))
                {
                    //database is created if none exsist
                    context.Database.CreateIfNotExists();

                    // Add Customers to the database
                    context.Customers.Add(c1);
                    context.Customers.Add(c2);
                    context.Customers.Add(c3);

                    // Save changes
                    context.SaveChanges();

                    Console.WriteLine("Customers added to the database successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating database: {ex.Message}");
            }
        }
    }
}
