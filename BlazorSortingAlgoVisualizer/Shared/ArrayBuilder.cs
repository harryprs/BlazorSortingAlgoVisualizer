namespace BlazorSortingAlgoVisualizer.Shared
{
	public class ArrayBuilder
	{
		public int[] GenerateArray(int size)
		{
			int[] array = new int[size];
			Random r = new Random();

			for(int i = 0; i < size; i++)
			{
				array[i] = r.Next(1,500);
			}

			return array;
		}

		public int[] ShuffleArray(int[] array)
		{
			Random r = new Random();
			int n = array.Length;
			while(n > 1)
			{
				int k = r.Next(n--);
				int temp = array[n];
				array[n] = array[k];
				array[k] = temp;
			}
			return array;
		}
	}
}
