namespace binarysearchtreeprogram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hash Table and Bst problem");
            binarytree<int> binarySearch = new binarytree<int>(56);
            binarySearch.Add(30);
            binarySearch.Add(70);
            binarySearch.Display();
        }
    }
}