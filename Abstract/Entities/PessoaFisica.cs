class PessoaFisica : Pessoa{
    public double Gastos { get; set; }

    public PessoaFisica(){}

    public PessoaFisica(string nome, double rendaAnual, double gastos) : base(nome, rendaAnual){
        Gastos = gastos;
    }

    public override double Imposto()
    {
        if (RendaAnual < 20000)
        {
            return RendaAnual * 0.15 - Gastos * 0.5;
        } else
        {
            return RendaAnual * 0.25 - Gastos * 0.5;
        }
    }
}