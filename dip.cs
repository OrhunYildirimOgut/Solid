/*
public class Uyuma{

    public void uyu(){
    }

}

public class EveGit{

    public void eve() { }

}

public class Insan{
    Uyuma u = new Uyuma();
    EveGit git = new EveGit();

    public void gunlukRutin(){
        u.uyu();
        git.eve();
    }
}
*/

public interface Eylem
{
    void eylemeGec();
}

public class Uyuma : Eylem{

    public void eylemeGec()
    {
        uyu();
    }

    public void uyu() {
    }
}

public class EveGit : Eylem
{
    public void eylemeGec()
    {
        eve();
    }
    public void eve() { }
}

public class Insan
{
    private List<Eylem> activities;

    public Insan(List<Eylem> activities)
    {
        this.activities = activities;
    }

    public void gunlukRutin()
    {
        for (Eylem activity : activities)
        {
            activity.eylemeGec();
        }

    }
}