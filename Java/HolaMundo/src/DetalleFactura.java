import java.util.Scanner;

public class DetalleFactura {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Escriba el nombre de la factura o descripcion");
        String datos = scanner.nextLine();

        System.out.println("Introduce el precio del producto");
        double price1 = scanner.nextDouble();

        System.out.println("Introduce el precio del segundo producto");
        double price2 = scanner.nextDouble();

        var totalBruto = price1 + price2;
        var impuesto = totalBruto * 0.19;
        var total = totalBruto + impuesto;
        System.out.println(
                "La factura " + datos +
                        " tiene un total bruto de " + totalBruto +
                        ", con un impuesto de " + impuesto +
                        " y el monto despues de impuesto es de " + total);
    }
}
