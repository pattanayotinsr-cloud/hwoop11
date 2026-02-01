namespace cs_oophw11;

 public interface IAnimal
{
    void Sound();
    void Eat();

    void PrintInfo()
    {
      Console.WriteLine("-----------------Class Info :" + this.GetType()+ "-----------") ;
    }
}
public interface IMammalis
{
    void Run ();
}

public interface IAves
{
    void Fly();
}

public interface IOsteicthyes
{
    void Swimming();
}

public interface IDog
{
    void Bark();
    bool Bite();
}