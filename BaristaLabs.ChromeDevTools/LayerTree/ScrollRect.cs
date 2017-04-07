namespace BaristaLabs.ChromeDevTools.LayerTree
{
    /// <summary>
    /// Rectangle where scrolling happens on the main thread.
    /// </summary>
    public sealed class ScrollRect
    {
    
        /// <summary>
        /// Rectangle itself.
        ///</summary>
        public BaristaLabs.ChromeDevTools.DOM.Rect Rect
        {
            get;
            set;
        }
    
        /// <summary>
        /// Reason for rectangle to force scrolling on the main thread
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
    }
}