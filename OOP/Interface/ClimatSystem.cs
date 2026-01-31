namespace OOP.Interface
{
    internal class ClimatSystem : IStopable
    {
        public void Stop()
        {
            Console.WriteLine("Агов, на дворі зима!, Кондиціонер вимкнуто!");
        }
    }
}
