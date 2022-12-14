using System.Collections.Generic;
using Challenge.Models;
using System.IO;
using System.Text.Json;

namespace Challenge.Repositories
{
    public class PersonInfoRepository
    {
        internal List<PersonInfo> GetAll()
        {
            var incomingData = new List<PersonInfo>();

            using (StreamReader r = new StreamReader("TestData.json"))
            {
                string json = r.ReadToEnd();
                json = json.Replace("SKU Number", "SKU_Number");
                incomingData = JsonSerializer.Deserialize<List<PersonInfo>>(json);
                // 
            }
            if (incomingData != null && incomingData.Count > 0){
            }
        return incomingData;
        }
    }
}