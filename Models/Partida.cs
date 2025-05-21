namespace TP04_Ahorcado.Models;

static class Partida
{
    static public List<char> palabra = new List<char> { 'O', 'T', 'O', 'R', 'R', 'I', 'N', 'O', 'L', 'A', 'R', 'I', 'N', 'G', 'O', 'L', 'O', 'G', 'I', 'A' };
    static public string palabraReal = "OTORRINOLARINGOLOGIA";
    static public int intentos { get; private set; }
    static public string palabraArriesga { get; private set; }
    static public List<char> letrasArriesga { get; private set; }
    static public char letra { get; private set; }
    public static int contadorLetrasAcertadas = 0;
    static HashSet<char> letrasAcertadas = new HashSet<char>();

    static public void InicializarPartida()
    {
        intentos = 0;
        letrasArriesga = new List<char>();
        contadorLetrasAcertadas = 0;
        letrasAcertadas = new HashSet<char>();
    }

    static public void sumarIntento()
    {
        intentos++;
    }

    static public string charAhorcado(char charArriesgado)
    {
        string view = "Juego";
        bool existe = letrasArriesga.Contains(charArriesgado);

        if (!existe)
        {
            letrasArriesga.Add(charArriesgado);

            // Si la letra está en la palabra y no la habíamos acertado antes, sumamos al contador
            if (palabra.Contains(charArriesgado) && !letrasAcertadas.Contains(charArriesgado))
            {
                // Sumar solo una vez por cada letra única acertada
                int cantidad = palabra.Count(c => c == charArriesgado);
                contadorLetrasAcertadas += cantidad;
                letrasAcertadas.Add(charArriesgado);
            }
        }

        if (contadorLetrasAcertadas == palabra.Count)
        {
            view = "Ganar";
        }
        return view;
    }

    static public string stringAhorcado(string stringArriesgado)
    {
        string view = "Juego";
        if (stringArriesgado == palabraReal)
        {
            view = "Ganar";
        }
        else
        {
            view = "Perder";
        }
        return view;
    }
}