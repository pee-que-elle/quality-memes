using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

// Token: 0x020000B6 RID: 182
[AddComponentMenu("NGUI/Internal/Draw Call")]
[ExecuteInEditMode]
public class KMCGDKDIJIE : MonoBehaviour
{
	// Token: 0x060016E1 RID: 5857 RVA: 0x000A5924 File Offset: 0x000A3B24
	public static void INHEEFCIMIH(Scene LOHFKNEKGNG)
	{
		using (IEnumerator<KMCGDKDIJIE> enumerator = KMCGDKDIJIE.PPDCFJJQBMD.KCNQDMFDMPE())
		{
			while (enumerator.MoveNext())
			{
				KMCGDKDIJIE kmcgdkdijie = enumerator.Current;
				SceneManager.MoveGameObjectToScene(kmcgdkdijie.gameObject, LOHFKNEKGNG);
			}
		}
		using (IEnumerator<KMCGDKDIJIE> enumerator2 = KMCGDKDIJIE.QLHOOGPJIME.KCNQDMFDMPE())
		{
			while (enumerator2.MoveNext())
			{
				KMCGDKDIJIE kmcgdkdijie2 = enumerator2.Current;
				SceneManager.MoveGameObjectToScene(kmcgdkdijie2.gameObject, LOHFKNEKGNG);
			}
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060016E6 RID: 5862 RVA: 0x0000BDA9 File Offset: 0x00009FA9
	// (set) Token: 0x060016E2 RID: 5858 RVA: 0x0000BD4E File Offset: 0x00009F4E
	public int BCKQKKMIGNM
	{
		get
		{
			return this.GPDLNOCEHPF;
		}
		set
		{
			if (this.GPDLNOCEHPF != value)
			{
				this.GPDLNOCEHPF = value;
				if (this.GLDEQICKCGJ != null)
				{
					this.GLDEQICKCGJ.renderQueue = value;
				}
			}
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0000BD7A File Offset: 0x00009F7A
	public int HICIPQBDOBM
	{
		get
		{
			return (!(this.GLDEQICKCGJ != null)) ? this.GPDLNOCEHPF : this.GLDEQICKCGJ.renderQueue;
		}
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x000A59B8 File Offset: 0x000A3BB8
	private void JEDBOKHFCFP(int IIHDGMLHICI, Vector4 EEOCOCHLBGI, Vector2 FEIMKFNQIND, float MPNNMHJBOPN)
	{
		MPNNMHJBOPN *= -0.0174532924f;
		Vector2 vector = new Vector2(1000f, 1000f);
		if (FEIMKFNQIND.x > 0f)
		{
			vector.x = EEOCOCHLBGI.z / FEIMKFNQIND.x;
		}
		if (FEIMKFNQIND.y > 0f)
		{
			vector.y = EEOCOCHLBGI.w / FEIMKFNQIND.y;
		}
		if (IIHDGMLHICI < KMCGDKDIJIE.FDKBIKIEKOO.Length)
		{
			this.GLDEQICKCGJ.SetVector(KMCGDKDIJIE.FDKBIKIEKOO[IIHDGMLHICI], new Vector4(-EEOCOCHLBGI.x / EEOCOCHLBGI.z, -EEOCOCHLBGI.y / EEOCOCHLBGI.w, 1f / EEOCOCHLBGI.z, 1f / EEOCOCHLBGI.w));
			this.GLDEQICKCGJ.SetVector(KMCGDKDIJIE.CKKLFLPKMJE[IIHDGMLHICI], new Vector4(vector.x, vector.y, Mathf.Sin(MPNNMHJBOPN), Mathf.Cos(MPNNMHJBOPN)));
		}
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0000BD9D File Offset: 0x00009F9D
	public static void EHFBNKDLLCG()
	{
		KMCGDKDIJIE.GDOLDMKCMEG();
		KMCGDKDIJIE.NHGEPFBPPPK();
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x0000BDB1 File Offset: 0x00009FB1
	private void OnEnable()
	{
		this.MOBMGGDFGFO = true;
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0000BDBA File Offset: 0x00009FBA
	[Obsolete("Use UIDrawCall.activeList")]
	public static MHIDKMCBQEN<KMCGDKDIJIE> NGDBDCQFDHI
	{
		get
		{
			return KMCGDKDIJIE.BKKBIKLKLKM;
		}
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x000A5ABC File Offset: 0x000A3CBC
	public static void MOPPIIOIIDM(KMCGDKDIJIE OBDLPFGDEFJ)
	{
		if (OBDLPFGDEFJ)
		{
			if (OBDLPFGDEFJ.HLLQDCEJEPH != null)
			{
				IKBQNBHOJJB.MOPPIIOIIDM(OBDLPFGDEFJ.gameObject);
				return;
			}
			OBDLPFGDEFJ.IOOHNELQHIO = null;
			if (Application.isPlaying)
			{
				if (KMCGDKDIJIE.BKKBIKLKLKM.FQDMDDOHCQJ(OBDLPFGDEFJ))
				{
					IKBQNBHOJJB.IFPIGKGKFEQ(OBDLPFGDEFJ.gameObject, false);
					KMCGDKDIJIE.DMKICIPCGOQ.LHQECHHMOGD(OBDLPFGDEFJ);
					OBDLPFGDEFJ.DOGGHQIOOQQ = true;
				}
			}
			else
			{
				KMCGDKDIJIE.BKKBIKLKLKM.FQDMDDOHCQJ(OBDLPFGDEFJ);
				IKBQNBHOJJB.QOLECCGGDNB(OBDLPFGDEFJ.gameObject);
			}
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060016EA RID: 5866 RVA: 0x0000BDC1 File Offset: 0x00009FC1
	public static MHIDKMCBQEN<KMCGDKDIJIE> QLHOOGPJIME
	{
		get
		{
			return KMCGDKDIJIE.DMKICIPCGOQ;
		}
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x0000BDC8 File Offset: 0x00009FC8
	public void BQLMLKHLKCD(string BGBMIEJJQKC)
	{
		if (this.DPBIEKGLOFP != null && this.MQHMLLMGMPK != BGBMIEJJQKC)
		{
			this.MQHMLLMGMPK = BGBMIEJJQKC;
			this.DPBIEKGLOFP.sortingLayerName = BGBMIEJJQKC;
		}
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x000A5B38 File Offset: 0x000A3D38
	private int[] QGPNLDHJKMB(int IDFEKGIOJOC, int PBKDGQBBCFG)
	{
		int i = 0;
		int count = KMCGDKDIJIE.EDDIMMFNGEM.Count;
		while (i < count)
		{
			int[] array = KMCGDKDIJIE.EDDIMMFNGEM[i];
			if (array != null && array.Length == PBKDGQBBCFG)
			{
				return array;
			}
			i++;
		}
		int[] array2 = new int[PBKDGQBBCFG];
		int num = 0;
		for (int j = 0; j < IDFEKGIOJOC; j += 4)
		{
			array2[num++] = j + 2;
			array2[num++] = j + 1;
			array2[num++] = j;
			array2[num++] = j;
			array2[num++] = j + 3;
			array2[num++] = j + 2;
		}
		if (KMCGDKDIJIE.EDDIMMFNGEM.Count > 10)
		{
			KMCGDKDIJIE.EDDIMMFNGEM.RemoveAt(0);
		}
		KMCGDKDIJIE.EDDIMMFNGEM.Add(array2);
		return array2;
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0000BE75 File Offset: 0x0000A075
	// (set) Token: 0x060016ED RID: 5869 RVA: 0x0000BDF9 File Offset: 0x00009FF9
	public int OQCHJGMLOCJ
	{
		get
		{
			return this.EKHDEEEGKDO;
		}
		set
		{
			if (this.EKHDEEEGKDO != value)
			{
				this.EKHDEEEGKDO = value;
				if (this.DPBIEKGLOFP != null)
				{
					this.DPBIEKGLOFP.sortingOrder = value;
				}
			}
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060016EE RID: 5870 RVA: 0x0000BE25 File Offset: 0x0000A025
	// (set) Token: 0x06001710 RID: 5904 RVA: 0x000A68F8 File Offset: 0x000A4AF8
	public KMCGDKDIJIE.FDOBLOLHNHE CHJOHKLHNFE
	{
		get
		{
			return this.NOEEHMFKQIN;
		}
		set
		{
			if (this.NOEEHMFKQIN != value)
			{
				this.NOEEHMFKQIN = value;
				if (this.DPBIEKGLOFP != null)
				{
					if (this.NOEEHMFKQIN == KMCGDKDIJIE.FDOBLOLHNHE.None)
					{
						this.DPBIEKGLOFP.shadowCastingMode = ShadowCastingMode.Off;
						this.DPBIEKGLOFP.receiveShadows = false;
					}
					else if (this.NOEEHMFKQIN == KMCGDKDIJIE.FDOBLOLHNHE.Receive)
					{
						this.DPBIEKGLOFP.shadowCastingMode = ShadowCastingMode.Off;
						this.DPBIEKGLOFP.receiveShadows = true;
					}
					else
					{
						this.DPBIEKGLOFP.shadowCastingMode = ShadowCastingMode.On;
						this.DPBIEKGLOFP.receiveShadows = true;
					}
				}
			}
		}
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x000A5C04 File Offset: 0x000A3E04
	private Material LFBCNNKOEFC()
	{
		IKBQNBHOJJB.QOLECCGGDNB(this.GLDEQICKCGJ);
		this.DQNGCOKGMKE();
		this.GLDEQICKCGJ.renderQueue = this.GPDLNOCEHPF;
		if (this.DPBIEKGLOFP != null)
		{
			this.DPBIEKGLOFP.sharedMaterials = new Material[]
			{
				this.GLDEQICKCGJ
			};
			this.DPBIEKGLOFP.sortingLayerName = this.MQHMLLMGMPK;
			this.DPBIEKGLOFP.sortingOrder = this.EKHDEEEGKDO;
		}
		return this.GLDEQICKCGJ;
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x0000BD4E File Offset: 0x00009F4E
	public void JGPBQMNIHDP(int BGBMIEJJQKC)
	{
		if (this.GPDLNOCEHPF != BGBMIEJJQKC)
		{
			this.GPDLNOCEHPF = BGBMIEJJQKC;
			if (this.GLDEQICKCGJ != null)
			{
				this.GLDEQICKCGJ.renderQueue = BGBMIEJJQKC;
			}
		}
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x000A5C84 File Offset: 0x000A3E84
	public static int EDHONKQBOQM(KQHJOLQLQBJ BCHNDNICINJ)
	{
		int num = 0;
		for (int i = 0; i < KMCGDKDIJIE.BKKBIKLKLKM.BJGMIBBEGDQ; i++)
		{
			if (KMCGDKDIJIE.BKKBIKLKLKM.get_KNPPMKBOGDL(i).NOCPDPDCFKM == BCHNDNICINJ)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x000A5CC8 File Offset: 0x000A3EC8
	public static int BQMONBNIECC(KQHJOLQLQBJ BCHNDNICINJ)
	{
		int num = 1;
		for (int i = 1; i < KMCGDKDIJIE.BKKBIKLKLKM.BJGMIBBEGDQ; i++)
		{
			if (KMCGDKDIJIE.BKKBIKLKLKM.get_KNPPMKBOGDL(i).NOCPDPDCFKM == BCHNDNICINJ)
			{
				num += 0;
			}
		}
		return num;
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0000BE2D File Offset: 0x0000A02D
	// (set) Token: 0x060016FF RID: 5887 RVA: 0x0000BED3 File Offset: 0x0000A0D3
	public Material HHQHIJOIBON
	{
		get
		{
			return this.JKFJKMBEOHJ;
		}
		set
		{
			if (this.JKFJKMBEOHJ != value)
			{
				this.JKFJKMBEOHJ = value;
				this.MOBMGGDFGFO = true;
			}
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060016FB RID: 5883 RVA: 0x0000BE91 File Offset: 0x0000A091
	// (set) Token: 0x060016F4 RID: 5876 RVA: 0x0000BE35 File Offset: 0x0000A035
	public Shader JHKGHDQFQNL
	{
		get
		{
			return this.EQLCFHLLDLB;
		}
		set
		{
			if (this.EQLCFHLLDLB != value)
			{
				this.EQLCFHLLDLB = value;
				this.MOBMGGDFGFO = true;
			}
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0000BE53 File Offset: 0x0000A053
	public Transform CGDFDPHIENG
	{
		get
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
			}
			return this.BLLEFKOLKLP;
		}
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x0000BD7A File Offset: 0x00009F7A
	public int PJDOJFKMOFP()
	{
		return (!(this.GLDEQICKCGJ != null)) ? this.GPDLNOCEHPF : this.GLDEQICKCGJ.renderQueue;
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0000BE7D File Offset: 0x0000A07D
	// (set) Token: 0x06001705 RID: 5893 RVA: 0x0000BEFF File Offset: 0x0000A0FF
	public Texture GOIHJQNMMJD
	{
		get
		{
			return this.KCENPPMLLCK;
		}
		set
		{
			this.KCENPPMLLCK = value;
			if (this.MBHJEBPQHEF == null)
			{
				this.MBHJEBPQHEF = new MaterialPropertyBlock();
			}
			this.MBHJEBPQHEF.SetTexture("_MainTex", value);
		}
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x000A5D0C File Offset: 0x000A3F0C
	public static void GDOLDMKCMEG()
	{
		bool isPlaying = Application.isPlaying;
		int i = KMCGDKDIJIE.BKKBIKLKLKM.BJGMIBBEGDQ;
		while (i > 0)
		{
			KMCGDKDIJIE kmcgdkdijie = KMCGDKDIJIE.BKKBIKLKLKM.get_KNPPMKBOGDL(--i);
			if (kmcgdkdijie)
			{
				if (isPlaying)
				{
					IKBQNBHOJJB.IFPIGKGKFEQ(kmcgdkdijie.gameObject, false);
				}
				else
				{
					IKBQNBHOJJB.QOLECCGGDNB(kmcgdkdijie.gameObject);
				}
			}
		}
		KMCGDKDIJIE.BKKBIKLKLKM.CPLBKPNNHJG();
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x0000BE85 File Offset: 0x0000A085
	public static KMCGDKDIJIE DPKGHFIHBPE(KQHJOLQLQBJ BCHNDNICINJ, Material HQNQNDECMLH, Texture NNFMFGDPCPF, Shader JHKGHDQFQNL)
	{
		return KMCGDKDIJIE.DPKGHFIHBPE(null, BCHNDNICINJ, HQNQNDECMLH, NNFMFGDPCPF, JHKGHDQFQNL);
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x000A5D70 File Offset: 0x000A3F70
	private void DLMQCMOQICN()
	{
		if (this.BCHNDNICINJ == null)
		{
			return;
		}
		if (this.MOBMGGDFGFO || this.GLDEQICKCGJ == null || this.OHKNJLDNPCQ != this.BCHNDNICINJ.PNOEILCQBKB || this.QGJDDCCKJCI != (this.BCHNDNICINJ.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask))
		{
			this.LFBCNNKOEFC();
			this.MOBMGGDFGFO = false;
		}
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x000A5DDC File Offset: 0x000A3FDC
	public void GMFDMDNCDPQ(int QBPMLOJLHML)
	{
		this.QBPMLOJLHML = QBPMLOJLHML;
		int count = this.EQINHIFFOGG.Count;
		if (count > 0 && count == this.PICFCJNMJMC.Count && count == this.HQOONBPDFHO.Count && count % 4 == 0)
		{
			if (KMCGDKDIJIE.HILLHGIEBFE == ColorSpace.Uninitialized)
			{
				KMCGDKDIJIE.HILLHGIEBFE = QualitySettings.activeColorSpace;
			}
			if (KMCGDKDIJIE.HILLHGIEBFE == ColorSpace.Linear)
			{
				for (int i = 0; i < count; i++)
				{
					Color value = this.HQOONBPDFHO[i];
					value.r = Mathf.GammaToLinearSpace(value.r);
					value.g = Mathf.GammaToLinearSpace(value.g);
					value.b = Mathf.GammaToLinearSpace(value.b);
					value.a = Mathf.GammaToLinearSpace(value.a);
					this.HQOONBPDFHO[i] = value;
				}
			}
			if (this.IQFLLQGBFMI == null)
			{
				this.IQFLLQGBFMI = base.gameObject.GetComponent<MeshFilter>();
			}
			if (this.IQFLLQGBFMI == null)
			{
				this.IQFLLQGBFMI = base.gameObject.AddComponent<MeshFilter>();
			}
			if (count < 65000)
			{
				int num = (count >> 1) * 3;
				bool flag = this.PBEPEJEQEBC == null || this.PBEPEJEQEBC.Length != num;
				if (this.KGQQLFDHQEN == null)
				{
					this.KGQQLFDHQEN = new Mesh();
					this.KGQQLFDHQEN.hideFlags = HideFlags.DontSave;
					this.KGQQLFDHQEN.name = ((!(this.JKFJKMBEOHJ != null)) ? "[NGUI] Mesh" : ("[NGUI] " + this.JKFJKMBEOHJ.name));
					if (KMCGDKDIJIE.CMFIJMQKNHO == 0)
					{
						this.KGQQLFDHQEN.MarkDynamic();
					}
					flag = true;
				}
				bool flag2;
				if (!(flag2 = (this.PICFCJNMJMC.Count != count || this.HQOONBPDFHO.Count != count || this.JBECBLJIKHI.Count != count || this.GQPDOFDBGEK.Count != count || this.JBPCENCPJKI.Count != count)) && this.BCHNDNICINJ != null && this.BCHNDNICINJ.BCKQKKMIGNM != KQHJOLQLQBJ.JMLFJLJPPDF.Automatic)
				{
					flag2 = (this.KGQQLFDHQEN == null || this.KGQQLFDHQEN.vertexCount != this.EQINHIFFOGG.Count);
				}
				if (!flag2 && count << 1 < this.EQINHIFFOGG.Count)
				{
					flag2 = true;
				}
				this.MKMHINIMINF = count >> 1;
				if (this.KGQQLFDHQEN.vertexCount != count)
				{
					this.KGQQLFDHQEN.Clear();
					flag = true;
				}
				this.KGQQLFDHQEN.SetVertices(this.EQINHIFFOGG);
				this.KGQQLFDHQEN.SetUVs(0, this.PICFCJNMJMC);
				this.KGQQLFDHQEN.SetColors(this.HQOONBPDFHO);
				this.KGQQLFDHQEN.SetUVs(1, (this.JBECBLJIKHI.Count != count) ? null : this.JBECBLJIKHI);
				this.KGQQLFDHQEN.SetNormals((this.GQPDOFDBGEK.Count != count) ? null : this.GQPDOFDBGEK);
				this.KGQQLFDHQEN.SetTangents((this.JBPCENCPJKI.Count != count) ? null : this.JBPCENCPJKI);
				if (flag)
				{
					this.PBEPEJEQEBC = this.QGPNLDHJKMB(count, num);
					this.KGQQLFDHQEN.triangles = this.PBEPEJEQEBC;
				}
				if (flag2 || !this.HKMFCLPOEEK)
				{
					this.KGQQLFDHQEN.RecalculateBounds();
				}
				this.IQFLLQGBFMI.mesh = this.KGQQLFDHQEN;
			}
			else
			{
				this.MKMHINIMINF = 0;
				if (this.KGQQLFDHQEN != null)
				{
					this.KGQQLFDHQEN.Clear();
				}
				Debug.LogError("Too many vertices on one panel: " + count);
			}
			if (this.DPBIEKGLOFP == null)
			{
				this.DPBIEKGLOFP = base.gameObject.GetComponent<MeshRenderer>();
			}
			if (this.DPBIEKGLOFP == null)
			{
				this.DPBIEKGLOFP = base.gameObject.AddComponent<MeshRenderer>();
				if (this.NOEEHMFKQIN == KMCGDKDIJIE.FDOBLOLHNHE.None)
				{
					this.DPBIEKGLOFP.shadowCastingMode = ShadowCastingMode.Off;
					this.DPBIEKGLOFP.receiveShadows = false;
				}
				else if (this.NOEEHMFKQIN == KMCGDKDIJIE.FDOBLOLHNHE.Receive)
				{
					this.DPBIEKGLOFP.shadowCastingMode = ShadowCastingMode.Off;
					this.DPBIEKGLOFP.receiveShadows = true;
				}
				else
				{
					this.DPBIEKGLOFP.shadowCastingMode = ShadowCastingMode.On;
					this.DPBIEKGLOFP.receiveShadows = true;
				}
			}
			if (this.DOGGHQIOOQQ)
			{
				this.DOGGHQIOOQQ = false;
				if (this.HLLQDCEJEPH != null)
				{
					this.HLLQDCEJEPH(this, this.IQFLLQGBFMI, this.DPBIEKGLOFP);
				}
			}
			this.DLMQCMOQICN();
		}
		else
		{
			if (this.IQFLLQGBFMI.mesh != null)
			{
				this.IQFLLQGBFMI.mesh.Clear();
			}
			Debug.LogError("UIWidgets must fill the buffer with 4 vertices per quad. Found " + count);
		}
		this.EQINHIFFOGG.Clear();
		this.PICFCJNMJMC.Clear();
		this.JBECBLJIKHI.Clear();
		this.HQOONBPDFHO.Clear();
		this.GQPDOFDBGEK.Clear();
		this.JBPCENCPJKI.Clear();
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600170D RID: 5901 RVA: 0x0000BF4D File Offset: 0x0000A14D
	// (set) Token: 0x06001700 RID: 5888 RVA: 0x0000BDC8 File Offset: 0x00009FC8
	public string HDGMMGCBBJE
	{
		get
		{
			if (!string.IsNullOrEmpty(this.MQHMLLMGMPK))
			{
				return this.MQHMLLMGMPK;
			}
			if (this.DPBIEKGLOFP == null)
			{
				return null;
			}
			this.MQHMLLMGMPK = this.DPBIEKGLOFP.sortingLayerName;
			return this.MQHMLLMGMPK;
		}
		set
		{
			if (this.DPBIEKGLOFP != null && this.MQHMLLMGMPK != value)
			{
				this.MQHMLLMGMPK = value;
				this.DPBIEKGLOFP.sortingLayerName = value;
			}
		}
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x0000BD7A File Offset: 0x00009F7A
	public int LFPCFDNJFMI()
	{
		return (!(this.GLDEQICKCGJ != null)) ? this.GPDLNOCEHPF : this.GLDEQICKCGJ.renderQueue;
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x0000BDA9 File Offset: 0x00009FA9
	public int DNDMEJCOFGH()
	{
		return this.GPDLNOCEHPF;
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06001703 RID: 5891 RVA: 0x0000BEF1 File Offset: 0x0000A0F1
	public bool QKNICDPOJFB
	{
		get
		{
			return this.OHKNJLDNPCQ != 0;
		}
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x0000BD9D File Offset: 0x00009F9D
	public static void FIQDQHHKFHE()
	{
		KMCGDKDIJIE.GDOLDMKCMEG();
		KMCGDKDIJIE.NHGEPFBPPPK();
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x000A62D4 File Offset: 0x000A44D4
	private static KMCGDKDIJIE DPKGHFIHBPE(string IHIHHCCEDHQ, KQHJOLQLQBJ MBNQPHGNDBK, Material HQNQNDECMLH, Texture NNFMFGDPCPF, Shader JHKGHDQFQNL)
	{
		KMCGDKDIJIE kmcgdkdijie = KMCGDKDIJIE.DPKGHFIHBPE(IHIHHCCEDHQ);
		kmcgdkdijie.gameObject.layer = MBNQPHGNDBK.LMOECGCMJKK.layer;
		kmcgdkdijie.HHQHIJOIBON = HQNQNDECMLH;
		kmcgdkdijie.GOIHJQNMMJD = NNFMFGDPCPF;
		kmcgdkdijie.JHKGHDQFQNL = JHKGHDQFQNL;
		kmcgdkdijie.BCKQKKMIGNM = MBNQPHGNDBK.NDQJIOMJNQE;
		kmcgdkdijie.OQCHJGMLOCJ = MBNQPHGNDBK.OQCHJGMLOCJ;
		kmcgdkdijie.NOCPDPDCFKM = MBNQPHGNDBK;
		return kmcgdkdijie;
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x000A6334 File Offset: 0x000A4534
	public static void NHGEPFBPPPK()
	{
		int i = KMCGDKDIJIE.DMKICIPCGOQ.BJGMIBBEGDQ;
		while (i > 0)
		{
			KMCGDKDIJIE kmcgdkdijie = KMCGDKDIJIE.DMKICIPCGOQ.get_KNPPMKBOGDL(--i);
			if (kmcgdkdijie)
			{
				IKBQNBHOJJB.QOLECCGGDNB(kmcgdkdijie.gameObject);
			}
		}
		KMCGDKDIJIE.DMKICIPCGOQ.CPLBKPNNHJG();
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x0000BD9D File Offset: 0x00009F9D
	public static void ECKEBCJPIHE()
	{
		KMCGDKDIJIE.GDOLDMKCMEG();
		KMCGDKDIJIE.NHGEPFBPPPK();
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06001709 RID: 5897 RVA: 0x0000BF2C File Offset: 0x0000A12C
	public Material DOLFDLNJOND
	{
		get
		{
			return this.GLDEQICKCGJ;
		}
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x000A6380 File Offset: 0x000A4580
	private static KMCGDKDIJIE DPKGHFIHBPE(string IHIHHCCEDHQ)
	{
		while (KMCGDKDIJIE.DMKICIPCGOQ.BJGMIBBEGDQ > 0)
		{
			KMCGDKDIJIE kmcgdkdijie = KMCGDKDIJIE.DMKICIPCGOQ.IPOQDLCFDFC();
			if (kmcgdkdijie != null)
			{
				KMCGDKDIJIE.BKKBIKLKLKM.LHQECHHMOGD(kmcgdkdijie);
				if (IHIHHCCEDHQ != null)
				{
					kmcgdkdijie.name = IHIHHCCEDHQ;
				}
				IKBQNBHOJJB.IFPIGKGKFEQ(kmcgdkdijie.gameObject, true);
				return kmcgdkdijie;
			}
		}
		GameObject gameObject = new GameObject(IHIHHCCEDHQ);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		KMCGDKDIJIE kmcgdkdijie2 = gameObject.AddComponent<KMCGDKDIJIE>();
		KMCGDKDIJIE.BKKBIKLKLKM.LHQECHHMOGD(kmcgdkdijie2);
		return kmcgdkdijie2;
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x0600170B RID: 5899 RVA: 0x0000BF34 File Offset: 0x0000A134
	public int PGJGMPHKOGJ
	{
		get
		{
			return (!(this.KGQQLFDHQEN != null)) ? 0 : this.MKMHINIMINF;
		}
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x000A6478 File Offset: 0x000A4678
	private void OnWillRenderObject()
	{
		this.DLMQCMOQICN();
		if (this.MBHJEBPQHEF != null)
		{
			this.DPBIEKGLOFP.SetPropertyBlock(this.MBHJEBPQHEF);
		}
		if (this.IOOHNELQHIO != null)
		{
			this.IOOHNELQHIO(this.GLDEQICKCGJ ?? this.JKFJKMBEOHJ);
		}
		if (!(this.GLDEQICKCGJ == null) && this.OHKNJLDNPCQ != 0)
		{
			if (this.QGJDDCCKJCI)
			{
				Vector4 dpjglgeeoim = this.BCHNDNICINJ.DPJGLGEEOIM;
				Vector2 phlkebhkgee = this.BCHNDNICINJ.PHLKEBHKGEE;
				Vector2 vector = new Vector2(1000f, 1000f);
				if (phlkebhkgee.x > 0f)
				{
					vector.x = dpjglgeeoim.z / phlkebhkgee.x;
				}
				if (phlkebhkgee.y > 0f)
				{
					vector.y = dpjglgeeoim.w / phlkebhkgee.y;
				}
				this.GLDEQICKCGJ.SetVector(KMCGDKDIJIE.FDKBIKIEKOO[0], new Vector4(-dpjglgeeoim.x / dpjglgeeoim.z, -dpjglgeeoim.y / dpjglgeeoim.w, 1f / dpjglgeeoim.z, 1f / dpjglgeeoim.w));
				this.GLDEQICKCGJ.SetTexture("_ClipTex", this.MHFDHQHMQQC);
			}
			else if (!this.MFNKQJGBFQP)
			{
				KQHJOLQLQBJ kqhjolqlqbj = this.BCHNDNICINJ;
				int num = 0;
				while (kqhjolqlqbj != null)
				{
					if (kqhjolqlqbj.BDFKBGCMLHC)
					{
						float mpnnmhjbopn = 0f;
						Vector4 dpjglgeeoim2 = kqhjolqlqbj.DPJGLGEEOIM;
						if (kqhjolqlqbj != this.BCHNDNICINJ)
						{
							Vector3 vector2 = kqhjolqlqbj.CGDFDPHIENG.InverseTransformPoint(this.BCHNDNICINJ.CGDFDPHIENG.position);
							dpjglgeeoim2.x -= vector2.x;
							dpjglgeeoim2.y -= vector2.y;
							Vector3 eulerAngles = this.BCHNDNICINJ.CGDFDPHIENG.rotation.eulerAngles;
							Vector3 eulerAngles2 = kqhjolqlqbj.CGDFDPHIENG.rotation.eulerAngles;
							Vector3 vector3 = eulerAngles2 - eulerAngles;
							vector3.x = JNNGOIIKENH.MCKGBIELBHK(vector3.x);
							vector3.y = JNNGOIIKENH.MCKGBIELBHK(vector3.y);
							vector3.z = JNNGOIIKENH.MCKGBIELBHK(vector3.z);
							if (Mathf.Abs(vector3.x) > 0.001f || Mathf.Abs(vector3.y) > 0.001f)
							{
								Debug.LogWarning("Panel can only be clipped properly if X and Y rotation is left at 0", this.BCHNDNICINJ);
							}
							mpnnmhjbopn = vector3.z;
						}
						this.JEDBOKHFCFP(num++, dpjglgeeoim2, kqhjolqlqbj.PHLKEBHKGEE, mpnnmhjbopn);
					}
					kqhjolqlqbj = kqhjolqlqbj.IEPOOINFQBL;
				}
			}
			else
			{
				Vector2 phlkebhkgee2 = this.BCHNDNICINJ.PHLKEBHKGEE;
				Vector4 dpjglgeeoim3 = this.BCHNDNICINJ.DPJGLGEEOIM;
				Vector2 mainTextureOffset = new Vector2(-dpjglgeeoim3.x / dpjglgeeoim3.z, -dpjglgeeoim3.y / dpjglgeeoim3.w);
				Vector2 mainTextureScale = new Vector2(1f / dpjglgeeoim3.z, 1f / dpjglgeeoim3.w);
				Vector2 v = new Vector2(1000f, 1000f);
				if (phlkebhkgee2.x > 0f)
				{
					v.x = dpjglgeeoim3.z / phlkebhkgee2.x;
				}
				if (phlkebhkgee2.y > 0f)
				{
					v.y = dpjglgeeoim3.w / phlkebhkgee2.y;
				}
				this.GLDEQICKCGJ.mainTextureOffset = mainTextureOffset;
				this.GLDEQICKCGJ.mainTextureScale = mainTextureScale;
				this.GLDEQICKCGJ.SetVector("_ClipSharpness", v);
			}
			return;
		}
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x000A6828 File Offset: 0x000A4A28
	private void Awake()
	{
		if (KMCGDKDIJIE.CMFIJMQKNHO == -1)
		{
			RuntimePlatform platform = Application.platform;
			KMCGDKDIJIE.CMFIJMQKNHO = ((platform != RuntimePlatform.WindowsPlayer || SystemInfo.graphicsShaderLevel >= 40 || !SystemInfo.graphicsDeviceVersion.Contains("Direct3D")) ? 0 : 1);
		}
		if (KMCGDKDIJIE.FDKBIKIEKOO == null)
		{
			KMCGDKDIJIE.FDKBIKIEKOO = new int[]
			{
				Shader.PropertyToID("_ClipRange0"),
				Shader.PropertyToID("_ClipRange1"),
				Shader.PropertyToID("_ClipRange2"),
				Shader.PropertyToID("_ClipRange4")
			};
		}
		if (KMCGDKDIJIE.CKKLFLPKMJE == null)
		{
			KMCGDKDIJIE.CKKLFLPKMJE = new int[]
			{
				Shader.PropertyToID("_ClipArgs0"),
				Shader.PropertyToID("_ClipArgs1"),
				Shader.PropertyToID("_ClipArgs2"),
				Shader.PropertyToID("_ClipArgs3")
			};
		}
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x000A6980 File Offset: 0x000A4B80
	private void OnDisable()
	{
		this.DEMPENNGPQL = int.MaxValue;
		this.EGLMNMJMLKQ = int.MinValue;
		this.BCHNDNICINJ = null;
		this.NOCPDPDCFKM = null;
		this.JKFJKMBEOHJ = null;
		this.KCENPPMLLCK = null;
		this.MHFDHQHMQQC = null;
		if (this.DPBIEKGLOFP != null)
		{
			this.DPBIEKGLOFP.sharedMaterials = new Material[0];
		}
		IKBQNBHOJJB.QOLECCGGDNB(this.GLDEQICKCGJ);
		this.GLDEQICKCGJ = null;
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x0000BF8A File Offset: 0x0000A18A
	private void OnDestroy()
	{
		IKBQNBHOJJB.QOLECCGGDNB(this.KGQQLFDHQEN);
		this.KGQQLFDHQEN = null;
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x000A69F8 File Offset: 0x000A4BF8
	private void DQNGCOKGMKE()
	{
		this.QGJDDCCKJCI = false;
		this.MFNKQJGBFQP = false;
		this.OHKNJLDNPCQ = this.BCHNDNICINJ.PNOEILCQBKB;
		string text = (!(this.EQLCFHLLDLB != null)) ? ((!(this.JKFJKMBEOHJ != null)) ? "Unlit/Transparent Colored" : this.JKFJKMBEOHJ.shader.name) : this.EQLCFHLLDLB.name;
		text = text.Replace("GUI/Text Shader", "Unlit/Text");
		if (text.Length > 2 && text[text.Length - 2] == ' ')
		{
			int num = (int)text[text.Length - 1];
			if (num > 48 && num <= 57)
			{
				text = text.Substring(0, text.Length - 2);
			}
		}
		if (text.StartsWith("Hidden/"))
		{
			text = text.Substring(7);
		}
		text = text.Replace(" (SoftClip)", string.Empty);
		text = text.Replace(" (TextureClip)", string.Empty);
		if (this.BCHNDNICINJ != null && this.BCHNDNICINJ.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask)
		{
			this.QGJDDCCKJCI = true;
			this.JHKGHDQFQNL = Shader.Find("Hidden/" + text + " (TextureClip)");
		}
		else if (this.OHKNJLDNPCQ != 0)
		{
			this.JHKGHDQFQNL = Shader.Find(string.Concat(new object[]
			{
				"Hidden/",
				text,
				" ",
				this.OHKNJLDNPCQ
			}));
			if (this.JHKGHDQFQNL == null)
			{
				this.JHKGHDQFQNL = Shader.Find(text + " " + this.OHKNJLDNPCQ);
			}
			if (this.JHKGHDQFQNL == null && this.OHKNJLDNPCQ == 1)
			{
				this.MFNKQJGBFQP = true;
				this.JHKGHDQFQNL = Shader.Find(text + " (SoftClip)");
			}
		}
		else
		{
			this.JHKGHDQFQNL = Shader.Find(text);
		}
		if (this.JHKGHDQFQNL == null)
		{
			this.JHKGHDQFQNL = Shader.Find("Unlit/Transparent Colored");
		}
		if (this.JKFJKMBEOHJ != null)
		{
			this.GLDEQICKCGJ = new Material(this.JKFJKMBEOHJ);
			this.GLDEQICKCGJ.name = "[NGUI] " + this.JKFJKMBEOHJ.name;
			this.GLDEQICKCGJ.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.GLDEQICKCGJ.CopyPropertiesFromMaterial(this.JKFJKMBEOHJ);
			string[] shaderKeywords = this.JKFJKMBEOHJ.shaderKeywords;
			for (int i = 0; i < shaderKeywords.Length; i++)
			{
				this.GLDEQICKCGJ.EnableKeyword(shaderKeywords[i]);
			}
			if (this.JHKGHDQFQNL != null)
			{
				this.GLDEQICKCGJ.shader = this.JHKGHDQFQNL;
			}
			else if (this.OHKNJLDNPCQ != 0)
			{
				Debug.LogError(string.Concat(new object[]
				{
					text,
					" shader doesn't have a clipped shader version for ",
					this.OHKNJLDNPCQ,
					" clip regions"
				}));
			}
		}
		else
		{
			this.GLDEQICKCGJ = new Material(this.JHKGHDQFQNL);
			this.GLDEQICKCGJ.name = "[NGUI] " + this.JHKGHDQFQNL.name;
			this.GLDEQICKCGJ.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06001714 RID: 5908 RVA: 0x0000BDBA File Offset: 0x00009FBA
	public static MHIDKMCBQEN<KMCGDKDIJIE> PPDCFJJQBMD
	{
		get
		{
			return KMCGDKDIJIE.BKKBIKLKLKM;
		}
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x0000BDC1 File Offset: 0x00009FC1
	public static MHIDKMCBQEN<KMCGDKDIJIE> KMOINGLMPCE()
	{
		return KMCGDKDIJIE.DMKICIPCGOQ;
	}

	// Token: 0x0400045D RID: 1117
	private static MHIDKMCBQEN<KMCGDKDIJIE> BKKBIKLKLKM = new MHIDKMCBQEN<KMCGDKDIJIE>();

	// Token: 0x0400045E RID: 1118
	private static MHIDKMCBQEN<KMCGDKDIJIE> DMKICIPCGOQ = new MHIDKMCBQEN<KMCGDKDIJIE>();

	// Token: 0x0400045F RID: 1119
	[HideInInspector]
	[NonSerialized]
	public int QBPMLOJLHML;

	// Token: 0x04000460 RID: 1120
	[HideInInspector]
	[NonSerialized]
	public int DEMPENNGPQL = int.MaxValue;

	// Token: 0x04000461 RID: 1121
	[HideInInspector]
	[NonSerialized]
	public int EGLMNMJMLKQ = int.MinValue;

	// Token: 0x04000462 RID: 1122
	[HideInInspector]
	[NonSerialized]
	public KQHJOLQLQBJ NOCPDPDCFKM;

	// Token: 0x04000463 RID: 1123
	[HideInInspector]
	[NonSerialized]
	public KQHJOLQLQBJ BCHNDNICINJ;

	// Token: 0x04000464 RID: 1124
	[HideInInspector]
	[NonSerialized]
	public Texture2D MHFDHQHMQQC;

	// Token: 0x04000465 RID: 1125
	[HideInInspector]
	[NonSerialized]
	public bool HKMFCLPOEEK;

	// Token: 0x04000466 RID: 1126
	[HideInInspector]
	[NonSerialized]
	public List<Vector3> EQINHIFFOGG = new List<Vector3>();

	// Token: 0x04000467 RID: 1127
	[HideInInspector]
	[NonSerialized]
	public List<Vector3> GQPDOFDBGEK = new List<Vector3>();

	// Token: 0x04000468 RID: 1128
	[HideInInspector]
	[NonSerialized]
	public List<Vector4> JBPCENCPJKI = new List<Vector4>();

	// Token: 0x04000469 RID: 1129
	[HideInInspector]
	[NonSerialized]
	public List<Vector2> PICFCJNMJMC = new List<Vector2>();

	// Token: 0x0400046A RID: 1130
	[HideInInspector]
	[NonSerialized]
	public List<Vector4> JBECBLJIKHI = new List<Vector4>();

	// Token: 0x0400046B RID: 1131
	[HideInInspector]
	[NonSerialized]
	public List<Color> HQOONBPDFHO = new List<Color>();

	// Token: 0x0400046C RID: 1132
	[NonSerialized]
	private Material JKFJKMBEOHJ;

	// Token: 0x0400046D RID: 1133
	[NonSerialized]
	private Texture KCENPPMLLCK;

	// Token: 0x0400046E RID: 1134
	[NonSerialized]
	private Shader EQLCFHLLDLB;

	// Token: 0x0400046F RID: 1135
	[NonSerialized]
	private int OHKNJLDNPCQ;

	// Token: 0x04000470 RID: 1136
	[NonSerialized]
	private Transform BLLEFKOLKLP;

	// Token: 0x04000471 RID: 1137
	[NonSerialized]
	private Mesh KGQQLFDHQEN;

	// Token: 0x04000472 RID: 1138
	[NonSerialized]
	private MeshFilter IQFLLQGBFMI;

	// Token: 0x04000473 RID: 1139
	[NonSerialized]
	private MeshRenderer DPBIEKGLOFP;

	// Token: 0x04000474 RID: 1140
	[NonSerialized]
	private Material GLDEQICKCGJ;

	// Token: 0x04000475 RID: 1141
	[NonSerialized]
	private int[] PBEPEJEQEBC;

	// Token: 0x04000476 RID: 1142
	[NonSerialized]
	private KMCGDKDIJIE.FDOBLOLHNHE NOEEHMFKQIN;

	// Token: 0x04000477 RID: 1143
	[NonSerialized]
	private bool MOBMGGDFGFO = true;

	// Token: 0x04000478 RID: 1144
	[NonSerialized]
	private bool MFNKQJGBFQP;

	// Token: 0x04000479 RID: 1145
	[NonSerialized]
	private int GPDLNOCEHPF = 3000;

	// Token: 0x0400047A RID: 1146
	[NonSerialized]
	private int MKMHINIMINF;

	// Token: 0x0400047B RID: 1147
	[NonSerialized]
	public bool HHDFDNFPDFJ;

	// Token: 0x0400047C RID: 1148
	[NonSerialized]
	private bool QGJDDCCKJCI;

	// Token: 0x0400047D RID: 1149
	[NonSerialized]
	private bool DOGGHQIOOQQ = true;

	// Token: 0x0400047E RID: 1150
	public KMCGDKDIJIE.MQQMDCIDPIL IOOHNELQHIO;

	// Token: 0x0400047F RID: 1151
	public KMCGDKDIJIE.QIMNIEECJIE HLLQDCEJEPH;

	// Token: 0x04000480 RID: 1152
	[NonSerialized]
	private string MQHMLLMGMPK;

	// Token: 0x04000481 RID: 1153
	[NonSerialized]
	private int EKHDEEEGKDO;

	// Token: 0x04000482 RID: 1154
	private static ColorSpace HILLHGIEBFE = ColorSpace.Uninitialized;

	// Token: 0x04000483 RID: 1155
	private const int LOHONHFHGOG = 10;

	// Token: 0x04000484 RID: 1156
	private static List<int[]> EDDIMMFNGEM = new List<int[]>(10);

	// Token: 0x04000485 RID: 1157
	protected MaterialPropertyBlock MBHJEBPQHEF;

	// Token: 0x04000486 RID: 1158
	private static int[] FDKBIKIEKOO = null;

	// Token: 0x04000487 RID: 1159
	private static int[] CKKLFLPKMJE = null;

	// Token: 0x04000488 RID: 1160
	private static int CMFIJMQKNHO = -1;

	// Token: 0x020000B7 RID: 183
	public enum PDFPPCIHPMI
	{
		// Token: 0x0400048A RID: 1162
		None,
		// Token: 0x0400048B RID: 1163
		TextureMask,
		// Token: 0x0400048C RID: 1164
		SoftClip = 3,
		// Token: 0x0400048D RID: 1165
		ConstrainButDontClip
	}

	// Token: 0x020000B8 RID: 184
	// (Invoke) Token: 0x06001717 RID: 5911
	public delegate void MQQMDCIDPIL(Material HQNQNDECMLH);

	// Token: 0x020000B9 RID: 185
	// (Invoke) Token: 0x0600171B RID: 5915
	public delegate void QIMNIEECJIE(KMCGDKDIJIE OBDLPFGDEFJ, MeshFilter NEGLEKQIEQH, MeshRenderer GFFHMNBCGLQ);

	// Token: 0x020000BA RID: 186
	public enum FDOBLOLHNHE
	{
		// Token: 0x0400048F RID: 1167
		None,
		// Token: 0x04000490 RID: 1168
		Receive,
		// Token: 0x04000491 RID: 1169
		CastAndReceive
	}
}
