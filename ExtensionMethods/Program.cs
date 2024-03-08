namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed tobe a very long blog post ...";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 2, 5, 19, 250, 11, 44, 99};
            var max = numbers.Max();

            Console.WriteLine(max);
        }
    }
}