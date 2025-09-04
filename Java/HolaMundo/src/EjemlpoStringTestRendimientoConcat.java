public class EjemlpoStringTestRendimientoConcat {
    public static void main(String[] args)
    {
        String a = "a";
        String b = "b";
        String c = a;

        StringBuilder sb = new StringBuilder(a);


        long inicio = System.currentTimeMillis();

        for(int i = 0; i < 100000; i++)
        {
//            c = c.concat(a).concat(b).concat("\n"); // 500 => 2ms, 1000 => 3ms, 10,000 => 143ms, 100,000 => 4301ms
//            c += a + b + "\n"; //500 => 4, 1000 => 6ms, 10,000 => 110ms, 100,000 => 1876ms
            sb.append(a).append(b).append("\n"); //500 => 0ms , 1000 => 0ms, 10,000 => 7ms, 100,000 => 17ms
        }

        long fin = System.currentTimeMillis();

        System.out.println("c = " + c);
        System.out.println("sb = " + sb.toString());
        System.out.println(fin-inicio);
    }
}
