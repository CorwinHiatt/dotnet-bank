public class BankAccount{
  public string accountNumber {get; set;} = "";

  // public decimal balance {get; set;} = 0;
  private decimal balance {get; set;}

//constructor
  // public BankAccount(string newAccountName){
  // accountNumber = newAccountName;
  // balance = 1000.01m;
  // }

  public BankAccount(decimal startingBalance){
  accountNumber = "unknown";
  balance = 10001;

  if (startingBalance > 10000) {
    balance = startingBalance + 2000;
  } else {
    balance = startingBalance + 100;

  }
 
  
  }

  public decimal getBalance() {
    return balance;;
  }
  public void makeDeposit(decimal newDeposit) {
    if (newDeposit < 0) {
      // balance = balance;
      throw new Exception("cant perform objective");

    }else {
      balance = balance + newDeposit;

    }
   

  }
}

