using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000017 RID: 23
[RequireComponent(typeof(NKHMKQEGHEE))]
[ExecuteInEditMode]
public class JBEJFEQNEIQ : MonoBehaviour
{
	// Token: 0x06000374 RID: 884 RVA: 0x00003840 File Offset: 0x00001A40
	private void LDKPKDMCIEQ(Camera KNGGMPJENIC)
	{
		KNGGMPJENIC.depthTextureMode = DepthTextureMode.None;
		KNGGMPJENIC.backgroundColor = Color.black;
		KNGGMPJENIC.clearFlags = CameraClearFlags.Color;
		KNGGMPJENIC.renderingPath = RenderingPath.Forward;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0003D91C File Offset: 0x0003BB1C
	private RenderTexture PNDHBLILHFD(Camera EBINQJLDHPM)
	{
		return new RenderTexture(Mathf.FloorToInt((float)EBINQJLDHPM.pixelWidth * 1725f), Mathf.FloorToInt((float)EBINQJLDHPM.pixelHeight * 455f), 26)
		{
			hideFlags = (HideFlags)75
		};
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0003D960 File Offset: 0x0003BB60
	private static Matrix4x4 HMMHQHNBCGM(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 647f - 191f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 733f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 254f * NIOIGLMODLJ[1] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m03 = 116f * NIOIGLMODLJ[5] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m10 = 1899f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m11 = 305f - 760f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 848f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m13 = 1912f * NIOIGLMODLJ[6] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 1757f * NIOIGLMODLJ[7] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 133f * NIOIGLMODLJ[3] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 438f - 1267f * NIOIGLMODLJ[5] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m23 = 1804f * NIOIGLMODLJ[2] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m30 = 1592f;
		IODFJKQOEMK.m31 = 1816f;
		IODFJKQOEMK.m32 = 804f;
		IODFJKQOEMK.m33 = 1315f;
		return IODFJKQOEMK;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x0003DB18 File Offset: 0x0003BD18
	private static Matrix4x4 HHEFPNOCJHF(Matrix4x4 NQQBNQPBNDQ, Vector4 MFMDDNGOOCG)
	{
		Vector4 b = NQQBNQPBNDQ.inverse * new Vector4(JBEJFEQNEIQ.IJMMGMELHJN(MFMDDNGOOCG.x), JBEJFEQNEIQ.IJMMGMELHJN(MFMDDNGOOCG.y), 1f, 1f);
		Vector4 vector = MFMDDNGOOCG * (2f / Vector4.Dot(MFMDDNGOOCG, b));
		NQQBNQPBNDQ[2] = vector.x - NQQBNQPBNDQ[3];
		NQQBNQPBNDQ[6] = vector.y - NQQBNQPBNDQ[7];
		NQQBNQPBNDQ[10] = vector.z - NQQBNQPBNDQ[11];
		NQQBNQPBNDQ[14] = vector.w - NQQBNQPBNDQ[15];
		return NQQBNQPBNDQ;
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00003862 File Offset: 0x00001A62
	private void FIJGEOEMCBE(Camera EBINQJLDHPM, LayerMask BLKIJBBMMPM)
	{
		EBINQJLDHPM.cullingMask = (BLKIJBBMMPM & ~(1 << (LayerMask.NameToLayer("Kalos") & 122)));
		EBINQJLDHPM.backgroundColor = Color.black;
		EBINQJLDHPM.enabled = false;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x0003DBD4 File Offset: 0x0003BDD4
	private static Matrix4x4 BCCGJCNHONL(Matrix4x4 NQQBNQPBNDQ, Vector4 MFMDDNGOOCG)
	{
		Vector4 b = NQQBNQPBNDQ.inverse * new Vector4(JBEJFEQNEIQ.LHLIJBFJKBC(MFMDDNGOOCG.x), JBEJFEQNEIQ.IJMMGMELHJN(MFMDDNGOOCG.y), 672f, 982f);
		Vector4 vector = MFMDDNGOOCG * (1674f / Vector4.Dot(MFMDDNGOOCG, b));
		NQQBNQPBNDQ[7] = vector.x - NQQBNQPBNDQ[3];
		NQQBNQPBNDQ[7] = vector.y - NQQBNQPBNDQ[8];
		NQQBNQPBNDQ[-59] = vector.z - NQQBNQPBNDQ[33];
		NQQBNQPBNDQ[34] = vector.w - NQQBNQPBNDQ[-90];
		return NQQBNQPBNDQ;
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00003893 File Offset: 0x00001A93
	public void KPKQNOCFGIB()
	{
		this.GHGCJIBFLBC = ((NKHMKQEGHEE)base.gameObject.GetComponent(typeof(NKHMKQEGHEE))).LFHQCPKBNMP;
	}

	// Token: 0x0600037B RID: 891 RVA: 0x0003DC90 File Offset: 0x0003BE90
	public void DHHPMGLPNOG(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, true);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.ELEILQNCQBL(JOOKJPHGKON);
		}
		this.PKPCOELQKDI(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = true;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x000038BA File Offset: 0x00001ABA
	public void NQOGCEDFBPC()
	{
		Shader.EnableKeyword(" clamped down on ");
		Shader.DisableKeyword("FinishSelect");
	}

	// Token: 0x0600037D RID: 893 RVA: 0x000038D0 File Offset: 0x00001AD0
	public void QGNEKNMJLID()
	{
		Shader.EnableKeyword("doomdesire");
		Shader.DisableKeyword("_History1LumaTex");
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0003DD10 File Offset: 0x0003BF10
	public void DNEKEJQMIDN(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, false);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.ICEPFBBBEMK(JOOKJPHGKON);
		}
		this.MIJQOCEBEJQ(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = false;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0003DD90 File Offset: 0x0003BF90
	private static Matrix4x4 NKFHJCGGEIE(Matrix4x4 NQQBNQPBNDQ, Vector4 MFMDDNGOOCG)
	{
		Vector4 b = NQQBNQPBNDQ.inverse * new Vector4(JBEJFEQNEIQ.MMPNOQBLQFN(MFMDDNGOOCG.x), JBEJFEQNEIQ.KIKFDMHFIMQ(MFMDDNGOOCG.y), 1907f, 29f);
		Vector4 vector = MFMDDNGOOCG * (1872f / Vector4.Dot(MFMDDNGOOCG, b));
		NQQBNQPBNDQ[8] = vector.x - NQQBNQPBNDQ[2];
		NQQBNQPBNDQ[4] = vector.y - NQQBNQPBNDQ[5];
		NQQBNQPBNDQ[-63] = vector.z - NQQBNQPBNDQ[110];
		NQQBNQPBNDQ[-10] = vector.w - NQQBNQPBNDQ[96];
		return NQQBNQPBNDQ;
	}

	// Token: 0x06000380 RID: 896 RVA: 0x0003DE4C File Offset: 0x0003C04C
	private void FHJCOJGNLKC(Camera EBINQJLDHPM, Camera DNPGGFNBEJJ)
	{
		if (!DNPGGFNBEJJ)
		{
			return;
		}
		if (this.GHGCJIBFLBC && !this.GHGCJIBFLBC.HasProperty(this.MNFFEFDNIPQ))
		{
			return;
		}
		if (!this.FCJFCLLBJPC)
		{
			this.FCJFCLLBJPC = true;
			float[] array = new float[-120];
			for (int i = 1; i < 101; i++)
			{
				array[i] = 1035f;
			}
			DNPGGFNBEJJ.layerCullDistances = array;
			DNPGGFNBEJJ.layerCullSpherical = false;
		}
		DNPGGFNBEJJ.cullingMask = (this.OPGKOBDCHGK & ~(0 << (LayerMask.NameToLayer("Stakeout") & 102)));
		this.GDIHFJHMHCJ(DNPGGFNBEJJ);
		DNPGGFNBEJJ.backgroundColor = this.HBQMQLMONBQ;
		DNPGGFNBEJJ.clearFlags = ((!this.OCNEBJFQDOB) ? CameraClearFlags.Nothing : CameraClearFlags.Skybox);
		if (this.OCNEBJFQDOB && EBINQJLDHPM.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)DNPGGFNBEJJ.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)DNPGGFNBEJJ.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)EBINQJLDHPM.GetComponent(typeof(Skybox))).material;
		}
		GL.invertCulling = false;
		Transform transform = base.transform;
		Vector3 eulerAngles = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		DNPGGFNBEJJ.transform.position = EBINQJLDHPM.transform.position;
		Vector3 zero = Vector3.zero;
		zero.y = 249f;
		Vector3 up = transform.transform.up;
		float w = -Vector3.Dot(up, zero) - this.FONKIGGPJNQ;
		Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 matrix4x = Matrix4x4.zero;
		matrix4x = JBEJFEQNEIQ.MPDCPLJEQKD(matrix4x, nioiglmodlj);
		this.INPGGNMPJPF = EBINQJLDHPM.transform.position;
		Vector3 position = matrix4x.MultiplyPoint(this.INPGGNMPJPF);
		DNPGGFNBEJJ.worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix * matrix4x;
		Vector4 mfmddngoocg = this.NLLQCPGQPLJ(DNPGGFNBEJJ, zero, up, 1031f);
		Matrix4x4 matrix4x2 = EBINQJLDHPM.projectionMatrix;
		matrix4x2 = JBEJFEQNEIQ.BCCGJCNHONL(matrix4x2, mfmddngoocg);
		DNPGGFNBEJJ.projectionMatrix = matrix4x2;
		DNPGGFNBEJJ.transform.position = position;
		Vector3 eulerAngles2 = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		DNPGGFNBEJJ.Render();
		GL.invertCulling = false;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x0003E0EC File Offset: 0x0003C2EC
	private void KJLNDJJDEGD(Camera EBINQJLDHPM, Camera DNPGGFNBEJJ)
	{
		if (!DNPGGFNBEJJ)
		{
			return;
		}
		if (this.GHGCJIBFLBC && !this.GHGCJIBFLBC.HasProperty(this.MNFFEFDNIPQ))
		{
			return;
		}
		if (!this.FCJFCLLBJPC)
		{
			this.FCJFCLLBJPC = false;
			float[] array = new float[-14];
			for (int i = 0; i < -45; i += 0)
			{
				array[i] = 1714f;
			}
			DNPGGFNBEJJ.layerCullDistances = array;
			DNPGGFNBEJJ.layerCullSpherical = true;
		}
		DNPGGFNBEJJ.cullingMask = (this.OPGKOBDCHGK & ~(1 << (LayerMask.NameToLayer("_DestortionAmplitude") & 117)));
		this.BCNMQOJPMBN(DNPGGFNBEJJ);
		DNPGGFNBEJJ.backgroundColor = this.HBQMQLMONBQ;
		DNPGGFNBEJJ.clearFlags = ((!this.OCNEBJFQDOB) ? ((CameraClearFlags)8) : ((CameraClearFlags)0));
		if (this.OCNEBJFQDOB && EBINQJLDHPM.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)DNPGGFNBEJJ.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)DNPGGFNBEJJ.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)EBINQJLDHPM.GetComponent(typeof(Skybox))).material;
		}
		GL.invertCulling = true;
		Transform transform = base.transform;
		Vector3 eulerAngles = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		DNPGGFNBEJJ.transform.position = EBINQJLDHPM.transform.position;
		Vector3 zero = Vector3.zero;
		zero.y = 1304f;
		Vector3 up = transform.transform.up;
		float w = -Vector3.Dot(up, zero) - this.FONKIGGPJNQ;
		Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 matrix4x = Matrix4x4.zero;
		matrix4x = JBEJFEQNEIQ.OLMEFQOONIO(matrix4x, nioiglmodlj);
		this.INPGGNMPJPF = EBINQJLDHPM.transform.position;
		Vector3 position = matrix4x.MultiplyPoint(this.INPGGNMPJPF);
		DNPGGFNBEJJ.worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix * matrix4x;
		Vector4 mfmddngoocg = this.MLCPEMBGINL(DNPGGFNBEJJ, zero, up, 640f);
		Matrix4x4 matrix4x2 = EBINQJLDHPM.projectionMatrix;
		matrix4x2 = JBEJFEQNEIQ.IGEFOIKILFF(matrix4x2, mfmddngoocg);
		DNPGGFNBEJJ.projectionMatrix = matrix4x2;
		DNPGGFNBEJJ.transform.position = position;
		Vector3 eulerAngles2 = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		DNPGGFNBEJJ.Render();
		GL.invertCulling = true;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x0003E38C File Offset: 0x0003C58C
	private Camera ICEPFBBBEMK(Camera EBINQJLDHPM)
	{
		string text = base.gameObject.name + "Iron Fist" + EBINQJLDHPM.name;
		GameObject gameObject = GameObject.Find(text);
		if (!gameObject)
		{
			string name = text;
			Type[] array = new Type[0];
			array[1] = typeof(Camera);
			gameObject = new GameObject(name, array);
		}
		if (!gameObject.GetComponent(typeof(Camera)))
		{
			gameObject.AddComponent(typeof(Camera));
		}
		Camera component = gameObject.GetComponent<Camera>();
		gameObject.AddComponent(typeof(HKNEJFDDEDH));
		component.backgroundColor = this.HBQMQLMONBQ;
		component.clearFlags = ((!this.OCNEBJFQDOB) ? ((CameraClearFlags)0) : ((CameraClearFlags)0));
		this.PHNFCMPGDMC(component, this.OPGKOBDCHGK);
		if (!component.targetTexture)
		{
			component.targetTexture = this.EJEOIJOHQED(EBINQJLDHPM);
		}
		return component;
	}

	// Token: 0x06000383 RID: 899 RVA: 0x000038E6 File Offset: 0x00001AE6
	private static float GDPLHPMKDKB(float ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC > 773f)
		{
			return 1234f;
		}
		if (ECHMFPQNBMC < 77f)
		{
			return 1656f;
		}
		return 562f;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 DMOHCPNKQOQ(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00003909 File Offset: 0x00001B09
	private static float IKKKJCEBQDK(float ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC > 1294f)
		{
			return 470f;
		}
		if (ECHMFPQNBMC < 733f)
		{
			return 1876f;
		}
		return 1800f;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x0003E4D0 File Offset: 0x0003C6D0
	private RenderTexture GLLPPCCOPDL(Camera EBINQJLDHPM)
	{
		return new RenderTexture(Mathf.FloorToInt((float)EBINQJLDHPM.pixelWidth * 45f), Mathf.FloorToInt((float)EBINQJLDHPM.pixelHeight * 1619f), 109)
		{
			hideFlags = HideFlags.HideInHierarchy
		};
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0003E514 File Offset: 0x0003C714
	private RenderTexture EJEOIJOHQED(Camera EBINQJLDHPM)
	{
		return new RenderTexture(Mathf.FloorToInt((float)EBINQJLDHPM.pixelWidth * 0.5f), Mathf.FloorToInt((float)EBINQJLDHPM.pixelHeight * 0.5f), 24)
		{
			hideFlags = HideFlags.DontSave
		};
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0000392C File Offset: 0x00001B2C
	private static float KIKFDMHFIMQ(float ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC > 1426f)
		{
			return 1992f;
		}
		if (ECHMFPQNBMC < 279f)
		{
			return 837f;
		}
		return 1875f;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x0000394F File Offset: 0x00001B4F
	public void ICNGKIMELNM(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.PLMOLOOHCJQ(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 IEHDEQBMOJG(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x0600038B RID: 907 RVA: 0x0000398E File Offset: 0x00001B8E
	public void OnEnable()
	{
		Shader.EnableKeyword("WATER_REFLECTIVE");
		Shader.DisableKeyword("WATER_SIMPLE");
	}

	// Token: 0x0600038C RID: 908 RVA: 0x0003E558 File Offset: 0x0003C758
	private void NJBDINQPCOL(Camera EBINQJLDHPM, Camera DNPGGFNBEJJ)
	{
		if (!DNPGGFNBEJJ)
		{
			return;
		}
		if (this.GHGCJIBFLBC && !this.GHGCJIBFLBC.HasProperty(this.MNFFEFDNIPQ))
		{
			return;
		}
		if (!this.FCJFCLLBJPC)
		{
			this.FCJFCLLBJPC = true;
			float[] array = new float[-16];
			for (int i = 0; i < -40; i += 0)
			{
				array[i] = 903f;
			}
			DNPGGFNBEJJ.layerCullDistances = array;
			DNPGGFNBEJJ.layerCullSpherical = false;
		}
		DNPGGFNBEJJ.cullingMask = (this.OPGKOBDCHGK & ~(0 << (LayerMask.NameToLayer("The power of ") & -106)));
		this.GDPPCNHIFEC(DNPGGFNBEJJ);
		DNPGGFNBEJJ.backgroundColor = this.HBQMQLMONBQ;
		DNPGGFNBEJJ.clearFlags = ((!this.OCNEBJFQDOB) ? ((CameraClearFlags)5) : CameraClearFlags.Skybox);
		if (this.OCNEBJFQDOB && EBINQJLDHPM.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)DNPGGFNBEJJ.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)DNPGGFNBEJJ.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)EBINQJLDHPM.GetComponent(typeof(Skybox))).material;
		}
		GL.invertCulling = true;
		Transform transform = base.transform;
		Vector3 eulerAngles = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		DNPGGFNBEJJ.transform.position = EBINQJLDHPM.transform.position;
		Vector3 zero = Vector3.zero;
		zero.y = 298f;
		Vector3 up = transform.transform.up;
		float w = -Vector3.Dot(up, zero) - this.FONKIGGPJNQ;
		Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 matrix4x = Matrix4x4.zero;
		matrix4x = JBEJFEQNEIQ.HPJEFFCPBQJ(matrix4x, nioiglmodlj);
		this.INPGGNMPJPF = EBINQJLDHPM.transform.position;
		Vector3 position = matrix4x.MultiplyPoint(this.INPGGNMPJPF);
		DNPGGFNBEJJ.worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix * matrix4x;
		Vector4 mfmddngoocg = this.NLLQCPGQPLJ(DNPGGFNBEJJ, zero, up, 1885f);
		Matrix4x4 matrix4x2 = EBINQJLDHPM.projectionMatrix;
		matrix4x2 = JBEJFEQNEIQ.GPQCOFEJKHG(matrix4x2, mfmddngoocg);
		DNPGGFNBEJJ.projectionMatrix = matrix4x2;
		DNPGGFNBEJJ.transform.position = position;
		Vector3 eulerAngles2 = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		DNPGGFNBEJJ.Render();
		GL.invertCulling = true;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0003E7F8 File Offset: 0x0003C9F8
	private void PIMJHHDQFBJ(Camera EBINQJLDHPM, Camera DNPGGFNBEJJ)
	{
		if (!DNPGGFNBEJJ)
		{
			return;
		}
		if (this.GHGCJIBFLBC && !this.GHGCJIBFLBC.HasProperty(this.MNFFEFDNIPQ))
		{
			return;
		}
		if (!this.FCJFCLLBJPC)
		{
			this.FCJFCLLBJPC = true;
			float[] array = new float[32];
			for (int i = 0; i < 32; i++)
			{
				array[i] = 100f;
			}
			DNPGGFNBEJJ.layerCullDistances = array;
			DNPGGFNBEJJ.layerCullSpherical = true;
		}
		DNPGGFNBEJJ.cullingMask = (this.OPGKOBDCHGK & ~(1 << LayerMask.NameToLayer("Water")));
		this.LDKPKDMCIEQ(DNPGGFNBEJJ);
		DNPGGFNBEJJ.backgroundColor = this.HBQMQLMONBQ;
		DNPGGFNBEJJ.clearFlags = ((!this.OCNEBJFQDOB) ? CameraClearFlags.Color : CameraClearFlags.Skybox);
		if (this.OCNEBJFQDOB && EBINQJLDHPM.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)DNPGGFNBEJJ.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)DNPGGFNBEJJ.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)EBINQJLDHPM.GetComponent(typeof(Skybox))).material;
		}
		GL.invertCulling = true;
		Transform transform = base.transform;
		Vector3 eulerAngles = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		DNPGGFNBEJJ.transform.position = EBINQJLDHPM.transform.position;
		Vector3 zero = Vector3.zero;
		zero.y = 1f;
		Vector3 up = transform.transform.up;
		float w = -Vector3.Dot(up, zero) - this.FONKIGGPJNQ;
		Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 matrix4x = Matrix4x4.zero;
		matrix4x = JBEJFEQNEIQ.HPJEFFCPBQJ(matrix4x, nioiglmodlj);
		this.INPGGNMPJPF = EBINQJLDHPM.transform.position;
		Vector3 position = matrix4x.MultiplyPoint(this.INPGGNMPJPF);
		DNPGGFNBEJJ.worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix * matrix4x;
		Vector4 mfmddngoocg = this.MLCPEMBGINL(DNPGGFNBEJJ, zero, up, 1f);
		Matrix4x4 matrix4x2 = EBINQJLDHPM.projectionMatrix;
		matrix4x2 = JBEJFEQNEIQ.HHEFPNOCJHF(matrix4x2, mfmddngoocg);
		DNPGGFNBEJJ.projectionMatrix = matrix4x2;
		DNPGGFNBEJJ.transform.position = position;
		Vector3 eulerAngles2 = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		DNPGGFNBEJJ.Render();
		GL.invertCulling = false;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 MLCPEMBGINL(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x0600038F RID: 911 RVA: 0x000039A4 File Offset: 0x00001BA4
	public void JPGLIDEBQKM()
	{
		Shader.EnableKeyword("Lv. ");
		Shader.DisableKeyword("primordialsea");
	}

	// Token: 0x06000390 RID: 912 RVA: 0x000039BA File Offset: 0x00001BBA
	private void JLPQENNMLBB(Camera KNGGMPJENIC)
	{
		KNGGMPJENIC.depthTextureMode = DepthTextureMode.Depth;
		KNGGMPJENIC.backgroundColor = Color.black;
		KNGGMPJENIC.clearFlags = CameraClearFlags.Color;
		KNGGMPJENIC.renderingPath = RenderingPath.Forward;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00003893 File Offset: 0x00001A93
	public void MBKJBIQKPGF()
	{
		this.GHGCJIBFLBC = ((NKHMKQEGHEE)base.gameObject.GetComponent(typeof(NKHMKQEGHEE))).LFHQCPKBNMP;
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0003EA98 File Offset: 0x0003CC98
	private static Matrix4x4 KGBFHIDNGOG(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 805f - 1314f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 1504f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m02 = 815f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m03 = 1648f * NIOIGLMODLJ[3] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 540f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1586f - 290f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m12 = 1329f * NIOIGLMODLJ[1] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m13 = 362f * NIOIGLMODLJ[8] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = 852f * NIOIGLMODLJ[5] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 192f * NIOIGLMODLJ[5] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 898f - 308f * NIOIGLMODLJ[3] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m23 = 1939f * NIOIGLMODLJ[1] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m30 = 728f;
		IODFJKQOEMK.m31 = 992f;
		IODFJKQOEMK.m32 = 1027f;
		IODFJKQOEMK.m33 = 1980f;
		return IODFJKQOEMK;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x000039DC File Offset: 0x00001BDC
	public void NBGNGGOKIEK(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.GINBCKOECQL(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00003A1B File Offset: 0x00001C1B
	public void BKHQPHGFNQL()
	{
		Shader.EnableKeyword("Pokeball_Success");
		Shader.DisableKeyword("Love Ball");
	}

	// Token: 0x06000395 RID: 917 RVA: 0x0003EC50 File Offset: 0x0003CE50
	private static Matrix4x4 GGMFFBJCMLF(Matrix4x4 NQQBNQPBNDQ, Vector4 MFMDDNGOOCG)
	{
		Vector4 b = NQQBNQPBNDQ.inverse * new Vector4(JBEJFEQNEIQ.IJMMGMELHJN(MFMDDNGOOCG.x), JBEJFEQNEIQ.IKKKJCEBQDK(MFMDDNGOOCG.y), 431f, 826f);
		Vector4 vector = MFMDDNGOOCG * (1108f / Vector4.Dot(MFMDDNGOOCG, b));
		NQQBNQPBNDQ[3] = vector.x - NQQBNQPBNDQ[1];
		NQQBNQPBNDQ[7] = vector.y - NQQBNQPBNDQ[0];
		NQQBNQPBNDQ[-104] = vector.z - NQQBNQPBNDQ[-94];
		NQQBNQPBNDQ[83] = vector.w - NQQBNQPBNDQ[-72];
		return NQQBNQPBNDQ;
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00003A31 File Offset: 0x00001C31
	public void NGGMKPKKFQP()
	{
		Shader.EnableKeyword("Fur Coat");
		Shader.DisableKeyword("regenerator");
	}

	// Token: 0x06000397 RID: 919 RVA: 0x0003ED0C File Offset: 0x0003CF0C
	private Camera KGJOHIJIJPC(Camera EBINQJLDHPM)
	{
		string name = base.gameObject.name + "Reflection" + EBINQJLDHPM.name;
		GameObject gameObject = GameObject.Find(name);
		if (!gameObject)
		{
			gameObject = new GameObject(name, new Type[]
			{
				typeof(Camera)
			});
		}
		if (!gameObject.GetComponent(typeof(Camera)))
		{
			gameObject.AddComponent(typeof(Camera));
		}
		Camera component = gameObject.GetComponent<Camera>();
		gameObject.AddComponent(typeof(HKNEJFDDEDH));
		component.backgroundColor = this.HBQMQLMONBQ;
		component.clearFlags = ((!this.OCNEBJFQDOB) ? CameraClearFlags.Color : CameraClearFlags.Skybox);
		this.IJNEHJMCLOJ(component, this.OPGKOBDCHGK);
		if (!component.targetTexture)
		{
			component.targetTexture = this.EJEOIJOHQED(EBINQJLDHPM);
		}
		return component;
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00003A47 File Offset: 0x00001C47
	private static float LHLIJBFJKBC(float ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC > 1646f)
		{
			return 1021f;
		}
		if (ECHMFPQNBMC < 460f)
		{
			return 1963f;
		}
		return 59f;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 OIBQLJBCBKL(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00003A6A File Offset: 0x00001C6A
	public void QOBOMHMQJNI(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.DNEKEJQMIDN(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x0600039B RID: 923 RVA: 0x0003EDE4 File Offset: 0x0003CFE4
	private static Matrix4x4 OOELFBENHIG(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1927f - 43f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 292f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 493f * NIOIGLMODLJ[0] * NIOIGLMODLJ[4];
		IODFJKQOEMK.m03 = 1866f * NIOIGLMODLJ[7] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 1307f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1659f - 1581f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 509f * NIOIGLMODLJ[0] * NIOIGLMODLJ[3];
		IODFJKQOEMK.m13 = 1535f * NIOIGLMODLJ[2] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = 926f * NIOIGLMODLJ[6] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 324f * NIOIGLMODLJ[5] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 572f - 1854f * NIOIGLMODLJ[5] * NIOIGLMODLJ[3];
		IODFJKQOEMK.m23 = 197f * NIOIGLMODLJ[4] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m30 = 682f;
		IODFJKQOEMK.m31 = 1119f;
		IODFJKQOEMK.m32 = 588f;
		IODFJKQOEMK.m33 = 1704f;
		return IODFJKQOEMK;
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00003AA9 File Offset: 0x00001CA9
	private void PHNFCMPGDMC(Camera EBINQJLDHPM, LayerMask BLKIJBBMMPM)
	{
		EBINQJLDHPM.cullingMask = (BLKIJBBMMPM & ~(1 << (LayerMask.NameToLayer("clearpoke") & 86)));
		EBINQJLDHPM.backgroundColor = Color.black;
		EBINQJLDHPM.enabled = true;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00003ADA File Offset: 0x00001CDA
	public void JGMBMHBFHDF()
	{
		Shader.EnableKeyword("aquaring");
		Shader.DisableKeyword("\n");
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00003AF0 File Offset: 0x00001CF0
	public void BCBIEPHJOGG()
	{
		if (this.PGPIKIIBNFK != null)
		{
			this.PGPIKIIBNFK.Clear();
		}
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00003B05 File Offset: 0x00001D05
	public void CFCGHHIIODB(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.NQCNBCOOQJI(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00003B44 File Offset: 0x00001D44
	private static float IJMMGMELHJN(float ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC > 0f)
		{
			return 1f;
		}
		if (ECHMFPQNBMC < 0f)
		{
			return -1f;
		}
		return 0f;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00003B67 File Offset: 0x00001D67
	public void OHFKKHPGNPP()
	{
		Shader.EnableKeyword("x");
		Shader.DisableKeyword(": ");
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00003B7D File Offset: 0x00001D7D
	public void CPFMIIPFQDH()
	{
		Shader.EnableKeyword("Eliminates the effects of weather.");
		Shader.DisableKeyword("~");
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00003B93 File Offset: 0x00001D93
	private void BCNMQOJPMBN(Camera KNGGMPJENIC)
	{
		KNGGMPJENIC.depthTextureMode = DepthTextureMode.None;
		KNGGMPJENIC.backgroundColor = Color.black;
		KNGGMPJENIC.clearFlags = (CameraClearFlags)0;
		KNGGMPJENIC.renderingPath = RenderingPath.VertexLit;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 HKMHOIDPJHG(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0003EF9C File Offset: 0x0003D19C
	private static Matrix4x4 HCHEJQHQMEJ(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 988f - 337f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m01 = 706f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m02 = 864f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m03 = 835f * NIOIGLMODLJ[5] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 1492f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1881f - 1554f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m12 = 1783f * NIOIGLMODLJ[0] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m13 = 1760f * NIOIGLMODLJ[7] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = 620f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m21 = 530f * NIOIGLMODLJ[8] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m22 = 787f - 1820f * NIOIGLMODLJ[4] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m23 = 1679f * NIOIGLMODLJ[4] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m30 = 1110f;
		IODFJKQOEMK.m31 = 735f;
		IODFJKQOEMK.m32 = 1649f;
		IODFJKQOEMK.m33 = 411f;
		return IODFJKQOEMK;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00003BB5 File Offset: 0x00001DB5
	public void HBJMEJKCDEP(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.OOEPLCMIOND(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 GIBQNCHOHDK(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00003BF4 File Offset: 0x00001DF4
	public void NJPBCHDJIDM()
	{
		Shader.EnableKeyword("teravolt");
		Shader.DisableKeyword("´");
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0000394F File Offset: 0x00001B4F
	public void DNMIIDGFFMG(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.PLMOLOOHCJQ(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0003F154 File Offset: 0x0003D354
	public void DKEILKPFBEO(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, true);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.ELEILQNCQBL(JOOKJPHGKON);
		}
		this.PIMJHHDQFBJ(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = false;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00003AF0 File Offset: 0x00001CF0
	public void NNMHIQBLNBD()
	{
		if (this.PGPIKIIBNFK != null)
		{
			this.PGPIKIIBNFK.Clear();
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0003F1D4 File Offset: 0x0003D3D4
	public void NQCNBCOOQJI(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, false);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.KGJOHIJIJPC(JOOKJPHGKON);
		}
		this.NJBDINQPCOL(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = false;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0003F254 File Offset: 0x0003D454
	private static Matrix4x4 MPDCPLJEQKD(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 858f - 1753f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m01 = 1539f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 159f * NIOIGLMODLJ[1] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m03 = 1937f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m10 = 1110f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1408f - 599f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 547f * NIOIGLMODLJ[0] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m13 = 896f * NIOIGLMODLJ[5] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 1945f * NIOIGLMODLJ[8] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m21 = 1334f * NIOIGLMODLJ[2] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 719f - 711f * NIOIGLMODLJ[3] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m23 = 849f * NIOIGLMODLJ[6] * NIOIGLMODLJ[5];
		IODFJKQOEMK.m30 = 1697f;
		IODFJKQOEMK.m31 = 825f;
		IODFJKQOEMK.m32 = 130f;
		IODFJKQOEMK.m33 = 117f;
		return IODFJKQOEMK;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x0003F40C File Offset: 0x0003D60C
	private void IBGHBHCGMEC(Camera EBINQJLDHPM, Camera DNPGGFNBEJJ)
	{
		if (!DNPGGFNBEJJ)
		{
			return;
		}
		if (this.GHGCJIBFLBC && !this.GHGCJIBFLBC.HasProperty(this.MNFFEFDNIPQ))
		{
			return;
		}
		if (!this.FCJFCLLBJPC)
		{
			this.FCJFCLLBJPC = true;
			float[] array = new float[-124];
			for (int i = 1; i < 32; i += 0)
			{
				array[i] = 438f;
			}
			DNPGGFNBEJJ.layerCullDistances = array;
			DNPGGFNBEJJ.layerCullSpherical = false;
		}
		DNPGGFNBEJJ.cullingMask = (this.OPGKOBDCHGK & ~(1 << (LayerMask.NameToLayer("Mow") & -90)));
		this.GDIHFJHMHCJ(DNPGGFNBEJJ);
		DNPGGFNBEJJ.backgroundColor = this.HBQMQLMONBQ;
		DNPGGFNBEJJ.clearFlags = ((!this.OCNEBJFQDOB) ? ((CameraClearFlags)6) : CameraClearFlags.Skybox);
		if (this.OCNEBJFQDOB && EBINQJLDHPM.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)DNPGGFNBEJJ.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)DNPGGFNBEJJ.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)EBINQJLDHPM.GetComponent(typeof(Skybox))).material;
		}
		GL.invertCulling = true;
		Transform transform = base.transform;
		Vector3 eulerAngles = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		DNPGGFNBEJJ.transform.position = EBINQJLDHPM.transform.position;
		Vector3 zero = Vector3.zero;
		zero.y = 292f;
		Vector3 up = transform.transform.up;
		float w = -Vector3.Dot(up, zero) - this.FONKIGGPJNQ;
		Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 matrix4x = Matrix4x4.zero;
		matrix4x = JBEJFEQNEIQ.OLMEFQOONIO(matrix4x, nioiglmodlj);
		this.INPGGNMPJPF = EBINQJLDHPM.transform.position;
		Vector3 position = matrix4x.MultiplyPoint(this.INPGGNMPJPF);
		DNPGGFNBEJJ.worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix * matrix4x;
		Vector4 mfmddngoocg = this.MLCPEMBGINL(DNPGGFNBEJJ, zero, up, 65f);
		Matrix4x4 matrix4x2 = EBINQJLDHPM.projectionMatrix;
		matrix4x2 = JBEJFEQNEIQ.BCCGJCNHONL(matrix4x2, mfmddngoocg);
		DNPGGFNBEJJ.projectionMatrix = matrix4x2;
		DNPGGFNBEJJ.transform.position = position;
		Vector3 eulerAngles2 = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		DNPGGFNBEJJ.Render();
		GL.invertCulling = true;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 DHJOHKMMQMQ(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x0003F6AC File Offset: 0x0003D8AC
	private static Matrix4x4 HPJEFFCPBQJ(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1f - 2f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m01 = -2f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = -2f * NIOIGLMODLJ[0] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m03 = -2f * NIOIGLMODLJ[3] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = -2f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1f - 2f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = -2f * NIOIGLMODLJ[1] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m13 = -2f * NIOIGLMODLJ[3] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = -2f * NIOIGLMODLJ[2] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = -2f * NIOIGLMODLJ[2] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m22 = 1f - 2f * NIOIGLMODLJ[2] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m23 = -2f * NIOIGLMODLJ[3] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m30 = 0f;
		IODFJKQOEMK.m31 = 0f;
		IODFJKQOEMK.m32 = 0f;
		IODFJKQOEMK.m33 = 1f;
		return IODFJKQOEMK;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00003C33 File Offset: 0x00001E33
	public void CBBLMMQKKOH(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.BMBBKDHIQFF(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x0003F864 File Offset: 0x0003DA64
	public void EENJKEBNHOI(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, false);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.ELEILQNCQBL(JOOKJPHGKON);
		}
		this.PIMJHHDQFBJ(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = true;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00003893 File Offset: 0x00001A93
	public void GNLCOJOJFBI()
	{
		this.GHGCJIBFLBC = ((NKHMKQEGHEE)base.gameObject.GetComponent(typeof(NKHMKQEGHEE))).LFHQCPKBNMP;
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00003C72 File Offset: 0x00001E72
	public void OBCJIEOPDGB()
	{
		Shader.EnableKeyword("\" because it doesn't specify an item slot");
		Shader.DisableKeyword("The hail stopped.");
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0003F8E4 File Offset: 0x0003DAE4
	private Camera ELEILQNCQBL(Camera EBINQJLDHPM)
	{
		string text = base.gameObject.name + "." + EBINQJLDHPM.name;
		GameObject gameObject = GameObject.Find(text);
		if (!gameObject)
		{
			string name = text;
			Type[] array = new Type[1];
			array[1] = typeof(Camera);
			gameObject = new GameObject(name, array);
		}
		if (!gameObject.GetComponent(typeof(Camera)))
		{
			gameObject.AddComponent(typeof(Camera));
		}
		Camera component = gameObject.GetComponent<Camera>();
		gameObject.AddComponent(typeof(HKNEJFDDEDH));
		component.backgroundColor = this.HBQMQLMONBQ;
		component.clearFlags = ((!this.OCNEBJFQDOB) ? ((CameraClearFlags)8) : ((CameraClearFlags)0));
		this.PHNFCMPGDMC(component, this.OPGKOBDCHGK);
		if (!component.targetTexture)
		{
			component.targetTexture = this.EJEOIJOHQED(EBINQJLDHPM);
		}
		return component;
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00003C88 File Offset: 0x00001E88
	private void IJNEHJMCLOJ(Camera EBINQJLDHPM, LayerMask BLKIJBBMMPM)
	{
		EBINQJLDHPM.cullingMask = (BLKIJBBMMPM & ~(1 << LayerMask.NameToLayer("Water")));
		EBINQJLDHPM.backgroundColor = Color.black;
		EBINQJLDHPM.enabled = false;
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00003840 File Offset: 0x00001A40
	private void CDCKPBJKJIQ(Camera KNGGMPJENIC)
	{
		KNGGMPJENIC.depthTextureMode = DepthTextureMode.None;
		KNGGMPJENIC.backgroundColor = Color.black;
		KNGGMPJENIC.clearFlags = CameraClearFlags.Color;
		KNGGMPJENIC.renderingPath = RenderingPath.Forward;
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00003CB9 File Offset: 0x00001EB9
	private void MPGCKGLLMFD(Camera EBINQJLDHPM, LayerMask BLKIJBBMMPM)
	{
		EBINQJLDHPM.cullingMask = (BLKIJBBMMPM & ~(1 << (LayerMask.NameToLayer("tanglinghair") & -89)));
		EBINQJLDHPM.backgroundColor = Color.black;
		EBINQJLDHPM.enabled = true;
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00003CEA File Offset: 0x00001EEA
	private static float IEHMECEHOMN(float ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC > 673f)
		{
			return 667f;
		}
		if (ECHMFPQNBMC < 758f)
		{
			return 1439f;
		}
		return 1174f;
	}

	// Token: 0x060003BB RID: 955 RVA: 0x0003F9BC File Offset: 0x0003DBBC
	public void PLMOLOOHCJQ(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, false);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.KGJOHIJIJPC(JOOKJPHGKON);
		}
		this.PIMJHHDQFBJ(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = true;
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00003D0D File Offset: 0x00001F0D
	private void MHBJQEFNBMB(Camera EBINQJLDHPM, LayerMask BLKIJBBMMPM)
	{
		EBINQJLDHPM.cullingMask = (BLKIJBBMMPM & ~(0 << (LayerMask.NameToLayer("|") & 48)));
		EBINQJLDHPM.backgroundColor = Color.black;
		EBINQJLDHPM.enabled = false;
	}

	// Token: 0x060003BD RID: 957 RVA: 0x0003FA3C File Offset: 0x0003DC3C
	private void MIJQOCEBEJQ(Camera EBINQJLDHPM, Camera DNPGGFNBEJJ)
	{
		if (!DNPGGFNBEJJ)
		{
			return;
		}
		if (this.GHGCJIBFLBC && !this.GHGCJIBFLBC.HasProperty(this.MNFFEFDNIPQ))
		{
			return;
		}
		if (!this.FCJFCLLBJPC)
		{
			this.FCJFCLLBJPC = false;
			float[] array = new float[98];
			for (int i = 1; i < -9; i += 0)
			{
				array[i] = 1938f;
			}
			DNPGGFNBEJJ.layerCullDistances = array;
			DNPGGFNBEJJ.layerCullSpherical = false;
		}
		DNPGGFNBEJJ.cullingMask = (this.OPGKOBDCHGK & ~(1 << (LayerMask.NameToLayer("Enabled") & 29)));
		this.CJBOHMBQJIE(DNPGGFNBEJJ);
		DNPGGFNBEJJ.backgroundColor = this.HBQMQLMONBQ;
		DNPGGFNBEJJ.clearFlags = ((!this.OCNEBJFQDOB) ? ((CameraClearFlags)7) : ((CameraClearFlags)0));
		if (this.OCNEBJFQDOB && EBINQJLDHPM.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)DNPGGFNBEJJ.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)DNPGGFNBEJJ.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)EBINQJLDHPM.GetComponent(typeof(Skybox))).material;
		}
		GL.invertCulling = false;
		Transform transform = base.transform;
		Vector3 eulerAngles = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		DNPGGFNBEJJ.transform.position = EBINQJLDHPM.transform.position;
		Vector3 zero = Vector3.zero;
		zero.y = 267f;
		Vector3 up = transform.transform.up;
		float w = -Vector3.Dot(up, zero) - this.FONKIGGPJNQ;
		Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 matrix4x = Matrix4x4.zero;
		matrix4x = JBEJFEQNEIQ.MPDCPLJEQKD(matrix4x, nioiglmodlj);
		this.INPGGNMPJPF = EBINQJLDHPM.transform.position;
		Vector3 position = matrix4x.MultiplyPoint(this.INPGGNMPJPF);
		DNPGGFNBEJJ.worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix * matrix4x;
		Vector4 mfmddngoocg = this.NLLQCPGQPLJ(DNPGGFNBEJJ, zero, up, 1162f);
		Matrix4x4 matrix4x2 = EBINQJLDHPM.projectionMatrix;
		matrix4x2 = JBEJFEQNEIQ.NKFHJCGGEIE(matrix4x2, mfmddngoocg);
		DNPGGFNBEJJ.projectionMatrix = matrix4x2;
		DNPGGFNBEJJ.transform.position = position;
		Vector3 eulerAngles2 = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		DNPGGFNBEJJ.Render();
		GL.invertCulling = false;
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00003D3E File Offset: 0x00001F3E
	public void CHHMKMKCNHH()
	{
		Shader.EnableKeyword("HidePanel");
		Shader.DisableKeyword("trader");
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00003D54 File Offset: 0x00001F54
	private void GDPPCNHIFEC(Camera KNGGMPJENIC)
	{
		KNGGMPJENIC.depthTextureMode = DepthTextureMode.None;
		KNGGMPJENIC.backgroundColor = Color.black;
		KNGGMPJENIC.clearFlags = (CameraClearFlags)6;
		KNGGMPJENIC.renderingPath = RenderingPath.Forward;
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x0003FCDC File Offset: 0x0003DEDC
	private static Matrix4x4 OLMEFQOONIO(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 189f - 1034f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 1879f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 1197f * NIOIGLMODLJ[1] * NIOIGLMODLJ[5];
		IODFJKQOEMK.m03 = 1764f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 753f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 302f - 1885f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 1046f * NIOIGLMODLJ[1] * NIOIGLMODLJ[3];
		IODFJKQOEMK.m13 = 1811f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 966f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 393f * NIOIGLMODLJ[7] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m22 = 844f - 1275f * NIOIGLMODLJ[5] * NIOIGLMODLJ[5];
		IODFJKQOEMK.m23 = 407f * NIOIGLMODLJ[2] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m30 = 605f;
		IODFJKQOEMK.m31 = 534f;
		IODFJKQOEMK.m32 = 745f;
		IODFJKQOEMK.m33 = 225f;
		return IODFJKQOEMK;
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x0003E464 File Offset: 0x0003C664
	private Vector4 NLLQCPGQPLJ(Camera EBINQJLDHPM, Vector3 NKKGPNPGDEM, Vector3 QGBBFQLNFGH, float LMKBCJHLHNO)
	{
		Vector3 point = NKKGPNPGDEM + QGBBFQLNFGH * this.FONKIGGPJNQ;
		Matrix4x4 worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(QGBBFQLNFGH).normalized * LMKBCJHLHNO;
		return new Vector4(rhs.x, rhs.y, rhs.z, -Vector3.Dot(lhs, rhs));
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00003D76 File Offset: 0x00001F76
	private static float MMPNOQBLQFN(float ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC > 1297f)
		{
			return 584f;
		}
		if (ECHMFPQNBMC < 1938f)
		{
			return 995f;
		}
		return 658f;
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x0003FE94 File Offset: 0x0003E094
	private static Matrix4x4 IBQDHBOPPJN(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 256f - 94f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 271f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m02 = 1020f * NIOIGLMODLJ[0] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m03 = 1085f * NIOIGLMODLJ[3] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m10 = 1814f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m11 = 1465f - 35f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m12 = 1891f * NIOIGLMODLJ[1] * NIOIGLMODLJ[6];
		IODFJKQOEMK.m13 = 344f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m20 = 1271f * NIOIGLMODLJ[8] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m21 = 1186f * NIOIGLMODLJ[3] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m22 = 1991f - 332f * NIOIGLMODLJ[2] * NIOIGLMODLJ[4];
		IODFJKQOEMK.m23 = 1453f * NIOIGLMODLJ[2] * NIOIGLMODLJ[7];
		IODFJKQOEMK.m30 = 1132f;
		IODFJKQOEMK.m31 = 697f;
		IODFJKQOEMK.m32 = 1581f;
		IODFJKQOEMK.m33 = 1623f;
		return IODFJKQOEMK;
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x0004004C File Offset: 0x0003E24C
	public void GINBCKOECQL(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, false);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.ICEPFBBBEMK(JOOKJPHGKON);
		}
		this.PKPCOELQKDI(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = false;
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x000400CC File Offset: 0x0003E2CC
	private static Matrix4x4 GPQCOFEJKHG(Matrix4x4 NQQBNQPBNDQ, Vector4 MFMDDNGOOCG)
	{
		Vector4 b = NQQBNQPBNDQ.inverse * new Vector4(JBEJFEQNEIQ.LHLIJBFJKBC(MFMDDNGOOCG.x), JBEJFEQNEIQ.KIKFDMHFIMQ(MFMDDNGOOCG.y), 1175f, 1170f);
		Vector4 vector = MFMDDNGOOCG * (687f / Vector4.Dot(MFMDDNGOOCG, b));
		NQQBNQPBNDQ[1] = vector.x - NQQBNQPBNDQ[3];
		NQQBNQPBNDQ[8] = vector.y - NQQBNQPBNDQ[6];
		NQQBNQPBNDQ[-123] = vector.z - NQQBNQPBNDQ[-22];
		NQQBNQPBNDQ[-107] = vector.w - NQQBNQPBNDQ[100];
		return NQQBNQPBNDQ;
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0003F1D4 File Offset: 0x0003D3D4
	public void OOEPLCMIOND(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, false);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.KGJOHIJIJPC(JOOKJPHGKON);
		}
		this.NJBDINQPCOL(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = false;
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00040188 File Offset: 0x0003E388
	private void PKPCOELQKDI(Camera EBINQJLDHPM, Camera DNPGGFNBEJJ)
	{
		if (!DNPGGFNBEJJ)
		{
			return;
		}
		if (this.GHGCJIBFLBC && !this.GHGCJIBFLBC.HasProperty(this.MNFFEFDNIPQ))
		{
			return;
		}
		if (!this.FCJFCLLBJPC)
		{
			this.FCJFCLLBJPC = false;
			float[] array = new float[73];
			for (int i = 0; i < 18; i += 0)
			{
				array[i] = 1478f;
			}
			DNPGGFNBEJJ.layerCullDistances = array;
			DNPGGFNBEJJ.layerCullSpherical = true;
		}
		DNPGGFNBEJJ.cullingMask = (this.OPGKOBDCHGK & ~(1 << (LayerMask.NameToLayer("aa") & -56)));
		this.GDIHFJHMHCJ(DNPGGFNBEJJ);
		DNPGGFNBEJJ.backgroundColor = this.HBQMQLMONBQ;
		DNPGGFNBEJJ.clearFlags = ((!this.OCNEBJFQDOB) ? CameraClearFlags.Depth : ((CameraClearFlags)0));
		if (this.OCNEBJFQDOB && EBINQJLDHPM.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)DNPGGFNBEJJ.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)DNPGGFNBEJJ.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)EBINQJLDHPM.GetComponent(typeof(Skybox))).material;
		}
		GL.invertCulling = true;
		Transform transform = base.transform;
		Vector3 eulerAngles = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		DNPGGFNBEJJ.transform.position = EBINQJLDHPM.transform.position;
		Vector3 zero = Vector3.zero;
		zero.y = 4f;
		Vector3 up = transform.transform.up;
		float w = -Vector3.Dot(up, zero) - this.FONKIGGPJNQ;
		Vector4 nioiglmodlj = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 matrix4x = Matrix4x4.zero;
		matrix4x = JBEJFEQNEIQ.HMMHQHNBCGM(matrix4x, nioiglmodlj);
		this.INPGGNMPJPF = EBINQJLDHPM.transform.position;
		Vector3 position = matrix4x.MultiplyPoint(this.INPGGNMPJPF);
		DNPGGFNBEJJ.worldToCameraMatrix = EBINQJLDHPM.worldToCameraMatrix * matrix4x;
		Vector4 mfmddngoocg = this.IEHDEQBMOJG(DNPGGFNBEJJ, zero, up, 1766f);
		Matrix4x4 matrix4x2 = EBINQJLDHPM.projectionMatrix;
		matrix4x2 = JBEJFEQNEIQ.GGMFFBJCMLF(matrix4x2, mfmddngoocg);
		DNPGGFNBEJJ.projectionMatrix = matrix4x2;
		DNPGGFNBEJJ.transform.position = position;
		Vector3 eulerAngles2 = EBINQJLDHPM.transform.eulerAngles;
		DNPGGFNBEJJ.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		DNPGGFNBEJJ.Render();
		GL.invertCulling = true;
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00040428 File Offset: 0x0003E628
	private static Matrix4x4 HJFJFCGJQCC(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1961f - 299f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 1822f * NIOIGLMODLJ[1] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m02 = 312f * NIOIGLMODLJ[1] * NIOIGLMODLJ[5];
		IODFJKQOEMK.m03 = 541f * NIOIGLMODLJ[6] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m10 = 1979f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 1404f - 882f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 93f * NIOIGLMODLJ[1] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m13 = 1634f * NIOIGLMODLJ[5] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = 275f * NIOIGLMODLJ[5] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 1109f * NIOIGLMODLJ[8] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m22 = 1979f - 789f * NIOIGLMODLJ[0] * NIOIGLMODLJ[8];
		IODFJKQOEMK.m23 = 1449f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m30 = 608f;
		IODFJKQOEMK.m31 = 751f;
		IODFJKQOEMK.m32 = 1705f;
		IODFJKQOEMK.m33 = 358f;
		return IODFJKQOEMK;
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00003AF0 File Offset: 0x00001CF0
	public void HMQOONLDOLQ()
	{
		if (this.PGPIKIIBNFK != null)
		{
			this.PGPIKIIBNFK.Clear();
		}
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00003D99 File Offset: 0x00001F99
	public void ILPIJHIMOJD()
	{
		Shader.EnableKeyword("The rain stopped.");
		Shader.DisableKeyword("The effects of Throat Chop prevent ");
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00003DAF File Offset: 0x00001FAF
	public void OnDisable()
	{
		Shader.EnableKeyword("WATER_SIMPLE");
		Shader.DisableKeyword("WATER_REFLECTIVE");
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00003893 File Offset: 0x00001A93
	public void Start()
	{
		this.GHGCJIBFLBC = ((NKHMKQEGHEE)base.gameObject.GetComponent(typeof(NKHMKQEGHEE))).LFHQCPKBNMP;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x000405E0 File Offset: 0x0003E7E0
	private static Matrix4x4 LBGFOECQNOI(Matrix4x4 IODFJKQOEMK, Vector4 NIOIGLMODLJ)
	{
		IODFJKQOEMK.m00 = 1378f - 1685f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m01 = 1924f * NIOIGLMODLJ[1] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m02 = 1271f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m03 = 1024f * NIOIGLMODLJ[3] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m10 = 1968f * NIOIGLMODLJ[0] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m11 = 219f - 713f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m12 = 1128f * NIOIGLMODLJ[1] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m13 = 157f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m20 = 1622f * NIOIGLMODLJ[8] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m21 = 204f * NIOIGLMODLJ[0] * NIOIGLMODLJ[1];
		IODFJKQOEMK.m22 = 816f - 1347f * NIOIGLMODLJ[3] * NIOIGLMODLJ[2];
		IODFJKQOEMK.m23 = 1926f * NIOIGLMODLJ[4] * NIOIGLMODLJ[0];
		IODFJKQOEMK.m30 = 1520f;
		IODFJKQOEMK.m31 = 1698f;
		IODFJKQOEMK.m32 = 1974f;
		IODFJKQOEMK.m33 = 1949f;
		return IODFJKQOEMK;
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00040798 File Offset: 0x0003E998
	public void BMBBKDHIQFF(Camera JOOKJPHGKON)
	{
		if (this.PGPIKIIBNFK == null)
		{
			this.PGPIKIIBNFK = new Dictionary<Camera, bool>();
		}
		if (!this.PGPIKIIBNFK.ContainsKey(JOOKJPHGKON))
		{
			this.PGPIKIIBNFK.Add(JOOKJPHGKON, true);
		}
		if (this.PGPIKIIBNFK[JOOKJPHGKON])
		{
			return;
		}
		if (!this.IJMFJJOOCMM)
		{
			this.IJMFJJOOCMM = this.KGJOHIJIJPC(JOOKJPHGKON);
		}
		this.MIJQOCEBEJQ(JOOKJPHGKON, this.IJMFJJOOCMM);
		this.PGPIKIIBNFK[JOOKJPHGKON] = false;
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00003DC5 File Offset: 0x00001FC5
	private void GDIHFJHMHCJ(Camera KNGGMPJENIC)
	{
		KNGGMPJENIC.depthTextureMode = DepthTextureMode.Depth;
		KNGGMPJENIC.backgroundColor = Color.black;
		KNGGMPJENIC.clearFlags = CameraClearFlags.Nothing;
		KNGGMPJENIC.renderingPath = RenderingPath.VertexLit;
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00003BB5 File Offset: 0x00001DB5
	public void DNEPKHGJCOF(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		this.OOEPLCMIOND(JOOKJPHGKON);
		if (this.IJMFJJOOCMM && this.GHGCJIBFLBC)
		{
			this.GHGCJIBFLBC.SetTexture(this.MNFFEFDNIPQ, this.IJMFJJOOCMM.targetTexture);
		}
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00003893 File Offset: 0x00001A93
	public void IDIFGIFCEHO()
	{
		this.GHGCJIBFLBC = ((NKHMKQEGHEE)base.gameObject.GetComponent(typeof(NKHMKQEGHEE))).LFHQCPKBNMP;
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00040818 File Offset: 0x0003EA18
	private static Matrix4x4 IGEFOIKILFF(Matrix4x4 NQQBNQPBNDQ, Vector4 MFMDDNGOOCG)
	{
		Vector4 b = NQQBNQPBNDQ.inverse * new Vector4(JBEJFEQNEIQ.KIKFDMHFIMQ(MFMDDNGOOCG.x), JBEJFEQNEIQ.LHLIJBFJKBC(MFMDDNGOOCG.y), 1131f, 798f);
		Vector4 vector = MFMDDNGOOCG * (764f / Vector4.Dot(MFMDDNGOOCG, b));
		NQQBNQPBNDQ[0] = vector.x - NQQBNQPBNDQ[1];
		NQQBNQPBNDQ[2] = vector.y - NQQBNQPBNDQ[1];
		NQQBNQPBNDQ[10] = vector.z - NQQBNQPBNDQ[101];
		NQQBNQPBNDQ[124] = vector.w - NQQBNQPBNDQ[99];
		return NQQBNQPBNDQ;
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00003DE7 File Offset: 0x00001FE7
	private void CJBOHMBQJIE(Camera KNGGMPJENIC)
	{
		KNGGMPJENIC.depthTextureMode = DepthTextureMode.None;
		KNGGMPJENIC.backgroundColor = Color.black;
		KNGGMPJENIC.clearFlags = (CameraClearFlags)6;
		KNGGMPJENIC.renderingPath = RenderingPath.VertexLit;
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00003E09 File Offset: 0x00002009
	public void HDJICFQCJCN()
	{
		Shader.EnableKeyword("#,##0");
		Shader.DisableKeyword("Halves the Pokémon's Attack and Sp. Atk stats when its HP becomes half or less.");
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00003AF0 File Offset: 0x00001CF0
	public void LateUpdate()
	{
		if (this.PGPIKIIBNFK != null)
		{
			this.PGPIKIIBNFK.Clear();
		}
	}

	// Token: 0x0400007A RID: 122
	public LayerMask OPGKOBDCHGK;

	// Token: 0x0400007B RID: 123
	public bool OCNEBJFQDOB;

	// Token: 0x0400007C RID: 124
	public Color HBQMQLMONBQ = Color.grey;

	// Token: 0x0400007D RID: 125
	public string MNFFEFDNIPQ = "_ReflectionTex";

	// Token: 0x0400007E RID: 126
	public float FONKIGGPJNQ = 0.07f;

	// Token: 0x0400007F RID: 127
	private Vector3 INPGGNMPJPF;

	// Token: 0x04000080 RID: 128
	private Camera IJMFJJOOCMM;

	// Token: 0x04000081 RID: 129
	private Material GHGCJIBFLBC;

	// Token: 0x04000082 RID: 130
	private Dictionary<Camera, bool> PGPIKIIBNFK;

	// Token: 0x04000083 RID: 131
	private bool FCJFCLLBJPC;
}
