namespace BaristaLabs.ChromeDevTools.CSS
{
    /// <summary>
    /// CSS rule collection for a single pseudo style.
    /// </summary>
    public sealed class PseudoElementMatches
    {
    
        /// <summary>
        /// Pseudo element type.
        ///</summary>
        public BaristaLabs.ChromeDevTools.DOM.PseudoType PseudoType
        {
            get;
            set;
        }
    
        /// <summary>
        /// Matches of CSS rules applicable to the pseudo style.
        ///</summary>
        public RuleMatch[] Matches
        {
            get;
            set;
        }
    
    }
}