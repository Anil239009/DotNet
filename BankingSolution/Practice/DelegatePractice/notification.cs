namespace Banking;

public delegate void Handler;

public class NotificationManager{


    public void sendSMS(){
        console.WriteLine("Message has been send to your official contact number")
    }

    public void SendEmail(){
        console.WriteLine("Email send to your official mail Id");

    }

    public void BlockAccount(){
        console.WriteLine("Due to insufficient funds your account has been blocked for now..!");
    }

    public void PayIncomeTax(){
        console.WriteLine("due to higher balance..Income tax has been deducted from your account")
    }
}