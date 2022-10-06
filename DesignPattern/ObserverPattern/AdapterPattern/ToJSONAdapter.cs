namespace AdapterPattern
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class ToJSONAdapter : ITarget
    {
        private readonly ConvertToJSONAdaptee _adaptee;

        public ToJSONAdapter(ConvertToJSONAdaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string Convert()
        {
            return _adaptee.Convert();
        }
    }
}