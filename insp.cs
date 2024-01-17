
/*

public interface Kuslar{
    void uc();
    void yuz();
    void beslen();
}

public class Guvercin : Kuslar{

    public void uc(){
    }
    public void yeme(){
    }

}

public class Penguen :  Kuslar{

    public void uc(){
    }
    public void yeme(){
    }

}
*/

public interface Flyable
{
    void fly();
}

public interface CanHunt{
    void Hunt();
}
public interface CanSwim{
    void yuz();
}

public class Guvercin : Flyable{
    public void fly(){}
}

public class Penguen : CanHunt, CanSwim{
    public void Hunt(){}
    public void yuz(){}
}