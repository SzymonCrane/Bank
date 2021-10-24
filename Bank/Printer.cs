﻿using System;
namespace Bank
{
    public class Printer : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane konta:");
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);
            Console.WriteLine("Typ: {0}", account.TypeName());
            Console.WriteLine("Saldo: {0}zł", account.GetBalance());
            Console.WriteLine("Imię i nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine("PESEL właściciela: {0}", account.Pesel);
            Console.WriteLine();
        }
    }
}