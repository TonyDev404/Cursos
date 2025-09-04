public class EjemlpoString {
    public static void main(String[] args)
    {
        String curso = "Programación Java";
        String curso2 = new String("Programación Java");
        
        boolean esIgual = curso == curso2; //Compara el objeto
        System.out.println("curso == curso2 = " + esIgual);
        
        esIgual = curso.equals(curso2); //Compara el valor
        System.out.println("curso.equals(curso2) = " + esIgual);

        String curso3 = "Programación Java";
        esIgual = curso == curso3;
        System.out.println("curso == curso3 = " + esIgual);
    }
}
