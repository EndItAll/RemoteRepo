using UnityEngine;
using System.Collections;

namespace EndItAll.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        void BottomStatusBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            GUILayout.Label("Bottom View");

            GUILayout.EndHorizontal();
        }
    }
}