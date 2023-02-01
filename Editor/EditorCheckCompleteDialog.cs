using UnityEditor;
using UnityEngine;

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
            if ( Application.isBatchMode ) return true;

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
            if ( Application.isBatchMode ) return;

            EditorUtility.DisplayDialog
            (
                title: m_title,
                message: $"{m_message}しました",
                ok: "OK"
            );
        }

        public void OpenComplete( bool isSuccess )
        {
            if ( Application.isBatchMode ) return;

            EditorUtility.DisplayDialog
            (
                title: m_title,
                message: isSuccess ? $"{m_message}に成功しました" : $"{m_message}に失敗しました",
                ok: "OK"
            );
        }
    }
}