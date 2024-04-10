namespace SchemeEditor
{
    public class OpBlockPin
    {
        public string Name { get; set; }
        public bool IsInPin { get; set; }
        public OpBlockPin? Connection { get; set; }
        public OpBlockType Parent { get; set; }

        public OpBlockPin(string name, bool isIn, OpBlockType parent)
        {
            Name = name;
            IsInPin = isIn;
            Parent = parent;
        }

        public void Connect(OpBlockPin target)
        {
            if (IsInPin != target.IsInPin)
            {
                Connection = target;
                target.Connection = this;
            }
        }

        public override string ToString() => Name;
    }
}