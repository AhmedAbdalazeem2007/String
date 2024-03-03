class Sort_1
{
    public static void selection_sortt<T>(T[] A, T a)
    {
        int min = 0;
        for (int i = 0; i < A.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[j].Equals(A[min]))
                    min = j;
            }
            T swap = A[min];
            A[min] = A[i];
            A[i] = swap;
        }
    }
    public static void selection_sort(int[] A)
    {
        int min = 0;
        for (int i = 0; i < A.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[j] < A[min])
                    min = j;
            }
            int swap = A[min];
            A[min] = A[i];
            A[i] = swap;
        }
    }
    public static int comare_to(int x, int y)
    {
        if (x > y) return 1;
        else if (x < y) return -1;
        return 0;
    }

    public static void insertion_sort(int[] A)
    {
        for (int i = 1; i < A.Length; i++)
        {
            int key = A[i];
            int j = i - 1;
            while (j >= 0 && (comare_to(A[j], key) == 1))
            {
                A[j + 1] = A[j];
                j = j - 1;
            }
            swap(ref A[j + 1], ref key);
        }
    }

    public static void swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
  
}