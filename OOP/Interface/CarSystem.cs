using OOP.Interface;

namespace OOP.Interface
{
    public class CarSystem : IStartable
    {
        public void Start()
        {
            Console.WriteLine("Автомобіль заведено!");
        }
    }
}
