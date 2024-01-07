using Banking;
NotificationManager mgr=new NotificationManager();

Account acct123=new Account(5000);
//Event Binding

//Attach event handler with event of object
//This Act of Subscription
acct123.notify+=new Handler(mgr.SendEmail);
acct123.notify+=new Handler(mgr.SendSMS);
acct123.underBalance+=new Handler(mgr.BlockAccount);
acct123.overBalance+=new Handler(mgr.PayIncomeTax);

acct123.Deposit(460000);
//acct123.Withdraw(61000);

float remainingBalance=acct123.Balance;
Console.WriteLine("Remaining Balance={0}",remainingBalance);