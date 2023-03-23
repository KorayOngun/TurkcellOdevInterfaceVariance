namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICovariant<Base> baseCovariant = null;
            ICovariant<Child> chieldCovariant = null;
            




        }
    }
}




interface ICovariant <out T>
{
    T GetValue();
}
interface IContravariant<in T>
{
    void GetValue(T t);
}
class Base
{
    void DoSomething()
    {
        Console.WriteLine("...");
    }
}

class Child : Base
{

}