#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Mongo.DAL.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace TestGuidFieldFromMongo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient();

            var monGoRepository = client.GetDatabase("skishift,");


            var parcelId = new Guid("3f2f47a3-860c-49a7-9618-a0884f79534d");

            var offerId = new Guid("3f2f47a3-860c-49a7-9618-a0884f79544d");

            var elementClientId = new Guid("3f7d416f-879d-41be-b411-2a08db977aa6");//client

            var filterParcelsByClientId = Builders<Parcel>.Filter.Eq("clientId", elementClientId);


            var mongoCollectionParcels = monGoRepository.GetCollection<Parcel>("Parcel");

            var element = (mongoCollectionParcels
                .Find(Builders<Parcel>.Filter.Eq("_id", parcelId))
                .FirstOrDefaultAsync()).Result;

            //works
            var allMongoCollectionParcels = monGoRepository.GetCollection<Parcel>("Parcel").Find(x=>true).ToList();
            //not works
            var parcelById = monGoRepository.GetCollection<Parcel>("Parcel").Find(x=>x.Id== parcelId).ToCursor().Current.FirstOrDefault();
            //not works
            var parcelByIdIdNext = monGoRepository.GetCollection<Parcel>("Parcel").Find(filterParcelsByClientId).FirstOrDefault();
        }
    }

    [BsonIgnoreExtraElements]
    public class Parcel
    {
        [BsonId]
        [BsonElement("_id")]
        public Guid Id { get; set; }
        public Guid? ClientId { get; set; }
        public DateTime Date { get; set; }
        public Address? AddressFrom { get; set; }
        public Address? AddressTo { get; set; }
        public BaggageType[]? BaggageTypes { get; set; }
        public double ParcelSum { get; set; }
        public string? ParcelDescription { get; set; }
        public Guid OfferId { get; set; }
    }

    public abstract class BaseEntity
    {

        [BsonId]
        [BsonElement("_id")]
        public Guid? Id { get; set; }
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
    }

    public class Address
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Additional { get; set; }

    }

    public enum BaggageType
    {
        [Description("Документы")] Documents,
        [Description("Легкий багаж")] LightLuggage,
        [Description("Среднегабаритный багаж")] Baggage,
        [Description("Паллеты")] Pallets
    }
}
