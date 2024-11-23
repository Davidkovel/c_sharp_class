using ClassApplication.Enteties;

namespace ClassApplication.Classes;

public class CreditCard
{
    public string number_card { get; set; }
    public string CardHolderName { get; set; }
    public int CVC { get; set; }
    public DateExpiredCard ExpiryDate { get; set; }

    public CreditCard() { 
        this.number_card = "Null";
        this.CardHolderName = string.Empty;
        this.CVC = 0;
        this.ExpiryDate = new DateExpiredCard();
    }

    public CreditCard(string card, string card_holder_name, int cvc, ref DateExpiredCard date_expired_card)
    {
        if (string.IsNullOrWhiteSpace(card) || card.Length != 16) 
        { 
            throw new ArgumentException("Номер картки повинен містити 16 цифр."); 
        }

        if (string.IsNullOrWhiteSpace(card_holder_name))
        {
            throw new ArgumentException("ПІБ власника картки не може бути порожнім.");
        }

        if (cvc < 100 || cvc > 999) { 
            throw new ArgumentException("CVC повинен містити 3 цифри."); 
        }
        DateTime expiryDate = date_expired_card.ToDateTime(); 

        if (expiryDate <= DateTime.UtcNow) { 
            throw new ArgumentException("Дата завершення роботи картки повинна бути в майбутньому."); 
        }

        this.number_card = card;
        this.CardHolderName= card_holder_name;
        this.CVC = cvc;
        this.ExpiryDate = date_expired_card;
    }
}