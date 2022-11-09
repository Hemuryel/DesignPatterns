namespace DDGofChainOfResponsabilityResponse
{ 
    public class Request
    {
        public Format Format { get; private set; }

        public Request(Format format)
        {
            this.Format = format;
        }
    }
}