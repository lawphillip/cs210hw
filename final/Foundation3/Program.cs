using System;

class Program
{
    static void Main(string[] args)
    {
        
        Lecture lecture = new Lecture("Tom Wolfe, Man of Letters, Man of Words","Writer of many award winning non-fiction novels and seasoned reporter talks on his experiences through out his life","May 3rd 2023","8:30pm",new Address("Lincoln Center Plaza","New York","NY", "USA"), "Tom Wolfe", 1085);
        Outdoor outdoor = new Outdoor("Coachella 2024","Featuring Lana Del Ray and Tyler the Creator with a total of 88 artists Coachella is the biggest music celebration of the Year","April 12st-12th & 19th - 21st","9am-2pm",new Address("81-800 51st Ave","Indio","California", "USA"), "Partly Cloudy");
        Reception reception = new Reception("Bob and Jenna's wedding Reception","To celebrate the wedding of Bob and Jenna after 6 years of dating they come together please come to celebrate","June 1st 2024","4pm",new Address("9 big horse rd","nashville","Tennessee", "USA"), "Bob1234@bmail.com");
        Console.WriteLine(lecture.displayStandard());
        Console.WriteLine(lecture.displayfull());
        Console.WriteLine(lecture.displayshort());
        Console.WriteLine(outdoor.displayStandard());
        Console.WriteLine(outdoor.displayfull());
        Console.WriteLine(outdoor.displayshort());
        Console.WriteLine(reception.displayStandard());
        Console.WriteLine(reception.displayfull());
        Console.WriteLine(reception.displayshort());


    }
}