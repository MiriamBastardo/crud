namespace MiPrimerCrud.Models
{
    public class Asignatura
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        //relacion a otra asignatura el Id siempre se pone al final
        public long? CursilloId { get; set; }

        public Curso? Cursillo { get; set; }
    }
}
