using ElevenNoteMobileApp.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ElevenNote.Models;
using System.Threading.Tasks;

namespace ElevenNoteMobileApp.Services
{
    public class FakeNoteService : INoteService
    {
        public Task<bool> AddNew(NoteCreate note)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int noteId)
        {
            throw new NotImplementedException();
        }

        public Task<List<NoteListItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<NoteDetail> GetById(int noteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(NoteEdit note)
        {
            throw new NotImplementedException();
        }
    }
}
