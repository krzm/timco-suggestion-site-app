using MongoDB.Bson.Serialization.Attributes;

namespace SuggestionAppLib.Models;

public class StatusModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string StatusName { get; set; }
    public string StatusDescription { get; set; }
}