namespace MultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banquet[] banquets = new Banquet[3];
            Banquet[] eventexhibition = new Banquet[2];

            GenerateBanquets(banquets);
            GenerateEventExhibition(eventexhibition);
        }

        static void GenerateBanquets(Banquet[] banquets)
        {
            banquets[0] = new Banquet(1, "Mumbai Mahal", 200);
            banquets[1] = new Banquet(2, "Hyderabad Hall", 150);
            banquets[2] = new Banquet(3, "Srinagar Space", 100);

            for (int i = 0; i < banquets.Length; i++)
            {
                banquets[i].Display();
                Console.WriteLine($"Total Earnings: {banquets[i].CalculateEarning()}");
            }
        }

        static void GenerateEventExhibition(Banquet[] eventexhibition)
        {
            eventexhibition[0] = new Event(4, "Music Concert", 200, 250);
            eventexhibition[1] = new Exhibition(5, "Tech Expo", 300, 100, 50);

            for (int i = 0; i < eventexhibition.Length; i++)
            {
                eventexhibition[i].Display();
                Console.WriteLine($"Total Earnings: {eventexhibition[i].CalculateEarning()}");
            }
        }
    }
}
