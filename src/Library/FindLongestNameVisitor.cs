namespace Library {
    public class FindLongestNameVisitor : IVisitor {
        public string LongestName {get; private set;}

        public FindLongestNameVisitor() {
            this.LongestName = "";
        }

        public void Visitar(Node n) {
            if (n.Value.Nombre.Length > this.LongestName.Length) {
                this.LongestName = n.Value.Nombre;
            }
            foreach (Node child in n.Children) {
                child.AcceptVisitor(this);
            }
        }
    }
}