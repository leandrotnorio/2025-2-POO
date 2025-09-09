public class Televisao
{
    private const int CAN_MAX = 520;
    private const int CAN_MIN = 1;
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;

    private const int ATIVAR_MUDO = 0;

    private int volumeAnterior;

    private const bool TV_LIG = true;
    private const bool TV_DESLIG = false;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Canal = CAN_MIN;
        Volume = VOL_MIN;
        volumeAnterior = Volume;
        Estado = TV_DESLIG;
    }
    public float Tamanho { get; private set; }
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
            Console.WriteLine("A TV ja está no volume mínimo");
    }

    public void SubirCanal()
    {
        if (Canal < CAN_MAX)
            Canal++;
        else
            Console.WriteLine("Canal já está no máximo");


    }
    public void DescerCanal()
    {
        if (Canal > CAN_MIN)
            Canal--;
        else if (Canal == CAN_MIN)
            Console.WriteLine("canal minimo");

    }

  public void LigarTelevisao()
    {
        if (!Estado)
        {
            Estado = true;
                Console.WriteLine("TV ligada");
        }
        else
        {
            Console.WriteLine("A TV já está ligada.");
        }
    }

    public void DesligarTelevisao()
    {
        if (Estado)
        {
            Estado = false;
            Console.WriteLine("TV desligada");
        }
        else
        {
            Console.WriteLine("A TV já está desligada.");
        }
    }


    public void AtivarMudo()
    {
        if (Volume > 0)
        {
            volumeAnterior = Volume;
            Volume = 0;
        }
    }
    public int DesativarMudo()
    {
        if (Volume == 0)
        {
            Volume = volumeAnterior;
        }
        return Volume;
    }

    public void MudarParaCanal(int novoCanal)
    {
        if (!Estado)
        {
            Console.WriteLine("A TV está desligada. Ligue a TV para mudar de canal.");
            return;
        }

        if (novoCanal >= CAN_MIN && novoCanal <= CAN_MAX)
        {
            Canal = novoCanal;
            Console.WriteLine($"Canal alterado para {Canal}");
        }
        else
        {
            Console.WriteLine($"Canal inválido. Digite um canal entre {CAN_MIN} e {CAN_MAX}.");
        }
    }
}