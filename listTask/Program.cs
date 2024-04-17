namespace listTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Custom<int> custom = new Custom<int>();
                custom.Add(23);
                custom.Add(12);
                custom.Add(33);
                custom.Add(40);
                custom.Add(20);
                custom.Add(50);
            custom.ShowElements();
            Console.WriteLine("-----------");


            int findElement = custom.Find(x => x == 40);
            Console.WriteLine(findElement);
            Console.WriteLine("-------------");

            List<int> findElements=custom.FindAll(x => x>23);
            foreach (var element in findElements)
            {
                Console.WriteLine(element);
            }




        }
    }
}
