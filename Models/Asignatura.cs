using System;

namespace ASP_Platzi.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public Asignatura()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}