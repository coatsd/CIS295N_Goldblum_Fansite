using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class EFMediaRepository : IMediaRepository
	{
        private AppDbContext context;

        public EFMediaRepository(AppDbContext cxt)
        {
            context = cxt;
        }

        public List<Media> Medias { get { return context.Medias.ToList(); } }

        public void AddMedia(Media media)
        {
            context.Medias.Add(media);
            context.SaveChanges();
        }
	}
}
