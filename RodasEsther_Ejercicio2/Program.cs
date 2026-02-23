Console.WriteLine("Seleccione una de las opciones: \n selecciones la opccion que desee \n1 Estudiante \n2.Docente \n3 Técnico IT \n4 Visitante ");
int option = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese hora");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese dia de la semana");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese carnet vigente (S/N)");
string carnet = Console.ReadLine();
Console.WriteLine("Ingrese autorizacion escrita (S/N)");
string autorizacion = Console.ReadLine();
Console.WriteLine("Trae usb (S/N)");
string traeUSB = Console.ReadLine();
Console.WriteLine("Si trae USB preguntar si está acompañado (S/N)");
string acompañado = Console.ReadLine();

if (hora >= 0 && hora <= 24 && dia >= 1 && dia <= 7 && carnet == "S" || carnet == "N" & autorizacion == "S" || autorizacion == "N" && traeUSB == "S" || traeUSB == "N" && acompañado == "S" || acompañado == "N")
{
    switch (option)
    {
        case 1:
            Console.WriteLine("Bienvenido estudiante");
            if (hora >= 7 && hora <= 18 && dia >= 1 && dia <= 5)
            {
                Console.WriteLine("Tiene ingreso al laboratorio");
            }
            else
            {
                Console.WriteLine("No tiene ingreso al laboratorio ");
            }

            break;
        case 2:
            Console.WriteLine("Bienvenido docente.");
            if (hora >= 7 && hora <= 18 && dia >= 1 && dia <= 5)
            {
                Console.WriteLine("Tiene ingreso al laboratorio.");
            }
            else
            {
                Console.WriteLine("No tiene ingreso al laboratorio.");
            }
            break;
    }
}