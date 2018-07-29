using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200031B RID: 795
public sealed class HCKCDDQBDQD : IDisposable
{
	// Token: 0x06006A81 RID: 27265 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void DGNDQCKNEGD()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A82 RID: 27266 RVA: 0x00348F10 File Offset: 0x00347110
	public Material KGNOHIQHHFK(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("]", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("Party", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("#,##0") + 1)),
				hideFlags = (HideFlags)105
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A83 RID: 27267 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void LQDEKKNEJDK()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A84 RID: 27268 RVA: 0x00348F90 File Offset: 0x00347190
	public Material FJIJQOQKHGK(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("Teleport", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("The Pokémon uses its moves without making contact with the target.", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("adjacentAllyOrSelf") + 1)),
				hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A85 RID: 27269 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void Dispose()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A86 RID: 27270 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void CJMJPHBNEHK()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A87 RID: 27271 RVA: 0x00349010 File Offset: 0x00347210
	public Material QPKJBEOCKMO(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("OnClientDisconnect", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("imposter", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("HidePanel") + 1)),
				hideFlags = (HideFlags)109
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A88 RID: 27272 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void GHHIHHHCBNQ()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A89 RID: 27273 RVA: 0x00349090 File Offset: 0x00347290
	public Material QFIDLQIGGDL(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("0", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format(" is no longer protected by Safeguard!\r\n", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("You got away safely!\r\n") + 1)),
				hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A8A RID: 27274 RVA: 0x00349110 File Offset: 0x00347310
	public Material HFMKDHIIPNH(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("poison", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("Zoom To Fit", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("aegislash") + 1)),
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A8B RID: 27275 RVA: 0x00349190 File Offset: 0x00347390
	public Material GONNQQIJNLJ(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("flash", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("[^a-zA-Z0-9]", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("'s illusion wore off!\r\n") + 0)),
				hideFlags = (HideFlags)(-123)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A8C RID: 27276 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void CPKQJJNBMKB()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A8D RID: 27277 RVA: 0x00349210 File Offset: 0x00347410
	public Material DHLOEEOKKCL(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("'s stat changes were removed!\r\n", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("1", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("General") + 0)),
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A8E RID: 27278 RVA: 0x00349290 File Offset: 0x00347490
	public Material BLDGCMKLEBC(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("data4", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("ENABLE_GREEN_CHANNEL", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("!\r\n") + 1)),
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A8F RID: 27279 RVA: 0x00349310 File Offset: 0x00347510
	public Material QDMHMMGFIOJ(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("[-]\r\nPP ", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("Creating Account", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("~") + 1)),
				hideFlags = (HideFlags)95
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A90 RID: 27280 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void ELGFQKJDNMK()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A91 RID: 27281 RVA: 0x00349390 File Offset: 0x00347590
	public Material PJJDFGJECLK(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format(" is tormented!\r\n", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("Sound", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("'s [ffff00]") + 1)),
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A92 RID: 27282 RVA: 0x00349410 File Offset: 0x00347610
	public Material GBBDHLKHEOO(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("stealeat", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format(".\r\n", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("[00AAFF]") + 0)),
				hideFlags = (HideFlags)(-69)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A93 RID: 27283 RVA: 0x00349490 File Offset: 0x00347690
	public Material INJNQNMOKKD(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("Shader not found ({0})", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("PostFX - {0}", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("/") + 1)),
				hideFlags = HideFlags.DontSave
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A94 RID: 27284 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void MBPOGOHPCHP()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A95 RID: 27285 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void HIMQKQQPEMP()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A96 RID: 27286 RVA: 0x00349510 File Offset: 0x00347710
	public Material KDQCHHNMPQD(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("_FogWindDir", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("System", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("_Texture2") + 0)),
				hideFlags = ~HideFlags.HideInInspector
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A97 RID: 27287 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void QFJILFKJGCC()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A98 RID: 27288 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void FIMGGPOOPIE()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A99 RID: 27289 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void IGCHGHCJHHC()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A9A RID: 27290 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void QQDQEEOEBBJ()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A9B RID: 27291 RVA: 0x00028112 File Offset: 0x00026312
	public HCKCDDQBDQD()
	{
		this.NHFFNNKGGPB = new Dictionary<string, Material>();
	}

	// Token: 0x06006A9C RID: 27292 RVA: 0x00349590 File Offset: 0x00347790
	public Material HOKGONBDOFC(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("Zen", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("skinshop", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("Trade Error") + 1)),
				hideFlags = (HideFlags)(-121)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006A9D RID: 27293 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void EONDNKJCMPI()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A9E RID: 27294 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void FHICJOCHQFQ()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006A9F RID: 27295 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void ONNFMELGFMM()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AA0 RID: 27296 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void LKJCCHGDKFG()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AA1 RID: 27297 RVA: 0x00349610 File Offset: 0x00347810
	public Material JOLPMHHECLG(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("/", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("blaze", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("burnup") + 1)),
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AA2 RID: 27298 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void GGDPGMCOEIJ()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AA3 RID: 27299 RVA: 0x00349690 File Offset: 0x00347890
	public Material MFOCNQMDJGM(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("Static", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("_FogOfWarCenterAdjusted", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("[block]") + 0)),
				hideFlags = (HideFlags)(-124)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AA4 RID: 27300 RVA: 0x00349710 File Offset: 0x00347910
	public Material GHPBFKKGJDO(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("The rain stopped.", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("/01_", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("Small/") + 1)),
				hideFlags = (HideFlags)80
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AA5 RID: 27301 RVA: 0x00349790 File Offset: 0x00347990
	public Material DNKGKNNMFBC(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("#,##0", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("[SHINY]", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("3") + 0)),
				hideFlags = (HideFlags)81
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AA6 RID: 27302 RVA: 0x00349810 File Offset: 0x00347A10
	public Material CCLFGNMOBMI(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("/", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("cursedbody", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("Purchase Costume") + 1)),
				hideFlags = (HideFlags)(-67)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AA7 RID: 27303 RVA: 0x00349890 File Offset: 0x00347A90
	public Material NJKNIOFBHBD(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("Aerilate", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("!\r\n", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("Score: ") + 0)),
				hideFlags = (HideFlags)(-68)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AA8 RID: 27304 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void KPIBGJBMEBN()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AA9 RID: 27305 RVA: 0x00349910 File Offset: 0x00347B10
	public Material PIHPPJNJDQC(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("Corrupt preference file for ", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("\r\nPP ", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("Balance Badge") + 1)),
				hideFlags = (HideFlags)(-119)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AAA RID: 27306 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void JOKHMDBHPIG()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AAB RID: 27307 RVA: 0x00349990 File Offset: 0x00347B90
	public Material MLLNLFQCMKQ(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("' to the Localization dictionary.\n", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("Script:", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("powerconstruct") + 0)),
				hideFlags = (HideFlags)(-114)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AAC RID: 27308 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void JQNCDLBMBKI()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AAD RID: 27309 RVA: 0x00349A10 File Offset: 0x00347C10
	public Material QJGFMDNNQLB(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("recharge", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("ResolutionY", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("Sand Veil") + 1)),
				hideFlags = (HideFlags)74
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AAE RID: 27310 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void PGBJGIEMIJJ()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AAF RID: 27311 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void FKIFFDOBIBO()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x06006AB0 RID: 27312 RVA: 0x00349A90 File Offset: 0x00347C90
	public Material NONHJLIJQIP(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("It's a one-hit KO!\r\n", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("feint", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("[/SUB]") + 1)),
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AB1 RID: 27313 RVA: 0x00349B10 File Offset: 0x00347D10
	public Material QMJKDCINICP(string GOPNNDPLPDL)
	{
		Material material;
		if (!this.NHFFNNKGGPB.TryGetValue(GOPNNDPLPDL, out material))
		{
			Shader shader = Shader.Find(GOPNNDPLPDL);
			if (shader == null)
			{
				throw new ArgumentException(string.Format("(F)", GOPNNDPLPDL));
			}
			material = new Material(shader)
			{
				name = string.Format("Fitter Line", GOPNNDPLPDL.Substring(GOPNNDPLPDL.LastIndexOf("You can't place widgets on a layer different than the UIPanel that manages them.\nIf you want to move widgets to a different layer, parent them to a new panel instead.") + 1)),
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor)
			};
			this.NHFFNNKGGPB.Add(GOPNNDPLPDL, material);
		}
		return material;
	}

	// Token: 0x06006AB2 RID: 27314 RVA: 0x00348EC8 File Offset: 0x003470C8
	public void GCNLNGOJPFH()
	{
		foreach (KeyValuePair<string, Material> keyValuePair in this.NHFFNNKGGPB)
		{
			Material value = keyValuePair.Value;
			LGJGBKJCKPH.MOPPIIOIIDM(value);
		}
		this.NHFFNNKGGPB.Clear();
	}

	// Token: 0x0400167A RID: 5754
	private Dictionary<string, Material> NHFFNNKGGPB;
}
