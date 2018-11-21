using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public interface IMediaRepository
    {
        List<Media> Media { get; }

        void AddMedia(Media media);
    }
}
