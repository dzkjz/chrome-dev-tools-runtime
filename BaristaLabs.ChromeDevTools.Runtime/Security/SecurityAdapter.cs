namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Security domain to simplify the command interface.
    /// </summary>
    public class SecurityAdapter
    {
        private readonly ChromeSession m_session;
        
        public SecurityAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Enables tracking security state changes.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables tracking security state changes.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Displays native dialog with the certificate details.
        /// </summary>
        public async Task<ShowCertificateViewerCommandResponse> ShowCertificateViewer(ShowCertificateViewerCommand command)
        {
            return await m_session.SendCommand<ShowCertificateViewerCommand, ShowCertificateViewerCommandResponse>(command);
        }
    
    }
}