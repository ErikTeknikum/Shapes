using Ovningsuppgift_objektorientering;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

int width = 0;
int height = 0;
int radius = 0;
IShape shape;
string AreaOrCircumferance;

Console.WriteLine("Vilken figur vill du räkna på?");
Console.WriteLine("a: rektangel b: triangel, c: Circle, d: Sfär, e: Cylinder");

string shapeInput = Console.ReadLine();

if (shapeInput == "a") // rektangel
{
    Console.WriteLine("Ange höjd:");
    string heightInput = Console.ReadLine();
    height = Convert.ToInt32(heightInput);

    Console.WriteLine("Ange bredd:");
    string widthInput = Console.ReadLine();
    width = Convert.ToInt32(widthInput);

    Console.WriteLine("Area eller Omkrets?");
    Console.WriteLine("a: Area, b: Omkrets");
    AreaOrCircumferance = Console.ReadLine();

    if (AreaOrCircumferance == "a")
    {
        shape = new Ovningsuppgift_objektorientering.Rectangle(width, height);
        Console.WriteLine("Arean på Rektangeln är: " + shape.Area());
    }
    if (AreaOrCircumferance == "b")
    {
        shape = new Ovningsuppgift_objektorientering.Rectangle(width, height);
        Console.WriteLine("Omkretsen på Rektangeln är: "+shape.Circumferance());
    }
}
else if (shapeInput == "b") // triangel
{
    Console.WriteLine("Ange höjd:");
    string heightInput = Console.ReadLine();
    height = Convert.ToInt32(heightInput);

    Console.WriteLine("Ange bredd:");
    string widthInput = Console.ReadLine();
    width = Convert.ToInt32(widthInput);

    Console.WriteLine("Area eller Omkrets?");
    Console.WriteLine("a: Area, b: Omkrets");
    AreaOrCircumferance = Console.ReadLine();

    if (AreaOrCircumferance == "a")
    {
        shape = new Ovningsuppgift_objektorientering.Triangle(width, height);
        Console.WriteLine("Arean på Triangeln är: " + shape.Area());
    }
    if (AreaOrCircumferance == "b")
    {
        shape = new Ovningsuppgift_objektorientering.Triangle(width, height);
        Console.WriteLine("Omkretsen på Triangeln är: " + shape.Circumferance());
    }
}
else if (shapeInput == "c") // cirkel
{
    Console.WriteLine("Ange radie:");
    string widthInput = Console.ReadLine();
    radius = Convert.ToInt32(widthInput);

    Console.WriteLine("Area eller Omkrets?");
    Console.WriteLine("a: Area, b: Omkrets");
    AreaOrCircumferance = Console.ReadLine();

    if (AreaOrCircumferance == "a")
    {
        shape = new Circle(radius);
        Console.WriteLine("Arean på Cirkeln är: " + shape.Area());
    }
    if (AreaOrCircumferance == "b")
    {
        shape = new Circle(radius);
        Console.WriteLine("Omkretsen på Cirkeln är: " + shape.Circumferance());
    }
}
else if (shapeInput == "d") // sfär
{

    Console.WriteLine("Ange radie:");
    string widthInput = Console.ReadLine();
    radius = Convert.ToInt32(widthInput);

    Console.WriteLine("Area eller Omkrets?");
    Console.WriteLine("a: Area, b: Omkrets");
    AreaOrCircumferance = Console.ReadLine();

    if (AreaOrCircumferance == "a")
    {
        shape = new Sphere(radius);
        Console.WriteLine("Arean på Sfären är: " + shape.Area());
    }
    if (AreaOrCircumferance == "b")
    {
        shape = new Sphere(radius);
        Console.WriteLine("Omkretsen på Sfären är: " + shape.Circumferance());
    }
}
else if (shapeInput == "e") // cylinder
{
    Console.WriteLine("Ange höjd:");
    string heightInput = Console.ReadLine();
    height = Convert.ToInt32(heightInput);

    Console.WriteLine("Ange radie:");
    string widthInput = Console.ReadLine();
    radius = Convert.ToInt32(widthInput);

    Console.WriteLine("Area eller Omkrets?");
    Console.WriteLine("a: Area, b: Omkrets");
    AreaOrCircumferance = Console.ReadLine();

    if (AreaOrCircumferance == "a")
    {
        shape = new Ovningsuppgift_objektorientering.Cylinder(radius, height);
        Console.WriteLine("Arean på Cylindern är: " + shape.Area());
    }
    if (AreaOrCircumferance == "b")
    {
        shape = new Ovningsuppgift_objektorientering.Cylinder(radius, height);
        Console.WriteLine("Omkretsen på Cylindern är: " + shape.Circumferance());
    }
}
else
{
    return;
}

