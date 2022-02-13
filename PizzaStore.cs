namespace SimplePizzaFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(){
            this.factory = new SimplePizzaFactory();
        }

        public void OrderPizza(string type, int number = 1){
            this.factory.CreatPizza(type, number);
        }

        public void Main(){
         // Customer order a Capriciosa and 2 Diavola Verace
           OrderPizza("Capriciosa");
           OrderPizza("DiavolaVerace", 2);
        }
    }
}   