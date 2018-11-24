using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class MediaTestRepository : IMediaRepository
    {
        private List<Media> medias = new List<Media>();
        
        public List<Media> Medias { get { return medias; } }

        public void AddMedia(Media media)
        {
            medias.Add(media);
        }

        public void CreateTestData(int cap)
        {
            for (int i = 0; i < cap; i++)
            {
                Media media = new Media
                {
                    MediaID = i,
                    Title = "Title for media " + i,
                    Artist = "Artist for media " + i,
                    Link = "Link for media " + i,
                    Type = "Type for media " + i
                };

                medias.Add(media);
            }
        }
    }
}
