namespace SimplePizzaFactory
{
    internal class PizzaCapriciosa : Pizza
    {
        public PizzaCapriciosa(int number){
            this.Number = number;
            Console.WriteLine(number + " Pizza Capriciosa has been ordered.");
            this.Prepare();
            this.Bake();
            this.Cut();
            this.Box();
        }
    }
}