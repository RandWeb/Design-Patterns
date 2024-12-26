namespace ServiceBacnkProject;
//Sub system classes
public interface IAccount
{
    public decimal Amount { get; set; }

    public void Deposit(decimal amount);
    public void WithDraw(decimal amount);
    public void transfer(IAccount account,decimal amount);
    public int GetAccountNumber();
}

public class Chequing : IAccount
{
    public Chequing(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Deposit(decimal amount)
    {
        throw new NotImplementedException();
    }

    public int GetAccountNumber()
    {
        throw new NotImplementedException();
    }

    public void transfer(IAccount account, decimal amount)
    {
        throw new NotImplementedException();
    }

    public void WithDraw(decimal amount)
    {
        throw new NotImplementedException();
    }
}

public class Saving : IAccount
{
    public Saving(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Deposit(decimal amount)
    {
        throw new NotImplementedException();
    }
    public int GetAccountNumber()
    {
        throw new NotImplementedException();
    }

    public void transfer(IAccount account, decimal amount)
    {
        throw new NotImplementedException();
    }

    public void WithDraw(decimal amount)
    {
        throw new NotImplementedException();
    }
}
public class Investment : IAccount
{
    public Investment(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Deposit(decimal amount)
    {
        throw new NotImplementedException();
    }

    public int GetAccountNumber()
    {
        throw new NotImplementedException();
    }


    public void transfer(IAccount account, decimal amount)
    {
        throw new NotImplementedException();
    }

    public void WithDraw(decimal amount)
    {
        throw new NotImplementedException();
    }
}
