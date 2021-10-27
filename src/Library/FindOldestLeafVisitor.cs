namespace Library {
    public class FindOldestLeafVisitor : IVisitor {
        public Persona OldestChild {get; private set;}

        public void Visitar(Node n) {
            if (n.Children.Count == 0) {
                if (this.OldestChild == null) {
                    this.OldestChild = n.Value;
                }
                else {
                    if (n.Value.Edad > this.OldestChild.Edad) {
                        this.OldestChild = n.Value;
                    }
                }
            }
            else {
                foreach (Node child in n.Children) {
                    child.AcceptVisitor(this);
                }
            }
        }
    }
}