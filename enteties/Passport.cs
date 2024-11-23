using ClassApplication.Enteties;

class Passport
{
    public string PassportNumber { get; private set; }
    public string FullName { get; private set; }
    public DateReceivedPassport receivedPassport { get; private set; }

    public Passport()
    {
        this.PassportNumber = string.Empty;
        this.FullName = string.Empty;
        this.receivedPassport = new DateReceivedPassport();
    }

    public Passport(string passportNumber, string fullName, ref DateReceivedPassport receivedPassport) : this()
    {
        if (string.IsNullOrWhiteSpace(passportNumber) || passportNumber.Length != 9)
        {
            throw new ArgumentException("Номер паспорта повинен містити 9 символів.");
        }

        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("ПІБ власника не може бути порожнім.");
        }

        if (receivedPassport.ToDateTime() > DateTime.Now)
        {
            throw new ArgumentException("Дата видачі не може бути в майбутньому.");
        }

        PassportNumber = passportNumber;
        FullName = fullName;
        receivedPassport = receivedPassport;
    }
}