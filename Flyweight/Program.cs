Console.Title = "Flyweight Pattern";

var trees = new List<Tree>();

// Creamos 3 árboles en diferentes coordenadas, pero comparten el mismo TreeType
TreeType oakType = TreeFactory.GetTreeType("Oak", "Green", "Rough");
trees.Add(new Tree(10, 20, oakType));
trees.Add(new Tree(30, 40, oakType));
trees.Add(new Tree(50, 60, oakType));


// Creamos 2 árboles más con un tipo diferente
TreeType pineType = TreeFactory.GetTreeType("Pine", "Dark Green", "Smooth");
trees.Add(new Tree(70, 80, pineType));
trees.Add(new Tree(90, 100, pineType));

foreach (var tree in trees)
{
    tree.Draw();
}

Console.ReadKey();