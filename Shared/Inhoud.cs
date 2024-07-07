namespace WASM.Shared
{
    public class Inhoud
    {
        
        public class Value
        {
            public int? id { get; set; } = 0;

            public string? omschrijving { get; set; } = string.Empty;

            public string? voornaam { get; set; } = string.Empty;

            public string? achternaam { get; set; } = string.Empty;

            public string? regio { get; set; } = string.Empty;
        }

        public Value? value { get; set; }

        public int StatusCode { get; set; }

        public string? ContentType { get; set; } = string.Empty;

    }
}
