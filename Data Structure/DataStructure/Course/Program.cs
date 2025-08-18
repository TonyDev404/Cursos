//Sub without -

// int Sub(int a, int b)
// {
//     var sub = 0;
//
//     for (var i = 0; i <= a; i++)
//     {
//         if (b != a)
//         {
//             b++;
//             sub++;
//         }
//         else if (b == a)
//         {
//             break;
//         }
//     }
//     return(sub);
// }
//  
// //=========================================================================
// //Multply without *
// int Multiply(int a, int b)
// {
//     var multiply = 0;
//
//     for (var i = 0; i < b; i++)
//     {
//         multiply += a;
//     }
//
//     return (multiply);
// }
//
// //=========================================================================
// //Divide without /
//
// var e = 8;
// var f = 2;
// var divide = 0;
//
// for (var k = 0; k <= f; k++)
// {
//     e -= 1;
// }
//
// divide = e;
//
// Console.WriteLine(Sub(5, 1));
// Console.WriteLine(Multiply(5, 2));

// //=========================================================================

CuentaBancaria cuentaTony = new CuentaBancaria(1, 125 , DateTime.Now, false, 0);
cuentaAhorro cuentaAhorroTony = new cuentaAhorro(1, 75, DateTime.Now, false, 0, 5);

cuentaTony.Depositar((decimal)25.50);
cuentaTony.AplicarInteresAnual();
cuentaAhorroTony.AplicarInteresAnual();

class CuentaBancaria
{
    public int IdCliente { get; set; }
    public static decimal Saldo { get; set; }
    public DateTime FechaApertura { get; set; }
    public bool TieneDeuda { get; set; }
    public decimal MontoDeuda { get; set; }

    public CuentaBancaria(int idCliente, decimal saldo, DateTime fechaApertura, bool tieneDeuda, decimal montoDeuda)
    {
        IdCliente = idCliente;
        Saldo = saldo;
        FechaApertura = fechaApertura;
        TieneDeuda = tieneDeuda;
        MontoDeuda = montoDeuda;
    }

    public virtual void AplicarInteresAnual()
    {
        Console.WriteLine("Esta cuenta no genera intereses.");
    }
    public void Depositar(decimal monto)
    {
        if (monto >= 1)
        {
            Saldo += monto;
            Console.WriteLine($"Deposito exitoso!!! Su saldo actual es de {Saldo}");
        }
        else
        {
            Console.WriteLine("El monto a depositar no puede ser menor a 1");
        }
    }
}

class cuentaAhorro : CuentaBancaria
{
    public decimal TasaInteresAnual { get; set; }

    public cuentaAhorro(int idCliente, decimal saldo, DateTime fechaApertura, bool tieneDeuda, decimal montoDeuda, decimal tasaInteres) : base (idCliente, saldo, fechaApertura, tieneDeuda, montoDeuda)
    {
        TasaInteresAnual = tasaInteres ;
    }

    public override void AplicarInteresAnual()
    {
        var interes = TasaInteresAnual / 100;
        Saldo += Math.Round(Saldo * interes, 2);
        Console.WriteLine($"Interes aplicado... Nuevo saldo {Saldo}");
    }
}