// Console.WriteLine("goodbye world!");

BankAccount account = new BankAccount(1);
// newBankAccount("new bank account");

// account.balance = 100;
try{
  account.makeDeposit(-13);
  
}catch (Exception ex) {
  Console.WriteLine(ex.Message);

}

Console.Write($"Your account balance is: ${account.getBalance()} ");
Console.WriteLine($"Account Number: {account.accountNumber}");
