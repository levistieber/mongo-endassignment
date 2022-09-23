using MongoDB.Bson;
using MongoDB.Driver;


namespace workPls
{
    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            db = client.GetDatabase(database);
        }

        public void InsertUserRecord<BsonDocument>(BsonDocument record)
        {
            var collection = db.GetCollection<BsonDocument>("User");
            collection.InsertOne(record);
        }

        public void selectUser()
        {
            var collection = db.GetCollection<UserModel>("User");
            var list = collection.Find(new BsonDocument()).ToList();

            foreach (var record in list)
            {
                Console.WriteLine(record.pass);
            }
        }

        public void updateUser()
        {
            var collection = db.GetCollection<BsonDocument>("User");
            var builder = Builders<BsonDocument>.Update;

            var update = builder.Set("activated", true);
            var filter = Builders<BsonDocument>.Filter.Empty;
            collection.UpdateMany(filter, update);
        }

        public void deleteUser()
        {
            var collection = db.GetCollection<UserModel>("User");
            var list = collection.Find(new BsonDocument()).ToList();

            var filter = Builders<UserModel>.Filter.Empty;
            collection.DeleteMany(filter);
        }

        public void InsertSubscriptionRecord<BsonDocument>(BsonDocument record)
        {
            var collection = db.GetCollection<BsonDocument>("Subscription");
            collection.InsertOne(record);
        }

        public void selectSubscription()
        {
            var collection = db.GetCollection<SubscriptionModel>("Subscription");
            var list = collection.Find(new BsonDocument()).ToList();

            foreach (var record in list)
            {
                Console.WriteLine(record.price);
            }
        }

        public void updateSubscription()
        {
            var collection = db.GetCollection<BsonDocument>("Subscription");
            var builder = Builders<BsonDocument>.Update;

            var update = builder.Set("price", 20);
            var filter = Builders<BsonDocument>.Filter.Empty;
            collection.UpdateMany(filter, update);
        }

        public void deleteSubscription()
        {
            var collection = db.GetCollection<SubscriptionModel>("Subscription");
            var list = collection.Find(new BsonDocument()).ToList();

            var filter = Builders<SubscriptionModel>.Filter.Empty;
            collection.DeleteMany(filter);
        }

        public void InsertProfileRecord<BsonDocument>(BsonDocument record)
        {
            var collection = db.GetCollection<BsonDocument>("Profile");
            collection.InsertOne(record);
        }

        public void selectProfile()
        {
            var collection = db.GetCollection<ProfileModel>("Profile");
            var list = collection.Find(new BsonDocument()).ToList();

            foreach (var record in list)
            {
                Console.WriteLine(record.name);
            }
        }

        public void updateProfile()
        {
            var collection = db.GetCollection<BsonDocument>("Profile");
            var builder = Builders<BsonDocument>.Update;

            var update = builder.Set("name", "John");
            var filter = Builders<BsonDocument>.Filter.Empty;
            collection.UpdateMany(filter, update);
        }

        public void deleteProfile()
        {
            var collection = db.GetCollection<ProfileModel>("Profile");
            var list = collection.Find(new BsonDocument()).ToList();

            var filter = Builders<ProfileModel>.Filter.Empty;
            collection.DeleteMany(filter);
        }
    }
}