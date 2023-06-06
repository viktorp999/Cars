using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarsDynamicLinkLibrary.IO
{
    public static class FileManager
    {
        public static void SaveGame(string filename, Player player)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);

            using (stream)
            {
                formatter.Serialize(stream, player);
            }
        }

        public static Player LoadGame(string filename)
        {
            Player player = null;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);

            using (stream)
            {
                player = (Player)formatter.Deserialize(stream);
            }

            return player;
        }

        public static Player NewGame()
        {
            Player player = new Player();

            return player;
        }
    }
}
