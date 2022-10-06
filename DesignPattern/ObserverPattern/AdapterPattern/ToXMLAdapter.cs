namespace AdapterPattern
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class ToXMLAdapter : ITarget
    {
        private readonly ConvertToXMLAdaptee _adaptee;

        public ToXMLAdapter(ConvertToXMLAdaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string Convert()
        {
            return _adaptee.Convert();
        }
    }
}