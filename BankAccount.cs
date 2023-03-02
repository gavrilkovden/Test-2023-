using System;
using System.Collections.Generic;
using System.Text;

namespace BankTask
{
    //    Task: Create a C# program that models a simple bank account.
    //    The program should include a BankAccount class that has the following properties and methods:

    //AccountNumber(string): The account number, which should be generated automatically when the account is created.
    //Owner(string): The name of the account owner.
    //Balance(decimal): The current balance of the account.
    //Deposit(decimal amount): Adds the specified amount to the account balance.
    //Withdraw(decimal amount): Subtracts the specified amount from the account balance, but only if the resulting balance would not be negative.
    //ToString(): Returns a string representation of the account, in the format "Account {AccountNumber} owned by {Owner} has a balance of {Balance:C}".

    //    Задача: Создайте программу на C#, которая моделирует простой банковский счет.
    //    Программа должна включать класс BankAccount, который обладает следующими свойствами и методами:
    //Номер счета(строка): Номер счета, который должен быть сгенерирован автоматически при создании учетной записи.
    //Владелец(строка): имя владельца учетной записи.
    //Баланс(десятичный): Текущий баланс счета.
    //Депозит(десятичная сумма): Добавляет указанную сумму к балансу счета.
    //Вывод(десятичная сумма): Вычитает указанную сумму из баланса счета, но только в том случае, если результирующий баланс не будет отрицательным.
    //toString(): Возвращает строковое представление учетной записи в формате "Учетная запись {Номер счета}, принадлежащая {Владельцу}, имеет баланс {Баланс:C}".
    class BankAccount
    {
        string AccountNumber { get; set; }
        string owner;
        decimal deposit;
        decimal withdraw;

        public string Owner
        {
            get => owner;
            set => owner = value;
        }

        public decimal Balance
        {
            get => deposit - withdraw;
        }

        public decimal Deposit
        {
            get => deposit;
            set => deposit = deposit + value;
        }

        public decimal Withdraw
        {
            get => withdraw;
            set
            {
                if (Balance >= value)
                {
                    withdraw = withdraw + value;
                }
                else
                {
                    throw new ArgumentException("There are not enough funds in our account");
                }
            }
        }

        public BankAccount(string owner)
        {
            int[] arrayNumbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                arrayNumbers[i] = random.Next(10);
            }
            foreach (var n in arrayNumbers)
            {
                AccountNumber = AccountNumber + n;
            }
            Owner = owner;
        }

        public override string ToString()
        {
            return $"Account {AccountNumber} owned by {Owner} has a balance of {Balance:C}";
        }
    }
}
