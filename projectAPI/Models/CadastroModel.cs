namespace projectAPI.Models
{
    public class CadastroModel
    {
        public CadastroModel(int id, string name, object idade)
        {
            Id = id;
            Name = name;
            Idade = idade;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public object Idade { get; set; }
    }
}
