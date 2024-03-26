namespace dotnetBank;

public class dotnetBank 
{
    public bool logged;
    public int loggedUser;
    public int[,] Bank;

    private int maxAccounts = 50;
    public int registredAccounts;
    public dotnetBank()
    {
        Bank = new int[maxAccounts, 4];
        loggedUser = -99;
        logged = false;
        registredAccounts = 0;
    }
    public void RegisterAccount(int number, int agency, int pass)
    {

    }
}
