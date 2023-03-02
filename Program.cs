using System;

namespace BankTask
{
    //    Задача: Создайте программу на C#, которая моделирует простой банковский счет.
    //    Программа должна включать класс BankAccount, который обладает следующими свойствами и методами:
    //Номер счета(строка): Номер счета, который должен быть сгенерирован автоматически при создании учетной записи.
    //Владелец(строка): имя владельца учетной записи.
    //Баланс(десятичный): Текущий баланс счета.
    //Депозит(десятичная сумма): Добавляет указанную сумму к балансу счета.
    //Вывод(десятичная сумма): Вычитает указанную сумму из баланса счета, но только в том случае, если результирующий баланс не будет отрицательным.
    //toString(): Возвращает строковое представление учетной записи в формате "Учетная запись {Номер счета}, принадлежащая {Владельцу}, имеет баланс {Баланс:C}".

    class Program
    {

        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount("Petr");
            bankAccount1.Deposit = 120;
            bankAccount1.Deposit = 120;
            bankAccount1.Withdraw = 40;
            Console.WriteLine(bankAccount1.ToString());


            BankAccount bankAccount2 = new BankAccount("Misha");
            bankAccount2.Deposit = 40;
            bankAccount2.Withdraw = 3;
            Console.WriteLine(bankAccount2.ToString());
        }
    }
}
