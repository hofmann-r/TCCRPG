﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Tilemaps;

public class TreeTile : Tile {

    public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) {
        go.GetComponent<SpriteRenderer>().sortingOrder = -position.y * 2;

        return base.StartUp(position, tilemap, go);
    }

#if UNITY_EDITOR
    [MenuItem("Assets/Create/Tiles/TreeTile")]
    public static void CreateTreeTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save TreeTile", "New TreeTile", "asset", "Save treeTile", "Assets");
        if (path == "")
        {
            return;
        }
        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<TreeTile>(), path);
    }

#endif
}
