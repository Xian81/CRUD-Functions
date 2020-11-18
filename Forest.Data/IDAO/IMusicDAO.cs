using System;
using System.Collections.Generic;
using Forest.Data.BEANS;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO {



        //To implement;
        //Method name: GetMusicRecordings>
        //Return type: IList<Music_Recordings>
        //Parameter type:string
        //Parameter name:genre


        IList<Music_Category> GetMusicCategories();

        //IList<Music_Recording> GetMusicRecordings(int genre);

        IList<MusicBEAN> GetMusicRecordings(int genre);

        //Music_Recording GetMusicRecording(int id);

        MusicBEAN GetMusicRecording(int id);


        void EditMusicRecording(MusicBEAN recording);


        void AddMusicRecording(Music_Recording recording);


        void DeleteMusicRecording(Music_Recording  recording);
        
        //Do not use <> brackets these are only for a list.

        //This is the interface that calls the methods in MusicDAO.


        //Need to have an input if this leads to other categories. 


    }

}

    
 


           

    


