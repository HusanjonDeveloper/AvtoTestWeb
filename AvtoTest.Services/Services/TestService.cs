using AvtoTest.Data.Entities.TestEntities;
using AvtoTest.Data.Repositories;

namespace AvtoTest.Services.Services;

public class TestService
{
    private readonly TestRepository _repository;
    public  List<Test> Tests { get; set; }

    public TestService(TestRepository repository)
    {
        _repository = repository;
        Tests = _repository.ReadFromDile();
    }

    public void ChangeLanguage(string Language)
    {
        Tests = _repository.ReadFromDile(Language);
    }
    
    
}