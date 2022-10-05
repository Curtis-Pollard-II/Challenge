// var incomingData = new List<PersonInfo>();

// using (StreamReader r = new StreamReader("TestData.json"))
// {
//     string json = r.ReadToEnd();
//     incomingData = JsonSerializer.Deserialize<List<PersonInfo>>(json);
// }

// if (incomingData != null && incomingData.Count > 0){
//     foreach (var personInfo in incomingData)
//     {
//         Console.WriteLine($"{personInfo.EventDate}");
//     }
// }

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