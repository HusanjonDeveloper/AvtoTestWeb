using AvtoTest.Data.Entities.TestEntities;
using Newtonsoft.Json;

namespace AvtoTest.Data.Repositories;

public class TestRepository
{
    private string Path { get; set; }

    public List<Test> ReadFromDile(string? Language = null)
    {
        if(string.IsNullOrEmpty(Language))
         Language = "uzb";

        switch (Language)
        {
            case "uzb": Path = "uzlotin.json"; break;
                case "ru" : Path = "rus.json"; break;
                case "uzkiril": Path = "uzkiril.json"; break;
                default: Path = "uzlotion.json"; break;
        }
        
        var jsonData = File.ReadAllText(Path);
       List<Test> tests = JsonConvert.DeserializeObject<List<Test>>(jsonData);
        return tests!;
    }
}