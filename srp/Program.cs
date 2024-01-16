/*public class Kus
{
    Boolean amIFly;
    int fleshCount;
    public Kus() { }

    public void fly()
    {
        amIFly = true;
    }

    public void land()
    {
        amIFly = false;
    }

    public void eat(int fleshNumber)
    {
        fleshCount+= fleshNumber;
        
    }

    public void printflesh()
    {
        Console.WriteLine(fleshCount);
    }

    public void printAmIFly()
    {
        Console.WriteLine(amIFly);
    }


}*/

public class Kus
{
    public Boolean amIFly;
    public int fleshCount;
    public Kus() { }

    public void fly()
    {
        amIFly = true;
    }

    public void land()
    {
        amIFly = false;
    }

    public void eat(int fleshNumber)
    {
        fleshCount += fleshNumber;
    }
}

public class KusPrint
{
    Kus holder;
    public KusPrint(Kus kus)
    {
        holder = kus;
    }

    public void printAmIFly()
    {
        Console.WriteLine(holder.amIFly);
    }

    public void printflesh()
    {
        Console.WriteLine(holder.fleshCount);
    }
}