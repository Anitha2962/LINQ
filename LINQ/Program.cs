using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

class employee
{
    public string Name { get; set; }
    public string Salary { get; set; }
    public string Designation { get; set; }
}
class progam
{
    static void main(string[] args)
    {
        List<employee> employees = new List<employee>()
        {
            new employee() { Name = "anu", Salary = "100000", Designation = "developer" }

        };
        var developer = from e in employees
                        where e.Designation == "developer"
                        select e;
        foreach (var item in developer)
        {
            Console.WriteLine($"{item.Name} {item.Designation}");

        }
    }
}


// LINQ filtering

//var filteredList = from in collection
//    where item.consition==true
//    select item;


// LINQ grouping

//var groupdata = from item in Collection
//                group itemby item.category in to grouped
//                select new { category = grouped.key.items = grouped
//                       };


// LINQ joining

//var joinData= from item A in collecton A
//              join item B in collection B
//              on item A.key equals item B.key
//              select new { item A = Item A, item B = item B };


// LINQ aggregating 

//var sum = Collection.sum(Item => Item.amount);
//var average = Collection.average(Item => Item.average);
//var count = Collection.count();