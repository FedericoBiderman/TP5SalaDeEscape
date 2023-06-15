static class Escape
{
    public static string[] incognitasSalas{get;private set;}
    public static int estadoJuego{get;private set;}

    public static void InicializarJuego()
    {
        incognitasSalas=new string[]{"Bilardo", "Clave 2", "Clave 3", "Clave 4"};
        estadoJuego=1;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int sala, string Incognita)
    {
            if (Incognita == incognitasSalas[sala - 1])
            {
                estadoJuego=estadoJuego+1;
                return true;
            }
            return false;
    }
}