namespace ServiceBacnkProject;

//Facade
public class BankService
{
    private Dictionary<int, IAccount> bankAccounts;

    public BankService()
    {
        bankAccounts = new Dictionary<int, IAccount>();
    }

    public int CreateNewAccount(string type, decimal initAmount)
    {
        IAccount newAccount = null;
        switch (type)
        {
            case "chequing":
                newAccount = new Chequing(initAmount);
                break;
            case "saving":
                newAccount = new Saving(initAmount);
                break;
            case "investment":
                newAccount = new Investment(initAmount);
                break;
        }

        if (newAccount != null)
        {
            bankAccounts.Add(newAccount.GetAccountNumber(), newAccount);
            return newAccount.GetAccountNumber();
        }
        return -1;
    }

    public void TransferMoney(int to, int from, decimal amount)
    {
        IAccount toAccount = bankAccounts[to];
        IAccount fromAccount = bankAccounts[from];
        fromAccount.transfer(toAccount, amount);
    }
}
