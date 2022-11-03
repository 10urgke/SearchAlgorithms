namespace SearchAlgorithms;

public class BinarySearch
{
    public static int binarySearch(int[] arr, int l, int r, int x)
    {
        if (r >= l) {
            int mid = l + (r - l) / 2;
 
            //  Ortanca eleman varsa ortadaki elemanı dönüyoruz.
            if (arr[mid] == x)
                return mid;
 
            // Öğe ortada bulunan elemandan küçükse, yalnızca sol alt dizide bulunabilir
            if (arr[mid] > x)
                return binarySearch(arr, l, mid - 1, x);
 
            // Aksi halde eleman yalnızca sağ alt dizide bulunabilir.
            return binarySearch(arr, mid + 1, r, x);
        }
 
        // Dizide eleman olmadığında buraya dönüyoruz.
        return -1;
    }
}