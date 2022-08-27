using UnityEditor;

namespace Kogane
{
    public sealed class EditorCheckCompleteDialog
    {
        private readonly string m_title;
        private readonly string m_message;

        public EditorCheckCompleteDialog( string title, string message )
        {
            m_title   = title;
            m_message = message;
        }

        public bool OpenCheck()
        {
            return EditorUtility.DisplayDialog
            (
                title: m_title,
                message: $"{m_message}しますか？",
                ok: "はい",
                cancel: "いいえ"
            );
        }

        public void OpenComplete()
        {
            EditorUtility.DisplayDialog
            (
                title: m_title,
                message: $"{m_message}しました",
                ok: "OK"
            );
        }
    }
}