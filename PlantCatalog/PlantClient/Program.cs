using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace PlantClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var plantClient = new PlantCatalog.PlantCatalog.PlantCatalogClient(channel);

            // await CreatePlant(plantClient);
            // await ReadPlant(plantClient);
            // await UpdatePlant(plantClient);
            // await DeletePlant(plantClient);
            await ListPlant(plantClient);
            
            channel.ShutdownAsync().Wait();
        }

        private static async Task CreatePlant(PlantCatalog.PlantCatalog.PlantCatalogClient plantClient)
        {
            var reply = await plantClient.CreatePlantAsync(new PlantCatalog.CreatePlantRequest()
            {
                Plant = new PlantCatalog.Plant()
                {
                    CommonName = "Baltic pine",
                    LatinName = "Pinus sylvestris",
                    Description = "Tree species of the pine family native to Eurasia."
                }
            });

            Console.WriteLine("This plant was created: " + reply.Plant);
        }

        private static async Task ReadPlant(PlantCatalog.PlantCatalog.PlantCatalogClient plantClient)
        {
            try
            {
                var reply = await plantClient.ReadPlantAsync(new PlantCatalog.ReadPlantRequest()
                {
                    // use an existing id from the database here
                    Id = "61865dfe1c481d4dc22d22c0",
                });

                Console.WriteLine("This plant was retrieved: " + reply.Plant.ToString());
            }
            catch(RpcException rpcException)
            {
                Console.WriteLine(rpcException.Status.Detail);
            }
        }

        private static async Task UpdatePlant(PlantCatalog.PlantCatalog.PlantCatalogClient plantClient)
        {
            try
            {
                var reply = await plantClient.UpdatePlantAsync(new PlantCatalog.UpdatePlantRequest()
                {
                    Plant = new PlantCatalog.Plant()
                    {
                        // use an existing id from the database here
                        Id = "61865dfe1c481d4dc22d22c0",
                        CommonName = "Daisy",
                        LatinName = "Bellis perennis",
                        Description = "Native European flowering plant."
                    }
                });

                Console.WriteLine("This plant was updated: " + reply.Plant.ToString());
            }
            catch (RpcException rpcException)
            {
                Console.WriteLine(rpcException.Status.Detail);
            }
        }

        private static async Task DeletePlant(PlantCatalog.PlantCatalog.PlantCatalogClient plantClient)
        {
            try
            {
                var reply = await plantClient.DeletePlantAsync(new PlantCatalog.DeletePlantRequest()
                {
                    Id = "61864ffe1100cedc3add79c8",
                });

                Console.WriteLine("Plant with this id was deleted: " + reply.Id.ToString());
            }
            catch (RpcException rpcException)
            {
                Console.WriteLine(rpcException.Status.Detail);
            }
        }

        private static async Task ListPlant(PlantCatalog.PlantCatalog.PlantCatalogClient plantClient)
        {
            var reply = plantClient.ListPlant(new PlantCatalog.ListPlantRequest());

            while (await reply.ResponseStream.MoveNext())
            {
                Console.WriteLine(reply.ResponseStream.Current.Plant.ToString());
            }
        }
    }
}
