namespace HaciendaAgricola.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Habilidades { get; set; }
        public List<PersonalLabor> LaboresAsignadas { get; set; } = new List<PersonalLabor>();
    }
}