using System;
using TechNotes.Domain.Notes;

namespace TechNotes.Application.Notes;

public class NoteService : INoteService
{
    public List<Note> GetAllNotes()
    {
        return new List<Note>
        {
            new()
            {
                Id=1,Title = "Primera Nota", Content = "Contenido de la primera nota", IsPublished = true, CreatedAt = DateTime.Now, PublishedAt = DateTime.Now
            },
            new()
            {
                Id=2,Title = "Primera Nota", Content = "Contenido de la segunda nota", IsPublished = false, CreatedAt = DateTime.Now, PublishedAt = null
            },
        };
    }
}
