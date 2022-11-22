using SerializationParseFiles.Models;
using static SerializationParseFiles.ObjectExtensions;

var output = ObjectExtentions.ReadFromJsonFile<Squad>(@"D:\Projects\SerializationParseFiles\JSON\Super hero squad.json");


ObjectExtentions.WriteToJsonFile<Squad>(@"D:\Projects\SerializationParseFiles\JSON\Super hero squad.json", output);
ObjectExtentions.WriteToXmlFile<Squad>(@"D:\Projects\SerializationParseFiles\JSON\Super hero squad.json", output);
var xmlOutput = ObjectExtentions.ReadFromXmlFile<Squad>(@"D:\Projects\SerializationParseFiles\JSON\Super hero squad.json");
ObjectExtentions.WriteToJsonFile<Squad>(@"D:\Projects\SerializationParseFiles\JSON\Super hero squad.json", xmlOutput);
