namespace SearchAlgorithms;

public class LinearSearch
{
    public static int[] arr = { 5, 15, 6, 9, 4 };

    // Dizideki aranacak item icin Recursive Method
    public static int linearsearch(int[] arr, int size, int key)
    {
        if (size == 0) {
            return -1;
        }
        else if (arr[size - 1] == key) {
            // Bulunan anahtarın dizinini döndürün.
            return size - 1;
        }
        else {
            return linearsearch(arr, size - 1, key);
        }
    }
}