
/*

public class Kus{

    public void uc(){
    }
    public void yeme(){
    }

}

public class Guvercin : kus{

    public void uc(){
    }
    public void yeme(){
    }

}

public class Penguen :  kus{

    public void uc(){
    }
    public void yeme(){
    }

}
*/

public interface Flyable{
    void uc();
}

public class Kus{
    public void yeme()
    {
    }
}

public class Guvercin : Kus, Flyable{

    public void uc(){
    }
}

public class Penguen : Kus{

}