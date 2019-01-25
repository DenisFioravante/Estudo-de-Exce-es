using System;
using System.Collections.Generic;
using System.Text;
using ExerciosExceçoes_ReservaDeHotel_.Entities.Exceptions;

namespace ExerciosExceçoes_ReservaDeHotel_.Entities
{
    class Reservacion
    {
        public int RoomNunber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservacion()
        {
        }

        public Reservacion(int roomNunber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)//com o throw é possível lançar a exceção no construtor
            {
                throw new DomainException("Erro in reservacion: Check-Out date must be after Check-In date");

            }

            RoomNunber = roomNunber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public int Duracion()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("Error in Reservacion: Reservacion dates for updates must be future dates");
                //o método throw lança a exceção mara a classe DomainExcetion

            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro in reservacion: Check-Out date must be after Check-In date");

            }
            CheckIn = checkIn;
            CheckOut = checkOut;

            
        }

        public override string ToString()
        {
            return "Roon "
                   + RoomNunber
                   + ", CheckIn "
                   + CheckIn.ToString("dd/MM/yyyy")
                   + ", CheckOut "
                   + CheckOut.ToString("dd/MM/yyyy")
                   + ", Duration "
                   + Duracion()
                   + " Nigths.";

        }
    }

}
