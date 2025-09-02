public class PrimitivosCaracteres {
    public static void main(String[] args) {
        char caracter = 'A';
        char caracter2 = '\u0040'; //unicode character "@"
        char decimal = 64; //@
        System.out.println("caracter = " + caracter);
        System.out.println("caracter2 = " + caracter2);
        System.out.println("decimal = " + decimal);

        char simbolo = '@';
        System.out.println("simbolo = " + simbolo);
        System.out.println("simbolo = caracter: " + (simbolo == caracter2));
        System.out.println("=========================================================================================");

        char espacio = ' ';
        char espacioU = '\u0020';
        char retroceso = '\b';
        char tabulador = '\t';
        char nuevaLinea = '\n'; //salta la línea
        char retornoCarro = '\r'; //limpia la línea

        System.out.println("char corresponde en byte:"+ espacio + retornoCarro + Character.BYTES);
        System.out.println("char corresponde en bites:"+ espacioU + nuevaLinea + Character.SIZE);
        System.out.println("Character.MIN_VALUE: " + retroceso + Character.MIN_VALUE);
        System.out.println("Character.MAX_VALUE:" + tabulador + Character.MAX_VALUE);
    }
}
