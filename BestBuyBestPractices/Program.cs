using BestBuyBestPractices;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

var x = new DapperDepartmentRepository(conn);
Console.WriteLine("What are you interested in?");
var userInput = Console.ReadLine();
x.InsertDepartment(userInput);
var c = x.GetAllDepartments();

foreach (var item in c)
{
    Console.WriteLine(item.Name);
}