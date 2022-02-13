namespace SimplePizzaFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(){
            this.factory = new SimplePizzaFactory();
        }

        public void OrderPizza(string type, int number = 1){
            Pizza pizza;

            pizza = this.factory.CreatPizza(type, number);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        public void Main(){
         // Customer order a Capriciosa and 2 Diavola Verace
           OrderPizza("Capriciosa");
           OrderPizza("DiavolaVerace", 2);
        }
    }
}   