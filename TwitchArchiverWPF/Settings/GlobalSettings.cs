namespace TwitchArchiverWPF.Settings
{
    public class GlobalSettings
    {
        public RecordingSettings RecordingSettings { get; set; } = new RecordingSettings();
        public RenderSettings RenderSettings { get; set; } = new RenderSettings();
    }
}