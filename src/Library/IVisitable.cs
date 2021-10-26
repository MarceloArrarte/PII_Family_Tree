namespace Library {
    public interface IVisitable {
        void AcceptVisitor(IVisitor visitor);
    }
}