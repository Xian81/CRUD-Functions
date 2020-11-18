using Forest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forest.Data.BEANS;

namespace Forest.Controllers
{
    public class MusicAdminController : Controller { 

  private Forest.Services.IService.IMusicService _MusicService;


    public MusicAdminController()
    {

        _MusicService = new Forest.Services.Service.MusicService();
    }



    
        // GET: MusicAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: MusicAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MusicAdmin/Create
        public ActionResult AddMusicRecording (int Genre)
        {
          
            return View();
        }
        //Why is this to convert to a string genre ? 
        //These two work together as one is Get and the other is Post.
        // POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult AddMusicRecording ( Music_Recording recording )
        {
            try
            {
                // TODO: Add insert logic here
                _MusicService.AddMusicRecording(recording);


                return RedirectToAction("GetMusicRecordings", new { genre = recording.GenreId, Controller = "Music" });
            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdmin/Edit/5
        
        public ActionResult EditMusicRecording(int id)
        {
            return View(_MusicService.GetMusicRecording(id));
        }

        // POST: MusicAdmin/Edit/5
        [HttpPost]
        public ActionResult EditMusicRecording (MusicBEAN recording )
        {
            try
            {
                // TODO: Add update logic here
                _MusicService.EditMusicRecording(recording);

                return RedirectToAction("GetMusicRecordingsTwo", new { genre = recording.Id, Controller = "Music" });
            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdmin/Delete/5
        [HttpGet]
        public ActionResult DeleteMusicRecording(int id)
        {
            return View(_MusicService.GetMusicRecording(id));
        }

        // POST: MusicAdmin/Delete/5
        [HttpPost]
        public ActionResult DeleteMusicRecording(Music_Recording rec)
        {
            try
            {
                // TODO: Add delete logic here


                //Music_Recording _recording;
                DeleteMusicRecording(rec);
                return RedirectToAction("Recordings",
                new { controller = "Music", Genre = rec.Id });


               

                
            }



            catch
            {
                return View();
            }
        }

    } 
}
