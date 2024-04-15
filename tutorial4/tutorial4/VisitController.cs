using Microsoft.AspNetCore.Mvc;

namespace tutorial4;

[Route("api/[controller]")]
[ApiController]
public class VisitController
{
    [HttpGet("/visits")]
    public IEnumerable<Visit> GetVisit(Animal animal)
    {
        List<Visit> animalVisit = new List<Visit>();
        foreach (var visit in ShelterData.Visits)
        {
            if (visit.Animal == animal) animalVisit.Add(visit);
        }

        return animalVisit;
    }
    
    [HttpPost]
    public void PostAnimal(Visit visit)
    {
        ShelterData.Visits.Add(visit);
    }
    
}