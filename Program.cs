// Primera practica Calculadora

//Declaracion de variables 
double numero;
double resultado;
double a;
double b;
int option;
int p1, p2, p3, p4;

Console.WriteLine("Bienvenido a Nuestra calculadora \n");

//Utilizaremos el do while para poder declarar una variable mienstra se ejecuta el programa.

do 
    {

    Console.WriteLine("Seleccion la opcion de lo que desea realizar: 1.Sumar, 2.Restar, 3.Multiplicacion, 4.Division, 5.Resultado de calificacion final 6.Salir \n");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option) {
    
    case 1:
            Console.WriteLine("Introduzca el Primer numero:\n");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo numero:\n");
            b = Convert.ToDouble(Console.ReadLine());
            resultado = a + b;
            Console.WriteLine($"El resultado de su suma es: {resultado}");
        break;

    case 2:
            Console.WriteLine("Introduzca el Primer numero:\n");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo numero:\n");
            b = Convert.ToDouble(Console.ReadLine());
            resultado = a - b;

            Console.WriteLine($"El resultado de su Resta es: {resultado}");
         break;

    case 3:
            Console.WriteLine("Introduzca el Primer numero:\n");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo numero:\n");
            b = Convert.ToDouble(Console.ReadLine());
            resultado = a * b;

            Console.WriteLine($"El resultado de su Resta es: {resultado}");
         break;

    case 4:
            Console.WriteLine("Introduzca el Primer numero:\n");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo numero:\n");
            b = Convert.ToDouble(Console.ReadLine());
            resultado = a / b;

            Console.WriteLine($"El resultado de su Resta es: {resultado}");
         break;

    case 5:
            Console.WriteLine("Bienvenido al sistema de calificaion final \n");
            Console.WriteLine("Introzduca la calificacion del Primer periodo: \n");
            p1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introzduca la calificacion del Segundo periodo: \n");
            p2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introzduca la calificacion del Tercer periodo: \n");
            p3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introzduca la calificacion del Cuarto periodo: \n");
            p4 = Convert.ToInt32(Console.ReadLine());

            int calificacion_final = p1 + p2 + p3 + p4;
            calificacion_final = calificacion_final / 4;

            if(calificacion_final >= 90 && calificacion_final <= 100) 
            {
                Console.WriteLine($"Felicidades, gracias a tus esfuerzos pasaste con: {calificacion_final}\n");
            
            }

            else if(calificacion_final >= 80 && calificacion_final <= 90)
            {
                Console.WriteLine($"Felicidades sigue esforzandote, pasaste con: {calificacion_final}\n");
            }

            else if (calificacion_final >= 70 && calificacion_final <= 80)
            {
                Console.WriteLine($"Felicidades, apenas pasaste con: {calificacion_final}\n");
            }

            else
            {
                Console.WriteLine($"Lo siento has reprobado con: {calificacion_final}\n");
            }

            break;

    }

}

while (option != 6);


Console.ReadKey();
