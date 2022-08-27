namespace Kogane
{
    public sealed class EditorCheckCompleteDialogCreator
    {
        private readonly string m_title;

        public EditorCheckCompleteDialogCreator( string title )
        {
            m_title = title;
        }

        public EditorCheckCompleteDialog Create( string message )
        {
            return new( m_title, message );
        }
    }
}