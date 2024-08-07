namespace WorkerIncome.Entities
{
    class Department
    {

        public string Name { get; set; }

        //Construtor padrão 
        public Department()
        {
        }

        // Construtor recebe name como argumento
        public Department(string name)
        {
            Name = name;
        }
    }
}
