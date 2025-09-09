public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;

    private const int CAN_MAX = 520;
    private const int CAN_MIN = 2;

    private const bool TV_LIG = true;
    private const bool TV_DESLIG = false;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }
    public float Tamanho { get; set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
            Volume++;
        else
            Console.WriteLine("A TV ja esta no maximo");
    }

    public void AbaixarVolume()
    {
        if (Volume > VOL_MIN)
            Volume--;
        else
            Console.WriteLine("A TV ja está no mínimo");
    }

    public void SubirCanal()
    {
        if (Canal <= CAN_MIN)
            Canal++;
        else
            Console.WriteLine("canal maximo");
    }
    public void DescerCanal()
    {
        if (Canal >= CAN_MAX)
            Canal--;
        else
            Console.WriteLine("canal minimo");
    }

    public void LigarTelevisao()
    {
        if (Estado == TV_LIG)
            Estado = true;
        else
            Console.WriteLine("TV ligada");
    }

    public void DesligarTelevisao()
    {
        if (Estado == TV_DESLIG)
            Estado = false;

        Console.WriteLine("TV desligada");
        
    }

}