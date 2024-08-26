namespace ClassAdapter;

public class CityFromExternalSystem
{
    public string Name { get; set; }
    public string NickName { get; set; }

    public int Inhabitants { get; set; }

    public CityFromExternalSystem(string name, string nickname, int inhabitants)
    {
        Name = name;
        NickName = nickname;
        Inhabitants = inhabitants;
    }
}

/// <summary>
/// Adapter
/// </summary>
public class ExternalSystem
{
    public CityFromExternalSystem GetCity()
    {
        return new CityFromExternalSystem("Liberia", "Ciudad Blanca", 150000);
    }
}


public class City
{
    public string FullName { get; private set; }
    public long Inhabitans { get; private set; }

    public City(string fullName, long inhabitans)
    {
        FullName = fullName;
        Inhabitans = inhabitans;
    }
}

/// <summary>
/// Target
/// </summary>
public interface ICityAdapter
{
    City GetCity();
}


/// <summary>
/// Adapter
/// </summary>
public class CityAdapter : ExternalSystem, ICityAdapter
{
    public City GetCity()
    {
        var cityFromExternalSystem = base.GetCity();

        return new City(
            fullName: $"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
            inhabitans: cityFromExternalSystem.Inhabitants
        );
    }
}
