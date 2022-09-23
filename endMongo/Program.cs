using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Diagnostics;

namespace workPls
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.insertAll(100);
            //program.selectAll();
            //program.updateAll();
            //program.deleteAll();



            //program.insertUser(100);
            //program.insertSubscription(100);
            //program.insertProfile(100);

            //program.selectUser();
            //program.selectSubscription();
            //program.selectProfile();

            //program.updateUser();
            //program.updateSubscription();
            //program.updateProfile();

            //program.deleteUser();
            //program.deleteSubscription();
            //program.deleteProfile();
        }

        private void insertAll(int num)
        {
            insertUser(num);
            insertSubscription(num);
            insertProfile(num);
        }

        private void selectAll()
        {
            selectUser();
            selectSubscription();
            selectProfile();
        }

        private void updateAll()
        {
            updateUser();
            updateSubscription();
            updateProfile();
        }
        private void deleteAll()
        {
            deleteUser();
            deleteSubscription();
            deleteProfile();
        }

        private void insertUser(int num)
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < num; i++)
            {
                db.InsertUserRecord(new UserModel { Id = i , email = "example@stenden.com", pass = "myPassword" + i + "", birthdate = "" + i + "-03-1999", activated = false, wrongAttempts = i, blockedSince = null});
            }
            sw.Stop();
            TimeSpan timeTaken = sw.Elapsed;
            string foo = timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to insert: " + foo);
        }

        private void selectUser()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swRead = new Stopwatch();
            swRead.Start();
            db.selectUser();
            swRead.Stop();
            TimeSpan timeTakenRead = swRead.Elapsed;
            string fooRead = timeTakenRead.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to read: " + fooRead);
        }

        private void updateUser()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swUpdate = new Stopwatch();
            swUpdate.Start();
            db.updateUser();
            swUpdate.Stop();
            TimeSpan timeTakenUpdate = swUpdate.Elapsed;
            string fooUpdate = timeTakenUpdate.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to update: " + fooUpdate);
        }

        private void deleteUser()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swDelete = new Stopwatch();
            swDelete.Start();
            db.deleteUser();
            swDelete.Stop();
            TimeSpan timeTakenDelete = swDelete.Elapsed;
            string fooDelete = timeTakenDelete.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to delete: " + fooDelete);
        }

        private void insertSubscription(int num)
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < num; i++)
            {
                db.InsertSubscriptionRecord(new SubscriptionModel { Id = i, price = i+2, email = "example@stenden.com" });
            }
            sw.Stop();
            TimeSpan timeTaken = sw.Elapsed;
            string foo = timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to insert: " + foo);
        }

        private void selectSubscription()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swRead = new Stopwatch();
            swRead.Start();
            db.selectSubscription();
            swRead.Stop();
            TimeSpan timeTakenRead = swRead.Elapsed;
            string fooRead = timeTakenRead.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to read: " + fooRead);
        }

        private void updateSubscription()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swUpdate = new Stopwatch();
            swUpdate.Start();
            db.updateSubscription();
            swUpdate.Stop();
            TimeSpan timeTakenUpdate = swUpdate.Elapsed;
            string fooUpdate = timeTakenUpdate.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to update: " + fooUpdate);
        }

        private void deleteSubscription()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swDelete = new Stopwatch();
            swDelete.Start();
            db.deleteSubscription();
            swDelete.Stop();
            TimeSpan timeTakenDelete = swDelete.Elapsed;
            string fooDelete = timeTakenDelete.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to delete: " + fooDelete);
        }

        private void insertProfile(int num)
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch sw = new Stopwatch();
            var language = new Language()
            {
                Id = 1,
                name = "english"
            };

            sw.Start();
            for (int i = 0; i < num; i++)
            {
                db.InsertProfileRecord(new ProfileModel { Id = i, name = "name" + i +"", age = 15+i, languageID =  language});
            }
            sw.Stop();
            TimeSpan timeTaken = sw.Elapsed;
            string foo = timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to insert: " + foo);
        }

        private void selectProfile()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swRead = new Stopwatch();
            swRead.Start();
            db.selectProfile();
            swRead.Stop();
            TimeSpan timeTakenRead = swRead.Elapsed;
            string fooRead = timeTakenRead.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to read: " + fooRead);
        }

        private void updateProfile()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swUpdate = new Stopwatch();
            swUpdate.Start();
            db.updateProfile();
            swUpdate.Stop();
            TimeSpan timeTakenUpdate = swUpdate.Elapsed;
            string fooUpdate = timeTakenUpdate.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to update: " + fooUpdate);
        }

        private void deleteProfile()
        {
            MongoCRUD db = new MongoCRUD("endassignmentMongo");
            Stopwatch swDelete = new Stopwatch();
            swDelete.Start();
            db.deleteProfile();
            swDelete.Stop();
            TimeSpan timeTakenDelete = swDelete.Elapsed;
            string fooDelete = timeTakenDelete.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time taken to delete: " + fooDelete);
        }
    }
}