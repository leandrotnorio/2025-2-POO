

public class CartaoDebito
{
    public CartaoDebito()
    {
        //Bandeira = "Visa";
        //Bandeira = "MinhaBandeira";
        Bandeira = BandeiraCartao.Mastercard;
    }

    public string Numero { get; set; }
    //public string Bandeira { get; set; } //visa, Visa, VISA.
    public BandeiraCartao Bandeira { get; set; }
    public DateTime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }


    public decimal Saldo { get; set; }
    public decimal Limite { get; set; }


    public bool Debitar(decimal valor)
    {
        if (valor > Saldo)
            return false;

        Saldo -= valor;
        return true;
    }



    public bool Debitar(decimal valor, bool usarLimite)
    {
        if (usarLimite)
        {
            if (valor <= (Saldo + Limite))
                return Debitar(valor);
            else
                return false;
        }

        return Debitar(valor);
    }
}




public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo

}

