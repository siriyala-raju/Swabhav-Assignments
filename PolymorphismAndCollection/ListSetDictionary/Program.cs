namespace ListSetDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(11);
            numbers.Add(22);
            numbers.Add(33);
            numbers.Add(44);
            numbers.Remove(33);
            numbers[1] = 55;

            Console.WriteLine("------List CRUD------");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            HashSet<int> values = new HashSet<int>();
            values.Add(5551);
            values.Add(5552);
            values.Add(5557);
            values.Remove(5552);
            values.Add(5553);
            values.Add(5551);

            Console.WriteLine();
            Console.WriteLine("------Hashset CRUD------");
            foreach (int n in values)
            {
                Console.WriteLine(n);
            }

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Raju");
            students.Add(2, "Ravi");
            students.Add(3, "Santhosh");
            students.Remove(2);
            students[3] = "Dinesh";

            Console.WriteLine();
            Console.WriteLine("------Dictionary CRUD------");
            foreach (KeyValuePair<int,string> kv in students)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
