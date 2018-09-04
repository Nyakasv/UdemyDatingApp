using System;

namespace DatingApp.API.Dtos
{
    public class MessageToReturnDto
    {
    // Auto mapper can figure out (if SenderId and RecipientId relates to a UserId) which other information we need.
    public int Id { get; set; }
       public int SenderId { get; set; }
       public string SenderKnownAs { get; set; }
       public string SenderPhotoUrl { get; set; }
       public int RecipientId { get; set; }
       public string RecipientKnownAs { get; set; }
       public string RecipientPhotoUrl { get; set; }
       public string Content { get; set; }
       public bool IsRead { get; set; }
       public DateTime? DateRead { get; set; }
       public DateTime MessageSent { get; set; }
    }
}