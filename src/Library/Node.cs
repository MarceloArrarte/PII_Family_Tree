using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : IVisitable
    {
        public Persona Value {get; private set;}

        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona value)
        {
            this.Value = value;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
        public void AcceptVisitor(IVisitor visitor) {
            visitor.Visitar(this);
        }
    }
}
