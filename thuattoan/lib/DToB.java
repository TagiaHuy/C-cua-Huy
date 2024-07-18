import java.util.Scanner;
public class DToB {
    public static String dToB(double x) {
        return String.format("%.2f", x);
    }
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double x = scanner.nextDouble(); //
        System.out.println(dToB(x)); // Output: 11010000.01
    }
}