using System.Collections.Generic;
using OwenSymes.API.Domain;

namespace OwenSymes.API.Features.Comments
{
    public class CommentsEnvelope
    {
        public CommentsEnvelope(List<Comment> comments)
        {
            Comments = comments;
        }

        public List<Comment> Comments { get; }
    }
}