namespace SimplePizzaFactory
{
    public abstract class Pizza
    {
        public int Number;

        public int Size;

        public virtual void Prepare(){
            Console.WriteLine("Pizza is preparing.");
        }

        public virtual void Bake(){
            Console.WriteLine("Pizza is baking in the oven.");
        }

        public virtual void Cut(){
            Console.WriteLine("Pizza has been cutted in 6 by a ninja.");
        }

        public virtual void Box(){
            Console.WriteLine("Pizza resting in a box.");
        }
    }
}