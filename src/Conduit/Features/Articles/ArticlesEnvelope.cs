using System.Collections.Generic;
using OwenSymes.API.Domain;

namespace OwenSymes.API.Features.Articles
{
    public class ArticlesEnvelope
    {
        public List<Article> Articles { get; set; }

        public int ArticlesCount { get; set; }
    }
}