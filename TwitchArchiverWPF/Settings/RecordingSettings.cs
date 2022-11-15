namespace TwitchArchiverWPF.Settings
{
    public class RecordingSettings
    {
        public bool EnableTtv { get; set; } = false;
        public bool EnableLiveOauth { get; set; } = false;
        public string LiveOauth { get; set; } = "";
        public int LiveCheck { get; set; } = 3;
        public bool EnableVodOauth { get; set; } = false;
        public string VodOauth { get; set; } = "";
    }
}
