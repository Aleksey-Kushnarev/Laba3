using System;


namespace Lab2
{
    internal class Program
    {
        static void Main()
        {
            double y;
            for (double x = 0.1; x <= 1; x += 0.09)
            {
                double cos = Math.Cos(x);
                y = 2 * (cos * cos - 1);
                double sn = SumRecurrentWithN(40, x);
                double se = SumRecurrentWithAccuracy(0.0001, x);
                Console.WriteLine($"x = {x:f10}\ty = {y:f10}\tsn = {sn:f10}\tse = {se:f10}");
            }


            Console.ReadLine();
        }


        public static double SumRecurrentWithAccuracy(double accuracy, double x)
        {

            double s = 0; // Переменная, в которую будет записываться результат вычеслений
            double fact = 1; // Переменная для рекурентного подсчета факториала
            double degree = 1; // Переменная для подсчета степени
            double one = 1; // Степень -1
            double iter;
            int i = 1;
            do
            {
                fact *= 2 * i * (2 * i - 1);
                degree *= (2 * x) * (2 * x);
                one *= -1;

                iter = degree / fact;
                iter *= one;
                if (Math.Abs(iter) > accuracy)
                {
                    s += iter;
                }
                
                i ++;
                
            } while (Math.Abs(iter) > accuracy);
            
            return s;
        }



        public static double SumRecurrentWithN(int n, double x)
        {
            double s = 0; // Переменная, в которую будет записываться результат вычеслений
            double fact = 1; // Переменная для рекурентного подсчета факториала
            double degree = 1; // Переменная для подсчета степени
            double one = 1; // Степень -1

            for (int i = 1; i <= n; i++)
            {
                fact *= 2 * i * (2 * i - 1);
                degree *= (2 * x) * (2 * x);
                one *= -1;

                double iter = degree / fact;
                iter *= one;
                s += iter;

            }
            return s;
        }

        public static double SumNotRecurrentWithN(int n, double x)
        {
            double s = 0; // Переменная, в которую будет записываться результат вычеслений

            for (int i = 1; i <= n; i++)
            {
                double fact = 1;
                for (int j = 1; j <= 2 * i; j++)
                {
                    fact *= j;
                }
                double degree = Math.Pow((2 * x), (2 * i));
                double one = Math.Pow(-1, i);

                double iter = degree / fact;
                iter *= one;
                s += iter;

            }
            return s;
        }

        public static double SumNotRecurrentWithAccuracy(double accuracy, double x)
        {

            double s = 0; // Переменная, в которую будет записываться результат вычеслений
            double iter;
            int i = 1;
            do
            {
                double fact = 1;
                for (int j = 1; j <= 2 * i; j++)
                {
                    fact *= j;
                }
                double degree = Math.Pow((2 * x), (2 * i));
                double one = Math.Pow(-1, i);

                iter = degree / fact;
                iter *= one;
                s += iter;
                i++;

            } while (iter > accuracy);

            return s;
        }

        public static double ResultFunction(double x)
        {
            double cos = Math.Cos(x);
            double y = 2 * (cos * cos - 1);
            return y;
            
        }

    }

    
}
