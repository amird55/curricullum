using GemBox.Spreadsheet;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // If you are using the Professional version, enter your serial key below.
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        // Definition of JSON file
        string jsonString = @"{
                ""0"": {
                    ""firstName"": ""John"",
                    ""lastName"": ""Smith"",
                    ""age"": 27,
                    ""email"": ""john.smith@gmail.com""
                },
                ""1"" : {
                    ""firstName"": ""Ann"",
                    ""lastName"": ""Doe"",
                    ""age"": 25,
                    ""email"": ""ann.doe@gmail.com""
                }
            }";

        // Deserialize JSON string
        Dictionary<string, User> users = JsonConvert.DeserializeObject<Dictionary<string, User>>(jsonString);

        // Create empty excel file with a sheet
        ExcelFile workbook = new ExcelFile();
        ExcelWorksheet worksheet = workbook.Worksheets.Add("Users");

        // Define header values
        worksheet.Cells[0, 0].Value = "First name";
        worksheet.Cells[0, 1].Value = "Last name";
        worksheet.Cells[0, 2].Value = "Age";
        worksheet.Cells[0, 3].Value = "Email";

        // Write deserialized values to a sheet
        int row = 0;
        foreach (User user in users.Values)
        {
            worksheet.Cells[++row, 0].Value = user.FirstName;
            worksheet.Cells[row, 1].Value = user.LastName;
            worksheet.Cells[row, 2].Value = user.Age;
            worksheet.Cells[row, 3].Value = user.Email;
        }

        // Save excel file
        workbook.Save("JsonToExcel.xlsx");
    }
}

class User
{
    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    [JsonProperty("lastName")]
    public string LastName { get; set; }

    [JsonProperty("age")]
    public int Age { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }
}