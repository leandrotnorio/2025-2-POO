using System.Data;

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
}


public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo

}

