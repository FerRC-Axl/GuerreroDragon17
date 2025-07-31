using System;

class Program
{
    // Variables globales
    static int fuerza = 10;
    static int resistencia = 10;
    static int energia = 100;
    static int vida = 100;
    static int experiencia = 0;
    static int nivel = 1;
    static int experienciaNecesaria = 50;
    static bool seguirJugando = true;

    static void Main(string[] args)
    {
        while (seguirJugando && vida > 0)
        {
            MostrarMenu();
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    VerEstado();
                    break;
                case 2:
                    EntrenarFuerza();
                    break;
                case 3:
                    EntrenarResistencia();
                    break;
                case 4:
                    Pelear();
                    break;
                case 5:
                    Dormir();
                    break;
                case 6:
                    seguirJugando = false;
                    Console.WriteLine("Saliendo del juego...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            RevisarNivel();
            if (vida <= 0)
            {
                Console.WriteLine("\n¡Has muerto en combate! Fin del juego.");
            }
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("----- MENÚ -----");
        Console.WriteLine("1. Ver estado");
        Console.WriteLine("2. Entrenar fuerza");
        Console.WriteLine("3. Entrenar resistencia");
        Console.WriteLine("4. Pelear con enemigo");
        Console.WriteLine("5. Dormir");
        Console.WriteLine("6. Salir");
        Console.Write("Elige una opción: ");
    }

    static void VerEstado()
    {
        Console.WriteLine("Fuerza: " + fuerza);
        Console.WriteLine("Resistencia: " + resistencia);
        Console.WriteLine("Energía: " + energia);
        Console.WriteLine("Vida: " + vida);
        Console.WriteLine("Experiencia: " + experiencia + "/" + experienciaNecesaria);
        Console.WriteLine("Nivel: " + nivel);
    }

    static void EntrenarFuerza()
    {
        if (energia >= 10)
        {
            fuerza = fuerza + 1;
            energia = energia - 10;
            experiencia = experiencia + 5;
            Console.WriteLine("Entrenaste fuerza.");
        }
        else
        {
            Console.WriteLine("No tienes suficiente energía para entrenar.");
        }
    }

    static void EntrenarResistencia()
    {
        if (energia >= 10)
        {
            resistencia = resistencia + 1;
            energia = energia - 10;
            experiencia = experiencia + 5;
            Console.WriteLine("Entrenaste resistencia.");
        }
        else
        {
            Console.WriteLine("No tienes suficiente energía para entrenar.");
        }
    }

    static void Pelear()
    {
        if (energia >= 20)
        {
            Random rnd = new Random();
            int enemigoFuerza = rnd.Next(nivel * 3, nivel * 6 + 1);
            int enemigoResistencia = rnd.Next(nivel * 2, nivel * 5 + 1);

            Console.WriteLine("¡Te enfrentas a un enemigo!");
            Console.WriteLine("Enemigo - Fuerza: " + enemigoFuerza + ", Resistencia: " + enemigoResistencia);

            if (fuerza >= enemigoFuerza && resistencia >= enemigoResistencia)
            {
                experiencia = experiencia + 15;
                energia = energia - 20;
                Console.WriteLine("¡Ganaste la pelea! Ganas experiencia.");
            }
            else
            {
                energia = energia - 20;
                int dano = nivel * 10;
                vida = vida - dano;
                Console.WriteLine("Perdiste la pelea. Pierdes energía y vida (" + dano + ").");
            }
        }
        else
        {
            Console.WriteLine("No tienes suficiente energía para pelear.");
        }
    }

    static void Dormir()
    {
        energia = energia + 20;
        if (energia > 100)
        {
            energia = 100;
        }
        Console.WriteLine("Descansaste y recuperaste energía.");
    }

    static void RevisarNivel()
    {
        while (experiencia >= experienciaNecesaria)
        {
            nivel = nivel + 1;
            experiencia = experiencia - experienciaNecesaria;
            experienciaNecesaria = experienciaNecesaria * 2;
            fuerza = fuerza + 1;
            resistencia = resistencia + 1;
            vida = vida + 5;
            Console.WriteLine("¡Subiste al nivel " + nivel + "!");
            Console.WriteLine("Ganaste +1 fuerza, +1 resistencia y +5 vida.");
        }
    }
} 
