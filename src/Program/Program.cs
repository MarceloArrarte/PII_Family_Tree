using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Persona("Artigas Arrarte", 93));

            Node n2 = new Node(new Persona("Gerardo Arrarte", 66));
            Node n3 = new Node(new Persona("Malila Arrarte", 64));
            Node n4 = new Node(new Persona("Silvana Arrarte", 61));
            Node n5 = new Node(new Persona("Alicia Arrarte", 59));
            Node n6 = new Node(new Persona("Pablo Arrarte", 54));

            Node n7 = new Node(new Persona("Marco Codevilla", 38));
            Node n8 = new Node(new Persona("Andrés Codevilla", 30));
            Node n9 = new Node(new Persona("Marcelo Arrarte", 20));

            Node n10 = new Node(new Persona("Julia Codevilla", 5));

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);
            n1.AddChildren(n5);
            n1.AddChildren(n6);

            n4.AddChildren(n7);
            n4.AddChildren(n8);

            n6.AddChildren(n9);

            n7.AddChildren(n10);

            // visitar el árbol aquí
            AddAgeVisitor visitor = new AddAgeVisitor();
            n1.AcceptVisitor(visitor);
            int sumaEdades = visitor.AddedAges;
            Console.WriteLine($"Suma edades: {sumaEdades}");

            FindOldestLeafVisitor visitor2 = new FindOldestLeafVisitor();
            n1.AcceptVisitor(visitor2);
            Persona oldestChild = visitor2.OldestChild;
            Console.WriteLine($"La hoja del árbol más vieja es {oldestChild.Nombre} y tiene {oldestChild.Edad} años.");
        
            FindLongestNameVisitor visitor3 = new FindLongestNameVisitor();
            n1.AcceptVisitor(visitor3);
            string longestName = visitor3.LongestName;
            Console.WriteLine($"El nombre más largo en el árbol es {longestName}.");
        }
    }
}
