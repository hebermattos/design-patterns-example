namespace regras_encadeadas.Controllers;

public interface ICache
{
    void SalvarRestricaoCache(string cpf, bool? possuiRestricao);
    
    bool? BuscarRestricaoCache(string cpf);
}