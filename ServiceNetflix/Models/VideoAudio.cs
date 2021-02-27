using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class VideoAudio
    {
        public int IdVideoAudio { get; set; }
        public int? IdAudio { get; set; }
        public int? IdVideo { get; set; }

        public virtual Audio IdAudioNavigation { get; set; }
        public virtual Video IdVideoNavigation { get; set; }
    }
}
