namespace SimplePizzaFactory
{
    internal class PizzaDiavolaVerace : Pizza
    {
        public PizzaDiavolaVerace(int number){
            this.Number = number;
            Console.WriteLine(number + " Pizza Diavola Verace has been ordered.");
            this.Prepare();
            this.Bake();
            this.Cut();
            this.Box();
        }
    }
}