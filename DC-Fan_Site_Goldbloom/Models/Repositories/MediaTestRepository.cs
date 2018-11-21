using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class MediaTestRepository : IMediaRepository
    {
        private List<Media> medias = new List<Media>();
        
        public List<Media> Media { get { return medias; } }

        public void AddMedia(Media media)
        {
            medias.Add(media);
        }
    }
}
