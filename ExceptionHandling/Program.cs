using System;
namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            //
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // try/catch for read file
            //try
            //{
            //    using (var streamReader = new StreamReader(@"C:\Users\TriNghia-Dev-26\Downloads\new 11.txt"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //        Console.WriteLine(content);
            //    }
            //} catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred");
            //}


            // Try/catch for divide
            //try
            //{
            //    var cal = new Calculator();
            //    var res = cal.Divide(5, 0);
            //    Console.WriteLine(res);
            //} 
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An unexpected error occurred");
            //}
        }
    }
}