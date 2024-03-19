using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Writegoalfile(string nameoffile, List<Goal> goallist)
    {
        var data = "";
        data += $"{pointtotal}\n";
        foreach(Goal hgoal in goallist)
        {
            var typeString = "";
            if (hgoal is Simple)
            {
                typeString = "S:";
            }
            else if (hgoal is Eternal)
            {
                typeString = "E:";
            }
            else if(hgoal is Checklist)
            {
                typeString = "C:";
            }

            data += typeString + hgoal.export() + "\n";
        }
        using (StreamWriter outputFile = new StreamWriter(nameoffile))
        {
            outputFile.Write(data);
        }
    }
    static List<Goal> readGoalFile(string nameoffile)
    {
        var goalie = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(nameoffile);
        pointtotal += int.Parse(lines[0]);
        foreach(string line in lines.Skip(1))
        {
            var typeString = line[0..2];
            if (typeString == "S:")
            {
                goalie.Add(new Simple(line[2..]));
            }
            else if (typeString == "E:")
            {
                goalie.Add(new Eternal(line[2..]));
            }
            else if (typeString == "C:")
            {
                goalie.Add(new Checklist(line[2..]));
            }
        }
        return goalie;
    }
    static List<Goal> goals = new List<Goal>();
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
    static string getfilename()
    {
        Console.WriteLine("What is the filename for the goal file?: ");
        string file = Console.ReadLine();
        return file;
    }


    static void Main(string[] args)
    {
        
        var menu = 0;
        var i = 0;
        while(menu != 6){
        Console.WriteLine($"You have {pointtotal} points\n");
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
                    goals.Add(new Checklist(getname(),getdes(), getreward(), getbonusgoal(), getgoalcount()));
                    break;
                    default:
                    Console.WriteLine("That is not an option");
                    break;
                }
                
                break;
                case 2:
                int bug0 = 1;
                Console.WriteLine("Your goals are:");
                foreach (Goal goal in goals){
                    Console.Write($"{bug0++}. ");
                    goal.Display();
                }

                break;

                case 3:
                Writegoalfile(getfilename(), goals);
                
                break;

                case 4:
                goals = readGoalFile(getfilename());
                break;
                case 5:
                    int bug = 0;
                    Console.WriteLine("Your goals are:");
                    foreach( Goal goal in goals)
                    {
                        bug++;
                        Console.Write($"{bug}. ");
                        goal.Display();
                    }
                    Console.WriteLine("");
                    int j = int.Parse(Console.ReadLine());
                    pointtotal += goals[j-1].Awardpoint();
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
