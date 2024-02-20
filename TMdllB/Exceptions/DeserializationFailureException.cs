namespace TMdllB.Exceptions
{
    public class DeserializationFailureException : Exception
    {
        public DeserializationFailureException() : base() { }

        public DeserializationFailureException(string json) : base($"Failed to deserialize the input: {json}") { }
        
    }
}
