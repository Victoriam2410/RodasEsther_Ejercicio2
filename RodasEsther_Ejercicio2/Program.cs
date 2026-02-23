Console.WriteLine("Seleccione una de las opciones: \n selecciones la opcción que desee \n1 Estudiante \n2.Docente \n3 Técnico IT \n4 Visitante ");
int option = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese hora (0-23)h: ");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese día (1-7):");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("¿Carnet vigente? (S/N):");
string carnet = Console.ReadLine();
Console.WriteLine("¿Autorización escrita? (S/N):");
string autorizacion = Console.ReadLine();
Console.WriteLine("¿Trae USB? (S/N):");
string traeUSB = Console.ReadLine();
Console.WriteLine("¿Está acompañado? (S/N):");
string acompañado = Console.ReadLine();

if (hora >= 0 && hora <= 24 && dia >= 1 && dia <= 7 && carnet == "S" || carnet == "N" & autorizacion == "S" || autorizacion == "N" && traeUSB == "S" || traeUSB == "N" && acompañado == "S" || acompañado == "N")
{
    switch (option)
    {
        case 1:
            Console.WriteLine("Bienvenido Estudiante");
            if (dia <= 5 && hora >= 7 && hora <= 18)
            {
                Console.WriteLine("Acceso permitido.");
            }
            else
            {
                Console.WriteLine("Acceso denegado.");
            }
            break;
        case 2:
            Console.WriteLine("Bienvenido Docente");
            if (dia <= 5 && hora >= 7 && hora <= 18)
            {
                Console.WriteLine("Acceso permitido, jornada laboral.");
            }
            else
            {
                Console.WriteLine("Acceso denegado, no esta en su jornada laboral. ");
            }
            break;
        case 3: 
            Console.WriteLine("Bienvenido Técnico IT");
            if (hora < 18)
            {
                Console.WriteLine("Acceso permitido.");
            }
            else if (autorizacion == "S")
                {
                    Console.WriteLine("Acceso permitido.");
                }
                else
                {
                    Console.WriteLine("Acceso denegado.");
                }
            break;
    }
}