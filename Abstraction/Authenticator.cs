public abstract class AuthUser
{
   public string userName;  
   private bool UserValid;
   public bool isUserValid
   {
     get
     {
         return UserValid;
     }
   }
   public AuthUser(string name)
   {
       this.userName = name;
       validateUser();
   }
   private void validateUser()
   {
       var hash = new List<string>();
       hash.Add("Rohit");
       UserValid = hash.Contains(this.userName);
   }

   public abstract void greetUserIfAuthenticated();   
   public abstract void restrictUserIfNotAuthenticated();   
}

public class Client : AuthUser
{
    public override void greetUserIfAuthenticated()
    {
        Console.WriteLine($"Hello client");
    }
    public override void restrictUserIfNotAuthenticated()
    {
        Console.WriteLine($"Hello client, wrong creds");
    }
    public Client(string clientName): base(clientName){}

}

public class DriverCode_Auth
{
    public static void Main(string [] args)
    {

        string [] arr = new string[]{"Rohit", "Rohit S"};
        foreach(var name in arr)
        {
            Client C = new Client(name);
            bool isValid = C.isUserValid;
            if(isValid)
                C.greetUserIfAuthenticated();
            else
            C.restrictUserIfNotAuthenticated();
        }

        Console.WriteLine();
    }
}
