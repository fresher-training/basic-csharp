// See https://aka.ms/new-console-template for more information
/*
 * Create 4 objects: user, product, cart, order - database schema 
 * Create SQL Adappter: AppDbAdapter - insert, update, delete, select
 * Create cart service: add product to user's cart
 * Create order service: create user order - add products from user's cart to order; delete products in cart
 */

using basic_csharp.SQLAdapter;
using System.Text;

string a = "";
a += "1312312";

StringBuilder b = new StringBuilder();
b.Append(1312312);
b.ToString();

List<string> list = new List<string>() { "1", "2", "3", "4", "5" };
for (int i = 0; i < list.Count; i++)
{
    if (list[i] == "3")
    {
        Console.WriteLine(list[i]);
    }
}

Console.WriteLine(list.Where(a=>a == "3").FirstOrDefault());

UserSQLAdapter.Num1 = 2;

Console.WriteLine(UserSQLAdapter.Num1);
Console.WriteLine(b.ToString());
Console.ReadLine();
