namespace Challenge.Models
{
    public record struct PersonInfo 
(
    	string Name,
		string Address,
		string city,
		string region,
		string postalZip,
		string EventDate,
		string SKU_Number,
		string TrackCode,
		string Value,
		string email,
		bool active,
		int Id
);
    
}

// {var SKU_Number = ["SKU Number"]}
        // [JsonPropertyName("SKU Number")]
        // [JsonProperty(SKU_Number = "SKU Number")]