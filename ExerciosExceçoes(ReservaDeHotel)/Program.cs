using System;
using ExerciosExceçoes_ReservaDeHotel_.Entities;
using ExerciosExceçoes_ReservaDeHotel_.Entities.Exceptions;

namespace ExerciosExceçoes_ReservaDeHotel_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room Number");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check In date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check Out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservacion reservacion = new Reservacion(number, checkIn, checkOut);
                Console.WriteLine("Reservacion " + reservacion);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservacion: ");
                Console.WriteLine("Check In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservacion.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservacion " + reservacion);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro: "+ e.Message);
            }
            catch(FormatException e)//caso o usuário digite letras para varáveis numbers
            {
                Console.WriteLine("Format Error: "+e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected Error: "+e.Message);
            }



        }




    }
}

