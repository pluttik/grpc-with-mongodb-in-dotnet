using Grpc.Core;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace PlantCatalog.Services
{
    public class PlantCatalogService : PlantCatalog.PlantCatalogBase
    {
        private readonly ILogger<PlantCatalogService> _logger;
        private static readonly MongoClient mongoClient = new("mongodb://localhost:27017");
        private static readonly IMongoDatabase mongoDb = mongoClient.GetDatabase("plantdb");
        private static readonly IMongoCollection<BsonDocument> mongoCollection = mongoDb.GetCollection<BsonDocument>("plant");

        public PlantCatalogService(ILogger<PlantCatalogService> logger)
        {
            _logger = logger;
        }

        public override Task<CreatePlantReply> CreatePlant(CreatePlantRequest request, ServerCallContext context)
        {
            var plant = request.Plant;
            BsonDocument doc = new BsonDocument("common_name", plant.CommonName)
                .Add("latin_name", plant.LatinName)
                .Add("description", plant.Description);
            mongoCollection.InsertOne(doc);
            string id = doc.GetValue("_id").ToString();
            plant.Id = id;

            return Task.FromResult(new CreatePlantReply()
            {
                Plant = plant,
            });
        }

        public override Task<ReadPlantReply> ReadPlant(ReadPlantRequest request, ServerCallContext context)
        {
            var plantId = request.Id;
            var filter = new FilterDefinitionBuilder<BsonDocument>().Eq("_id", new ObjectId(plantId));
            var result = mongoCollection.Find(filter).FirstOrDefault();

            if (result == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Plant with id " + plantId + " was not found."));
            }

            Plant plant = new()
            {
                CommonName = result.GetValue("common_name").AsString,
                LatinName = result.GetValue("latin_name").AsString,
                Description = result.GetValue("description").AsString,
            };

            return Task.FromResult(new ReadPlantReply()
            {
                Plant = plant,
            });
        }

        public override Task<UpdatePlantReply> UpdatePlant(UpdatePlantRequest request, ServerCallContext context)
        {
            var plantId = request.Plant.Id;
            var filter = new FilterDefinitionBuilder<BsonDocument>().Eq("_id", new ObjectId(plantId));
            var result = mongoCollection.Find(filter).FirstOrDefault();

            if (result == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Plant with id " + plantId + " was not found."));
            }

            BsonDocument doc = new BsonDocument("common_name", request.Plant.CommonName)
                .Add("latin_name", request.Plant.LatinName)
                .Add("description", request.Plant.Description);
            mongoCollection.ReplaceOne(filter, doc);

            Plant plant = new Plant()
            {
                CommonName = doc.GetValue("common_name").AsString,
                LatinName = doc.GetValue("latin_name").AsString,
                Description = doc.GetValue("description").AsString,
            };
            return Task.FromResult(new UpdatePlantReply()
            {
                Plant = plant,
            });
        }

        public override Task<DeletePlantReply> DeletePlant(DeletePlantRequest request, ServerCallContext context)
        {
            var plantId = request.Id;
            var filter = new FilterDefinitionBuilder<BsonDocument>().Eq("_id", new ObjectId(plantId));

            var result = mongoCollection.DeleteOne(filter);

            if (result.DeletedCount == 0)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Plant with id " + plantId + " was not found."));
            }

            return Task.FromResult(new DeletePlantReply()
            {
                Id = plantId,
            });
        }

        public override async Task ListPlant(ListPlantRequest request, IServerStreamWriter<ListPlantReply> responseStream, ServerCallContext context)
        {
            var filter = new FilterDefinitionBuilder<BsonDocument>().Empty;
            var result = mongoCollection.Find(filter);

            foreach (var doc in result.ToList())
            {
                await responseStream.WriteAsync(new ListPlantReply()
                {
                    Plant = new Plant()
                    {
                        Id = doc.GetValue("_id").ToString(),
                        CommonName = doc.GetValue("common_name").AsString,
                        LatinName = doc.GetValue("latin_name").AsString,
                        Description = doc.GetValue("description").AsString,
                    }
                });
            }
        }
    }
}
