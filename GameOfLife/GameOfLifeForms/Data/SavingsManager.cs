using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Gameplay;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using GameOfLife.Data;

namespace GameOfLife.Data
{
    public class SavingsManager
    {
        public void SaveGameIntoDatabase(GameObject currentGame)
        {
            if (currentGame.typeGame >= 0)
            {
                UpdateSaving(currentGame);
                return;
            }
            using (var db = new GameSaving())
            {
                var js = new DataContractJsonSerializer(typeof(GameObject));
                using (MemoryStream stream1 = new MemoryStream())
                {
                    js.WriteObject(stream1, currentGame);
                    stream1.Position = 0;
                    Saving saving = new Saving() { typeGame = currentGame.typeGame };
                    db.Data.Add(saving);
                }
                db.SaveChanges();
            }
        }
        private void UpdateSaving(GameObject currentGame)
        {
            using (var db = new GameSaving())
            {
                var js = new DataContractJsonSerializer(typeof(GameObject));
                using (MemoryStream stream1 = new MemoryStream())
                {
                    js.WriteObject(stream1, currentGame);
                    stream1.Position = 0;
                    var query = db.Data.Where(g => g.Id == currentGame.typeGame);
                }
                db.SaveChanges();
            }
        }
        public void DeleteGame(GameObject currentGame)
        {
            using (var db = new GameSaving())
            {
                var query = db.Data.Where(s => s.Id == currentGame.typeGame).ToList();
                for (int i = 0; i < query.Count; i++)
                    db.Data.Remove(query[i]);
                db.SaveChanges();
            }
        }
        public bool CheckSavingsExists()
        {
            List<Saving> query;
            using (var db = new GameSaving())
            {
                query = db.Data.ToList();

            }
            return query.Count > 0;
        }
        public List<Saving> GetSavings()
        {
            List<Saving> savings = new List<Saving>();
            using (var db = new GameSaving())
            {
                savings = db.Data.ToList();
            }
            return savings;
        }
        public GameObject LoadGameByIndex(int index)
        {
            List<Saving> savings = GetSavings();
            GameObject currentGame = null;
            using (var db = new GameSaving())
            {
                var js = new DataContractJsonSerializer(typeof(GameObject));
                using (MemoryStream stream1 = new MemoryStream(Encoding.Unicode.GetBytes(savings[index].typeGame.ToString())))
                {
                    currentGame = (GameObject)js.ReadObject(stream1);
                    currentGame.typeGame = savings[index].Id;
                }
            }
            return currentGame;
        }
    }
}
