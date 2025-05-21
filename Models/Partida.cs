namespace TP04_Ahorcado.Models;

static class Partida{
    static public List<char> palabra = new List<char> { 'O', 'T', 'O', 'R', 'R', 'I', 'N', 'O', 'L', 'A', 'R', 'I', 'N', 'G', 'O', 'L', 'O', 'G', 'I', 'A' };
    static public string palabraReal = "OTORRINOLARINGOLOGIA";
    static public int intentos{get; private set;}
    static public string palabraArriesga{get; private set;}
    static public List<char> letrasArriesga{get; private set;}
    static public char letra{get; private set;}
    static int contadorLetrasAcertadas = 0;
    static public void InicializarPartida()
    {
        intentos = 0;
        letrasArriesga = new List<char>();
    }
    static public void sumarIntento()
    {
        intentos++;
    }
    static public string charAhorcado(char charArriesgado)
    {
        string view = "Juego";
        bool existe = false;
        if(letrasArriesga.Count>=1)
        {
            foreach(char char1 in Partida.letrasArriesga)
            {
                if(char1 == charArriesgado)
                {
                    existe = true;
                }
            }
        }
            if(existe == false)
            {
                Partida.letrasArriesga.Add(charArriesgado);
                if(Partida.intentos>=1)
                {
                    foreach(char charPalabra in Partida.palabra)
                    {
                    if(charArriesgado == charPalabra)
                    {
                    contadorLetrasAcertadas++;
                    }
                    }
                }
            }
            if(contadorLetrasAcertadas==Partida.palabra.Count)
            {
                view = "Ganar";
            }
        return view;
    }
    static public string stringAhorcado(string stringArriesgado)
    {
        string view = "Juego";
        if(stringArriesgado ==  Partida.palabraReal)
            {
                view = "Ganar";
            }else
            {
                view = "Perder";
            }
        return view;
    }
}