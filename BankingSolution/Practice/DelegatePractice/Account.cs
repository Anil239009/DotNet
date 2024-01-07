namespace Balance;


public class Account{
    public event Handler notify;
    public event Handler underBalance;
    public event Handler overBalance;
    public  float balance{set;get;}

    public Account(float bal){
        this.balance=bal;
    }

    public void Withdraw(float amount){
        balance-=amount;
        notify();
        if(balance<=5000){
            underBalance();
        }

    }

    public void Deposit(float amount){
        balance+=amount;
        notify();
        if(balance>=250000){
            overBalance();
        }
    }

}