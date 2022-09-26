namespace HogarGestor.App.Dominio;
public class Cls_Beneficiario : Cls_Persona
{
    public string? direccion { get; set; }
    public float? latitud { get; set; }
    public float? longitud { get; set; }
    public string? ciudad { get; set; }
    public DateTime? fechaNacimiento { get; set; }
    public Cls_Familiar? familiar { get; set; }
    public Cls_PersonalSalud? pediatra { get; set; }
    public Cls_PersonalSalud? nutricionista { get; set; }
    public Cls_Historia? historiaClinica { get; set; }
    public System.Collections.Generic.List<Cls_PatronCrecimiento>? patronCrecimiento { get; set; }
}