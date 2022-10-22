



int[] arr = new int[] { 10, 4, 10, 10, 10, 18, 10 };

int minocurr = Int32.MaxValue;
int maxocurr= Int32.MinValue;
binarySearch(arr, ref minocurr, ref maxocurr, 0, arr.Length - 1, 10);

Console.WriteLine(@$"the minimum occurrent is:{minocurr} \n the maximum occurrence is {maxocurr}");

static void binarySearch(int[] arr, ref int minvalue, ref int maxvalue, int low, int high, int k)
{
    if (low > high)
    {
        return;
    }

    int mid = low + (high - low) / 2;

    if(arr[mid] == k)
    {
        minvalue = Math.Min(minvalue, mid + 1);
        maxvalue = Math.Max(maxvalue, mid + 1); 
    }

    binarySearch(arr, ref minvalue, ref maxvalue, low, mid-1, k);
    binarySearch(arr, ref minvalue, ref maxvalue, mid+1, high, k);




}



