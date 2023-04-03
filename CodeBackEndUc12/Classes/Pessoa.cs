using Back_End_ER04.Interfaces;
namespace Back_End_ER04.Classes

{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public float rendimento { get; set; }

        public Endereco? endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);
       
    }
}