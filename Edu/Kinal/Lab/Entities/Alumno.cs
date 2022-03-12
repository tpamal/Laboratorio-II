using KinalLab.Edu.Kinal.Lab.Interfaces;

namespace KinalLab.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public Alumno()
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