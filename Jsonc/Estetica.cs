using Newtonsoft.Json;

public class Estetica
{
    public string Nome{ get; set; }

    public string Email { get; set; }

    public string Cpf { get; set; }

    public string datanascimento { get; set; }

    public string telefone { get; set; }

    public string Endereço { get; set; }

    public Estetica()
    {

    }
    public Estetica(string Nome, string Email, string Cpf, string datanascimento, string telefone, string Endereço)
    {
        this.Nome = Nome;
        this.Email = Email;
        this.Cpf = Cpf;
        this.datanascimento = datanascimento;
        this.telefone = telefone;
        this.Endereço = Endereço;

    }

    public string JsonSerializar(Estetica estetica)
    {
        return JsonConvert.SerializeObject(estetica);
    }
    public static Estetica Deserialize(string json)
    {
        return JsonConvert.DeserializeObject<Estetica>(json);
    }

}