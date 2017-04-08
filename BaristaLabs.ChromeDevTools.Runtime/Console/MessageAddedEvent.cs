namespace BaristaLabs.ChromeDevTools.Runtime.Console
{
    /// <summary>
    /// Issued when new console message is added.
    /// </summary>
    [Event("Console.messageAdded")]
    public sealed class MessageAddedEvent : IEvent
    {
    
        
        /// <summary>
        /// Console message that has been added.
        /// </summary>
        
        public ConsoleMessage Message
        {
            get;
            set;
        }
    
    }
}