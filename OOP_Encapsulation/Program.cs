using OOP_Encapsulation;

BankAccount bankAccount = new BankAccount(1000);

bankAccount.Deposit(1000);
bankAccount.Withdraw(500);

Console.WriteLine(bankAccount.GetBalance());


