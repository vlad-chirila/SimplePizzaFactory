namespace SimplePizzaFactory
{
    internal class PizzaMargerita : Pizza
    {
        public PizzaMargerita(int number){
            this.Number = number;
            Console.WriteLine(number + " Pizza Margerita has been ordered.");
        }
    }
}