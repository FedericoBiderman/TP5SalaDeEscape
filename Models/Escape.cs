static class Escape
{
    public static string[] incognitasSalas{get;private set;}
    public static int estadoJuego{get;private set;}

    public static void InicializarJuego()
    {
        incognitasSalas=new string[]{"Bilardo", "Puskas", "Brasil", "Messi"};
        estadoJuego=1;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int sala, string Incognita)
    {
            //pojngan que haga tolower en los 2
            if (Incognita.ToLower() == incognitasSalas[sala - 1].ToLower())
            {
                estadoJuego=estadoJuego+1;
                return true;
            }
            return false;
    }
}