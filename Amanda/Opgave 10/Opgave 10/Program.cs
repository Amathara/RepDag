namespace Opgave_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Opgave 10
            // Skriv en ugedag
 Console.WriteLine("Hej!\nLad os finde en ugedag\nSkriv et tal mellem 1 og 7");
 int dag = Convert.ToInt32(Console.ReadLine());

 switch(dag)
 {
     case 1:
         Console.WriteLine("Det er Mandag!");
         break;
         case 2:
         Console.WriteLine("Det er Tirsdag!");
         break;
         case 3:
         Console.WriteLine("Det er Onsdag!");
         break;
         case 4:
         Console.WriteLine("Det er Torsdag!");
         break;
         case 5:
         Console.WriteLine("Det er Fredag! (så det snart weekend)");
         break;
         case 6:
         Console.WriteLine("Det er Lørdag! Enjoy!");
         break;
         case 7:
         Console.WriteLine("Det er Søndag!");
         break;



 }
 Console.ReadLine();
}
}
}
