namespace KinalLab.Edu.Kinal.Lab.Entities
{
    public abstract class Persona
    {
        public string uuid { get; set; }

        public string apellidos { get; set; }

        public string nombres { get; set; }
        public string email { get; set; }
        public abstract void TomarAsistencia();

        public Persona()
        {
            
        }
    }

}
