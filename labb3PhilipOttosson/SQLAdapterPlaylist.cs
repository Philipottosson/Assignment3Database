using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace labb3PhilipOttosson.Models
{
    public class SQLAdapterPlaylist
    {

        /// <summary>
        /// Will ask the user for the name of the new playlist
        /// Will send to diffrent method to get all the tracks.
        /// Will add all the tracks to the new playlist
        /// </summary>
        public static void AddPlaylist()
        {
            Console.WriteLine("\nEnter the name of the playlist!");
            string playlistName = Console.ReadLine();
            List<int> trackList = new List<int>();
            trackList = AddTracks();
            Playlist playlist = new Playlist();
            Track track = new Track();
            using (var context = new MusicContext())
            {
                int id = context.Playlists.OrderBy(x => x.PlaylistId).Last().PlaylistId + 1;
                playlist.Name = playlistName;
                playlist.PlaylistId = id;
                context.Playlists.Add(playlist);
                context.SaveChanges();
                foreach (var item in trackList)
                {
                    track = context.Tracks.SingleOrDefault(x => x.TrackId == item);

                    if (track != null)
                    {
                        playlist.PlaylistId = id;
                        context.Database.ExecuteSqlRaw("insert into music.playlist_track values({0}, {1})",playlist.PlaylistId, track.TrackId);
                        context.SaveChanges();
                    }
                }
                Console.WriteLine("They have been successfully added");
                //context.SaveChanges();
            }
        }
        /// <summary>
        /// Will ask for the name or id of the playlist
        /// Will then remove all the items in the playlist_track
        /// And then remove the playlist
        /// </summary>
        public static void RemovePlaylist()
        {
            Console.WriteLine("\nEnter the playlist you would like to remove (PlaylistId or Name)");
            string PlaylistName = Console.ReadLine();
            int playlistID;
            bool isNumber = Int32.TryParse(PlaylistName, out playlistID);
            Playlist playlist = new Playlist();
            PlaylistTrack playListTrack = new PlaylistTrack();
            using (var context = new MusicContext())
            {

                if (isNumber)
                {
                    playlist = context.Playlists.SingleOrDefault(
                    x => x.PlaylistId == playlistID);
                }
                else
                {
                    playlist = context.Playlists.SingleOrDefault(
                    x => x.Name == PlaylistName);

                }
                if (playlist != null)
                {
                    playListTrack = context.PlaylistTracks.Where(x => x.PlaylistId == playlist.PlaylistId).FirstOrDefault();
                    if (playListTrack != null)
                    {
                        context.Database.ExecuteSqlRaw("delete from music.playlist_track where PlaylistId={0}", playListTrack.PlaylistId);
                        context.SaveChanges();
                    }
                    context.Playlists.Remove(playlist);
                    context.SaveChanges();
                    Console.WriteLine("They have been successfully deleted");
                }
                else
                {
                    Console.WriteLine("Could not find the playlist.\n");
                }
            }
        }

        /// <summary>
        /// Will ask for the name or id of the playlist.
        /// Will ask if the user wants to remove or add tracks.
        /// Will send to diffrent method
        /// </summary>
        public static void ModifyPlaylist()
        {
            Console.WriteLine("\nEnter the information about the playlist\nyou would like to modify (PlaylistId or Name)");
            string playlistInfo = Console.ReadLine();
            bool addOrRemove = false;
            string value ="";
            using (var context = new MusicContext())
            {
                Playlist playlist = context.Playlists.SingleOrDefault(x => x.Name == playlistInfo || x.PlaylistId == Int32.Parse(playlistInfo));
                if (playlist == null)
                {
                    Console.WriteLine("\nCould not find playlist");
                    addOrRemove = true;
                }
            }
            
            //checking if the user wnats to add or remove
            while (!addOrRemove)
            {
                Console.WriteLine("\nWould you like to add or remove track?(add / remove)");
                value = Console.ReadLine().ToLower();
                if (value == "add" || value == "remove")
                {
                    addOrRemove = true;
                }
                else Console.WriteLine("\nWrong input");
            }
            //sending it to a new method to handle it
            switch (value)
            {
                case "add":
                    ModifyAdd(playlistInfo);
                    break;
                case "remove":
                    ModifyRemove(playlistInfo);
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// Will ask the user for trackids to remove form the list
        /// </summary>
        /// <param name="playlistInfo">Information about the playlist (Could be name or id)</param>
        private static void ModifyRemove(string playlistInfo)
        {
            bool moreTracks = true;
            List<int> trackList = new List<int>();
            while (moreTracks)
            {
                Console.WriteLine("\nEnter the TrackId that you would like to remove \n(-1 to continue without removing more)");
                int trackID;


                bool isValid = true;
                string Input = Console.ReadLine();
                if (Input == "-1")
                {
                    moreTracks = false;
                }
                foreach (char c in Input)
                {
                    if (!Char.IsDigit(c))
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    trackID = Int32.Parse(Input);
                    trackList.Add(trackID);
                }
            }
            //Finds the right playlist
            int playlistID;
            bool isNumber = Int32.TryParse(playlistInfo, out playlistID);


            Playlist playlist = new Playlist();
            PlaylistTrack playListTrack = new PlaylistTrack();

            using (var context = new MusicContext())
            {
                if (isNumber)
                {
                    playlist = context.Playlists.SingleOrDefault(
                       x => x.PlaylistId == playlistID);
                }
                else playlist = context.Playlists.SingleOrDefault(
                       x => x.Name == playlistInfo);
                foreach (var item in trackList)
                {
                    playListTrack = context.PlaylistTracks.Where(x => x.PlaylistId == playlist.PlaylistId &&
                    x.TrackId == item).SingleOrDefault();
                    if (playListTrack != null)
                    {
                        context.Database.ExecuteSqlRaw("delete from music.playlist_track where TrackId={0}", playListTrack.TrackId);
                        context.SaveChanges();
                    }
                }
                Console.WriteLine("They have been successfully removed");
            }
        }
        private static void ModifyAdd(string playlistInfo)
        {
            List<int> trackList = new List<int>();
            trackList = AddTracks();
            //Finds the right playlist
            int playlistID;
            bool isNumber = Int32.TryParse(playlistInfo, out playlistID);
            Track track = new Track();
            Playlist playlist = new Playlist();
            using (var context = new MusicContext())
            {
                if (isNumber)
                {
                    playlist = context.Playlists.SingleOrDefault(
                       x => x.PlaylistId == playlistID);
                }
                else playlist = context.Playlists.SingleOrDefault(
                       x => x.Name == playlistInfo);
                if (playlist != null)
                {
                    foreach (var item in trackList)
                    {
                        track = context.Tracks.SingleOrDefault(x => x.TrackId == item);

                        if (track != null && playlist != null)
                        {
                            context.Database.ExecuteSqlRaw("insert into music.playlist_track values({0}, {1})", playlist.PlaylistId, track.TrackId);
                            context.SaveChanges();
                        }
                    }
                    Console.WriteLine("They have been successfully added");
                }
                else
                {
                    Console.WriteLine("\nCould not find playlist\n");
                }
            }
        }
        private static List<int> AddTracks()
        {
            Console.WriteLine("\nWould you like to see a list of the tracks? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {

                using (var context = new MusicContext())
                {
                    List<Track> track = context.Tracks.ToList();
                    foreach (var item in track)
                    {
                        Console.WriteLine("Name: " + item.Name + ", Id: " + item.TrackId + "\n");
                    }
                }
            }
            List<int> trackList = new List<int>();
            Console.WriteLine("\nEnter trackIDs that you would like to have in your playlist (-1 to continue)");
            Console.WriteLine("If a trackID is invalid it will just be ignored\n");
            int trackID = 0;
            bool moreTracks = true;

            while (moreTracks)
            {
                bool isValid = true;
                string Input = Console.ReadLine();
                if (Input == "-1")
                {
                    moreTracks = false;
                }
                foreach (char c in Input)
                {
                    bool isNumber = Char.IsDigit(c);
                    if (!isNumber)
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    trackID = Int32.Parse(Input);
                    trackList.Add(trackID);
                }
            }
            return trackList;
        }
    }
}
