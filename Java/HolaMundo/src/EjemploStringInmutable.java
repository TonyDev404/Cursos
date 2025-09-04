public class EjemploStringInmutable {
    public static void main(String[] args) {
        String curso = "Programación Java";
        String profesor = "Antonio Narvaez";

        String resultado = curso.concat(profesor);
        System.out.println("curso = " + curso);
        System.out.println("resultado = " + resultado);
        System.out.println(curso == resultado);

        String resultado2 = curso.transform((c) -> {
            return c + " con " + profesor;
        });
        //No se modifica, solo crea una nueva instancia
        System.out.println("curso = " + curso);
        System.out.println("resultado2 = " + resultado2);

        String resultado3 = resultado.replace("a", "A"); //Tenemos que guardar el reslutado en una variable para ver el cambio
        System.out.println("resultado = " + resultado);
        System.out.println("resultado3 = " + resultado3);
    }
}
