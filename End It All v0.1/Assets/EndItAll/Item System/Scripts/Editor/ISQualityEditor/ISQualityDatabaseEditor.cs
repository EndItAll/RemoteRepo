using UnityEditor;
using UnityEngine;
using System.Collections;

namespace EndItAll.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {
        ISQualityDatabase qualityDatabase;
        Texture2D selectedTexture;
        int selectedIndex = -1;
        Vector2 _scrollPos;     //scroll for the listview

        const int SPRITE_BUTTON_SIZE = 64;

        const string DATABASE_NAME = @"eiaQualityDatabase.asset";
        const string DATABASE_PATH = @"Database";
//        const string DATABASE_FULL_PATH = @"Assets/"+ DATABASE_PATH +"/" + DATABASE_NAME;

        [MenuItem("EIA/Database/Quality Editor %#w")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.title = "Quality DB";
            window.Show();
        }

        void OnEnable()
        {
            if(qualityDatabase == null)
                qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
        }


        void OnGUI()
        {
            if(qualityDatabase == null)
            {
                Debug.LogWarning("qualityDatabase not loaded");
                    return;
            }
            ListView();

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
        }
        void BottomBar()
        {
            //count
            GUILayout.Label("Qualities: " + qualityDatabase.Count);

            //addbutton
            if(GUILayout.Button("Add", GUILayout.Width(33)))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }
    }
}