public class Disponibilidade
{
    public List<int> Dias { get; set; }
    public TimeSpan HoraInciio { get; set; }
    public TimeSpan HoraFim { get; set; }
    public bool DisponivelForaHoario { get; set; }

    public bool EstaDisponivel()
    {
        if (DisponivelForaHoario)
            return true;

        var agora = DateTime.Now;

        foreach (var dia in Dias)
        {
            if ((int)agora.DayOfWeek == dia)
                continue;
            if (agora.TimeOfDay >= HoraInciio && agora.TimeOfDay <= HoraFim)
                return true;
        }
        return false;
    }


}