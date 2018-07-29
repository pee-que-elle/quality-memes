using System;
using UnityEngine;

// Token: 0x0200031A RID: 794
public static class LGJGBKJCKPH
{
	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x06006A79 RID: 27257 RVA: 0x000280D8 File Offset: 0x000262D8
	public static bool HDMIHMIGIKJ
	{
		get
		{
			return QualitySettings.activeColorSpace == ColorSpace.Linear;
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x06006A7A RID: 27258 RVA: 0x000280E2 File Offset: 0x000262E2
	public static bool KGOQIEBFKHH
	{
		get
		{
			return SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06006A7B RID: 27259 RVA: 0x00348B58 File Offset: 0x00346D58
	public static Texture2D BHNJCHPOBIE
	{
		get
		{
			if (LGJGBKJCKPH.NDQLNNLJHII != null)
			{
				return LGJGBKJCKPH.NDQLNNLJHII;
			}
			LGJGBKJCKPH.NDQLNNLJHII = new Texture2D(1, 1, TextureFormat.ARGB32, false);
			LGJGBKJCKPH.NDQLNNLJHII.SetPixel(0, 0, new Color(1f, 1f, 1f, 1f));
			LGJGBKJCKPH.NDQLNNLJHII.Apply();
			return LGJGBKJCKPH.NDQLNNLJHII;
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06006A7C RID: 27260 RVA: 0x00348BBC File Offset: 0x00346DBC
	public static Mesh FCPPPOBKFHK
	{
		get
		{
			if (LGJGBKJCKPH.JFCLMIQDGCJ != null)
			{
				return LGJGBKJCKPH.JFCLMIQDGCJ;
			}
			Vector3[] vertices = new Vector3[]
			{
				new Vector3(-1f, -1f, 0f),
				new Vector3(1f, 1f, 0f),
				new Vector3(1f, -1f, 0f),
				new Vector3(-1f, 1f, 0f)
			};
			Vector2[] uv = new Vector2[]
			{
				new Vector2(0f, 0f),
				new Vector2(1f, 1f),
				new Vector2(1f, 0f),
				new Vector2(0f, 1f)
			};
			int[] triangles = new int[]
			{
				0,
				1,
				2,
				1,
				0,
				3
			};
			LGJGBKJCKPH.JFCLMIQDGCJ = new Mesh
			{
				vertices = vertices,
				uv = uv,
				triangles = triangles
			};
			LGJGBKJCKPH.JFCLMIQDGCJ.RecalculateNormals();
			LGJGBKJCKPH.JFCLMIQDGCJ.RecalculateBounds();
			return LGJGBKJCKPH.JFCLMIQDGCJ;
		}
	}

	// Token: 0x06006A7D RID: 27261 RVA: 0x00348D24 File Offset: 0x00346F24
	public static void FBQHMCHIOFB(Material PPLIPCEHGNM, int JGNJGIKCNQM)
	{
		GL.PushMatrix();
		GL.LoadOrtho();
		PPLIPCEHGNM.SetPass(JGNJGIKCNQM);
		GL.Begin(5);
		GL.TexCoord2(0f, 0f);
		GL.Vertex3(0f, 0f, 0.1f);
		GL.TexCoord2(1f, 0f);
		GL.Vertex3(1f, 0f, 0.1f);
		GL.TexCoord2(0f, 1f);
		GL.Vertex3(0f, 1f, 0.1f);
		GL.TexCoord2(1f, 1f);
		GL.Vertex3(1f, 1f, 0.1f);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06006A7E RID: 27262 RVA: 0x00348DE0 File Offset: 0x00346FE0
	public static void KOQKFCNKECJ(Texture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC, Material PPLIPCEHGNM, int JGNJGIKCNQM, bool HBQMQLMONBQ = true, bool BMLDHOPHLOK = false)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = OBEPQQEKFLC;
		GL.Clear(false, HBQMQLMONBQ, Color.clear);
		GL.PushMatrix();
		GL.LoadOrtho();
		PPLIPCEHGNM.SetTexture("_MainTex", PBHPQFLMQDB);
		PPLIPCEHGNM.SetPass(JGNJGIKCNQM);
		GL.Begin(5);
		GL.TexCoord2(0f, 0f);
		GL.Vertex3(0f, 0f, 0.1f);
		GL.TexCoord2(1f, 0f);
		GL.Vertex3(1f, 0f, 0.1f);
		GL.TexCoord2(0f, 1f);
		GL.Vertex3(0f, 1f, 0.1f);
		GL.TexCoord2(1f, 1f);
		GL.Vertex3(1f, 1f, 0.1f);
		GL.End();
		GL.PopMatrix();
		RenderTexture.active = active;
	}

	// Token: 0x06006A7F RID: 27263 RVA: 0x000280F5 File Offset: 0x000262F5
	public static void MOPPIIOIIDM(UnityEngine.Object NJBFOQDJBON)
	{
		if (NJBFOQDJBON != null)
		{
			UnityEngine.Object.Destroy(NJBFOQDJBON);
		}
	}

	// Token: 0x06006A80 RID: 27264 RVA: 0x00028106 File Offset: 0x00026306
	public static void LPQIKIFQJMF()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(LGJGBKJCKPH.JFCLMIQDGCJ);
	}

	// Token: 0x04001678 RID: 5752
	private static Texture2D NDQLNNLJHII;

	// Token: 0x04001679 RID: 5753
	private static Mesh JFCLMIQDGCJ;
}
