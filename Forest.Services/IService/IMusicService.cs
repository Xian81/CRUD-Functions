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

        IList<Forest.Data.Music_Category> GetMusicCategories();
        //IList<Forest.Data.Music_Recording> GetMusicRecordings(int genre);

        IList<MusicBEAN> GetMusicRecordings(int genre);

        MusicBEAN GetMusicRecording(int Id);

        //Music_Recording GetMusicRecording(int Id);

        void EditMusicRecording(MusicBEAN recording);


        void AddMusicRecording(Music_Recording recording);


        void DeleteMusicRecording(Music_Recording recording);









    }
}
