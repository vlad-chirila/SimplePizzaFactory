namespace SimplePizzaFactory
{
    public class SimplePizzaFactory{
        public Pizza CreatPizza(string type, int number){
            if(type=="Capriciosa"){
                return new PizzaCapriciosa(number);
            }else if(type=="DiavolaVerace"){
                return new PizzaDiavolaVerace(number);
            }
                return new PizzaMargerita(number);
        }
    }
}