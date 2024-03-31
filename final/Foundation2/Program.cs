using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Bill", new Address("8 bigrig Rd", "Newbuck", "Kentucky", "USA")));
        order1.addproduct("diapers","dia32pk",23.23,4);
        order1.addproduct("toothpaste","tthpst4oz",5.60,3);
        order1.addproduct("bathroom tissue","bthtss24pk",15.76,1);
        Order order2 = new Order(new Customer("Beth", new Address("1224 S 4th E St", "Amsterdam", "North Holland", "Netherlands")));
        order2.addproduct("peanutbutter","pntbttr16oz",6.89,2);
        order2.addproduct("white bread","whtbrdlf",3.45,1);
        order2.addproduct("Raspberry Jam","rspbryjm",4.47,5);
        Console.WriteLine(order1.getpackinglabel());
        Console.WriteLine(order1.getshippinglabel());
        Console.WriteLine($"{order1.totalcost()}");

        Console.WriteLine(order2.getpackinglabel());
        Console.WriteLine(order2.getshippinglabel());
        Console.WriteLine($"{order2.totalcost()}");


    }
}