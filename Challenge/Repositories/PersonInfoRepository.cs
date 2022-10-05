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
                incomingData = JsonSerializer.Deserialize<List<PersonInfo>>(json);
            }
        return <;
        }
    }
}