using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Final
{
    public class Array
    {
        public float Sum(float[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            float sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public float Multiply(float[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            float product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }
            return product;
        }

        public float Average(float[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            if (numbers.Length == 0)
                throw new ArgumentException();

            return Sum(numbers) / numbers.Length;
        }
    }
}
