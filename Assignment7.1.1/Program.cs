namespace Assignment7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] studentGrades = { 97, 88, 67, 100, 75, 98 };
			Console.WriteLine($"Student grades: {string.Join(", ", studentGrades)}");

			SortedGrades(studentGrades);
			Console.WriteLine($"The student grades sorted from lowest to high are: {string.Join(", ", studentGrades)}");
		}

		public static void SortedGrades(int[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				int minValue = i;

				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[j] < array[minValue])
					{
						minValue = j;
					}
				}

				if (minValue != i)
				{
					int tempValue = array[i];
					array[i] = array[minValue];
					array[minValue] = tempValue;
				}
			}
		}
    }
}
