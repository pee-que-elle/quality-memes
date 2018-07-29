using System;
using System.Collections.Generic;
using DynamicFogAndMist;
using UnityEngine;
using UnityEngine.XR;

// Token: 0x0200039A RID: 922
[AddComponentMenu("")]
public class HICINJKHLNP : MonoBehaviour
{
	// Token: 0x06007BA5 RID: 31653 RVA: 0x0002BB90 File Offset: 0x00029D90
	public void MJIGHGFGNJJ(Color BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._color2)
		{
			this._color2 = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.Mist;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BA6 RID: 31654 RVA: 0x0002BBB4 File Offset: 0x00029DB4
	public void LFNQHDLFFGJ(Color BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._color2)
		{
			this._color2 = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.HeavyFog;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BA7 RID: 31655 RVA: 0x0002BBD8 File Offset: 0x00029DD8
	private void BEONBLCKKOJ()
	{
		this.GLCLIFMJOCH = this._alpha;
		this.KQDFKFHCLQB = this._skyAlpha;
		this.QLBNKCNGIQJ = this._color;
		this.ILMGPGCHQMF = this._color2;
	}

	// Token: 0x06007BA8 RID: 31656 RVA: 0x0002BC0A File Offset: 0x00029E0A
	public void LPNLKBMNKNB(Color BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._color)
		{
			this._color = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.Clear;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BA9 RID: 31657 RVA: 0x0002BC2E File Offset: 0x00029E2E
	public Color GOIDJQIBIEE()
	{
		return this._color2;
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x06007BAA RID: 31658 RVA: 0x0002BC36 File Offset: 0x00029E36
	// (set) Token: 0x06007C0D RID: 31757 RVA: 0x0002C073 File Offset: 0x0002A273
	public bool BJBIEKOKBKH
	{
		get
		{
			return this._clipUnderBaseline;
		}
		set
		{
			if (value != this._clipUnderBaseline)
			{
				this._clipUnderBaseline = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BAB RID: 31659 RVA: 0x0002BC3E File Offset: 0x00029E3E
	public void JCFGEQBMMJL(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._useXZDistance)
		{
			this._useXZDistance = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06007BAC RID: 31660 RVA: 0x0002BC56 File Offset: 0x00029E56
	// (set) Token: 0x06007BFB RID: 31739 RVA: 0x0002BFF2 File Offset: 0x0002A1F2
	public Color NEIBPQBEDNG
	{
		get
		{
			return this._scatteringColor;
		}
		set
		{
			if (value != this._scatteringColor)
			{
				this._scatteringColor = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06007BAD RID: 31661 RVA: 0x0002BC5E File Offset: 0x00029E5E
	// (set) Token: 0x06007BB1 RID: 31665 RVA: 0x0002BC7E File Offset: 0x00029E7E
	public float DJIBLBLECIJ
	{
		get
		{
			return this._skySpeed;
		}
		set
		{
			if (value != this._skySpeed)
			{
				this._skySpeed = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BAE RID: 31662 RVA: 0x003ABEA0 File Offset: 0x003AA0A0
	private void OnDestroy()
	{
		this.fogMat = null;
		if (this.QHKPFNOGMEL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHKPFNOGMEL);
			this.QHKPFNOGMEL = null;
			if (this.QDNLGGKJBLF != null)
			{
				UnityEngine.Object.DestroyImmediate(this.QDNLGGKJBLF);
				this.QDNLGGKJBLF = null;
			}
		}
		if (this.NNLFDNKMEHL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.NNLFDNKMEHL);
			this.NNLFDNKMEHL = null;
		}
		if (this.JFQNEDJIGGB != null)
		{
			UnityEngine.Object.DestroyImmediate(this.JFQNEDJIGGB);
			this.JFQNEDJIGGB = null;
		}
		if (this.BPGMNFJGJDG != null)
		{
			UnityEngine.Object.DestroyImmediate(this.BPGMNFJGJDG);
			this.BPGMNFJGJDG = null;
		}
		if (this.BIHOGKQQQKM != null)
		{
			UnityEngine.Object.DestroyImmediate(this.BIHOGKQQQKM);
			this.BIHOGKQQQKM = null;
		}
		if (this.KQDENOHFPNL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.KQDENOHFPNL);
			this.KQDENOHFPNL = null;
		}
		if (this.MLMCQLPFGEP != null)
		{
			UnityEngine.Object.DestroyImmediate(this.MLMCQLPFGEP);
			this.MLMCQLPFGEP = null;
		}
		if (this.QDNLGGKJBLF != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QDNLGGKJBLF);
			this.MLMCQLPFGEP = null;
		}
		if (this.QHFJCEIJGJL != null)
		{
			UnityEngine.Object.DestroyImmediate(this.QHFJCEIJGJL);
			this.QHFJCEIJGJL = null;
		}
	}

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06007BAF RID: 31663 RVA: 0x003ABFF4 File Offset: 0x003AA1F4
	public static OCPDQGMMEMQ HBFFCJHOCPE
	{
		get
		{
			if (HICINJKHLNP.HGLLGJGOPGL == null)
			{
				foreach (Camera camera in Camera.allCameras)
				{
					HICINJKHLNP.HGLLGJGOPGL = camera.GetComponent<OCPDQGMMEMQ>();
					if (HICINJKHLNP.HGLLGJGOPGL != null)
					{
						break;
					}
				}
			}
			return HICINJKHLNP.HGLLGJGOPGL;
		}
	}

	// Token: 0x06007BB0 RID: 31664 RVA: 0x0002BC66 File Offset: 0x00029E66
	private int MQQKQQMCJCN(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 1;
		if (BJGMIBBEGDQ < 0)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 5;
	}

	// Token: 0x06007BB2 RID: 31666 RVA: 0x003AC044 File Offset: 0x003AA244
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

	// Token: 0x06007BB3 RID: 31667 RVA: 0x003AC0F8 File Offset: 0x003AA2F8
	private void DEDCNJLLLOL()
	{
		if (this.fogMat == null)
		{
			return;
		}
		if (this._sun != null)
		{
			if (this.FEKLJCJFPKJ == null)
			{
				this.FEKLJCJFPKJ = this._sun.GetComponent<Light>();
			}
			if (this.FEKLJCJFPKJ != null && this.FEKLJCJFPKJ.transform != this._sun.transform)
			{
				this.FEKLJCJFPKJ = this._sun.GetComponent<Light>();
			}
			this.KPLDKDEQOFI = this._sun.transform.forward;
			if (this.FEKLJCJFPKJ != null)
			{
				this.JBMCKIDQGFC = this.FEKLJCJFPKJ.color;
				this.GKENELBBCHD = this.FEKLJCJFPKJ.intensity;
			}
		}
		float b = this.GKENELBBCHD * Mathf.Clamp01(1f - this.KPLDKDEQOFI.y);
		this.fogMat.SetColor("_FogColor", b * this.QLBNKCNGIQJ * this.JBMCKIDQGFC);
		this.fogMat.SetColor("_FogColor2", b * this.ILMGPGCHQMF * this.JBMCKIDQGFC);
		Color color = b * this.NEIBPQBEDNG;
		this.fogMat.SetColor("_SunColor", new Vector4(color.r, color.g, color.b, this.GFDLIPMBDCE));
		this.fogMat.SetVector("_SunDir", -this.KPLDKDEQOFI);
	}

	// Token: 0x06007BB4 RID: 31668 RVA: 0x0002BC9D File Offset: 0x00029E9D
	public void HOECCFHIHNG(float CPKNEQGKQPQ)
	{
		this.EILIPOLPCJM = false;
		this.CHFPDGBKGOD(this.CEGFBBHMKOE, this.GNBPCEIDMJH, CPKNEQGKQPQ);
	}

	// Token: 0x06007BB5 RID: 31669 RVA: 0x0002BCB9 File Offset: 0x00029EB9
	public void PDJEKHQFNBI(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._noiseStrength)
		{
			this._noiseStrength = BGBMIEJJQKC;
			this._preset = (KJOKMDLJNNE)8;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BB6 RID: 31670 RVA: 0x0002BCD8 File Offset: 0x00029ED8
	public GameObject CPNOOQEIMIP()
	{
		return this._sun;
	}

	// Token: 0x06007BB7 RID: 31671 RVA: 0x003AC294 File Offset: 0x003AA494
	public void HDDNCDQLOGM()
	{
		if (this._preset != KJOKMDLJNNE.Custom)
		{
			this._effectType = GFJGCGGGJOJ.DesktopFogWithSkyHaze;
		}
		switch (this.CNMNNFBKKKD)
		{
		case KJOKMDLJNNE.Clear:
			this.DIIHJCJOKMP = 0f;
			break;
		case KJOKMDLJNNE.Mist:
			this.DIIHJCJOKMP = 0.75f;
			this.DJIBLBLECIJ = 0.11f;
			this.DKNOOICFJBB = 15f;
			this.JJMJBGOLEJO = 1f;
			this.QCEQDIPGIOP = 0.33f;
			this.FKDGEKNHQFB = 0f;
			this.NDEEIMGBGIM = 0.07f;
			this.DFKQMMIQDOO = 4.4f;
			this.BKKCFKMONJH = 1f;
			this.OHDLJLKFBCE = 0f;
			this.JHNOMPGDFLE = 0.6f;
			this.KDEMMJKGDJM = 0.01f;
			this.CEGFBBHMKOE = new Color(0.89f, 0.89f, 0.89f, 1f);
			this.GNBPCEIDMJH = this.CEGFBBHMKOE;
			this.PPMBGLDKDQI = 0.999f;
			this.KCOMNCBFJGJ = 0f;
			break;
		case KJOKMDLJNNE.WindyMist:
			this.DIIHJCJOKMP = 0.75f;
			this.DJIBLBLECIJ = 0.3f;
			this.DKNOOICFJBB = 35f;
			this.JJMJBGOLEJO = 0.32f;
			this.QCEQDIPGIOP = 0.33f;
			this.FKDGEKNHQFB = 0f;
			this.NDEEIMGBGIM = 0.07f;
			this.DFKQMMIQDOO = 2f;
			this.BKKCFKMONJH = 1f;
			this.OHDLJLKFBCE = 2f;
			this.JHNOMPGDFLE = 0.6f;
			this.KDEMMJKGDJM = 0.06f;
			this.CEGFBBHMKOE = new Color(0.89f, 0.89f, 0.89f, 1f);
			this.GNBPCEIDMJH = this.CEGFBBHMKOE;
			this.PPMBGLDKDQI = 0.999f;
			this.KCOMNCBFJGJ = 0f;
			break;
		case KJOKMDLJNNE.GroundFog:
			this.DIIHJCJOKMP = 1f;
			this.DJIBLBLECIJ = 0.3f;
			this.DKNOOICFJBB = 35f;
			this.JJMJBGOLEJO = 0.32f;
			this.QCEQDIPGIOP = 0.33f;
			this.FKDGEKNHQFB = 0f;
			this.NDEEIMGBGIM = 0f;
			this.DFKQMMIQDOO = 1f;
			this.BKKCFKMONJH = 1f;
			this.OHDLJLKFBCE = 0.4f;
			this.JHNOMPGDFLE = 0.7f;
			this.KDEMMJKGDJM = 0.005f;
			this.CEGFBBHMKOE = new Color(0.89f, 0.89f, 0.89f, 1f);
			this.GNBPCEIDMJH = this.CEGFBBHMKOE;
			this.PPMBGLDKDQI = 0.999f;
			this.KCOMNCBFJGJ = 0f;
			break;
		case KJOKMDLJNNE.Fog:
			this.DIIHJCJOKMP = 0.96f;
			this.DJIBLBLECIJ = 0.3f;
			this.DKNOOICFJBB = 155f;
			this.JJMJBGOLEJO = 0.6f;
			this.QCEQDIPGIOP = 0.93f;
			this.FKDGEKNHQFB = ((!this.LQHEDIGQFGF.PKELNIMGQJE()) ? 0.01f : 0.2f);
			this.NDEEIMGBGIM = 0.04f;
			this.DFKQMMIQDOO = 20f;
			this.BKKCFKMONJH = 1f;
			this.OHDLJLKFBCE = 0.4f;
			this.JHNOMPGDFLE = 0.4f;
			this.KDEMMJKGDJM = 0.005f;
			this.CEGFBBHMKOE = new Color(0.89f, 0.89f, 0.89f, 1f);
			this.GNBPCEIDMJH = this.CEGFBBHMKOE;
			this.PPMBGLDKDQI = 0.999f;
			this.KCOMNCBFJGJ = 0f;
			break;
		case KJOKMDLJNNE.HeavyFog:
			this.DIIHJCJOKMP = 1f;
			this.DJIBLBLECIJ = 0.05f;
			this.DKNOOICFJBB = 350f;
			this.JJMJBGOLEJO = 0.8f;
			this.QCEQDIPGIOP = 0.97f;
			this.FKDGEKNHQFB = ((!this.LQHEDIGQFGF.PKELNIMGQJE()) ? 0f : 0.1f);
			this.NDEEIMGBGIM = 0.045f;
			this.DFKQMMIQDOO = 35f;
			this.BKKCFKMONJH = 0.88f;
			this.OHDLJLKFBCE = 0.4f;
			this.JHNOMPGDFLE = 0.24f;
			this.KDEMMJKGDJM = 0.003f;
			this.CEGFBBHMKOE = new Color(0.86f, 0.847f, 0.847f, 1f);
			this.GNBPCEIDMJH = this.CEGFBBHMKOE;
			this.PPMBGLDKDQI = 0.999f;
			this.KCOMNCBFJGJ = 0f;
			break;
		case KJOKMDLJNNE.SandStorm:
			this.DIIHJCJOKMP = 1f;
			this.DJIBLBLECIJ = 0.49f;
			this.DKNOOICFJBB = 333f;
			this.JJMJBGOLEJO = 0.72f;
			this.QCEQDIPGIOP = 0.97f;
			this.FKDGEKNHQFB = ((!this.LQHEDIGQFGF.PKELNIMGQJE()) ? 0f : 0.15f);
			this.NDEEIMGBGIM = 0.028f;
			this.DFKQMMIQDOO = 83f;
			this.BKKCFKMONJH = 0f;
			this.OHDLJLKFBCE = 15f;
			this.JHNOMPGDFLE = 0.45f;
			this.KDEMMJKGDJM = 0.2f;
			this.CEGFBBHMKOE = new Color(0.364f, 0.36f, 0.36f, 1f);
			this.GNBPCEIDMJH = this.CEGFBBHMKOE;
			this.PPMBGLDKDQI = 0.999f;
			this.KCOMNCBFJGJ = 0f;
			break;
		}
	}

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x0002BCE0 File Offset: 0x00029EE0
	// (set) Token: 0x06007BC1 RID: 31681 RVA: 0x0002BD2E File Offset: 0x00029F2E
	public Vector3 QKOEKNCNLHK
	{
		get
		{
			return this._fogOfWarSize;
		}
		set
		{
			if (value != this._fogOfWarSize)
			{
				this._fogOfWarSize = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x0002BCE8 File Offset: 0x00029EE8
	// (set) Token: 0x06007C4D RID: 31821 RVA: 0x0002C400 File Offset: 0x0002A600
	public float DFEQNEFMDEQ
	{
		get
		{
			return this._noiseScale;
		}
		set
		{
			if (value != this._noiseScale)
			{
				this._noiseScale = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BBA RID: 31674 RVA: 0x0002BCF0 File Offset: 0x00029EF0
	private void LHKNMLIGQOG()
	{
		this.EGHPIHKDNMD = true;
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06007BBB RID: 31675 RVA: 0x0002BCF9 File Offset: 0x00029EF9
	// (set) Token: 0x06007BE3 RID: 31715 RVA: 0x0002BEEC File Offset: 0x0002A0EC
	public bool LIJNQCKKGKK
	{
		get
		{
			return this._useFogVolumes;
		}
		set
		{
			if (value != this._useFogVolumes)
			{
				this._useFogVolumes = value;
			}
		}
	}

	// Token: 0x06007BBC RID: 31676 RVA: 0x003AC7E4 File Offset: 0x003AA9E4
	public void PDEOPHHEQPB(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - this.KQLFJBLIQPF.x) / this.QKOEKNCNLHK.x + 0.5f;
		if (num < 0f || num > 1f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - this.KQLFJBLIQPF.z) / this.QKOEKNCNLHK.z + 0.5f;
		if (num2 >= 0f && num2 <= 1f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			float num6 = HLDJHBLPJJF / this.QKOEKNCNLHK.z;
			int num7 = Mathf.FloorToInt((float)height * num6);
			for (int i = num4 - num7; i <= num4 + num7; i++)
			{
				if (i > 0 && i < height - 1)
				{
					for (int j = num3 - num7; j <= num3 + num7; j++)
					{
						if (j > 0 && j < width - 1)
						{
							int num8 = Mathf.FloorToInt(Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j))));
							if (num8 <= num7)
							{
								num5 = i * width + j;
								Color32 color = this.OKCPBLQPQKI[num5];
								color.a = byte.MaxValue;
								this.OKCPBLQPQKI[num5] = color;
								this.QHFJCEIJGJL.SetPixel(j, i, color);
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06007C18 RID: 31768 RVA: 0x0002C1AE File Offset: 0x0002A3AE
	// (set) Token: 0x06007BBD RID: 31677 RVA: 0x0002BD01 File Offset: 0x00029F01
	public Vector3 KQLFJBLIQPF
	{
		get
		{
			return this._fogOfWarCenter;
		}
		set
		{
			if (value != this._fogOfWarCenter)
			{
				this._fogOfWarCenter = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BBE RID: 31678 RVA: 0x003AC9C4 File Offset: 0x003AABC4
	protected void LEKEJJENHQC()
	{
		this.HDDNCDQLOGM();
		this.BEONBLCKKOJ();
		if (this.EBNOGGPBLNC == null)
		{
			this.EBNOGGPBLNC = base.GetComponent<Camera>();
		}
		switch (this.LQHEDIGQFGF)
		{
		case GFJGCGGGJOJ.MobileFogWithSkyHaze:
			if (this.JFQNEDJIGGB == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFOWithSky";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGWithSky";
				}
				this.JFQNEDJIGGB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.JFQNEDJIGGB.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.JFQNEDJIGGB;
			break;
		case GFJGCGGGJOJ.MobileFogOnlyGround:
			if (this.BPGMNFJGJDG == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFOOnlyFog";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGOnlyFog";
				}
				this.BPGMNFJGJDG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.BPGMNFJGJDG.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.BPGMNFJGJDG;
			break;
		case GFJGCGGGJOJ.DesktopFogPlusWithSkyHaze:
			if (this.QHKPFNOGMEL == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFODesktopPlus";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGDesktopPlus";
				}
				this.QHKPFNOGMEL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.QHKPFNOGMEL.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.QHKPFNOGMEL;
			break;
		case GFJGCGGGJOJ.MobileFogSimple:
			if (this.BIHOGKQQQKM == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFOSimple";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGSimple";
				}
				this.BIHOGKQQQKM = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.BIHOGKQQQKM.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.BIHOGKQQQKM;
			break;
		case GFJGCGGGJOJ.MobileFogBasic:
			if (this.KQDENOHFPNL == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFOBasic";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGBasic";
				}
				this.KQDENOHFPNL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.KQDENOHFPNL.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.KQDENOHFPNL;
			break;
		case GFJGCGGGJOJ.MobileFogOrthogonal:
			if (this.MLMCQLPFGEP == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFOOrthogonal";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGOrthogonal";
				}
				this.MLMCQLPFGEP = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.MLMCQLPFGEP.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.MLMCQLPFGEP;
			break;
		case GFJGCGGGJOJ.DesktopFogPlusOrthogonal:
			if (this.QDNLGGKJBLF == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFODesktopPlusOrthogonal";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGDesktopPlusOrthogonal";
				}
				this.QDNLGGKJBLF = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.QDNLGGKJBLF.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.QDNLGGKJBLF;
			break;
		default:
			if (this.NNLFDNKMEHL == null)
			{
				string path;
				if (this.EBNOGGPBLNC.orthographic)
				{
					this.PDMEJDMEHGH = true;
					path = "Materials/DFODesktop";
				}
				else
				{
					this.PDMEJDMEHGH = false;
					path = "Materials/DFGDesktop";
				}
				this.NNLFDNKMEHL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(path));
				this.NNLFDNKMEHL.hideFlags = HideFlags.DontSave;
			}
			this.fogMat = this.NNLFDNKMEHL;
			break;
		}
		if (this.fogMat == null)
		{
			return;
		}
		float d = (this.LQHEDIGQFGF != GFJGCGGGJOJ.DesktopFogPlusWithSkyHaze) ? this._speed : (this._speed * 5f);
		this.fogMat.SetVector("_FogSpeed", -this._windDirection.normalized * d);
		Vector4 value = new Vector4(this._noiseStrength, this._turbulence, this.EBNOGGPBLNC.farClipPlane * 15f / 1000f, this._noiseScale);
		this.fogMat.SetVector("_FogNoiseData", value);
		Vector4 value2 = new Vector4(this._height + 0.001f, this._baselineHeight, (!this._clipUnderBaseline) ? -10000f : -0.01f, this._heightFallOff);
		if (this._effectType == GFJGCGGGJOJ.MobileFogOrthogonal || this._effectType == GFJGCGGGJOJ.DesktopFogPlusOrthogonal)
		{
			value2.z = this.DKLQCGDMQKB;
		}
		this.fogMat.SetVector("_FogHeightData", value2);
		this.fogMat.SetFloat("_FogAlpha", this.GLCLIFMJOCH);
		Vector4 value3 = new Vector4(this._distance, this._distanceFallOff, this._maxDistance, this._maxDistanceFallOff);
		if (this.LQHEDIGQFGF.PKELNIMGQJE())
		{
			value3.x = this.EBNOGGPBLNC.farClipPlane * this._distance;
			value3.y = this.NDEEIMGBGIM * value3.x + 0.0001f;
			value3.z *= this.EBNOGGPBLNC.farClipPlane;
		}
		this.fogMat.SetVector("_FogDistance", value3);
		this.DEDCNJLLLOL();
		this.GCFBDJBMCGG();
		if (this.BCHQLQMPGJL == null)
		{
			this.BCHQLQMPGJL = new List<string>();
		}
		else
		{
			this.BCHQLQMPGJL.Clear();
		}
		if (this.IGGDQFDQBFJ)
		{
			if (this.QHFJCEIJGJL == null)
			{
				this.GEQJHGNKEKB();
			}
			this.fogMat.SetTexture("_FogOfWar", this.QHFJCEIJGJL);
			this.fogMat.SetVector("_FogOfWarCenter", this._fogOfWarCenter);
			this.fogMat.SetVector("_FogOfWarSize", this._fogOfWarSize);
			Vector3 vector = this.KQLFJBLIQPF - 0.5f * this._fogOfWarSize;
			this.fogMat.SetVector("_FogOfWarCenterAdjusted", new Vector3(vector.x / this._fogOfWarSize.x, 1f, vector.z / this._fogOfWarSize.z));
			this.BCHQLQMPGJL.Add("FOG_OF_WAR_ON");
		}
		if (this._enableDithering)
		{
			this.fogMat.SetFloat("_FogDither", this._ditherStrength);
			this.BCHQLQMPGJL.Add("DITHER_ON");
		}
		this.fogMat.shaderKeywords = this.BCHQLQMPGJL.ToArray();
	}

	// Token: 0x06007BBF RID: 31679 RVA: 0x0002BD1E File Offset: 0x00029F1E
	public bool QNFJINCLEHK()
	{
		return this._useXZDistance;
	}

	// Token: 0x06007BC0 RID: 31680 RVA: 0x0002BD26 File Offset: 0x00029F26
	public float EMKJBMDKJNP()
	{
		return this._skyAlpha;
	}

	// Token: 0x06007BC2 RID: 31682 RVA: 0x0002BD4B File Offset: 0x00029F4B
	public void FLNLLNKBLIN(Vector3 BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._windDirection)
		{
			this._windDirection = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06007BC3 RID: 31683 RVA: 0x0002BD68 File Offset: 0x00029F68
	// (set) Token: 0x06007C15 RID: 31765 RVA: 0x0002C17F File Offset: 0x0002A37F
	public GFJGCGGGJOJ LQHEDIGQFGF
	{
		get
		{
			return this._effectType;
		}
		set
		{
			if (value != this._effectType)
			{
				this._effectType = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BC5 RID: 31685 RVA: 0x0002BD70 File Offset: 0x00029F70
	public void ENDDJHCLDDG(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._fogOfWarEnabled)
		{
			this._fogOfWarEnabled = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BC6 RID: 31686 RVA: 0x0002BD88 File Offset: 0x00029F88
	public void MMCDGDCNEOC(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._baselineHeight)
		{
			this._baselineHeight = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BC7 RID: 31687 RVA: 0x003AA000 File Offset: 0x003A8200
	private void OnRenderImage(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 0f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				this.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					this.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("_ClipDir", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				this.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("_ClipToWorld", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_ClipToWorld", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06007C26 RID: 31782 RVA: 0x0002C29B File Offset: 0x0002A49B
	// (set) Token: 0x06007BC8 RID: 31688 RVA: 0x0002BDA0 File Offset: 0x00029FA0
	public float PPMBGLDKDQI
	{
		get
		{
			return this._maxDistance;
		}
		set
		{
			if (value != this._maxDistance)
			{
				this._maxDistance = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BC9 RID: 31689 RVA: 0x0002BDBF File Offset: 0x00029FBF
	public float CIJNCCMQJON()
	{
		return this._speed;
	}

	// Token: 0x06007BCA RID: 31690 RVA: 0x0002BD4B File Offset: 0x00029F4B
	public void JIIEQJGQPOD(Vector3 BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._windDirection)
		{
			this._windDirection = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BCB RID: 31691 RVA: 0x0002BDC7 File Offset: 0x00029FC7
	public void IFBFFPMLKOC(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._alpha)
		{
			this._alpha = BGBMIEJJQKC;
			this._preset = (KJOKMDLJNNE)8;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x06007BCC RID: 31692 RVA: 0x0002BDE6 File Offset: 0x00029FE6
	// (set) Token: 0x06007C2E RID: 31790 RVA: 0x0002BD88 File Offset: 0x00029F88
	public float JDOCEEJICLI
	{
		get
		{
			return this._baselineHeight;
		}
		set
		{
			if (value != this._baselineHeight)
			{
				this._baselineHeight = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BCD RID: 31693 RVA: 0x0002BDEE File Offset: 0x00029FEE
	public void EIOLECFDCPK(float CPKNEQGKQPQ)
	{
		this.LCHHLOCMEFC(-1f, -1f, CPKNEQGKQPQ);
	}

	// Token: 0x06007BCE RID: 31694 RVA: 0x0002BE01 File Offset: 0x0002A001
	public KJOKMDLJNNE OFJFOOBLOLG()
	{
		return this._preset;
	}

	// Token: 0x06007BCF RID: 31695 RVA: 0x0002BE09 File Offset: 0x0002A009
	private void OnPreCull()
	{
		if (this.EBNOGGPBLNC != null && this.EBNOGGPBLNC.depthTextureMode == DepthTextureMode.None)
		{
			this.EBNOGGPBLNC.depthTextureMode = DepthTextureMode.Depth;
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06007BD0 RID: 31696 RVA: 0x0002BE32 File Offset: 0x0002A032
	// (set) Token: 0x06007C32 RID: 31794 RVA: 0x0002C2E7 File Offset: 0x0002A4E7
	public float BKKCFKMONJH
	{
		get
		{
			return this._heightFallOff;
		}
		set
		{
			if (value != this._heightFallOff)
			{
				this._heightFallOff = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BD1 RID: 31697 RVA: 0x003AD1A4 File Offset: 0x003AB3A4
	public void GGDINPCCLFL()
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
		Color32 color = new Color32((byte)-150, 44, 184, 34);
		for (int i = 1; i < num; i++)
		{
			this.OKCPBLQPQKI[i] = color;
		}
		this.QHFJCEIJGJL.SetPixels32(this.OKCPBLQPQKI);
		this.QHFJCEIJGJL.Apply();
	}

	// Token: 0x06007BD2 RID: 31698 RVA: 0x0002BE3A File Offset: 0x0002A03A
	public float MBGQOJFBEPP()
	{
		return this._maxHeight;
	}

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06007BD3 RID: 31699 RVA: 0x0002BE42 File Offset: 0x0002A042
	// (set) Token: 0x06007C08 RID: 31752 RVA: 0x0002C0B6 File Offset: 0x0002A2B6
	public float KCOMNCBFJGJ
	{
		get
		{
			return this._maxDistanceFallOff;
		}
		set
		{
			if (value != this._maxDistanceFallOff)
			{
				this._maxDistanceFallOff = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BD4 RID: 31700 RVA: 0x0002BCD8 File Offset: 0x00029ED8
	public GameObject GDHJLDDOMPO()
	{
		return this._sun;
	}

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06007BF6 RID: 31734 RVA: 0x0002BE01 File Offset: 0x0002A001
	// (set) Token: 0x06007BD5 RID: 31701 RVA: 0x0002BE4A File Offset: 0x0002A04A
	public KJOKMDLJNNE CNMNNFBKKKD
	{
		get
		{
			return this._preset;
		}
		set
		{
			if (value != this._preset)
			{
				this._preset = value;
				this.LEKEJJENHQC();
			}
		}
	}

	// Token: 0x06007BD6 RID: 31702 RVA: 0x0002BC9D File Offset: 0x00029E9D
	public void ELEFGKBOLCD(float CPKNEQGKQPQ)
	{
		this.EILIPOLPCJM = false;
		this.CHFPDGBKGOD(this.CEGFBBHMKOE, this.GNBPCEIDMJH, CPKNEQGKQPQ);
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06007BEE RID: 31726 RVA: 0x0002BECC File Offset: 0x0002A0CC
	// (set) Token: 0x06007BD7 RID: 31703 RVA: 0x0002BE62 File Offset: 0x0002A062
	public Color CEGFBBHMKOE
	{
		get
		{
			return this._color;
		}
		set
		{
			if (value != this._color)
			{
				this._color = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06007C10 RID: 31760 RVA: 0x0002BE3A File Offset: 0x0002A03A
	// (set) Token: 0x06007BD8 RID: 31704 RVA: 0x0002BE86 File Offset: 0x0002A086
	public float DKLQCGDMQKB
	{
		get
		{
			return this._maxHeight;
		}
		set
		{
			if (value != this._maxHeight)
			{
				this._maxHeight = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BD9 RID: 31705 RVA: 0x003AD258 File Offset: 0x003AB458
	public void DNLMKPMOOEH(DynamicFogProfile GOFFLIBLOEO, float CPKNEQGKQPQ)
	{
		if (!this._useFogVolumes)
		{
			return;
		}
		this.CNMNNFBKKKD = KJOKMDLJNNE.Custom;
		this.ENEEDHHHQJD = ScriptableObject.CreateInstance<DynamicFogProfile>();
		this.ENEEDHHHQJD.CPMMKIODFLM(this);
		this.GOFFLIBLOEO = GOFFLIBLOEO;
		this.FQCECBMJCDB = CPKNEQGKQPQ;
		this.QLDEDDPFHNQ = Time.time;
		this.MJEGNCCHIBP = true;
	}

	// Token: 0x06007BDA RID: 31706 RVA: 0x0002BEA5 File Offset: 0x0002A0A5
	public void FDGQBMEFNFJ(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._maxDistanceFallOff)
		{
			this._maxDistanceFallOff = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.GroundFog;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BDB RID: 31707 RVA: 0x0002BCD8 File Offset: 0x00029ED8
	public GameObject PCJQNQKQHBG()
	{
		return this._sun;
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06007BDC RID: 31708 RVA: 0x0002BEC4 File Offset: 0x0002A0C4
	// (set) Token: 0x06007C1A RID: 31770 RVA: 0x0002C1B6 File Offset: 0x0002A3B6
	public float DFKQMMIQDOO
	{
		get
		{
			return this._height;
		}
		set
		{
			if (value != this._height)
			{
				this._height = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BDD RID: 31709 RVA: 0x003AD2AC File Offset: 0x003AB4AC
	public void EMLMCBCKQOM(Color NHMQDFMMGGO, Color GNBPCEIDMJH, float CPKNEQGKQPQ)
	{
		if (!this.LIJNQCKKGKK)
		{
			return;
		}
		this.CGEBLJBKNML(KJOKMDLJNNE.HeavyFog);
		this.GLFGQFNGIFJ = this.QLBNKCNGIQJ;
		this.LQQEEKLPFDJ = this.ILMGPGCHQMF;
		this.ECCBJFEDHOO = NHMQDFMMGGO;
		this.EPBQLBQLGOF = GNBPCEIDMJH;
		this.FQCECBMJCDB = CPKNEQGKQPQ;
		this.QLDEDDPFHNQ = Time.time;
		this.EILIPOLPCJM = false;
		this.NGOMCPCLNFN = false;
	}

	// Token: 0x06007BDE RID: 31710 RVA: 0x0002BECC File Offset: 0x0002A0CC
	public Color EFHNNQJHLLM()
	{
		return this._color;
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06007BE0 RID: 31712 RVA: 0x0002BED4 File Offset: 0x0002A0D4
	// (set) Token: 0x06007BDF RID: 31711 RVA: 0x0002BD4B File Offset: 0x00029F4B
	public Vector3 MECHHMBPDCJ
	{
		get
		{
			return this._windDirection;
		}
		set
		{
			if (value != this._windDirection)
			{
				this._windDirection = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x0002BEDC File Offset: 0x0002A0DC
	public Camera KENQFJNMGDL
	{
		get
		{
			return this.EBNOGGPBLNC;
		}
	}

	// Token: 0x06007BE2 RID: 31714 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
	public bool PKLJNOHFNNN()
	{
		return this._enableDithering;
	}

	// Token: 0x06007BE4 RID: 31716 RVA: 0x003AD310 File Offset: 0x003AB510
	private void BBCGLGJEEHI()
	{
		Vector4 value = new Vector4(this._skyHaze, this._skySpeed, this._skyNoiseStrength, this.KQDFKFHCLQB);
		this.fogMat.SetVector("Normal-type moves become Flying-type moves. The power of those moves is boosted a little.", value);
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06007C3D RID: 31805 RVA: 0x0002C19E File Offset: 0x0002A39E
	// (set) Token: 0x06007BE5 RID: 31717 RVA: 0x0002BEFE File Offset: 0x0002A0FE
	public float GFDLIPMBDCE
	{
		get
		{
			return this._scattering;
		}
		set
		{
			if (value != this._scattering)
			{
				this._scattering = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06007BE6 RID: 31718 RVA: 0x0002BD1E File Offset: 0x00029F1E
	// (set) Token: 0x06007C01 RID: 31745 RVA: 0x0002BC3E File Offset: 0x00029E3E
	public bool NLNDBPCCJCP
	{
		get
		{
			return this._useXZDistance;
		}
		set
		{
			if (value != this._useXZDistance)
			{
				this._useXZDistance = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BE7 RID: 31719 RVA: 0x0002BEC4 File Offset: 0x0002A0C4
	public float JFKBCDFHDOQ()
	{
		return this._height;
	}

	// Token: 0x06007BE8 RID: 31720 RVA: 0x0002BF16 File Offset: 0x0002A116
	public float PQKBIDNEONI()
	{
		return this._noiseStrength;
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x06007C29 RID: 31785 RVA: 0x0002C2A3 File Offset: 0x0002A4A3
	// (set) Token: 0x06007BE9 RID: 31721 RVA: 0x0002BF1E File Offset: 0x0002A11E
	public float DIIHJCJOKMP
	{
		get
		{
			return this._alpha;
		}
		set
		{
			if (value != this._alpha)
			{
				this._alpha = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x06007BEA RID: 31722 RVA: 0x0002BF3D File Offset: 0x0002A13D
	// (set) Token: 0x06007C36 RID: 31798 RVA: 0x0002BD70 File Offset: 0x00029F70
	public bool IGGDQFDQBFJ
	{
		get
		{
			return this._fogOfWarEnabled;
		}
		set
		{
			if (value != this._fogOfWarEnabled)
			{
				this._fogOfWarEnabled = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06007BEB RID: 31723 RVA: 0x0002BC2E File Offset: 0x00029E2E
	// (set) Token: 0x06007C1B RID: 31771 RVA: 0x0002C1D5 File Offset: 0x0002A3D5
	public Color GNBPCEIDMJH
	{
		get
		{
			return this._color2;
		}
		set
		{
			if (value != this._color2)
			{
				this._color2 = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BEC RID: 31724 RVA: 0x0002BF45 File Offset: 0x0002A145
	public void JQNQNIPGLHM(Color BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._color2)
		{
			this._color2 = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.Clear;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BED RID: 31725 RVA: 0x0002BF69 File Offset: 0x0002A169
	public void GDCLQIGDHGJ(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._skyHaze)
		{
			this._skyHaze = BGBMIEJJQKC;
			this._preset = (KJOKMDLJNNE)8;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BEF RID: 31727 RVA: 0x003AD350 File Offset: 0x003AB550
	private void DMCMPHLDFFO()
	{
		Vector4 value = new Vector4(this._skyHaze, this._skySpeed, this._skyNoiseStrength, this.KQDFKFHCLQB);
		this.fogMat.SetVector("Purchasing", value);
	}

	// Token: 0x06007BF0 RID: 31728 RVA: 0x003AD390 File Offset: 0x003AB590
	private void Update()
	{
		if (this.fogMat == null)
		{
			return;
		}
		if (this.MJEGNCCHIBP)
		{
			float num = (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB;
			if (num > 1f)
			{
				num = 1f;
			}
			DynamicFogProfile.GGJJLQLFKCE(this.ENEEDHHHQJD, this.GOFFLIBLOEO, num, this);
			if (num >= 1f)
			{
				this.MJEGNCCHIBP = false;
			}
		}
		if (this.JODLKDDNFKP)
		{
			if (this.LPNBHOHIEMM >= 0f)
			{
				if (this.LPNBHOHIEMM != this.GLCLIFMJOCH || this.GLCNGDEIDHM != this.KQDFKFHCLQB)
				{
					if (this.FQCECBMJCDB > 0f)
					{
						this.GLCLIFMJOCH = Mathf.Lerp(this.KIBQIJDFPEI, this.LPNBHOHIEMM, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
						this.KQDFKFHCLQB = Mathf.Lerp(this.NHEMMGFJOQO, this.GLCNGDEIDHM, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
					}
					else
					{
						this.GLCLIFMJOCH = this.LPNBHOHIEMM;
						this.KQDFKFHCLQB = this.GLCNGDEIDHM;
						this.JODLKDDNFKP = false;
					}
					this.fogMat.SetFloat("_FogAlpha", this.GLCLIFMJOCH);
					this.GCFBDJBMCGG();
				}
			}
			else if (this.GLCLIFMJOCH != this.DIIHJCJOKMP || this.GLCNGDEIDHM != this.KQDFKFHCLQB)
			{
				if (this.FQCECBMJCDB > 0f)
				{
					this.GLCLIFMJOCH = Mathf.Lerp(this.KIBQIJDFPEI, this.DIIHJCJOKMP, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
					this.KQDFKFHCLQB = Mathf.Lerp(this.NHEMMGFJOQO, this.DIIHJCJOKMP, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
				}
				else
				{
					this.GLCLIFMJOCH = this.DIIHJCJOKMP;
					this.KQDFKFHCLQB = this.QCEQDIPGIOP;
					this.JODLKDDNFKP = false;
				}
				this.fogMat.SetFloat("_FogAlpha", this.GLCLIFMJOCH);
				this.GCFBDJBMCGG();
			}
		}
		if (this.NGOMCPCLNFN)
		{
			if (this.EILIPOLPCJM)
			{
				if (this.ECCBJFEDHOO != this.QLBNKCNGIQJ || this.EPBQLBQLGOF != this.ILMGPGCHQMF)
				{
					if (this.FQCECBMJCDB > 0f)
					{
						this.QLBNKCNGIQJ = Color.Lerp(this.GLFGQFNGIFJ, this.ECCBJFEDHOO, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
						this.ILMGPGCHQMF = Color.Lerp(this.LQQEEKLPFDJ, this.EPBQLBQLGOF, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
					}
					else
					{
						this.QLBNKCNGIQJ = this.ECCBJFEDHOO;
						this.ILMGPGCHQMF = this.EPBQLBQLGOF;
						this.NGOMCPCLNFN = false;
					}
					this.fogMat.SetColor("_FogColor", this.QLBNKCNGIQJ);
					this.fogMat.SetColor("_FogColor2", this.ILMGPGCHQMF);
				}
			}
			else if (this.QLBNKCNGIQJ != this.CEGFBBHMKOE || this.ILMGPGCHQMF != this.GNBPCEIDMJH)
			{
				if (this.FQCECBMJCDB > 0f)
				{
					this.QLBNKCNGIQJ = Color.Lerp(this.GLFGQFNGIFJ, this.CEGFBBHMKOE, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
					this.ILMGPGCHQMF = Color.Lerp(this.LQQEEKLPFDJ, this.GNBPCEIDMJH, (Time.time - this.QLDEDDPFHNQ) / this.FQCECBMJCDB);
				}
				else
				{
					this.QLBNKCNGIQJ = this.CEGFBBHMKOE;
					this.ILMGPGCHQMF = this.GNBPCEIDMJH;
					this.NGOMCPCLNFN = false;
				}
				this.fogMat.SetColor("_FogColor", this.QLBNKCNGIQJ);
				this.fogMat.SetColor("_FogColor2", this.ILMGPGCHQMF);
			}
		}
		if (this.MDBILOHFMOM != null)
		{
			bool flag = false;
			if (this.MDBILOHFMOM.transform.forward != this.KPLDKDEQOFI)
			{
				flag = true;
			}
			if (this.FEKLJCJFPKJ != null && (this.FEKLJCJFPKJ.color != this.JBMCKIDQGFC || this.FEKLJCJFPKJ.intensity != this.GKENELBBCHD))
			{
				flag = true;
			}
			if (flag)
			{
				this.DEDCNJLLLOL();
			}
		}
	}

	// Token: 0x06007BF1 RID: 31729 RVA: 0x0002BE32 File Offset: 0x0002A032
	public float MEQGGMDNKCI()
	{
		return this._heightFallOff;
	}

	// Token: 0x06007BF2 RID: 31730 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
	public bool JIGIKHGKBJL()
	{
		return this._enableDithering;
	}

	// Token: 0x06007BF3 RID: 31731 RVA: 0x003AD7D0 File Offset: 0x003AB9D0
	private void NPKLKCDEJPF(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1928f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				this.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					this.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("General", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				this.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("#,##0", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Player/Mounts/", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007BF4 RID: 31732 RVA: 0x0002BF88 File Offset: 0x0002A188
	public void IHLPOMDLEED(float CPKNEQGKQPQ)
	{
		this.DNLMKPMOOEH(this.ENEEDHHHQJD, CPKNEQGKQPQ);
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x06007BF5 RID: 31733 RVA: 0x0002BD26 File Offset: 0x00029F26
	// (set) Token: 0x06007BFF RID: 31743 RVA: 0x0002C03E File Offset: 0x0002A23E
	public float QCEQDIPGIOP
	{
		get
		{
			return this._skyAlpha;
		}
		set
		{
			if (value != this._skyAlpha)
			{
				this._skyAlpha = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BF7 RID: 31735 RVA: 0x0002BF97 File Offset: 0x0002A197
	public void MGQIGGNBBBD(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._height)
		{
			this._height = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.SandStorm;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007BF8 RID: 31736 RVA: 0x0002BFB6 File Offset: 0x0002A1B6
	public void ENMLQMFKJKC(GameObject BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._sun)
		{
			this._sun = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06007C2D RID: 31789 RVA: 0x0002C2AB File Offset: 0x0002A4AB
	// (set) Token: 0x06007BF9 RID: 31737 RVA: 0x0002BFD3 File Offset: 0x0002A1D3
	public float JJMJBGOLEJO
	{
		get
		{
			return this._skyNoiseStrength;
		}
		set
		{
			if (value != this._skyNoiseStrength)
			{
				this._skyNoiseStrength = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007BFA RID: 31738 RVA: 0x0002BE4A File Offset: 0x0002A04A
	public void KIFQQBDFMHK(KJOKMDLJNNE BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._preset)
		{
			this._preset = BGBMIEJJQKC;
			this.LEKEJJENHQC();
		}
	}

	// Token: 0x06007BFC RID: 31740 RVA: 0x0002C00F File Offset: 0x0002A20F
	public float BCDMFEFLDPG()
	{
		return this._turbulence;
	}

	// Token: 0x06007BFD RID: 31741 RVA: 0x0002C017 File Offset: 0x0002A217
	public void JPNCFLMQOLQ(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._skyAlpha)
		{
			this._skyAlpha = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.SandStorm;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06007BFE RID: 31742 RVA: 0x0002C036 File Offset: 0x0002A236
	// (set) Token: 0x06007C3C RID: 31804 RVA: 0x0002C35C File Offset: 0x0002A55C
	public float DKNOOICFJBB
	{
		get
		{
			return this._skyHaze;
		}
		set
		{
			if (value != this._skyHaze)
			{
				this._skyHaze = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C00 RID: 31744 RVA: 0x0002C05D File Offset: 0x0002A25D
	private void CQEICEGBPJC()
	{
		this.LEKEJJENHQC();
	}

	// Token: 0x06007C02 RID: 31746 RVA: 0x0002C065 File Offset: 0x0002A265
	private void OnEnable()
	{
		this.CPCICJDOELQ();
		this.LEKEJJENHQC();
	}

	// Token: 0x06007C03 RID: 31747 RVA: 0x0002C073 File Offset: 0x0002A273
	public void ELFHOIIDKDQ(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._clipUnderBaseline)
		{
			this._clipUnderBaseline = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007C04 RID: 31748 RVA: 0x003AD8E8 File Offset: 0x003ABAE8
	private void GEQJHGNKEKB()
	{
		if (!this.IGGDQFDQBFJ)
		{
			return;
		}
		int num = this.BFIMMFPELCH(this.IJBCMDHIEBK, 1f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.ARGB32, false);
		this.QHFJCEIJGJL.hideFlags = HideFlags.DontSave;
		this.QHFJCEIJGJL.filterMode = FilterMode.Bilinear;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.QCKHPPOPFGF();
	}

	// Token: 0x06007C05 RID: 31749 RVA: 0x003AD94C File Offset: 0x003ABB4C
	private void GCFBDJBMCGG()
	{
		Vector4 value = new Vector4(this._skyHaze, this._skySpeed, this._skyNoiseStrength, this.KQDFKFHCLQB);
		this.fogMat.SetVector("_FogSkyData", value);
	}

	// Token: 0x06007C06 RID: 31750 RVA: 0x0002C08B File Offset: 0x0002A28B
	private int HBFEBMEHHIE(int BJGMIBBEGDQ, float PJDGFDBEOOJ)
	{
		BJGMIBBEGDQ = (int)((float)BJGMIBBEGDQ / PJDGFDBEOOJ);
		BJGMIBBEGDQ /= 1;
		if (BJGMIBBEGDQ < 1)
		{
			BJGMIBBEGDQ = 0;
		}
		return BJGMIBBEGDQ * 2;
	}

	// Token: 0x06007C07 RID: 31751 RVA: 0x0002C0A3 File Offset: 0x0002A2A3
	public void NPOEFIKEMOM(float CPKNEQGKQPQ)
	{
		this.LCHHLOCMEFC(1347f, 904f, CPKNEQGKQPQ);
	}

	// Token: 0x06007C09 RID: 31753 RVA: 0x0002BF16 File Offset: 0x0002A116
	public float MBEQQLDOLPD()
	{
		return this._noiseStrength;
	}

	// Token: 0x06007C0A RID: 31754 RVA: 0x003AD98C File Offset: 0x003ABB8C
	protected void NOOBNMLOBCP()
	{
		this.fogMat = null;
		this.NNLFDNKMEHL = null;
		this.JFQNEDJIGGB = null;
		this.BPGMNFJGJDG = null;
		this.BIHOGKQQQKM = null;
		this.KQDENOHFPNL = null;
		this.QHKPFNOGMEL = null;
		this.QDNLGGKJBLF = null;
		this.MLMCQLPFGEP = null;
		this.NHJFCPFQLPJ();
	}

	// Token: 0x06007C0B RID: 31755 RVA: 0x0002C0D5 File Offset: 0x0002A2D5
	public void QGHOEPGGHIP(float CPKNEQGKQPQ)
	{
		this.EILIPOLPCJM = true;
		this.OGQBDFFDMOP(this.EFHNNQJHLLM(), this.GOIDJQIBIEE(), CPKNEQGKQPQ);
	}

	// Token: 0x06007C0C RID: 31756 RVA: 0x0002C0F1 File Offset: 0x0002A2F1
	public void MFGQFNFJPIK(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._noiseScale)
		{
			this._noiseScale = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.Clear;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06007C0E RID: 31758 RVA: 0x0002BDBF File Offset: 0x00029FBF
	// (set) Token: 0x06007C3A RID: 31802 RVA: 0x0002C325 File Offset: 0x0002A525
	public float KDEMMJKGDJM
	{
		get
		{
			return this._speed;
		}
		set
		{
			if (value != this._speed)
			{
				this._speed = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06007C0F RID: 31759 RVA: 0x0002C110 File Offset: 0x0002A310
	// (set) Token: 0x06007C4E RID: 31822 RVA: 0x0002C41F File Offset: 0x0002A61F
	public float NDEEIMGBGIM
	{
		get
		{
			return this._distanceFallOff;
		}
		set
		{
			if (value != this._distanceFallOff)
			{
				this._distanceFallOff = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C11 RID: 31761 RVA: 0x0002C118 File Offset: 0x0002A318
	public void FEDLPGBOFBJ(Color BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._color2)
		{
			this._color2 = BGBMIEJJQKC;
			this._preset = KJOKMDLJNNE.Fog;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06007C12 RID: 31762 RVA: 0x0002C13C File Offset: 0x0002A33C
	// (set) Token: 0x06007C24 RID: 31780 RVA: 0x0002C283 File Offset: 0x0002A483
	public bool DKGELEKMEFE
	{
		get
		{
			return this._useSinglePassStereoRenderingMatrix;
		}
		set
		{
			if (value != this._useSinglePassStereoRenderingMatrix)
			{
				this._useSinglePassStereoRenderingMatrix = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06007C4C RID: 31820 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
	// (set) Token: 0x06007C13 RID: 31763 RVA: 0x0002C144 File Offset: 0x0002A344
	public float FKDGEKNHQFB
	{
		get
		{
			return this._distance;
		}
		set
		{
			if (value != this._distance)
			{
				this._distance = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C14 RID: 31764 RVA: 0x0002C163 File Offset: 0x0002A363
	public void CELJNHFKEJF(float CPKNEQGKQPQ)
	{
		this.EILIPOLPCJM = true;
		this.CHFPDGBKGOD(this.EFHNNQJHLLM(), this.GNBPCEIDMJH, CPKNEQGKQPQ);
	}

	// Token: 0x06007C16 RID: 31766 RVA: 0x0002C19E File Offset: 0x0002A39E
	public float LJCCGMQCGLI()
	{
		return this._scattering;
	}

	// Token: 0x06007C17 RID: 31767 RVA: 0x0002C1A6 File Offset: 0x0002A3A6
	public DynamicFogProfile FOIKKIGGPDF()
	{
		return this._profile;
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06007C19 RID: 31769 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
	// (set) Token: 0x06007C40 RID: 31808 RVA: 0x0002C39A File Offset: 0x0002A59A
	public bool GLDHDDCKIQD
	{
		get
		{
			return this._enableDithering;
		}
		set
		{
			if (value != this._enableDithering)
			{
				this._enableDithering = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C1C RID: 31772 RVA: 0x0002C1F9 File Offset: 0x0002A3F9
	public void JJPLPKOHJHF(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._ditherStrength)
		{
			this._ditherStrength = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x06007C1D RID: 31773 RVA: 0x0002BF16 File Offset: 0x0002A116
	public float QBIPCQGBEQO()
	{
		return this._noiseStrength;
	}

	// Token: 0x06007C1E RID: 31774 RVA: 0x0002BD26 File Offset: 0x00029F26
	public float GJDLGOFEFOK()
	{
		return this._skyAlpha;
	}

	// Token: 0x06007C1F RID: 31775 RVA: 0x0002C211 File Offset: 0x0002A411
	public string DFIOKENDDQJ()
	{
		return Enum.GetName(typeof(KJOKMDLJNNE), this.OFJFOOBLOLG());
	}

	// Token: 0x06007C20 RID: 31776 RVA: 0x003AD9E0 File Offset: 0x003ABBE0
	public void ONNIJPKFOLH(DynamicFogProfile GOFFLIBLOEO, float CPKNEQGKQPQ)
	{
		if (!this._useFogVolumes)
		{
			return;
		}
		this.CNMNNFBKKKD = KJOKMDLJNNE.GroundFog;
		this.ENEEDHHHQJD = ScriptableObject.CreateInstance<DynamicFogProfile>();
		this.ENEEDHHHQJD.EOJLHBMFOFE(this);
		this.GOFFLIBLOEO = GOFFLIBLOEO;
		this.FQCECBMJCDB = CPKNEQGKQPQ;
		this.QLDEDDPFHNQ = Time.time;
		this.MJEGNCCHIBP = false;
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06007C30 RID: 31792 RVA: 0x0002C1A6 File Offset: 0x0002A3A6
	// (set) Token: 0x06007C21 RID: 31777 RVA: 0x0002C22D File Offset: 0x0002A42D
	public DynamicFogProfile MQPNOMLJGKF
	{
		get
		{
			return this._profile;
		}
		set
		{
			if (value != this._profile)
			{
				this._profile = value;
				if (this._profile != null)
				{
					this._profile.BJNHBGHBHII(this);
					this._preset = KJOKMDLJNNE.Custom;
					this.NHJFCPFQLPJ();
				}
			}
		}
	}

	// Token: 0x06007C22 RID: 31778 RVA: 0x003ADA34 File Offset: 0x003ABC34
	private void CPCICJDOELQ()
	{
		this.LPNBHOHIEMM = -1f;
		this.GLCNGDEIDHM = -1f;
		this.EBNOGGPBLNC = base.GetComponent<Camera>();
		this.GEQJHGNKEKB();
		if (this._profile != null)
		{
			this._profile.BJNHBGHBHII(this);
		}
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06007C51 RID: 31825 RVA: 0x0002C43E File Offset: 0x0002A63E
	// (set) Token: 0x06007C23 RID: 31779 RVA: 0x0002C26B File Offset: 0x0002A46B
	public int IJBCMDHIEBK
	{
		get
		{
			return this._fogOfWarTextureSize;
		}
		set
		{
			if (value != this._fogOfWarTextureSize)
			{
				this._fogOfWarTextureSize = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C25 RID: 31781 RVA: 0x0002C05D File Offset: 0x0002A25D
	private void Reset()
	{
		this.LEKEJJENHQC();
	}

	// Token: 0x06007C27 RID: 31783 RVA: 0x003ADA84 File Offset: 0x003ABC84
	public void BQOGNMGPIHN(float NHDMOPEBGCJ, float PHKDQDMKOEL, float CPKNEQGKQPQ)
	{
		if (!this.LIJNQCKKGKK)
		{
			return;
		}
		this.CGEBLJBKNML(KJOKMDLJNNE.Custom);
		this.KIBQIJDFPEI = this.GLCLIFMJOCH;
		this.NHEMMGFJOQO = this.KQDFKFHCLQB;
		this.LPNBHOHIEMM = NHDMOPEBGCJ;
		this.GLCNGDEIDHM = PHKDQDMKOEL;
		this.FQCECBMJCDB = CPKNEQGKQPQ;
		this.QLDEDDPFHNQ = Time.time;
		this.JODLKDDNFKP = false;
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06007C28 RID: 31784 RVA: 0x0002BF16 File Offset: 0x0002A116
	// (set) Token: 0x06007C35 RID: 31797 RVA: 0x0002C306 File Offset: 0x0002A506
	public float JHNOMPGDFLE
	{
		get
		{
			return this._noiseStrength;
		}
		set
		{
			if (value != this._noiseStrength)
			{
				this._noiseStrength = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C2A RID: 31786 RVA: 0x0002BCE8 File Offset: 0x00029EE8
	public float LGFCIDDBIIO()
	{
		return this._noiseScale;
	}

	// Token: 0x06007C2B RID: 31787 RVA: 0x003ADAE0 File Offset: 0x003ABCE0
	public void CHFPDGBKGOD(Color NHMQDFMMGGO, Color GNBPCEIDMJH, float CPKNEQGKQPQ)
	{
		if (!this.LIJNQCKKGKK)
		{
			return;
		}
		this.CNMNNFBKKKD = KJOKMDLJNNE.Custom;
		this.GLFGQFNGIFJ = this.QLBNKCNGIQJ;
		this.LQQEEKLPFDJ = this.ILMGPGCHQMF;
		this.ECCBJFEDHOO = NHMQDFMMGGO;
		this.EPBQLBQLGOF = GNBPCEIDMJH;
		this.FQCECBMJCDB = CPKNEQGKQPQ;
		this.QLDEDDPFHNQ = Time.time;
		this.EILIPOLPCJM = true;
		this.NGOMCPCLNFN = true;
	}

	// Token: 0x06007C2C RID: 31788 RVA: 0x003ADB44 File Offset: 0x003ABD44
	private void DFQJNCOICLO()
	{
		if (!this.IGGDQFDQBFJ)
		{
			return;
		}
		int num = this.MQQKQQMCJCN(this.IJBCMDHIEBK, 1548f);
		this.QHFJCEIJGJL = new Texture2D(num, num, TextureFormat.Alpha8, true);
		this.QHFJCEIJGJL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		this.QHFJCEIJGJL.filterMode = FilterMode.Point;
		this.QHFJCEIJGJL.wrapMode = TextureWrapMode.Clamp;
		this.QCKHPPOPFGF();
	}

	// Token: 0x06007C2F RID: 31791 RVA: 0x0002C2B3 File Offset: 0x0002A4B3
	public string DNDQJNJCOEB()
	{
		return Enum.GetName(typeof(KJOKMDLJNNE), this.CNMNNFBKKKD);
	}

	// Token: 0x06007C31 RID: 31793 RVA: 0x0002C2CF File Offset: 0x0002A4CF
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

	// Token: 0x06007C33 RID: 31795 RVA: 0x003ADBA8 File Offset: 0x003ABDA8
	public void OGQBDFFDMOP(Color NHMQDFMMGGO, Color GNBPCEIDMJH, float CPKNEQGKQPQ)
	{
		if (!this.LIJNQCKKGKK)
		{
			return;
		}
		this.CGEBLJBKNML(KJOKMDLJNNE.Clear);
		this.GLFGQFNGIFJ = this.QLBNKCNGIQJ;
		this.LQQEEKLPFDJ = this.ILMGPGCHQMF;
		this.ECCBJFEDHOO = NHMQDFMMGGO;
		this.EPBQLBQLGOF = GNBPCEIDMJH;
		this.FQCECBMJCDB = CPKNEQGKQPQ;
		this.QLDEDDPFHNQ = Time.time;
		this.EILIPOLPCJM = false;
		this.NGOMCPCLNFN = false;
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x06007C34 RID: 31796 RVA: 0x0002C00F File Offset: 0x0002A20F
	// (set) Token: 0x06007C3F RID: 31807 RVA: 0x0002C37B File Offset: 0x0002A57B
	public float OHDLJLKFBCE
	{
		get
		{
			return this._turbulence;
		}
		set
		{
			if (value != this._turbulence)
			{
				this._turbulence = value;
				this._preset = KJOKMDLJNNE.Custom;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C37 RID: 31799 RVA: 0x0002BE42 File Offset: 0x0002A042
	public float KNIDENGPCDG()
	{
		return this._maxDistanceFallOff;
	}

	// Token: 0x06007C38 RID: 31800 RVA: 0x003ADC0C File Offset: 0x003ABE0C
	private void PPOFGKILCIM(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 181f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				this.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					this.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("_Male", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				this.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("vSync", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Fly", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007C39 RID: 31801 RVA: 0x003ADD24 File Offset: 0x003ABF24
	public void LCHHLOCMEFC(float NHDMOPEBGCJ, float PHKDQDMKOEL, float CPKNEQGKQPQ)
	{
		if (!this.LIJNQCKKGKK)
		{
			return;
		}
		this.CNMNNFBKKKD = KJOKMDLJNNE.Custom;
		this.KIBQIJDFPEI = this.GLCLIFMJOCH;
		this.NHEMMGFJOQO = this.KQDFKFHCLQB;
		this.LPNBHOHIEMM = NHDMOPEBGCJ;
		this.GLCNGDEIDHM = PHKDQDMKOEL;
		this.FQCECBMJCDB = CPKNEQGKQPQ;
		this.QLDEDDPFHNQ = Time.time;
		this.JODLKDDNFKP = true;
	}

	// Token: 0x06007C3B RID: 31803 RVA: 0x0002C344 File Offset: 0x0002A544
	public void NHJFCPFQLPJ()
	{
		if (Application.isPlaying)
		{
			this.EGHPIHKDNMD = true;
		}
		else
		{
			this.LEKEJJENHQC();
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06007C4A RID: 31818 RVA: 0x0002C3B2 File Offset: 0x0002A5B2
	// (set) Token: 0x06007C3E RID: 31806 RVA: 0x0002C1F9 File Offset: 0x0002A3F9
	public float GHLDEJLGOFI
	{
		get
		{
			return this._ditherStrength;
		}
		set
		{
			if (value != this._ditherStrength)
			{
				this._ditherStrength = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C41 RID: 31809 RVA: 0x0002BDBF File Offset: 0x00029FBF
	public float JIPEIMIJFCO()
	{
		return this._speed;
	}

	// Token: 0x06007C42 RID: 31810 RVA: 0x0002BE4A File Offset: 0x0002A04A
	public void CGEBLJBKNML(KJOKMDLJNNE BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._preset)
		{
			this._preset = BGBMIEJJQKC;
			this.LEKEJJENHQC();
		}
	}

	// Token: 0x06007C43 RID: 31811 RVA: 0x003ADD80 File Offset: 0x003ABF80
	public void BIJGBLGPKHB(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - this.KQLFJBLIQPF.x) / this.QKOEKNCNLHK.x + 1411f;
		if (num < 609f || num > 908f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - this.KQLFJBLIQPF.z) / this.QKOEKNCNLHK.z + 1725f;
		if (num2 >= 992f && num2 <= 1306f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 1420f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / this.QKOEKNCNLHK.z;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i += 0)
				{
					if (i > 1 && i < height - 1)
					{
						for (int j = num3 - num7; j <= num3 + num7; j += 0)
						{
							if (j > 1 && j < width - 0)
							{
								int num8 = Mathf.FloorToInt(Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j))));
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

	// Token: 0x06007C44 RID: 31812 RVA: 0x003ADFA4 File Offset: 0x003AC1A4
	public void JBJLGOCLNJN(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - this.KQLFJBLIQPF.x) / this.QKOEKNCNLHK.x + 53f;
		if (num < 182f || num > 1129f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - this.KQLFJBLIQPF.z) / this.QKOEKNCNLHK.z + 663f;
		if (num2 >= 1684f && num2 <= 507f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			byte b = (byte)(EKGEPJPOHQI * 1371f);
			Color32 color = this.OKCPBLQPQKI[num5];
			if (b != color.a)
			{
				float num6 = HLDJHBLPJJF / this.QKOEKNCNLHK.z;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i += 0)
				{
					if (i > 1 && i < height - 0)
					{
						for (int j = num3 - num7; j <= num3 + num7; j++)
						{
							if (j > 1 && j < width - 0)
							{
								int num8 = Mathf.FloorToInt(Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j))));
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

	// Token: 0x06007C45 RID: 31813 RVA: 0x0002BEDC File Offset: 0x0002A0DC
	public Camera EEMLGKOOGJB()
	{
		return this.EBNOGGPBLNC;
	}

	// Token: 0x06007C46 RID: 31814 RVA: 0x003AE1C8 File Offset: 0x003AC3C8
	public void DEIKIDNHLNJ(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - this.KQLFJBLIQPF.x) / this.QKOEKNCNLHK.x + 1444f;
		if (num < 1146f || num > 1589f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - this.KQLFJBLIQPF.z) / this.QKOEKNCNLHK.z + 863f;
		if (num2 >= 638f && num2 <= 1261f)
		{
			int width = this.QHFJCEIJGJL.width;
			int height = this.QHFJCEIJGJL.height;
			int num3 = (int)(num * (float)width);
			int num4 = (int)(num2 * (float)height);
			int num5 = num4 * width + num3;
			float num6 = HLDJHBLPJJF / this.QKOEKNCNLHK.z;
			int num7 = Mathf.FloorToInt((float)height * num6);
			for (int i = num4 - num7; i <= num4 + num7; i++)
			{
				if (i > 1 && i < height - 1)
				{
					for (int j = num3 - num7; j <= num3 + num7; j++)
					{
						if (j > 0 && j < width - 1)
						{
							int num8 = Mathf.FloorToInt(Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j))));
							if (num8 <= num7)
							{
								num5 = i * width + j;
								Color32 color = this.OKCPBLQPQKI[num5];
								color.a = (byte)-120;
								this.OKCPBLQPQKI[num5] = color;
								this.QHFJCEIJGJL.SetPixel(j, i, color);
							}
						}
					}
				}
				this.QHFJCEIJGJL.Apply();
			}
			return;
		}
	}

	// Token: 0x06007C47 RID: 31815 RVA: 0x003AE3A8 File Offset: 0x003AC5A8
	public void MGMJNODQCOI(Vector3 IFKGDDJPEPK, float HLDJHBLPJJF, float EKGEPJPOHQI)
	{
		if (this.QHFJCEIJGJL == null)
		{
			return;
		}
		float num = (IFKGDDJPEPK.x - this.KQLFJBLIQPF.x) / this.QKOEKNCNLHK.x + 0.5f;
		if (num < 0f || num > 1f)
		{
			return;
		}
		float num2 = (IFKGDDJPEPK.z - this.KQLFJBLIQPF.z) / this.QKOEKNCNLHK.z + 0.5f;
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
				float num6 = HLDJHBLPJJF / this.QKOEKNCNLHK.z;
				int num7 = Mathf.FloorToInt((float)height * num6);
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 0 && i < height - 1)
					{
						for (int j = num3 - num7; j <= num3 + num7; j++)
						{
							if (j > 0 && j < width - 1)
							{
								int num8 = Mathf.FloorToInt(Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j))));
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

	// Token: 0x06007C48 RID: 31816 RVA: 0x0002C1F9 File Offset: 0x0002A3F9
	public void EQBHJIMBDIL(float BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._ditherStrength)
		{
			this._ditherStrength = BGBMIEJJQKC;
			this.NHJFCPFQLPJ();
		}
	}

	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x06007C49 RID: 31817 RVA: 0x0002BCD8 File Offset: 0x00029ED8
	// (set) Token: 0x06007C4F RID: 31823 RVA: 0x0002BFB6 File Offset: 0x0002A1B6
	public GameObject MDBILOHFMOM
	{
		get
		{
			return this._sun;
		}
		set
		{
			if (value != this._sun)
			{
				this._sun = value;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C4B RID: 31819 RVA: 0x0002C3BA File Offset: 0x0002A5BA
	public void GBJLCIDJHLB(DynamicFogProfile BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != this._profile)
		{
			this._profile = BGBMIEJJQKC;
			if (this._profile != null)
			{
				this._profile.OKJEEMNELDN(this);
				this._preset = KJOKMDLJNNE.Fog;
				this.NHJFCPFQLPJ();
			}
		}
	}

	// Token: 0x06007C50 RID: 31824 RVA: 0x0002BCF0 File Offset: 0x00029EF0
	private void LFJONQBEPPL()
	{
		this.EGHPIHKDNMD = true;
	}

	// Token: 0x04001AC7 RID: 6855
	[SerializeField]
	private GFJGCGGGJOJ _effectType = GFJGCGGGJOJ.DesktopFogPlusWithSkyHaze;

	// Token: 0x04001AC8 RID: 6856
	[SerializeField]
	private KJOKMDLJNNE _preset = KJOKMDLJNNE.Mist;

	// Token: 0x04001AC9 RID: 6857
	[SerializeField]
	private DynamicFogProfile _profile;

	// Token: 0x04001ACA RID: 6858
	[SerializeField]
	private bool _useFogVolumes;

	// Token: 0x04001ACB RID: 6859
	[SerializeField]
	private bool _enableDithering;

	// Token: 0x04001ACC RID: 6860
	[Range(0f, 0.2f)]
	[SerializeField]
	private float _ditherStrength = 0.03f;

	// Token: 0x04001ACD RID: 6861
	[SerializeField]
	[Range(0f, 1f)]
	protected float _alpha = 1f;

	// Token: 0x04001ACE RID: 6862
	[Range(0f, 1f)]
	[SerializeField]
	private float _noiseStrength = 0.5f;

	// Token: 0x04001ACF RID: 6863
	[Range(0.01f, 1f)]
	[SerializeField]
	private float _noiseScale = 0.1f;

	// Token: 0x04001AD0 RID: 6864
	[SerializeField]
	[Range(0f, 0.999f)]
	private float _distance = 0.1f;

	// Token: 0x04001AD1 RID: 6865
	[SerializeField]
	[Range(0.0001f, 2f)]
	private float _distanceFallOff = 0.01f;

	// Token: 0x04001AD2 RID: 6866
	[SerializeField]
	[Range(0f, 1.2f)]
	private float _maxDistance = 0.999f;

	// Token: 0x04001AD3 RID: 6867
	[SerializeField]
	[Range(0.0001f, 0.5f)]
	private float _maxDistanceFallOff;

	// Token: 0x04001AD4 RID: 6868
	[Range(0f, 500f)]
	[SerializeField]
	private float _height = 1f;

	// Token: 0x04001AD5 RID: 6869
	[SerializeField]
	[Range(0f, 500f)]
	private float _maxHeight = 100f;

	// Token: 0x04001AD6 RID: 6870
	[SerializeField]
	[Range(0.0001f, 1f)]
	private float _heightFallOff = 0.1f;

	// Token: 0x04001AD7 RID: 6871
	[SerializeField]
	private float _baselineHeight;

	// Token: 0x04001AD8 RID: 6872
	[SerializeField]
	private bool _clipUnderBaseline;

	// Token: 0x04001AD9 RID: 6873
	[SerializeField]
	[Range(0f, 15f)]
	private float _turbulence = 0.1f;

	// Token: 0x04001ADA RID: 6874
	[SerializeField]
	[Range(0f, 5f)]
	private float _speed = 0.1f;

	// Token: 0x04001ADB RID: 6875
	[SerializeField]
	private Vector3 _windDirection = new Vector3(1f, 0f, 1f);

	// Token: 0x04001ADC RID: 6876
	[SerializeField]
	private Color _color = Color.white;

	// Token: 0x04001ADD RID: 6877
	[SerializeField]
	private Color _color2 = Color.gray;

	// Token: 0x04001ADE RID: 6878
	[Range(0f, 500f)]
	[SerializeField]
	private float _skyHaze = 50f;

	// Token: 0x04001ADF RID: 6879
	[Range(0f, 1f)]
	[SerializeField]
	private float _skySpeed = 0.3f;

	// Token: 0x04001AE0 RID: 6880
	[SerializeField]
	[Range(0f, 1f)]
	private float _skyNoiseStrength = 0.1f;

	// Token: 0x04001AE1 RID: 6881
	[SerializeField]
	[Range(0f, 1f)]
	private float _skyAlpha = 1f;

	// Token: 0x04001AE2 RID: 6882
	[SerializeField]
	private GameObject _sun;

	// Token: 0x04001AE3 RID: 6883
	[SerializeField]
	private bool _fogOfWarEnabled;

	// Token: 0x04001AE4 RID: 6884
	[SerializeField]
	private Vector3 _fogOfWarCenter;

	// Token: 0x04001AE5 RID: 6885
	[SerializeField]
	private Vector3 _fogOfWarSize = new Vector3(1024f, 0f, 1024f);

	// Token: 0x04001AE6 RID: 6886
	[SerializeField]
	private int _fogOfWarTextureSize = 256;

	// Token: 0x04001AE7 RID: 6887
	[SerializeField]
	protected bool _useSinglePassStereoRenderingMatrix;

	// Token: 0x04001AE8 RID: 6888
	[SerializeField]
	private bool _useXZDistance;

	// Token: 0x04001AE9 RID: 6889
	[SerializeField]
	[Range(0f, 1f)]
	private float _scattering = 0.7f;

	// Token: 0x04001AEA RID: 6890
	[SerializeField]
	private Color _scatteringColor = new Color(1f, 1f, 0.8f);

	// Token: 0x04001AEB RID: 6891
	private Material NNLFDNKMEHL;

	// Token: 0x04001AEC RID: 6892
	private Material JFQNEDJIGGB;

	// Token: 0x04001AED RID: 6893
	private Material BPGMNFJGJDG;

	// Token: 0x04001AEE RID: 6894
	private Material QHKPFNOGMEL;

	// Token: 0x04001AEF RID: 6895
	private Material BIHOGKQQQKM;

	// Token: 0x04001AF0 RID: 6896
	private Material KQDENOHFPNL;

	// Token: 0x04001AF1 RID: 6897
	private Material MLMCQLPFGEP;

	// Token: 0x04001AF2 RID: 6898
	private Material QDNLGGKJBLF;

	// Token: 0x04001AF3 RID: 6899
	[SerializeField]
	protected Material fogMat;

	// Token: 0x04001AF4 RID: 6900
	private float KIBQIJDFPEI;

	// Token: 0x04001AF5 RID: 6901
	private float LPNBHOHIEMM;

	// Token: 0x04001AF6 RID: 6902
	private float NHEMMGFJOQO;

	// Token: 0x04001AF7 RID: 6903
	private float GLCNGDEIDHM;

	// Token: 0x04001AF8 RID: 6904
	private bool EILIPOLPCJM;

	// Token: 0x04001AF9 RID: 6905
	private Color GLFGQFNGIFJ;

	// Token: 0x04001AFA RID: 6906
	private Color ECCBJFEDHOO;

	// Token: 0x04001AFB RID: 6907
	private Color LQQEEKLPFDJ;

	// Token: 0x04001AFC RID: 6908
	private Color EPBQLBQLGOF;

	// Token: 0x04001AFD RID: 6909
	private float FQCECBMJCDB;

	// Token: 0x04001AFE RID: 6910
	private float QLDEDDPFHNQ;

	// Token: 0x04001AFF RID: 6911
	private float GLCLIFMJOCH;

	// Token: 0x04001B00 RID: 6912
	private float KQDFKFHCLQB;

	// Token: 0x04001B01 RID: 6913
	private bool JODLKDDNFKP;

	// Token: 0x04001B02 RID: 6914
	private bool NGOMCPCLNFN;

	// Token: 0x04001B03 RID: 6915
	private bool MJEGNCCHIBP;

	// Token: 0x04001B04 RID: 6916
	private DynamicFogProfile ENEEDHHHQJD;

	// Token: 0x04001B05 RID: 6917
	private DynamicFogProfile GOFFLIBLOEO;

	// Token: 0x04001B06 RID: 6918
	private Color QLBNKCNGIQJ;

	// Token: 0x04001B07 RID: 6919
	private Color ILMGPGCHQMF;

	// Token: 0x04001B08 RID: 6920
	protected Camera EBNOGGPBLNC;

	// Token: 0x04001B09 RID: 6921
	private Texture2D QHFJCEIJGJL;

	// Token: 0x04001B0A RID: 6922
	private Color32[] OKCPBLQPQKI;

	// Token: 0x04001B0B RID: 6923
	private Light FEKLJCJFPKJ;

	// Token: 0x04001B0C RID: 6924
	private Vector3 KPLDKDEQOFI = Vector3.zero;

	// Token: 0x04001B0D RID: 6925
	private Color JBMCKIDQGFC = Color.white;

	// Token: 0x04001B0E RID: 6926
	private float GKENELBBCHD = 1f;

	// Token: 0x04001B0F RID: 6927
	private static OCPDQGMMEMQ HGLLGJGOPGL;

	// Token: 0x04001B10 RID: 6928
	private List<string> BCHQLQMPGJL;

	// Token: 0x04001B11 RID: 6929
	protected bool PDMEJDMEHGH;

	// Token: 0x04001B12 RID: 6930
	protected bool EGHPIHKDNMD;
}
