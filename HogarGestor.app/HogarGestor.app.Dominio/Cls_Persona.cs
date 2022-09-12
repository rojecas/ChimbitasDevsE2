namespace HogarGestor.App.Dominio
{
    public class Cls_Persona
    {
       public int Id {get; set;} 
       public string  nombre{get; set;}
       public string  apellido {get; set;}
       public string  documento {get; set;}
       public string telefono {get; set;}
       public Genero genero {get;  set;}
    }
}