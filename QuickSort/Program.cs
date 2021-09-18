using System.Linq;

class QuickSort
{
	static int Partition(int[] array, int low, int high)
	{
		//1. Select a pivot point.
		int pivot = array[high];

		int lowIndex = (low - 1);

		//2. Reorder the collection.
		for (int j = low; j < high; j++)
		{
			if (array[j] <= pivot)
			{
				lowIndex++;

				int temp = array[lowIndex];
				array[lowIndex] = array[j];
				array[j] = temp;
			}
		}

		int temp1 = array[lowIndex + 1];
		array[lowIndex + 1] = array[high];
		array[high] = temp1;

		return lowIndex + 1;
	}

	static void Sort(int[] array, int low, int high)
	{
		array.ToList().ForEach(x => System.Console.Write(x));
		System.Console.WriteLine("");
		if (low < high)
		{
			int partitionIndex = Partition(array, low, high);
			//3. Recursively continue sorting the array
			Sort(array, low, partitionIndex - 1);
			Sort(array, partitionIndex + 1, high);
		}
	}

	public static void Main()
	{
		int[] array = { 1,3,2,10,12,11,9,5,8,7,6,4 };

		int length = array.Length;

		Sort(array, 0, length - 1);
	}
}