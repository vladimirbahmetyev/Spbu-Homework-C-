namespace Hw13
{
    /// <summary>
    /// Класс программы, которая включает в себя
    /// функцию сортировки матрицы в порядке возрастания
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Сортирует матрицу в порядке возрастания
        /// </summary>
        public static void Sort(int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                int minNumber = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minNumber = j;
                    }
                }
                array[minNumber] = array[i];
                array[i] = min;
            }
        }

        public static void Main(string[] args)
        {
        }
    }
}
