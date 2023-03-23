namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



           Base x = new Base();
           Base y = new Derived();
           Derived z = new Derived();

            // Derived : Base
            // IProducer<Derived> : Iproducer<Base>

            IProducer<Base> prodOfBase = null;
            Base a = prodOfBase.Produce();

            IProducer<Derived> prodOfDerived = null;
            Derived b = prodOfDerived.Produce();
            Base c = prodOfDerived.Produce();
            

            // Derived : Base
            // IConsumer<Base> : IConsumer<Derived>

            IConsumer<Base> consumerOfBase = null;
            consumerOfBase.Consume(new Base());
            consumerOfBase.Consume(new Derived());

            IConsumer<Derived> consumerOfDerived = null;
            consumerOfDerived.Consume(new Derived());


            //----------------------------------------------------------------

            // Derived : Base
            // IProducer<Derived> : Iproducer<Base>
            IProducer<Base> p = prodOfBase;
            IProducer<Base> q = prodOfDerived;

            // Derived : Base
            // IConsumer<Base> : IConsumer<Derived>
            IConsumer<Derived> k = consumerOfBase;
            IConsumer<Derived> l = consumerOfDerived;


        }
    }
}




interface IProducer <out T>
{
    T Produce();
}
interface IConsumer<in T>
{
    void Consume(T t);
}
class Base
{
    public  void  DoSomething()
    {
        Console.WriteLine("...");
    }
}

class Derived : Base
{
    public void DoMore()
    {
        Console.WriteLine("........");
    }


}