namespace TP04_Ahorcado.Models;

static class Partida{
    static public List<char> palabra = new List<char> { 'O', 'T', 'O', 'R', 'R', 'I', 'N', 'O', 'L', 'A', 'R', 'I', 'N', 'G', 'O', 'L', 'O', 'G', 'I', 'A' };
    static public string palabraReal = "OTORRINOLARINGOLOGIA";
    static public int intentos{get; private set;}
    static public string palabraArriesga{get; private set;}
    static public List<char> letrasArriesga{get; private set;}
    static public char letra{get; private set;}
    static public void InicializarPartida()
    {
        intentos = 0;
        letrasArriesga = null;
    }
    static public void sumarIntento()
    {
        intentos++;
    }
}