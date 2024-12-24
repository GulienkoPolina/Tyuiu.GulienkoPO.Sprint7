

namespace AxWMPLib
{
    internal class AxWindowsMediaPlayer
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public AxWindowsMediaPlayer()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
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