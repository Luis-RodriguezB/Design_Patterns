namespace Proxy;

/// <summary>
/// Common interface between proxy and real object
/// </summary>
public interface IImage
{
    void Display();
}

/// <summary>
/// Real Object that is expensive to create
/// </summary>
public class RealImage : IImage
{
    private string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        Console.WriteLine($"Loading image from disk: {_filename}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {_filename}");
    }
}

/// <summary>
/// Proxy that controls access to the RealImage
/// </summary>
public class ImageProxy : IImage
{
    private RealImage _realImage;
    private string _filename;

    public ImageProxy(string filename)
    {
        _filename = filename;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_filename);
        }

        _realImage.Display();
    }
}
