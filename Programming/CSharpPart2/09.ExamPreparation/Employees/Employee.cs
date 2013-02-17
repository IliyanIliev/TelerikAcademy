using System;
using System.Text;
using System.Collections.Generic;

class Employees
{
    public class Employee
    {
        public string firstName;
        public string secondName;
        public int points;

        public Employee(string first, string second, int points)
        {
            this.firstName = first;
            this.secondName = second;
            this.points = points;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.firstName, this.secondName);
        }
    }
    static void Main()
    {
        Dictionary<string, int> positions = new Dictionary<string, int>();
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            GetPositionPoints(positions);
        }

        number = int.Parse(Console.ReadLine());
        Employee[] employees = new Employee[number];
        for (int i = 0; i < number; i++)
        {
            GetEmployee(employees, i, positions);
        }

        Array.Sort(employees, (x, y) =>
        {
            if (y.points.Equals(x.points))
            {
                if (y.secondName.Equals(x.secondName))
                {
                    return x.firstName.CompareTo(y.firstName);
                }
                else
                {
                    return x.secondName.CompareTo(y.secondName);
                }
            }
            else
            {
                return y.points.CompareTo(x.points);
            }
        });

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }

    private static void GetEmployee(Employee[] employees, int i, Dictionary<string, int> positions)
    {
        string[] input = Console.ReadLine().Split('-');
        employees[i] = new Employee(input[0].Split(' ')[0].Trim(), input[0].Split(' ')[1].Trim(), positions[input[1].Trim()]);

    }

    private static void GetPositionPoints(Dictionary<string, int> positions)
    {
        string[] input = Console.ReadLine().Split('-');
        if (!positions.ContainsKey(input[0].Trim()))
        {
            positions.Add(input[0].Trim(), int.Parse(input[1].Trim()));
        }

    }
}