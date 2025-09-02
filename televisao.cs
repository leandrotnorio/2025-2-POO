public class Televisao
{
    private const int VOL_MAX = 100;
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }
    public float Tamanho { get; set;}
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set;}
    public bool Estado { get; set;}

    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
            Volume++;
        else
            Console.WriteLine("A TV ja esta no maximo");
    }
}