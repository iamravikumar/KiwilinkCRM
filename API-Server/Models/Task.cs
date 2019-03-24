﻿using API_Server.Data;
using API_Server.ViewModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Linq;

namespace API_Server.Models
{
    public class Task : Base
    {
        [JsonConverter(typeof(ObjectIdConverter))] public ObjectId ClientId { get; set; }
        public string ClientName { get; set; }
        public string Content { get; set; }
        public bool IsComplete { get; set; } = false;
        public string AssignedEmployeeName { get; set; }

        [BsonIgnore] public bool Saving { get; set; }
        [BsonIgnore] public bool Completing { get; set; }

        public void Save()
        {
            DB.Save<Task>(this);
        }

        public void MarkComplete(ObjectId Id)
        {
            var task = DB.Collection<Task>().Single(t => t.Id.Equals(Id));
            task.IsComplete = true;
            DB.Save<Task>(task);
        }
    }
}
