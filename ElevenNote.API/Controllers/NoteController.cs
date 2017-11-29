using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.API.Controllers
{
    [Authorize]
    public class NoteController : ApiController
    {
        //  GET api/note
        public IHttpActionResult Get()
        {
            NoteService noteService = CreateNoteService();

            var notes = noteService.GetNotes();

            return Ok(notes);
        }

        //  GET api/note/5
        public IHttpActionResult Get(int id)
        {
            NoteService noteService = CreateNoteService();

            var note = noteService.GetNoteById(id);

            return Ok(note);
        }

        //  POST /api/note
        public IHttpActionResult Post(NoteCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            NoteService noteService = CreateNoteService();

            noteService.CreateNote(note);

            if (!noteService.CreateNote(note))
                return InternalServerError();

            return Ok();
        }

        //  /api/note/5
        public IHttpActionResult Put(NoteEdit note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            NoteService noteService = CreateNoteService();

            if (!noteService.UpdateNote(note))
            {
                return InternalServerError();
            }

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            NoteService noteService = CreateNoteService();

            if (!noteService.DeleteNote(id))
            {
                return InternalServerError();
            }

            return Ok();
        }

        private NoteService CreateNoteService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new NoteService(userId);
            return noteService;
        }
    }
}
