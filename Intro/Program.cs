// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

// variables --> camelCase

bool isAuthenticated = false;

Console.WriteLine(message1);

//condition
if (isAuthenticated == true) // == true koymasaydık yine true algılayacaktı
{
    Console.WriteLine("Buton--> Hoşgeldin Eren");
}
else
{
    Console.WriteLine("Buton--> Sisteme Giriş Yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";


//start     condition   increment  
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);

}
/*
Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java 17";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
} */

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}

Console.WriteLine("Kod Bitti");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Eren";
customer1.LastName = "Duran";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678911";
customer2.FirstName = "Ömer";
customer2.LastName = "Duran";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "1234567891";

// Base class lar inherit edildiği class ların referanslarını tutabilirler.
                             //101      //102      //103      //104 
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

// Bütün müşterilerin müşteri numaralarını yazdırmak istiyorum
//polymorphism 
foreach (BaseCustomer customer in customers)
{
  /*  if (customer is IndividualCustomer)
    {
        Console.WriteLine(((IndividualCustomer)customer).NationalIdentity);
    }*/
    Console.WriteLine(customer.CustomerNumber);
}