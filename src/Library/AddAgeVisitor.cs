namespace Library {
    public class AddAgeVisitor : IVisitor {
        public int AddedAges {get; private set;}

        public AddAgeVisitor() {
            this.AddedAges = 0;
        }

        public void Visitar(Node n)
        {
            this.AddedAges += n.Value.Edad;
            foreach (Node nodoHijo in n.Children) {
                nodoHijo.AcceptVisitor(this);
            }
        }
    }
}