using Aspose.Gis.Geometries;
using Aspose.Gis;

var layer = Drivers.Gpx.OpenLayer(@"C:\Users\po66qga\Documents\GitHub\323-Programmation_fonctionnelle\perso\ExoRando\Ballade_chataignere.gpx");

foreach (var feature in layer)
{
    // Check for Point geometry
    if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
    {
        // Read Points
        MultiLineString point = (MultiLineString)feature.Geometry;
        Console.WriteLine(point.AsText() + " X: " + point + " Y: " + point);
    }
}
Console.ReadLine();

