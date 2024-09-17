
public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing tree of type {Name} at coordinates ({x}, {y}) with color '{Color}' and texture '{Texture}'");
    }
}

/// <summary>
/// Fyweight Factory: Gestiona la creación de objetos compartidos (TreeType)
/// </summary>
public class TreeFactory
{
    private static Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

    public static TreeType GetTreeType(string name, string color, string texture)
    {
        string key = $"{name}_{color}_{texture}";

        if (!_treeTypes.ContainsKey(key))
        {
            _treeTypes[key] = new TreeType(name, color, texture);
        }

        return _treeTypes[key];
    }
}

/// <summary>
/// Client clase: Define el estado extrínseco (x,y) único para cada objeto
/// </summary>
public class Tree
{
    private int _x;
    private int _y;
    private TreeType _type;

    public Tree(int x, int y, TreeType type)
    {
        _x = x;
        _y = y;
        _type = type;
    }

    public void Draw()
    {
        _type.Draw(_x, _y);
    }
}