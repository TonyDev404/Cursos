public class EjemploStringExtensionArchivo {
    public static void main(String[] args) {
        String archivo = "alguna_imagen.js";
        int i = archivo.indexOf(".");
        System.out.println("archivo.length() = " + archivo.length());
        System.out.println("archivo.substring(archivo.length() -4) = " + archivo.substring(i +1 )); //le aumentamos uno, porque también toma en cuenta el punto

        String archivo2 = "alguna.imagen.jpg";
        int i2 = archivo.lastIndexOf(".");
        System.out.println("archivo.substring(archivo.length() -4) = " + archivo2.substring(i2 +1 ));
    }
}
