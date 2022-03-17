namespace MaxNumber.Domain
{
    public class NumberProcessor
    {
        public int FindSecondMaxNumber(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            var secondMaxNumber = numbers[numbers.Length - 2];
            return secondMaxNumber;
        }
    }
}