namespace BaristaLabs.ChromeDevTools.DOM
{
    /// <summary>
    /// Called when a pseudo element is removed from an element.
    /// </summary>
    public sealed class PseudoElementRemovedEvent
    {
    
        
        /// <summary>
        /// Pseudo element's parent element id.
        /// </summary>
        
        public long ParentId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The removed pseudo element id.
        /// </summary>
        
        public long PseudoElementId
        {
            get;
            set;
        }
    
    }
}