namespace NullablleTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2024, 3, 5);
            DateTime? date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;

            if(date != null)
            {
                date2 = date.GetValueOrDefault();
            } else
            {
                date2 = DateTime.Today;
            }

            Console.WriteLine(date);
            Console.WriteLine(date2);
            Console.WriteLine(date3.GetValueOrDefault());
        }
    }
}