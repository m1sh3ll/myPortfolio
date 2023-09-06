public class TestVariables {

  public static void main(String[] args) {
    int apples = 50;
    int goneBad = 5;
    int rotten = 20;
    int sold = 20;

    apples -= goneBad;
    apples -= rotten;
    apples -= sold;
    System.out.print("Apples: ");
    System.out.println(apples);

    int score = 0;
    int goal = 1;
    score += goal;
    score += goal;
    score += goal;
    score += goal;

    System.out.print("Score: ");
    System.out.println(score);

    int foo = 2;
    int bar = foo - 6;
    foo += bar;

    System.out.print("Foo: ");
    System.out.println(foo);
    System.out.print("Bar: ");
    System.out.println(bar);

    int year = 2010;
    String winner = "Spain";
    String announcement = "The winner of the " + year + " world cup are " + winner;
    System.out.println(announcement);

    System.out.println("Part 2-----------------------------------------------");
    String course = "chemistry";
    char grade = 'B';
    System.out.println("I got a " + grade + " in " + course);

    int fans = 50000;
    long cellsInHumanBody = 372000000000L;
    int usaPopulation = 328200000;
    System.out.println(2.0 / 5);

    double decimal = 20.0;
    int integer = (int) decimal;
    System.out.println(integer / 6);

    apples = 5;
    int bananas = 10;
    System.out.println("John has " + apples + bananas + " fruits");

    System.out.println(487 % 32);
    System.out.println(487 / 32);

  }
}
