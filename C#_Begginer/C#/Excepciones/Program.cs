 
 try
 {
     string content = File.ReadAllText(@"C:\Users\ironm\Documents\pato.txt");
     Console.WriteLine(content);

     // string content2 = File.ReadAllText(@"C:\Users\ironm\Documents\pato2.txt");
     // Console.WriteLine(content2);

     throw new Exception("Ocurrio algo raro");
 }
 catch (FileNotFoundException e)
 {
     Console.WriteLine("El archivo no existe");
 }
 catch (Exception ex)
 {
     Console.WriteLine(ex.Message);
 }
 finally
 {
     Console.WriteLine("Aqui me he ejecutado, pase lo que pase");
 }

 Console.WriteLine("Aqui se sigue ejecutando");