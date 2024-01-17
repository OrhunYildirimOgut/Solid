//Elimizde 3 farkli bilgisayar modeli olsun. Hepsinin hesaplama gucleri farkli olsun ve farkli bilgisayar modelleri gelmeye devam etsin
//suan burda ekledikce computer ekledikce duzenlemek gerekiyor calculator methodunu duzenlemeden ekleyerek islem yapabilicek sekilde
//duzenleyecegiz
/*
public class Computer1
{
    private int var1 = 1;
    private int var2 = 2;

    public int getvar1()
    {
        return var1;
    }
    public int getvar2()
    {
        return var2;
    }
}

public class Computer2
{
    private int var1 = 2;
    private int var2 = 4;

    public int getvar1()
    {
        return var1;
    }
    public int getvar2()
    {
        return var2;
    }
}

public class Computer3
{
    private int var1 = 3;
    private int var2 = 6;

    public int getvar1()
    {
        return var1;
    }
    public int getvar2()
    {
        return var2;
    }
}

public class Calculator{
    public int calculate(Object o)
    {
        if (o is Computer1 computer1)
        {
            return computer1.getvar1() + computer1.getvar2();
        }
        else if (o is Computer2 computer2)
        {
            return computer2.getvar1() + computer2.getvar2();
        }
        else if (o is Computer3 computer3)
        {
            return computer3.getvar1() + computer3.getvar2();
        }
        else return -1;
    }
}
*/
public interface Calculate{
    int calculator();
}

public class Computer1 : Calculate{
    private int var1 = 1;
    private int var2 = 2;

    public int calculator(){
        return var1 + var2;
    }
}

public class Computer2 : Calculate{
    private int var1 = 3;
    private int var2 = 4;

    public int calculator(){
        return var1 * var2;
    }
}

public class Computer3 : Calculate{
    private int var1 = 5;
    private int var2 = 6;

    public int calculator(){    
        return var1 - var2; 
    }
}

public class Calculator{
    public int calculate(Calculate calcObject){
        return calcObject.calculator();
    }
}