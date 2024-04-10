namespace SchemeEditor
{
    public class OpBlockType
    {
        public string Name { get; set; }
        public List<OpBlockPin> InPins { get; set; }
        public List<OpBlockPin> OutPins { get; set; }

        public OpBlockType() : this("AND", new[] { "A", "B", "C" }, new[] { "A", "B" }) { }
        public OpBlockType(string name, string[] ins, string[] outs)
        {
            Name = name;
            InPins = ins.Select(x => new OpBlockPin(x, true, this)).ToList();
            OutPins = outs.Select(x => new OpBlockPin(x, false, this)).ToList();
        }
    }
}