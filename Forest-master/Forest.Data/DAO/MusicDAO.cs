using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.BEANS;
using Forest.Data.DAO;
using Forest.Data.IDAO;

namespace Forest.Data.DAO
{
    public class MusicDAO : IMusicDAO
    {
        private ForestDatabaseEntities  _context;
        public MusicDAO() { _context = new ForestDatabaseEntities(); }

        public IList<Music_Catergory> GetMusicCategories()
        {

            IQueryable<Music_Catergory> _categories;
            _categories = from category
                          in _context.Music_Catergory
                          select category;
            var a = _categories.ToList();
            return a;




        }

        public IList<MusicBEAN> GetMusicRecordings(int genre)
        {
            IQueryable<MusicBEAN> _musicBEANS = from recs in _context.Music_Recording
                                                from cats in _context.Music_Catergory
                                                where recs.Genre == cats.GenreId
                                                where cats.GenreId == genre
                                                select new MusicBEAN
                                                {
                                                    Id = recs.Id,
                                                    Artist = recs.Artist,
                                                    Title = recs.Title,
                                                    Genre = cats.Genre,
                                                    Image_Name = recs.Image_Name,
                                                    Num_Tracks = recs.Num_Tracks,
                                                    Price = recs.Price,
                                                    Stock_Count = recs.Stock_Count,
                                                    Released = recs.Released,
                                                    //Url = recs.Url

                                                };
            return _musicBEANS.ToList<MusicBEAN>();
        }


        //public IList<Music_Recording> GetMusicRecordings(string genre)
        //{

        //    IQueryable<Music_Recording> _recordings;
        //    _recordings = from recording
        //                  in _context.Music_Recording
        //                  where recording.Genre.Contains(genre)
        //                  select recording;
        //    var b = _recordings.ToList<Music_Recording>();
        //    return b;


        //    //This is a method to call information from the Music_Recording table.

        //}


        public MusicBEAN GetMusicRecording (int genre)
        {

        }


        //public Music_Recording GetMusicRecording(int id)

        //{
        //    IQueryable<Music_Recording> _recording;
        //    _recording = from recording
        //                 in _context.Music_Recording
        //                 where recording.Id == id
        //                 select recording;
        //    return _recording.ToList<Music_Recording>().First();


        //}






        // to remove the list wrapper use the .First(); 

        // match the variable to the where. Make sure these match. 






        public void EditMusicRecording(Music_Recording recording)

        {

            Music_Recording record = GetMusicRecording(recording.Id);
            //record.Artist = recording.Artist;
            record.Genre = recording.Genre;
            record.Image_Name = recording.Image_Name;
            record.Num_Tracks = recording.Num_Tracks;
            record.Price = recording.Price;
            record.Released = recording.Released;
            record.Stock_Count = recording.Stock_Count;
            record.Title = recording.Title;
            //record.Url = recording.Url;
            _context.SaveChanges();




            
        }

    public void AddMusicRecording(Music_Recording recording)

        {

            _context.Music_Recording.Add(recording);
            _context.SaveChanges();



        }



    public void DeleteMusicRecording(Music_Recording recording)
        {


            _context.Music_Recording.Remove(recording);
            _context.SaveChanges();



        }

      
    }
}
