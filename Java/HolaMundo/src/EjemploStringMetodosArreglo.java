public class EjemploStringMetodosArreglo {
    public static void main(String[] args) {
        String trabalenguas = "trabalenguas";
        System.out.println("trabalenguas.toCharArray() = " + trabalenguas.toCharArray());

        char[] arreglo = trabalenguas.toCharArray();
        int largo = arreglo.length;

        for(var i = 0; i < largo; i++)
        {
            System.out.println("arreglo = " + arreglo[i]);
        }
        System.out.println();
        System.out.println("trabalenguas = " + trabalenguas.split("a"));
        
        String[] arreglo2 = trabalenguas.split("a");
        int l = arreglo2.length;
        for (var i = 0; i < l; i++)
        {
            System.out.println("arreglo2[i] = " + arreglo2[i]);
        }

        System.out.println();
        String archivo = "alguna.imagen.jpg";
        String[] archivoArr = archivo.split("\\."); //La doble diagonal es para indicar un caracter especial pero tambien se puede poner entre []
        l = archivoArr.length;
        for (var i = 0; i < l; i++)
        {
            System.out.println("arreglo2[i] = " + archivoArr[i]);
        }
        System.out.println("extensión = " + archivoArr[l-1]);
//        for (char c : arreglo) {
//            System.out.println("arreglo = " + c);
//        }
    }
}
