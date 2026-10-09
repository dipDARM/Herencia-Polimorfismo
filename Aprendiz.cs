public class Aprendiz : Persona
{
    private string numeroFicha = string.Empty;
    private string programaFormacion = string.Empty;

    public string NumeroFicha
    {
        get { return numeroFicha; }
        set { numeroFicha = value; }
    }

    public string ProgramaFormacion
    {
        get { return programaFormacion; }
        set { programaFormacion = value; }
    }

    public Aprendiz(
        string nombres,
        string apellidos,
        string documento,
        string numeroFicha,
        string programaFormacion
    ) : base(nombres, apellidos, documento)
    {
        NumeroFicha = numeroFicha;
        ProgramaFormacion = programaFormacion;
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombres} {Apellidos}, mi documento es {Documento}, mi numero de ficha es {NumeroFicha} y pertenezco al programa {ProgramaFormacion}";
    }
}