using System.Globalization;

class Conta {
    public int Num { get; private set; }
    public string Titular { get; set; }
    public double Saldo {get; private set;}

    public Conta(int num, string nome){
        Num = num;
        Titular = nome;
    }

    public Conta(int num, string nome, double saldo) : this(num, nome){
        Depositar(saldo);
    }

    public void Depositar(double valor){
        Saldo += valor;
    }

    public void Sacar(double valor){
        Saldo -= valor + 5;
    }

    public override string ToString()
    {
        return "Conta "
            + Num 
            + ", Titular: "
            + Titular
            + ", Saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
}