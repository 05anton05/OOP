namespace OOP.Interface
{
    internal class SecuritySystem : ILockable
    {
        public void Lock()
        {
            Console.WriteLine("Автомобіль закрито!");
        }
        public void Unlock()
        {
            Console.WriteLine("Автомобіль відкрито!");
        }
    }
}
