
public class Main {
    public static void main(String[] args) {
        var t1 = new ThaiRidgeback(Color.BLACK,Size.MEDIUM,5,true,"Thailine");
        t1.printInfo();
        t1.bark();
        t1.run();
        t1.bite();
        System.out.println(t1);
        System.out.println( t1 instanceof IAnimal);
        System.out.println( t1 instanceof Mammalis);

        var t2 =new ThaiRidgeback(Color.WHITE,Size.MEDIUM,5,true,"Thailne");

        System.out.println(t1.equals(t2));

        var h1 = new HummingBird(Color.WHITE,Size.SMALL,"Bird Egg");

        h1.printInfo();
        h1.eat();
        h1.fly();
        h1.sound();
        System.out.println(h1);


        var A1 = new AngelFish(Color.WHITE,Size.SMALL,"FreshWater","Amazon");
        A1.printInfo();
        A1.eat();
        A1.swimming();
        A1.sound();
        System.out.println(A1);



    }
}

enum Color {
    BLACK,WHITE,BROWN,DARK_BROWN,BLACK_STRIPES,WHITE_STRIPES
}
enum Size{
    SMALL,MEDIUM,LARGE,HUGE
}
interface IAnimal{
    void sound();
    void eat();

    default void printInfo(){
        System.out.println("-----Class Info :"+this.getClass() +" ------");
    }

}
interface IMammalis{
    void run();
}
interface IDog{
    void bark();
    void bite();
}
interface IAves{
    void fly();
}
interface IOsteicthyes{
    void swimming();
}

 abstract class Animal implements IAnimal{
    protected Color color;
    protected Size  size;

    public Animal(Color color,Size size){
        this.color=color;
        this.size = size;


    }

     @Override
     public String toString() {
         return " color =" + color + ", size = " + size  ;
     }
 }


class Mammalis extends Animal implements IMammalis{
    protected int numberBabies;

    Mammalis(Color color,Size size,int numberBabies){
        super(color,size);
        this.numberBabies=numberBabies;
    }


    @Override
    public void sound() {
        System.out.println("The Mammalis sound ");
    }

    @Override
    public void eat() {
        System.out.println("Mammalis eat");

    }

    @Override
    public void run() {
        System.out.println("Mammalis run");

    }

    @Override
    public String toString() {
        return super.toString() + " ,Babies = "+numberBabies;
    }
}
class Aves extends  Animal implements IAves{
    public Aves(Color color, Size size) {
        super(color, size);
    }

    @Override
    public void sound() {
        System.out.println("Aver Sound");
    }

    @Override
    public void eat() {

        System.out.println("Aves eat ");

    }
    @Override
    public void fly(){
        System.out.println("The Bird Flies");
    }
}
class Osteicthyes extends Animal implements IOsteicthyes{
    public Osteicthyes(Color color, Size size) {
        super(color, size);
    }

    @Override
    public void sound() {
        System.out.println("fish sound");

    }

    @Override
    public void eat() {
        System.out.println("fish eat");
    }
    @Override
    public void swimming(){
        System.out.println("The fish swims" );
    }
}

class Dog extends Mammalis implements IDog{
    protected boolean fierce;

    public Dog(Color color, Size size, int numberBabies, boolean fierce) {
        super(color, size, numberBabies);
        this.fierce = fierce;
    }

    @Override
    public void bark() {
        System.out.println("Dog : Woof Woof");
    }

    @Override
    public void eat() {
        System.out.println("Dog eats meat.");
    }

    @Override
    public void bite() {
        if (fierce) System.out.println("The dog bites!");
        else System.out.println("The dog is gentle.");


    }

    @Override
    public String toString() {
        return super.toString() + " ,Fierce = " + fierce;
    }
}

class Bird extends Aves {
    protected String egg;

    public Bird(Color color, Size size, String egg) {
        super(color, size);
        this.egg = egg;
    }

    @Override
    public void sound() {
        System.out.println("Chirp Chirp");
    }

    @Override
    public void eat() {
        System.out.println("Bird eats seeds.");
    }

}
class Fish extends Osteicthyes{
    protected String waterGroup;

    public Fish(Color color, Size size, String waterGroup) {
        super(color, size);
        this.waterGroup = waterGroup;
    }
    @Override
    public void sound() {
        System.out.println("Blub Blub");
    }

    @Override
    public void eat() {
        System.out.println("Fish eats plankton.");
    }
}
class ThaiRidgeback extends Dog {
   protected String origin;


    public ThaiRidgeback(Color color, Size size, int numberBabies, boolean fierce, String origin) {
        super(color, size, numberBabies, fierce);
        this.origin = origin;
    }

    @Override
    public String toString() {
        return super.toString()+ ", Origin: " + origin;
    }
}

class HummingBird extends Bird {
    public HummingBird(Color color, Size size, String egg) {
        super(color, size, egg);
    }
}

class AngelFish extends Fish {
    protected String location;

    public AngelFish(Color color, Size size, String waterGroup, String location) {
        super(color, size, waterGroup);
        this.location = location;
    }
}