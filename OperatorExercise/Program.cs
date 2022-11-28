namespace OperatorExercise
{
    public class Program
    {
      
        static void Main(string[] args)

        {

            int x = 5;
            int y = 10;

            int addIng = x += y;
            int subBing = x -= y;
            int mulTing = x *= y;
            int divIng = x /= y;

            int a = 17;
            int b = 4;
            var div = a / b;
            var mod = a % b;


                Console.WriteLine($" {a} divided {b} is {div} and remainder is {mod}");
            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($" The area of a circle with radius of  {r} isn {areaOfCircle} ");

        }
    }
}
