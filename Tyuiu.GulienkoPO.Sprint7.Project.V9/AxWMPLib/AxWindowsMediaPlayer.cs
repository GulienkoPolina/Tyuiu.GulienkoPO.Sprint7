

namespace AxWMPLib
{
    internal class AxWindowsMediaPlayer
    {
        public AxWindowsMediaPlayer()
        {
        }

        public DockStyle Dock { get; internal set; }
        public bool Enabled { get; internal set; }
        public Point Location { get; internal set; }
        public string Name { get; internal set; }
        public AxHost.State? OcxState { get; internal set; }
        public Size Size { get; internal set; }
        public int TabIndex { get; internal set; }
        public string URL { get; internal set; }
    }
}