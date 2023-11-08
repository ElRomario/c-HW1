using System;


/*Вычисления, ветвления, циклы. Рефлекторы
Срок: к следующему занятию, понедельнику 18 сентября

1. Напишите банковский калькулятор. В программе создаётся переменная, хранящая сумму на вкладе, равная
100 000. Вторая переменная задаёт годовую процентную ставку в 6%. В конце года доход присоединяется ко вкладу.
Из-за этого в следующий год проценты начисляются на новую, увеличенную сумма вклада.

Программа рассчитывает доходность за 1 год, 2 года, 3 года и так далее до 25 лет.

2. Декомпилируйте вашу программу любым рефлектором. В качестве решения приложите файл с декомпилированным кодом.*/
namespace BankCalculatorHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double deposit = 100000;
            const double annualRate = 0.06;

            DepositMultyply(deposit, annualRate);
             

            
        }
        static void DepositMultyply(double deposit, double annualRate)
        {
            Console.WriteLine("Year | Multyplyed Deposit ");
            Console.WriteLine("---------------------------");
            double multyDeposit = deposit;

            for (int i =0; i < 25; i++)
            {
                multyDeposit += multyDeposit * annualRate;
                Print(i, multyDeposit);
            }
        }
        static void Print(double year, double multyDeposit)
        {
            Console.WriteLine($"{year + 2023} | {multyDeposit:0.000} RUB");
        }
    }
}
