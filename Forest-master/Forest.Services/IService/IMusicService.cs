using Forest.Data;
using Forest.Data.BEANS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Services.IService
{
    public interface IMusicService
    {

        IList<Music_Catergory> GetMusicCategories();

        //IList<Music_Recording> GetMusicRecordings(string genre);

        IList<MusicBEAN> GetMusicRecordings(int genre);

        Music_Recording GetMusicRecording(int id);

        void EditMusicRecording(Music_Recording recording);


        void AddMusicRecording(Music_Recording recording);


        void DeleteMusicRecording(Music_Recording recording);









    }
}
