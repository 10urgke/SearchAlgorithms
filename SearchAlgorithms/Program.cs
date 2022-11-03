
using static SearchAlgorithms.LinearSearch;
using static SearchAlgorithms.BinarySearch;

static class Test {
    
    
    public static void Main(String[] args)
    {
        int key = 4;
        
        int index = linearsearch(arr, arr.Length, key);

        if (index != -1)
            Console.WriteLine("Eleman " + key
                                         + " Bulunur " + index
                                         + " Verilen dizinin indeksi");
        else
            Console.WriteLine("Eleman" + key
                                         + " Bulunmaz");
    }
    
    public static void Main2()
    {
 
        int[] arr = { 2, 3, 4, 10, 40 };
        int n = arr.Length;
        int x = 10;
 
        int result = binarySearch(arr, 0, n - 1, x);
 
        if (result == -1)
            Console.WriteLine("Öğe mevcut değil");
        else
            Console.WriteLine("Öğenin bulunduğu dizin"
                              + result);
    }
}
