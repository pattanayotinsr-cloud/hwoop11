using System;
using System.Globalization;

namespace cs_oophw11;

public class Program
{
    public static void Main(string[] args)
    {
       ThiaRidgeBack t1 = new ThiaRidgeBack(Color.BLACK,Size.MEDIUM,5,true,"TH");
       HummingBird   h1 = new HummingBird(Color.WHITE_STRIPES,Size.SMALL,"Bird Egg");
       AngelFish     a1 = new AngelFish(Color.WHITE,Size.SMALL,"FreshWater","Amazon");
      

      ((IAnimal)t1).PrintInfo();
      t1.Bark();
      t1.Bite();
      t1.Eat();
      t1.Run();
      Console.WriteLine(t1.ToString());
      Console.WriteLine("--------------------------------------------------");

      

      ((IAnimal)h1).PrintInfo();
      h1.Eat();
      h1.Sound();
      h1.Fly();
      Console.WriteLine(h1.ToString());
      Console.WriteLine("--------------------------------------------------");

      ((IAnimal)a1).PrintInfo();
      a1.Eat();
      a1.Sound();
      a1.Swimming();
      Console.WriteLine(h1.ToString());
      Console.WriteLine("--------------------------------------------------");

      Console.WriteLine(t1);
      Console.WriteLine(t1.Equals(a1));
      Console.WriteLine(t1 is ThiaRidgeBack);
      Console.WriteLine(t1 is Mammalis);
      Console.WriteLine(t1 is Animal);



    }



}

public enum Color
{
    BLACK,WHITE,GREY,BROWN,DARK_BROWN,BLACK_STRIPES,WHITE_STRIPES
}
public enum Size{
    SMALL,MEDIUM,LARGE,C
}

public abstract class Animal : IAnimal
{
    protected Color color;
    protected Size size;

    public Animal(Color color,Size size)
    {
        this.color = color;
        this.size= size;
    }

    public abstract void Sound();
    public abstract void  Eat();

    public override string ToString()
    {
        return $"Color = {color} , Size = {size}";
    }



}

public class Mammalis : Animal , IMammalis
{
    protected int numberBabies;

    public Mammalis(Color color,Size size,int numberBabies) 
    :base(color, size)
{
    this.numberBabies= numberBabies;
}

    public override void Sound()
    {
        Console.WriteLine("Mammalis Sound");

    }
    public override void Eat()
    {
        Console.WriteLine(" Mammalis Eating");
    }

    public void Run()
    {
        Console.WriteLine("Mammalis  Running");
    }

    public override string ToString()
    {
        return base.ToString() + $" numberBabies = " + numberBabies;
    }
}

public class Aves : Animal, IAves
{
    public Aves(Color color,Size size ) : base(color,size){}

    public override void Sound()
    {
        Console.WriteLine("Aves Sound");
    }

    public override void Eat()
    {
        Console.WriteLine("Aves Eating");

    }
    public void Fly()
    {
        Console.WriteLine("Bird Flies");
    }

}

public class  Osteicthyes : Animal,IOsteicthyes
{
    public Osteicthyes(Color color,Size size ) : base(color,size){}

    public override void Sound()
    {
        Console.WriteLine("Fish Sound");
    }

    public override void Eat()
    {
        Console.WriteLine("Fish Eating");

    }
    public void Swimming()
    {
        Console.WriteLine("Fish Swimming");
    }

}


public class Dog : Mammalis,IDog
{
    protected Boolean fierce;

    public Dog(Color color,Size size ,int numberBabies , Boolean fierce) : base(color,size,numberBabies)
    {
        this.fierce = fierce;
    }

    public void Bark()
    {
         Console.WriteLine("เสียง Woof Woof ");
    }

    public bool Bite()
    {
        if (fierce)
        {
            Console.WriteLine("มีนิสัยดุร้าย");
            return true;
        }
        else
        {
            Console.WriteLine("มีนิสัยออนโยน");
            return false; 
        }
    }


 
}

public class Bird : Aves
{
    protected String egg;

    public Bird(Color color,Size size, String egg ) : base(color, size)
    {
        this.egg = egg;
    }

    public override string ToString()
    {
        return base.ToString() +$", Egg : "+ egg;
    }
    
}

public class Fish : Osteicthyes
{
    protected String waterGroup;

    public Fish(Color color,Size size,String waterGroup ) : base(color, size)
    {
        this.waterGroup = waterGroup;
    }

    public override string ToString()
    {
        return base.ToString()+$" , waterGroup : " + waterGroup;
    }
}

public class ThiaRidgeBack : Dog
{
    protected String origin;

    public ThiaRidgeBack(Color color,Size size ,int numberBabies , Boolean fierce, String origin) 
    : base(color, size, numberBabies, fierce)
    {
        this.origin = origin;
    }
    public override void Eat()
    {
        Console.WriteLine("อาหารสัตว์กินเนื้อ");
    }

    public override string ToString()
    {
        return base.ToString()+$" , Origin  : " + origin;
    }
}

public class HummingBird : Bird
{
    public HummingBird(Color color,Size size, String egg ) : base(color, size,egg){}

    public override void Sound()
    {
        Console.WriteLine("เสียง Hummmmmm...");
    }

    public override void Eat()
    {
        Console.WriteLine("อาหาร นํ้าหวานจากดอกไม้ ");
    }
}

public class AngelFish : Fish
{
    protected String location;

    public AngelFish(Color color,Size size,String waterGroup,String location ) : base(color, size, waterGroup)
    {
        this.location = location;
    }
     public override void Sound()
    {
        Console.WriteLine("เสียง ไม่มีเสียง");
    }

    public override void Eat()
    {
        Console.WriteLine("อาหาร สัตว์นํ้าขนาดเล็ก พืชในนํ้า ");
    }

    public override string ToString()
    {
        return base.ToString()+$" , Location :" + location;
    }

}
