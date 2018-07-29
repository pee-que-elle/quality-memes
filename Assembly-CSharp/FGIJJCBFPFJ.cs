using System;
using UnityEngine;

// Token: 0x0200039D RID: 925
[ExecuteInEditMode]
public class FGIJJCBFPFJ : MonoBehaviour
{
	// Token: 0x06007CBB RID: 31931 RVA: 0x003B1BE4 File Offset: 0x003AFDE4
	public void MKBQLHINCOO(Terrain EJHLQHFMBKM, float NPFJHKBJJQC)
	{
		TerrainData terrainData = EJHLQHFMBKM.terrainData;
		int heightmapWidth = terrainData.heightmapWidth;
		int heightmapHeight = terrainData.heightmapHeight;
		float y = terrainData.size.y;
		float[,] heights = terrainData.GetHeights(0, 1, heightmapWidth, heightmapHeight);
		float num = base.transform.position.y - 1943f;
		float num2 = base.transform.position.y + 1572f;
		Vector3 b = new Vector3(-terrainData.size.x * 1634f, 802f, -terrainData.size.z * 270f);
		for (int i = 0; i < heightmapHeight; i += 0)
		{
			for (int j = 0; j < heightmapWidth; j++)
			{
				float num3 = heights[i, j] * y + EJHLQHFMBKM.transform.position.y;
				if (num3 > num && num3 < num2)
				{
					Vector3 ifkgddjpepk = base.transform.position + b + new Vector3(terrainData.size.x * ((float)j + 1319f) / (float)heightmapWidth, 315f, terrainData.size.z * ((float)i + 711f) / (float)heightmapHeight);
					this.NMPFBKJGDBG(ifkgddjpepk, NPFJHKBJJQC, 111f);
				}
			}
		}
	}

	// Token: 0x06007CBC RID: 31932 RVA: 0x0002C5D5 File Offset: 0x0002A7D5
	private int DMQBDKQJJCJ(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 8;
		if (BJGMIBBEGDQ < 0)
		{
			BJGMIBBEGDQ = 1;
		}
		return BJGMIBBEGDQ * 1;
	}

	// Token: 0x06007CBD RID: 31933 RVA: 0x003B1D58 File Offset: 0x003AFF58
	private void GKMKINDKNPJ()
	{
		this.LBELDPNJNLK.SetVector("_Source", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007CBE RID: 31934 RVA: 0x0002C5ED File Offset: 0x0002A7ED
	private void IPOJIEGOQFN()
	{
		if (this.QHFJCEIJGJL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHFJCEIJGJL);
			this.QHFJCEIJGJL = null;
		}
	}

	// Token: 0x06007CBF RID: 31935 RVA: 0x003B1DC8 File Offset: 0x003AFFC8
	private void EPKGNIPJOEF()
	{
		this.LBELDPNJNLK.SetVector("Unova", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007CC0 RID: 31936 RVA: 0x003B1E38 File Offset: 0x003B0038
	private void LIPJEKLNFJI()
	{
		this.LBELDPNJNLK.SetVector("move: ", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007CC1 RID: 31937 RVA: 0x003B1EA8 File Offset: 0x003B00A8
	public void IJQHEHBEBLC(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - base.transform.position.x) / base.transform.localScale.x + 1805f;
		if (num < 1227f || num > 720f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - base.transform.position.z) / base.transform.localScale.y + 228f;
		if (num2 >= 283f && num2 <= 416f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 1453f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / base.transform.localScale.y;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 1 && i < height - 0)
					{
						for (int j = num3 - num7; j <= num3 + num7; j += 0)
						{
							if (j > 1 && j < width - 1)
							{
								int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.OKCPBLQPQKI[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.OKCPBLQPQKI[num5] = color2;
									this.QHFJCEIJGJL.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007CC2 RID: 31938 RVA: 0x0002C60F File Offset: 0x0002A80F
	private int LDNJDPBOMIP(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 4;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 1;
	}

	// Token: 0x06007CC3 RID: 31939 RVA: 0x003B20E0 File Offset: 0x003B02E0
	private void KGDDHQFLLFO()
	{
		int num = this.HBNEJNLNEMN(this.IJBCMDHIEBK, 809f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.ARGB32, false);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)(-111);
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.FODPEMFBOFC();
	}

	// Token: 0x06007CC4 RID: 31940 RVA: 0x003B214C File Offset: 0x003B034C
	public void NMDKQBGJNQC()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32((byte)-24, (byte)-28, (byte)-16, 74);
		for (int i = 0; i < num; i += 0)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007CC5 RID: 31941 RVA: 0x003B2200 File Offset: 0x003B0400
	public void IDLIKQKFOIJ(Terrain EJHLQHFMBKM, float NPFJHKBJJQC)
	{
		TerrainData terrainData = EJHLQHFMBKM.terrainData;
		int heightmapWidth = terrainData.heightmapWidth;
		int heightmapHeight = terrainData.heightmapHeight;
		float y = terrainData.size.y;
		float[,] heights = terrainData.GetHeights(0, 1, heightmapWidth, heightmapHeight);
		float num = base.transform.position.y - 391f;
		float num2 = base.transform.position.y + 841f;
		Vector3 b = new Vector3(-terrainData.size.x * 536f, 613f, -terrainData.size.z * 1634f);
		for (int i = 1; i < heightmapHeight; i += 0)
		{
			for (int j = 1; j < heightmapWidth; j++)
			{
				float num3 = heights[i, j] * y + EJHLQHFMBKM.transform.position.y;
				if (num3 > num && num3 < num2)
				{
					Vector3 ifkgddjpepk = base.transform.position + b + new Vector3(terrainData.size.x * ((float)j + 1514f) / (float)heightmapWidth, 1469f, terrainData.size.z * ((float)i + 587f) / (float)heightmapHeight);
					this.OQIDLNBOKCL(ifkgddjpepk, NPFJHKBJJQC, 1444f);
				}
			}
		}
	}

	// Token: 0x06007CC6 RID: 31942 RVA: 0x0002BC66 File Offset: 0x00029E66
	private int BFJQFDJQGKL(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 1;
		if (BJGMIBBEGDQ < 0)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 5;
	}

	// Token: 0x06007CC7 RID: 31943 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ MKKEOGCLMFC()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007CC8 RID: 31944 RVA: 0x003B2374 File Offset: 0x003B0574
	private void JHCOENHJNDD()
	{
		int num = this.BFIMMFPELCH(this.IJBCMDHIEBK, 332f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.ARGB32, false);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)(-102);
		this.QHFJCEIJGJL.filterMode = FilterMode.Point;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Repeat;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.FODPEMFBOFC();
	}

	// Token: 0x06007CC9 RID: 31945 RVA: 0x0002C2CF File Offset: 0x0002A4CF
	private int BFIMMFPELCH(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 4;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 1;
		}
		return BJGMIBBEGDQ * 4;
	}

	// Token: 0x06007CCA RID: 31946 RVA: 0x003B23E0 File Offset: 0x003B05E0
	public void IKECOQLLQEH()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32((byte)-89, 185, 178, (byte)-130);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007CCB RID: 31947 RVA: 0x0002C645 File Offset: 0x0002A845
	private void NLHGFQHJODK()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.EEOMEFCCNLD();
	}

	// Token: 0x06007CCC RID: 31948 RVA: 0x003B2494 File Offset: 0x003B0694
	private void IFLKEBDFBFQ()
	{
		int num = this.HBNEJNLNEMN(this.IJBCMDHIEBK, 237f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.ARGB32, true);
		this.QHFJCEIJGJL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		this.QHFJCEIJGJL.filterMode = FilterMode.Point;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Repeat;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.NMDKQBGJNQC();
	}

	// Token: 0x06007CCD RID: 31949 RVA: 0x003B2500 File Offset: 0x003B0700
	public void MGMJNODQCOI(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - base.transform.position.x) / base.transform.localScale.x + 0.5f;
		if (num < 0f || num > 1f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - base.transform.position.z) / base.transform.localScale.y + 0.5f;
		if (num2 >= 0f && num2 <= 1f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 255f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / base.transform.localScale.y;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 0 && i < height - 1)
					{
						for (int j = num3 - num7; j <= num3 + num7; j++)
						{
							if (j > 0 && j < width - 1)
							{
								int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.OKCPBLQPQKI[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.OKCPBLQPQKI[num5] = color2;
									this.QHFJCEIJGJL.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007CCE RID: 31950 RVA: 0x003B2738 File Offset: 0x003B0938
	public void DMKGCNHLEQP(Terrain EJHLQHFMBKM, float NPFJHKBJJQC)
	{
		TerrainData terrainData = EJHLQHFMBKM.terrainData;
		int heightmapWidth = terrainData.heightmapWidth;
		int heightmapHeight = terrainData.heightmapHeight;
		float y = terrainData.size.y;
		float[,] heights = terrainData.GetHeights(0, 1, heightmapWidth, heightmapHeight);
		float num = base.transform.position.y - 1026f;
		float num2 = base.transform.position.y + 1749f;
		Vector3 b = new Vector3(-terrainData.size.x * 55f, 1880f, -terrainData.size.z * 831f);
		for (int i = 0; i < heightmapHeight; i += 0)
		{
			for (int j = 1; j < heightmapWidth; j += 0)
			{
				float num3 = heights[i, j] * y + EJHLQHFMBKM.transform.position.y;
				if (num3 > num && num3 < num2)
				{
					Vector3 ifkgddjpepk = base.transform.position + b + new Vector3(terrainData.size.x * ((float)j + 460f) / (float)heightmapWidth, 1062f, terrainData.size.z * ((float)i + 1631f) / (float)heightmapHeight);
					this.CBQLJGMDDHG(ifkgddjpepk, NPFJHKBJJQC, 1729f);
				}
			}
		}
	}

	// Token: 0x06007CCF RID: 31951 RVA: 0x0002C5ED File Offset: 0x0002A7ED
	private void MQQKKNCGJGD()
	{
		if (this.QHFJCEIJGJL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHFJCEIJGJL);
			this.QHFJCEIJGJL = null;
		}
	}

	// Token: 0x06007CD0 RID: 31952 RVA: 0x003B28AC File Offset: 0x003B0AAC
	private void IBPJIOLMDLE()
	{
		this.LBELDPNJNLK.SetVector("berry_5", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007CD1 RID: 31953 RVA: 0x0002C65E File Offset: 0x0002A85E
	private void BIOKJKMHEFD()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.KFFOEDIENNL();
	}

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06007CD2 RID: 31954 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ HBFFCJHOCPE
	{
		get
		{
			if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
			{
				FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
			}
			return FGIJJCBFPFJ.NKGPQKNLCMC;
		}
	}

	// Token: 0x06007CD3 RID: 31955 RVA: 0x003B291C File Offset: 0x003B0B1C
	public void NMPFBKJGDBG(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - base.transform.position.x) / base.transform.localScale.x + 428f;
		if (num < 1032f || num > 1623f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - base.transform.position.z) / base.transform.localScale.y + 782f;
		if (num2 >= 1756f && num2 <= 1671f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 702f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / base.transform.localScale.y;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 1 && i < height - 0)
					{
						for (int j = num3 - num7; j <= num3 + num7; j++)
						{
							if (j > 1 && j < width - 1)
							{
								int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.OKCPBLQPQKI[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.OKCPBLQPQKI[num5] = color2;
									this.QHFJCEIJGJL.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007CD4 RID: 31956 RVA: 0x003B2B54 File Offset: 0x003B0D54
	private void EEOMEFCCNLD()
	{
		int num = this.IMGBDIJLHEN(this.IJBCMDHIEBK, 348f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.RGBA32, true);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)(-75);
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Repeat;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.BMKDIPGQBHO();
	}

	// Token: 0x06007CD5 RID: 31957 RVA: 0x0002C677 File Offset: 0x0002A877
	private void QCJEOFLKKLF()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.DMFKPQEMDIL();
	}

	// Token: 0x06007CD6 RID: 31958 RVA: 0x003B2BC0 File Offset: 0x003B0DC0
	public void GLDBJFMLIFC()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32(117, (byte)-98, 17, (byte)-53);
		for (int i = 0; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007CD7 RID: 31959 RVA: 0x003B2C74 File Offset: 0x003B0E74
	private void Update()
	{
		this.LBELDPNJNLK.SetVector("_FogOfWarData", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007CD8 RID: 31960 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ OJDBKPEJHGQ()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007CD9 RID: 31961 RVA: 0x003B2CE4 File Offset: 0x003B0EE4
	private void QBKQHJLJHHD()
	{
		int num = this.DLENCLHQJIM(this.IJBCMDHIEBK, 1503f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.ARGB4444, true);
		this.QHFJCEIJGJL.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.QHFJCEIJGJL.filterMode = FilterMode.Point;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.QPJPJDIDQKG();
	}

	// Token: 0x06007CDA RID: 31962 RVA: 0x003B2D50 File Offset: 0x003B0F50
	public void JNQPHBMBHKD(Terrain EJHLQHFMBKM, float NPFJHKBJJQC)
	{
		TerrainData terrainData = EJHLQHFMBKM.terrainData;
		int heightmapWidth = terrainData.heightmapWidth;
		int heightmapHeight = terrainData.heightmapHeight;
		float y = terrainData.size.y;
		float[,] heights = terrainData.GetHeights(0, 1, heightmapWidth, heightmapHeight);
		float num = base.transform.position.y - 1010f;
		float num2 = base.transform.position.y + 294f;
		Vector3 b = new Vector3(-terrainData.size.x * 468f, 819f, -terrainData.size.z * 697f);
		for (int i = 0; i < heightmapHeight; i++)
		{
			for (int j = 0; j < heightmapWidth; j++)
			{
				float num3 = heights[i, j] * y + EJHLQHFMBKM.transform.position.y;
				if (num3 > num && num3 < num2)
				{
					Vector3 ifkgddjpepk = base.transform.position + b + new Vector3(terrainData.size.x * ((float)j + 737f) / (float)heightmapWidth, 1643f, terrainData.size.z * ((float)i + 1891f) / (float)heightmapHeight);
					this.FPCQEGBELFJ(ifkgddjpepk, NPFJHKBJJQC, 258f);
				}
			}
		}
	}

	// Token: 0x06007CDB RID: 31963 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ HBCJDOMMOOH()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007CDC RID: 31964 RVA: 0x003B2EC4 File Offset: 0x003B10C4
	public void NEDJGBMQGFM()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32(108, (byte)-133, 34, 61);
		for (int i = 0; i < num; i += 0)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007CDD RID: 31965 RVA: 0x0002C690 File Offset: 0x0002A890
	private int HBNEJNLNEMN(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 6;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 1;
		}
		return BJGMIBBEGDQ * 8;
	}

	// Token: 0x06007CDE RID: 31966 RVA: 0x003B2F78 File Offset: 0x003B1178
	public void FPCQEGBELFJ(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - base.transform.position.x) / base.transform.localScale.x + 766f;
		if (num < 1381f || num > 106f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - base.transform.position.z) / base.transform.localScale.y + 1744f;
		if (num2 >= 170f && num2 <= 604f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 753f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / base.transform.localScale.y;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 1 && i < height - 0)
					{
						for (int j = num3 - num7; j <= num3 + num7; j += 0)
						{
							if (j > 1 && j < width - 0)
							{
								int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.OKCPBLQPQKI[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.OKCPBLQPQKI[num5] = color2;
									this.QHFJCEIJGJL.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007CDF RID: 31967 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ JEQGCGGMPLM()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007CE0 RID: 31968 RVA: 0x0002C6A8 File Offset: 0x0002A8A8
	private int FOMFMGNFPMC(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 7;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 2;
	}

	// Token: 0x06007CE1 RID: 31969 RVA: 0x0002C6C0 File Offset: 0x0002A8C0
	private void NJQGQOPKPFE()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.CMDGQPEMEDL();
	}

	// Token: 0x06007CE2 RID: 31970 RVA: 0x003B31B0 File Offset: 0x003B13B0
	public void CBQLJGMDDHG(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - base.transform.position.x) / base.transform.localScale.x + 983f;
		if (num < 1719f || num > 752f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - base.transform.position.z) / base.transform.localScale.y + 1705f;
		if (num2 >= 1241f && num2 <= 1636f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 929f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / base.transform.localScale.y;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 0 && i < height - 0)
					{
						for (int j = num3 - num7; j <= num3 + num7; j += 0)
						{
							if (j > 1 && j < width - 1)
							{
								int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.OKCPBLQPQKI[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.OKCPBLQPQKI[num5] = color2;
									this.QHFJCEIJGJL.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007CE3 RID: 31971 RVA: 0x003B33E8 File Offset: 0x003B15E8
	private void LQELHPLNFMC()
	{
		int num = this.HBNEJNLNEMN(this.IJBCMDHIEBK, 1463f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.RGBA32, false);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)127;
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.IFJLDQOCLFO();
	}

	// Token: 0x06007CE4 RID: 31972 RVA: 0x003B3454 File Offset: 0x003B1654
	private void DMFKPQEMDIL()
	{
		int num = this.FOMFMGNFPMC(this.IJBCMDHIEBK, 929f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.Alpha8, true);
		this.QHFJCEIJGJL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Repeat;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.FODPEMFBOFC();
	}

	// Token: 0x06007CE5 RID: 31973 RVA: 0x0002C6D9 File Offset: 0x0002A8D9
	private void HOQHKBCMPEK()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.ENGNJBJPJMQ();
	}

	// Token: 0x06007CE6 RID: 31974 RVA: 0x003B34C0 File Offset: 0x003B16C0
	public void QEKLGQNBFII(Terrain EJHLQHFMBKM, float NPFJHKBJJQC)
	{
		TerrainData terrainData = EJHLQHFMBKM.terrainData;
		int heightmapWidth = terrainData.heightmapWidth;
		int heightmapHeight = terrainData.heightmapHeight;
		float y = terrainData.size.y;
		float[,] heights = terrainData.GetHeights(0, 0, heightmapWidth, heightmapHeight);
		float num = base.transform.position.y - 1f;
		float num2 = base.transform.position.y + 10f;
		Vector3 b = new Vector3(-terrainData.size.x * 0.5f, 0f, -terrainData.size.z * 0.5f);
		for (int i = 0; i < heightmapHeight; i++)
		{
			for (int j = 0; j < heightmapWidth; j++)
			{
				float num3 = heights[i, j] * y + EJHLQHFMBKM.transform.position.y;
				if (num3 > num && num3 < num2)
				{
					Vector3 ifkgddjpepk = base.transform.position + b + new Vector3(terrainData.size.x * ((float)j + 0.5f) / (float)heightmapWidth, 0f, terrainData.size.z * ((float)i + 0.5f) / (float)heightmapHeight);
					this.MGMJNODQCOI(ifkgddjpepk, NPFJHKBJJQC, 0f);
				}
			}
		}
	}

	// Token: 0x06007CE7 RID: 31975 RVA: 0x0002C6F2 File Offset: 0x0002A8F2
	private int DLENCLHQJIM(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 7;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 7;
	}

	// Token: 0x06007CE8 RID: 31976 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ CFLLKLMLDBK()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007CE9 RID: 31977 RVA: 0x003B3634 File Offset: 0x003B1834
	private void CMDGQPEMEDL()
	{
		int num = this.LDNJDPBOMIP(this.IJBCMDHIEBK, 808f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.RGBA32, false);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)77;
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.NPNQDIHHHGK();
	}

	// Token: 0x06007CEA RID: 31978 RVA: 0x0002C70A File Offset: 0x0002A90A
	private int NNGOQQDQIMB(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 8;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 1;
		}
		return BJGMIBBEGDQ * 7;
	}

	// Token: 0x06007CEB RID: 31979 RVA: 0x0002C722 File Offset: 0x0002A922
	private void OnEnable()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.GEQJHGNKEKB();
	}

	// Token: 0x06007CEC RID: 31980 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ JPBHDFFDPBQ()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007CEE RID: 31982 RVA: 0x003B36A0 File Offset: 0x003B18A0
	private void KFFOEDIENNL()
	{
		int num = this.DJLEOOIIPBH(this.IJBCMDHIEBK, 641f);
		this.QHFJCEIJGJL = new Texture2D(num, num, (TextureFormat)8, false);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)(-110);
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.IFJLDQOCLFO();
	}

	// Token: 0x06007CEF RID: 31983 RVA: 0x003B370C File Offset: 0x003B190C
	public void OFIDJDKNJNG()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32(18, 186, 141, 186);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007CF0 RID: 31984 RVA: 0x003B37C0 File Offset: 0x003B19C0
	public void OQIDLNBOKCL(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - base.transform.position.x) / base.transform.localScale.x + 206f;
		if (num < 1853f || num > 1466f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - base.transform.position.z) / base.transform.localScale.y + 1563f;
		if (num2 >= 1035f && num2 <= 1089f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 824f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / base.transform.localScale.y;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 0 && i < height - 0)
					{
						for (int j = num3 - num7; j <= num3 + num7; j++)
						{
							if (j > 0 && j < width - 1)
							{
								int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.OKCPBLQPQKI[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.OKCPBLQPQKI[num5] = color2;
									this.QHFJCEIJGJL.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007CF1 RID: 31985 RVA: 0x003B39F8 File Offset: 0x003B1BF8
	public void FODPEMFBOFC()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32(125, (byte)-149, 129, (byte)-188);
		for (int i = 0; i < num; i += 0)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007CF2 RID: 31986 RVA: 0x0002C74E File Offset: 0x0002A94E
	private int IMGBDIJLHEN(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 5;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 3;
	}

	// Token: 0x06007CF3 RID: 31987 RVA: 0x003B3AAC File Offset: 0x003B1CAC
	public void NPNQDIHHHGK()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32((byte)-41, (byte)-6, 14, (byte)-152);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007CF4 RID: 31988 RVA: 0x003B3B60 File Offset: 0x003B1D60
	private void JIQDDDIKFMC()
	{
		int num = this.HBNEJNLNEMN(this.IJBCMDHIEBK, 542f);
		this.QHFJCEIJGJL = new Texture2D(num, num, (TextureFormat)0, false);
		this.QHFJCEIJGJL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.OFIDJDKNJNG();
	}

	// Token: 0x06007CF5 RID: 31989 RVA: 0x003B3BCC File Offset: 0x003B1DCC
	private void OBNDQJFDQEK()
	{
		this.LBELDPNJNLK.SetVector("English", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007CF6 RID: 31990 RVA: 0x003B3C3C File Offset: 0x003B1E3C
	public void KDFNMNJNNKO(Terrain EJHLQHFMBKM, float NPFJHKBJJQC)
	{
		TerrainData terrainData = EJHLQHFMBKM.terrainData;
		int heightmapWidth = terrainData.heightmapWidth;
		int heightmapHeight = terrainData.heightmapHeight;
		float y = terrainData.size.y;
		float[,] heights = terrainData.GetHeights(1, 1, heightmapWidth, heightmapHeight);
		float num = base.transform.position.y - 553f;
		float num2 = base.transform.position.y + 748f;
		Vector3 b = new Vector3(-terrainData.size.x * 422f, 1073f, -terrainData.size.z * 182f);
		for (int i = 0; i < heightmapHeight; i++)
		{
			for (int j = 0; j < heightmapWidth; j++)
			{
				float num3 = heights[i, j] * y + EJHLQHFMBKM.transform.position.y;
				if (num3 > num && num3 < num2)
				{
					Vector3 ifkgddjpepk = base.transform.position + b + new Vector3(terrainData.size.x * ((float)j + 342f) / (float)heightmapWidth, 1841f, terrainData.size.z * ((float)i + 354f) / (float)heightmapHeight);
					this.JLKLNEBDEMK(ifkgddjpepk, NPFJHKBJJQC, 1563f);
				}
			}
		}
	}

	// Token: 0x06007CF7 RID: 31991 RVA: 0x003B3DB0 File Offset: 0x003B1FB0
	private void LPIIJKKCPND()
	{
		int num = this.BFJQFDJQGKL(this.IJBCMDHIEBK, 234f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.ARGB32, false);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)(-109);
		this.QHFJCEIJGJL.filterMode = FilterMode.Point;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Repeat;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.OFIDJDKNJNG();
	}

	// Token: 0x06007CF8 RID: 31992 RVA: 0x0002C766 File Offset: 0x0002A966
	private int LDBOIDPGPKF(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 1;
		if (BJGMIBBEGDQ < 0)
		{
			BJGMIBBEGDQ = 1;
		}
		return BJGMIBBEGDQ * 6;
	}

	// Token: 0x06007CF9 RID: 31993 RVA: 0x0002C77E File Offset: 0x0002A97E
	private int DJLEOOIIPBH(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 4;
		if (BJGMIBBEGDQ < 0)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 3;
	}

	// Token: 0x06007CFA RID: 31994 RVA: 0x003B3E1C File Offset: 0x003B201C
	private void JDPDKFLMJBO()
	{
		this.LBELDPNJNLK.SetVector("Sunny", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007CFB RID: 31995 RVA: 0x003B3E8C File Offset: 0x003B208C
	public void JLKLNEBDEMK(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - base.transform.position.x) / base.transform.localScale.x + 1350f;
		if (num < 502f || num > 1655f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - base.transform.position.z) / base.transform.localScale.y + 859f;
		if (num2 >= 540f && num2 <= 1371f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 752f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / base.transform.localScale.y;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i += 0)
				{
					if (i > 1 && i < height - 0)
					{
						for (int j = num3 - num7; j <= num3 + num7; j += 0)
						{
							if (j > 0 && j < width - 1)
							{
								int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
								if (num8 <= num7)
								{
									num5 = i * width + j;
									Color32 color2 = this.OKCPBLQPQKI[num5];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
									this.OKCPBLQPQKI[num5] = color2;
									this.QHFJCEIJGJL.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007CFC RID: 31996 RVA: 0x0002C65E File Offset: 0x0002A85E
	private void PCFEHILJBGE()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.KFFOEDIENNL();
	}

	// Token: 0x06007CFD RID: 31997 RVA: 0x0002C796 File Offset: 0x0002A996
	private int CJBPDBHFHOM(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 3;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 1;
		}
		return BJGMIBBEGDQ * 2;
	}

	// Token: 0x06007CFE RID: 31998 RVA: 0x003B40C4 File Offset: 0x003B22C4
	private void ENGNJBJPJMQ()
	{
		int num = this.CJBPDBHFHOM(this.IJBCMDHIEBK, 94f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.RGBA32, true);
		this.QHFJCEIJGJL.hideFlags = (HideFlags)(-80);
		this.QHFJCEIJGJL.filterMode = FilterMode.Point;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.IKECOQLLQEH();
	}

	// Token: 0x06007CFF RID: 31999 RVA: 0x0002C7AE File Offset: 0x0002A9AE
	private int CJIHOQOOMGQ(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 2;
		if (BJGMIBBEGDQ < 0)
		{
			BJGMIBBEGDQ = 1;
		}
		return BJGMIBBEGDQ * 4;
	}

	// Token: 0x06007D00 RID: 32000 RVA: 0x0002C5ED File Offset: 0x0002A7ED
	private void NGGMKPKKFQP()
	{
		if (this.QHFJCEIJGJL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHFJCEIJGJL);
			this.QHFJCEIJGJL = null;
		}
	}

	// Token: 0x06007D01 RID: 32001 RVA: 0x003B4130 File Offset: 0x003B2330
	public void MJKGEBGEHID()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32((byte)-183, 90, (byte)-19, 72);
		for (int i = 0; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007D02 RID: 32002 RVA: 0x003B41E4 File Offset: 0x003B23E4
	public void BMKDIPGQBHO()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32((byte)-187, (byte)-105, (byte)-156, 10);
		for (int i = 1; i < num; i += 0)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007D03 RID: 32003 RVA: 0x003B4298 File Offset: 0x003B2498
	private void GEQJHGNKEKB()
	{
		int num = this.BFIMMFPELCH(this.IJBCMDHIEBK, 1f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.ARGB32, false);
		this.QHFJCEIJGJL.hideFlags = HideFlags.DontSave;
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.LBELDPNJNLK.mainTexture = this.QHFJCEIJGJL;
		this.QCKHPPOPFGF();
	}

	// Token: 0x06007D04 RID: 32004 RVA: 0x003B4304 File Offset: 0x003B2504
	public void QPJPJDIDQKG()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32(147, 33, (byte)-9, 72);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007D05 RID: 32005 RVA: 0x003B43B8 File Offset: 0x003B25B8
	public void PCDKLJOEFCQ()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32((byte)-57, 193, 195, 131);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007D06 RID: 32006 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ HKMPKMFCGPQ()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007D07 RID: 32007 RVA: 0x003B446C File Offset: 0x003B266C
	private void LPFCGLONBKP()
	{
		this.LBELDPNJNLK.SetVector("Teleport Exhaustion", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007D08 RID: 32008 RVA: 0x003B44DC File Offset: 0x003B26DC
	public void MGQNBDFBMLO()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32(180, 163, 8, 53);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007D09 RID: 32009 RVA: 0x0002C7C6 File Offset: 0x0002A9C6
	private void HNPKPINGJID()
	{
		this.LBELDPNJNLK = base.GetComponent<MeshRenderer>().sharedMaterial;
		this.JHCOENHJNDD();
	}

	// Token: 0x06007D0A RID: 32010 RVA: 0x003B4590 File Offset: 0x003B2790
	public void QCKHPPOPFGF()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		for (int i = 0; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007D0B RID: 32011 RVA: 0x0002C5ED File Offset: 0x0002A7ED
	private void OnDisable()
	{
		if (this.QHFJCEIJGJL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHFJCEIJGJL);
			this.QHFJCEIJGJL = null;
		}
	}

	// Token: 0x06007D0C RID: 32012 RVA: 0x0002C5ED File Offset: 0x0002A7ED
	private void CCIIKDGCEIL()
	{
		if (this.QHFJCEIJGJL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHFJCEIJGJL);
			this.QHFJCEIJGJL = null;
		}
	}

	// Token: 0x06007D0D RID: 32013 RVA: 0x003B4644 File Offset: 0x003B2844
	public void IFJLDQOCLFO()
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		int height = this.QHFJCEIJGJL.height;
		int width = this.QHFJCEIJGJL.width;
		int num = height * width;
		if (this.OKCPBLQPQKI == null || this.OKCPBLQPQKI.Length != num)
		{
			this.OKCPBLQPQKI = new Color32[num];
		}
		Color32 color = new Color32((byte)-135, 185, 169, (byte)-163);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007D0E RID: 32014 RVA: 0x0002C5ED File Offset: 0x0002A7ED
	private void HDJICFQCJCN()
	{
		if (this.QHFJCEIJGJL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHFJCEIJGJL);
			this.QHFJCEIJGJL = null;
		}
	}

	// Token: 0x06007D0F RID: 32015 RVA: 0x0002C627 File Offset: 0x0002A827
	public static FGIJJCBFPFJ PBDOIONLBCP()
	{
		if (FGIJJCBFPFJ.NKGPQKNLCMC == null)
		{
			FGIJJCBFPFJ.NKGPQKNLCMC = UnityEngine.Object.FindObjectOfType<FGIJJCBFPFJ>();
		}
		return FGIJJCBFPFJ.NKGPQKNLCMC;
	}

	// Token: 0x06007D10 RID: 32016 RVA: 0x003B46F8 File Offset: 0x003B28F8
	private void POQDMFECIJF()
	{
		this.LBELDPNJNLK.SetVector("/", new Vector4(base.transform.position.x, base.transform.position.z, base.transform.localScale.x, base.transform.localScale.y));
	}

	// Token: 0x06007D11 RID: 32017 RVA: 0x0002C7DF File Offset: 0x0002A9DF
	private int IMLMMDMKEHK(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 4;
		if (BJGMIBBEGDQ < 0)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 1;
	}

	// Token: 0x04001B22 RID: 6946
	public int IJBCMDHIEBK = 512;

	// Token: 0x04001B23 RID: 6947
	private Material LBELDPNJNLK;

	// Token: 0x04001B24 RID: 6948
	private static FGIJJCBFPFJ NKGPQKNLCMC;

	// Token: 0x04001B25 RID: 6949
	private Texture2D QHFJCEIJGJL;

	// Token: 0x04001B26 RID: 6950
	private Color32[] OKCPBLQPQKI;
}
