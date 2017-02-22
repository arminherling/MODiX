﻿using MongoDB.Bson.Serialization.Attributes;

namespace Modix.Data.Models
{
    public class Ban : BaseModel
    {
        public Ban()
        {
            CollectionName = nameof(Ban);
        }

        [BsonElement("UserId")]
        public ulong UserId { get; set; }
        [BsonElement("CreatorId")]
        public ulong CreatorId { get; set; }
        [BsonElement("GuildId")]
        public ulong GuildId { get; set; }
        [BsonElement("Reason")]
        public string Reason { get; set; }
        [BsonElement("Active")]
        public bool Active { get; set; }
    }
}