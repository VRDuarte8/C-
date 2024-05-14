using System.Globalization;

abstract class Pessoa{
    public string Nome { get; set; }
    public double RendaAnual { get; set; }

    public Pessoa(){}

    protected Pessoa(string nome, double rendaAnual){
        Nome = nome;
        RendaAnual = rendaAnual;
    }

    public abstract double Imposto();

    public override string ToString()
    {
        return $"{Nome}: ${Imposto().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}