﻿
using UnityEngine;

namespace Siccity.GLTFUtility {
	[UnityEditor.AssetImporters.ScriptedImporter(1, "glb")]
	public class GLBImporter : GLTFImporter {

		public override void OnImportAsset(UnityEditor.AssetImporters.AssetImportContext ctx) {
			// Load asset
			GLTFAnimation.ImportResult[] animations;
			GameObject root = Importer.LoadFromFile(ctx.assetPath, importSettings, out animations, Format.GLB);
			// Save asset
			GLTFAssetUtility.SaveToAsset(root, animations, ctx);
		}
	}
}