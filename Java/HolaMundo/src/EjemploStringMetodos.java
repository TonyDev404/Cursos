public class EjemploStringMetodos {
    public static void main(String[] args) {
        String nombre = "Antonio";

        System.out.println("nombre.length() = " + nombre.length());
        System.out.println("nombre.toUpperCase() = " + nombre.toUpperCase());
        System.out.println("nombre.toLowerCase() = " + nombre.toLowerCase());
        System.out.println("nombre.equals(\"Antonio\") = " + nombre.equals("Antonio")); //True
        System.out.println("nombre.equals(\"antonio\") = " + nombre.equals("antonio")); // False - Java es sensible a minusculas y mayusculas
        System.out.println("nombre.equalsIgnoreCase(\"antonio\") = " + nombre.equalsIgnoreCase("antonio")); //True
        System.out.println("nombre.compareTo(\"Antonio\") = " + nombre.compareTo("Antonio")); //Si es 0 es porque son idénticos
        System.out.println("nombre.compareTo(\"Aaron\") = " + nombre.compareTo("Aaron"));
        System.out.println("nombre.charAt(0) = " + nombre.charAt(0)); //Pasamos el índice
        System.out.println("nombre.charAt(1) = " + nombre.charAt(1));
        System.out.println("nombre.charAt(5) = " + nombre.charAt(5));
        System.out.println("nombre.charAt(5) = " + nombre.charAt(nombre.length() - 1)); //Obtener el último caracter

        System.out.println("nombre.substring(1) = " + nombre.substring(4)); //trae desde "n" en adelante, si queremos todo, es desde 0
        System.out.println("nombre.substring(1, 4) = " + nombre.substring(1, 4));
        System.out.println("nombre.substring(4, 6) = " + nombre.substring(nombre.length() - 1));
        
        String trabalenguas = "trabalenguas";
        System.out.println("trabalenguas.replace(\"a\", \".\") = " + trabalenguas.replace("a", "."));
        System.out.println("trabalenguas = " + trabalenguas);
        System.out.println("trabalenguas.indexOf('a') = " + trabalenguas.indexOf('a')); //devuelve la primera ocurrencia
        System.out.println("trabalenguas.lastIndexOf('a') = " + trabalenguas.lastIndexOf('a')); //devuelve la ulima ocurrencia
        System.out.println("trabalenguas.indexOf('z') = " + trabalenguas.indexOf('z')); //retorna -1 porque no existe
        System.out.println("trabalenguas = " + trabalenguas.contains("t")); //Retorna true o false, pero además debe ser un string, no un char es decir, poner "" no ''
        System.out.println("trabalenguas.startsWith(\"tr\") = " + trabalenguas.startsWith("tr"));
        System.out.println("trabalenguas.endsWith(\"s\") = " + trabalenguas.endsWith("s"));
        System.out.println("  trabalenguas  ");
        System.out.println("  trabalenguas  ".trim()); //quita espacios
    }
}
