using Microsoft.AspNetCore.Mvc;

namespace tutorial4;

[Route("api/[controller]")]
[ApiController]
public class AnimalController
{
    [HttpGet("/animals")]
    public IEnumerable<Animal> GetAllAnimals()
    {
        return ShelterData.Animals;
    }
    
    [HttpGet("{id}")]
    public Animal GetAnimalsById(int id)
    {
        foreach (var animal in ShelterData.Animals)
        {
            if (animal.Id == id) return animal;
        }
        return null;
    }
    
    [HttpPost]
    public void PostAnimal(Animal animal)
    {
        ShelterData.Animals.Add(animal);
    }

    [HttpPut("{id}")]
    public void PutAnimal(int id, string name, string category, float weight, string furColor)
    {
        foreach (var animal in ShelterData.Animals)
        {
            if (animal.Id == id) animal.Name = name;
            animal.Category = category;
            animal.Weight = weight;
            animal.FurColor = furColor;
        }
    }

    [HttpDelete("{id}")]
    public void DeleteAnimal(int id)
    {
        foreach (var animal in ShelterData.Animals)
        {
            if (animal.Id == id) ShelterData.Animals.Remove(animal);
        }
    }
    
}