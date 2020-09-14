using System.Collections.Generic;
using Forest.Data;
using Forest.Data.IDAO;
using Forest.Data.DAO;
using Forest.Services.IService;
using Forest.Data.BEANS;

namespace Forest.Services.Service
{
    public class MusicService: IMusicService

    {
        private IMusicDAO _musicDAO;
    
        public MusicService()
        {
          _musicDAO = new MusicDAO();
        }


    public IList<Music_Catergory>GetMusicCategories()

    {


        return _musicDAO.GetMusicCategories();
        


    }
        //public IList<Music_Recording> GetMusicRecordings(string genre)
        //{

        //    return _musicDAO.GetMusicRecordings(genre);



        //}


        public IList<MusicBEAN> GetMusicRecordings(int genre)
        {
            return _musicDAO.GetMusicRecordings(genre);
        }

        public Music_Recording GetMusicRecording(int id)
        {
            return _musicDAO.GetMusicRecording(id);
        }




        public void EditMusicRecording(Music_Recording recording)
        
        {

            _musicDAO.EditMusicRecording(recording);

        }

        public void AddMusicRecording(Music_Recording recording)
        {
            _musicDAO.AddMusicRecording(recording);
        }



        public void DeleteMusicRecording (Music_Recording recording)
        {

            _musicDAO.DeleteMusicRecording(recording);



        }




        //to implement
        //Method name:GetMusicRecordings
        //Return type:ILIst<Music Recording>
        //Parameter type:string
        //Parameter name:genre
        //Call the appropriate method of your DAO 
        //and return the result  


        // This order:

        // class
        // attributes
        //constructor
        //method


    }
}
