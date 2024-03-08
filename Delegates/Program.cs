namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PhotoProcessor photoProcess = new();
            //photoProcess.Process("photo.jpg");
            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();
            Action<Photo> filterHandler = filter.ApplyBrighness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}