using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Random rng = new Random();

        // Queue
        Queue<string> names = new Queue<string>();

        names.Enqueue("Mike");
        names.Enqueue("Jacob");
        names.Enqueue("Gabriel");
        names.Enqueue("Kenny");
        names.Enqueue("Jake");

        if(names.Contains("Jacob")) Console.WriteLine("Jacob is part of the names queue");
        Console.WriteLine();

        Console.WriteLine("There are {0} names in queue.", names.Count());

        foreach(string name in names) Console.WriteLine(name);

        names.Dequeue();
        Console.WriteLine();

        Console.WriteLine("There are {0} names in queue.", names.Count());

        foreach (string name in names) Console.WriteLine(name);

        // PriorityQueue
        PriorityQueue<string, uint> customers = new PriorityQueue<string, uint>();

        customers.Enqueue("Joe", 89);
        customers.Enqueue("Henry", 9);
        customers.Enqueue("Elizabell", 39);
        customers.Enqueue("Jackson", 21);
        customers.Enqueue("Eli", 18);

        Console.WriteLine("There are {0} customers\n", customers.Count);

        while (customers.TryDequeue(out string item, out uint priority))
        {
            Console.WriteLine("Dequeued Item: {0} Priority: {1}", item, priority);
        }

        Console.WriteLine("There are {0} customers\n", customers.Count);

        // Stack
        Stack<DateTime> visited = new Stack<DateTime>();

        visited.Push(new DateTime(2023, 8, 12));
        visited.Push(new DateTime(2023, 8, 10));
        visited.Push(new DateTime(2023, 6, 7));
        visited.Push(new DateTime(2023, 6, 5));
        visited.Push(new DateTime(2023, 5, 3));

        if(visited.Contains(new DateTime(2023, 6, 7)))
        {
            Console.WriteLine("Someone visited on June 7th, 2023");
        }

        visited.Pop();

        Console.WriteLine("There are {0} items on the stack", visited.Count);

        foreach(DateTime date in visited)
        {
            Console.WriteLine("Visited: {0}", date.ToShortDateString());
        }

        Console.WriteLine();

        // Linked List
        LinkedList<int> ids = new LinkedList<int>();

        for(int i=0;i<5;i++) ids.AddLast(i + 1);

        Console.WriteLine("First ID #{0}", ids.First.Value);
        Console.WriteLine("Last ID #{0}", ids.Last.Value);

        ids.Remove(ids.Find(2)); // Remove

        ids.AddBefore(ids.Find(4), 78); // Add to middle

        foreach (int id in ids)
        {
            Console.WriteLine("ID #{0}", id);
        }

        // Dictionary
        // Name (string) score (uint)
        Dictionary<string, uint> gamePlayers = new Dictionary<string, uint>();

        gamePlayers.Add("JESS", 48180);
        gamePlayers.Add("ALEX", 81180);
        gamePlayers.Add("MOE", 180);
        gamePlayers.Add("WILL", 14023);
        gamePlayers.Add("JMES", 6023);

        gamePlayers.Remove("MOE");

        Console.WriteLine("Displaying all {0} players", gamePlayers.Count);

        foreach(string key in gamePlayers.Keys)
        {
            Console.WriteLine("Player: {0}", key);
        }

        foreach (uint _value in gamePlayers.Values) Console.WriteLine("Score: {0}", _value);

        // Sorted List
        SortedList<string, uint> groceries = new SortedList<string, uint>();

        groceries.Add("lettuce", 3);
        groceries.Add("tomatos", 5);
        groceries.Add("spinach", 2);
        groceries.Add("milk", 1);
        groceries.Add("hot dogs", 4);

        foreach(string key in groceries.Keys)
        {
            Console.WriteLine("Item: {0}", key);
        }

        string prompt = string.Empty;
        bool loop = true;

        while(loop)
        {
            Console.Write("Enter grocery name ");
            prompt = Console.ReadLine();

            if(groceries.ContainsKey(prompt))
            {
                Console.WriteLine("An item with that name already exists, please enter a different value.");
            } else
            {
                Console.Write("Enter amount ");
                uint amt = uint.Parse(Console.ReadLine());
                groceries.Add(prompt, amt);

                loop = false;
            }
        }

        groceries.Remove("milk");

        foreach(KeyValuePair<string, uint> item in groceries)
        {
            Console.WriteLine("Item: {0} Amount: {1}", item.Key, item.Value);
        }

        // Hash Set
        HashSet<decimal> prices_today = new HashSet<decimal>(); // first
        HashSet<decimal> prices_today2 = new HashSet<decimal>(); // third
        HashSet<decimal> prices_tomorrow = new HashSet<decimal>(); // second

        prices_today.Add(19.99M);
        prices_today.Add(14.03M);
        prices_today.Add(7.63M);
        prices_today.Add(1.43M);
        prices_today.Add(9.00M);

        prices_today2.Add(8.33M);
        prices_today2.Add(1.00M);
        prices_today2.Add(2.05M);
        prices_today2.Add(6.33M);
        prices_today2.Add(12.83M);

        prices_tomorrow.Add(19.99M);
        prices_tomorrow.Add(9.99M);
        prices_tomorrow.Add(9.00M);
        prices_tomorrow.Add(6.29M);
        prices_tomorrow.Add(3.19M);

        prices_today.UnionWith(prices_tomorrow);

        foreach(decimal price in prices_today)
        {
            Console.WriteLine("Price: ${0}", price);
        }

        HashSet<decimal> dupes = new HashSet<decimal>(prices_today);

        dupes.IntersectWith(prices_tomorrow);

        Console.WriteLine("Amount of dupes {0}", dupes.Count);

        foreach (decimal price in dupes) Console.WriteLine("Dupe Price: ${0}", price);

        // List
        List<double> grades = new List<double>();

        grades.Add(89);
        grades.Add(90);
        grades.Add(93);
        grades.Add(82);
        grades.Add(62);

        grades.AddRange(new double[] { 92, 78, 99, 87, 97 });
        grades.Sort();

        foreach(double grade in grades)
        {
            Console.WriteLine("Grade: {0}", grade);
        }

        grades.Remove(62);
        Console.WriteLine();
        grades.Reverse();

        foreach (double grade in grades)
        {
            Console.WriteLine("Grade: {0}", grade);
        }
    }
}