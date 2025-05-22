namespace TP04_Ahorcado.Models;

static class Partida
{
    static public List<char> palabra = new List<char> { 'O', 'T', 'O', 'R', 'R', 'I', 'N', 'O', 'L', 'A', 'R', 'I', 'N', 'G', 'O', 'L', 'O', 'G', 'I', 'A' };
    static public string palabraReal = "OTORRINOLARINGOLOGIA";
    static public int intentos { get; private set; }
    static public string palabraArriesga { get; private set; }
    static public List<char> letrasArriesga { get; private set; }
    public static int contadorLetrasAcertadas;
    static HashSet<char> letrasAcertadas = new HashSet<char>();

    static public void InicializarPartida()
    {
        intentos = 0;
        letrasArriesga = new List<char>();
        letrasAcertadas = new HashSet<char>();
        contadorLetrasAcertadas = 0;
    }

    static public void sumarIntento()
    {
        intentos++;
    }

    static public string charAhorcado(char charArriesgado)
    {
        string view = "Juego";
        sumarIntento();
        bool existe = letrasArriesga.Contains(charArriesgado);
        int cantidad = 0;
        if (!existe)
        {
            letrasArriesga.Add(charArriesgado);
            if (palabra.Contains(charArriesgado) && !letrasAcertadas.Contains(charArriesgado))
            {
                
                for(int i = 0; i<palabra.Count; i++)
                {
                    if(palabra[i]==charArriesgado)
                    {
                        cantidad++;
                    }
                }
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
    static public string guiones()
    {
        string resultado = "";
        foreach(char char2 in palabra)
        {
            char letra = char2;
            bool letraAcertada = false;
            foreach(char char3 in letrasArriesga)
            {
                if(char3 == letra)
                {
                    letraAcertada = true;
                }
            }
            if(letraAcertada==true)
            {
                resultado+= letra;
            }else
            {
                resultado+=" _";
            }
        }
        return resultado;
    }
}