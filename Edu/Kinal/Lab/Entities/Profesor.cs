
using KinalLab.Edu.Kinal.Lab.Interfaces;

namespace KinalLab.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string cargo { get; set; }

        public Profesor()
        {
            
        }

        public void EliminarAsignatura(string asignatura)
        {
            throw new NotImplementedException();
        }

        public void ListarDatos(string identificador)
        {
            throw new NotImplementedException();
        }

        public override void TomarAsistencia()
        {
            throw new NotImplementedException();
        }
    }
}