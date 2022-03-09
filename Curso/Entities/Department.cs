namespace Curso.Entities
{
    class Department
    {
        public string Name { get; set; }

        //Construtor padrão da classe
        public Department()
        {

        }

        //Construtor que recebe o Name como argumento
        public Department (string name)
        {
            Name = name; //atributo Name recebendo Name que chegou como entrada no parametro do construtor
        }


    }
}
