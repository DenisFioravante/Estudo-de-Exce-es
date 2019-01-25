using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciosExceçoes_ReservaDeHotel_.Entities.Exceptions
{
    class DomainException: ApplicationException
    {
        public DomainException(string mensagem): base(mensagem)// irar pegar as mensagem já construídas na Application Exception
        {

        }
    }
}
