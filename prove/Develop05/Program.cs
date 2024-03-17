using System;
using System.Runtime.CompilerServices;

class Program
{
    static List<Goal> goals;
    static int pointtotal;
    
    static string getname()
    {
        Console.WriteLine("What is the name of your goal?: ");
        string name = Console.ReadLine();
        return name;
    }
    static string getdes()
    {
        Console.WriteLine("What is a short description of your goal?: ");
        string desc = Console.ReadLine();
        return desc;
    }
    static int getreward()
    {
        Console.WriteLine("What is the amount of points associated with your goal?: ");
        int reward = int.Parse(Console.ReadLine());
        return reward;
    }
    static int getgoalcount()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?: ");
        int reward = int.Parse(Console.ReadLine());
        return reward;
    }
    static int getbonusgoal()
    {
        Console.WriteLine("What is the bonus for accomplishing the goal that many times?: ");
        int reward = int.Parse(Console.ReadLine());
        return reward;
    }


    static void Main(string[] args)
    {
        
        var menu = 0;
        var i = 0;
        while(menu != 6){
         Console.WriteLine("Menu Options:\n1. Create new goal\n 2. List Goals\n 3. Save Goals\n 4. Load goals \n 5. Record event \n 6. Quit");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
                i = int.Parse(Console.ReadLine());
                switch(i)
                {
                    case 1:
                    goals.Add(new Simple(getname(), getdes(), getreward()));
                    break;
                    case 2:
                    goals.Add(new Eternal(getname(),getdes(),getreward()));
                    break;
                    case 3:
                    goals.Add(new Checklist(getname(),getdes(), getreward(), getgoalcount(), getbonusgoal()));
                    break;
                    default:
                    Console.WriteLine("That is not an option");
                    break;
                }
                
                break;
                case 2:
                foreach (Goal goal in goals){
                    goal.Display();
                }

                break;

                case 3:
                foreach(Goal goal in goals)
                {
                    
                }
                break;

                case 4:

                break;
                case 5:
                    foreach( Goal goal in goals)
                    {
                        goal.Display();
                    }
                    Console.WriteLine("");
                    int j = int.Parse(Console.ReadLine());
                    pointtotal += goals[j].Awardpoint();
                break;
                case 6:
                break;

                default:
                Console.WriteLine("That is not an option");
                break;
            }
        }
    }
}
// i will have this code finished by 3/19/2024
