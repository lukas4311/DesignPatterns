using System.Collections.Generic;

public class Car
{
    private List<string> carParts = new List<string>();

    public void AddPart(string part)
    {
        this.carParts.Add(part);
    }

    public string GetCarConfiguration()
    {
        return "Configuration: " + string.Join(",", this.carParts);
    }
}