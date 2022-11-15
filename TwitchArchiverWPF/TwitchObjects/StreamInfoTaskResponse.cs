using System.Collections.Generic;

namespace TwitchArchiverWPF.TwitchObjects
{
    class StreamInfoTaskResponse
    {
        public string? Title { get; set; }
        public List<string> Games { get; set; } = new List<string>();
    }
}
