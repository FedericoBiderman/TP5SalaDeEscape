static class Escape
{
    public static string[] incognitasSalas{get;private set;}
    public static int estadoJuego{get;private set;}

    private static void InicializarJuego()
    {
        incognitasSalas=new string[]{"Clave 1", "Clave 2", "Clave 3", "Clave 4"};
        estadoJuego=1;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
        if (estadoJuego != Sala)
            {
                return false; 
            }

            if (Incognita == incognitasSalas[Sala - 1])
            {
                estadoJuego=estadoJuego+1;
                return true;
            }

            return false;
    }
}