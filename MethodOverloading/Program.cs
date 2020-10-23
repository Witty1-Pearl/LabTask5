using System;

public class demo {
    public static int mulDisplay(int one, int two) {
        return one * two;
    }

    public static int mulDisplay (int one, int two, int three) {
        return one * two * three;
    }
    public static int mulDisplay (int one, int two, int three, int four) {
        return one * two * three * four;
    }


}


public class program {
    public static void Main() {
        Console.WriteLine("Multiplication of two numbers: "+demo.mulDisplay(10, 15));
        Console.WriteLine("Multiplication of three numbers: "+demo.mulDisplay(8, 13, 20));
        Console.WriteLine("Multiplication of four numbers: "+demo.mulDisplay(3, 7, 10, 7));
    }
}