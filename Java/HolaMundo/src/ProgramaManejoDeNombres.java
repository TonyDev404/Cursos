import java.util.Scanner;

public class ProgramaManejoDeNombres {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Introduce el primer familiar");
        String familiar1 = sc.nextLine();
        System.out.println("Introduce el segundo familiar");
        String familiar2 = sc.nextLine();
        System.out.println("Introduce el tercer familiar");
        String familiar3 = sc.nextLine();

        String[] nombres;

        var familiar1PT1 = familiar1.substring(1, 2).toUpperCase().concat(".");
        var familiar2PT1 = familiar2.substring(1, 2).toUpperCase().concat(".");
        var familiar3PT1 = familiar3.substring(1, 2).toUpperCase().concat(".");

        var familiar1PT2 = familiar1.substring(familiar1.length() - 2);
        var familiar2PT2 = familiar2.substring(familiar2.length() - 2);
        var familiar3PT2 = familiar3.substring(familiar3.length() - 2);

        System.out.println(familiar1PT1 + familiar1PT2 + "_" + familiar2PT1 + familiar2PT2 + "_" + familiar3PT1 + familiar3PT2);



    }
}
