public class EjemlpoStringConcatenacion {
    public static void main(String[] args)
    {
        String curso = "Programación Java";
        String profesor = "Antonio Narvaez";

        String detalle = curso + " con el instructor " + profesor + " ";
        System.out.println("detalle = " + detalle);

        int numeroA = 10;
        int numeroB = 5;

        System.out.println(detalle + numeroA + numeroB); //detalle + 10 + 5 = detalle 105
        System.out.println(detalle + (numeroA + numeroB));// detalle + (10+5) = detalle 15
        System.out.println(numeroA + numeroB + detalle);
        
        String detalle2 = curso.concat(" con ").concat(profesor);
        System.out.println("detalle2 = " + detalle2);

        //Formas de concatenación "+" ".concat(param)"

    }
}
