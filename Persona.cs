public class Persona
{
    private string nombres = string.Empty;
    private string apellidos = string.Empty;
    private string documento = string.Empty;

    public string Nombres
    {
        get { return nombres; }
        set { nombres = value; }
    }

    public string Apellidos
    {
        get { return apellidos; }
        set { apellidos = value; }
    }

    public string Documento
    {
        get { return documento; }
        set { documento = value; }
    }

    public Persona(string nombres, string apellidos, string documento)
    {
        Nombres = nombres;
        Apellidos = apellidos;
        Documento = documento;
    }

    public virtual string Presentarse()
    {
        return $"Hola, soy {Nombres} {Apellidos} y mi número de documento es {Documento}.";
    }
}