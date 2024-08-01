namespace ModuloCinco
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string n, string e)
        {
            Nome = n;
            Email = e;
        }
        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}