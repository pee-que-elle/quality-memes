using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000A8 RID: 168
public static class IKBQNBHOJJB
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060015BC RID: 5564 RVA: 0x0000B62E File Offset: 0x0000982E
	// (set) Token: 0x060015BD RID: 5565 RVA: 0x0000B656 File Offset: 0x00009856
	public static float PMFCIBGFNJL
	{
		get
		{
			if (!IKBQNBHOJJB.NPPOMNGEQPE)
			{
				IKBQNBHOJJB.NPPOMNGEQPE = true;
				IKBQNBHOJJB.LEIQKCELCMG = PlayerPrefs.GetFloat("Sound", 1f);
			}
			return IKBQNBHOJJB.LEIQKCELCMG;
		}
		set
		{
			if (IKBQNBHOJJB.LEIQKCELCMG != value)
			{
				IKBQNBHOJJB.NPPOMNGEQPE = true;
				IKBQNBHOJJB.LEIQKCELCMG = value;
				PlayerPrefs.SetFloat("Sound", value);
			}
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060015BE RID: 5566 RVA: 0x0000B677 File Offset: 0x00009877
	public static bool OKELBOEPHFB
	{
		get
		{
			return Application.platform != RuntimePlatform.WebGLPlayer;
		}
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x0000B685 File Offset: 0x00009885
	public static AudioSource LKHCJLDFLEJ(AudioClip HICQBQLOLNH)
	{
		return IKBQNBHOJJB.LKHCJLDFLEJ(HICQBQLOLNH, 1f, 1f);
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x0000B697 File Offset: 0x00009897
	public static AudioSource LKHCJLDFLEJ(AudioClip HICQBQLOLNH, float KKKLPHMOKBP)
	{
		return IKBQNBHOJJB.LKHCJLDFLEJ(HICQBQLOLNH, KKKLPHMOKBP, 1f);
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x0009F228 File Offset: 0x0009D428
	public static AudioSource LKHCJLDFLEJ(AudioClip HICQBQLOLNH, float KKKLPHMOKBP, float EPFDOOIODDN)
	{
		KKKLPHMOKBP = DCCFQPDFBFO.QOQONHOOLNE.EEOPJMPGFME;
		float moglgjgfndm = JMIOBJFFGBN.MOGLGJGFNDM;
		if (IKBQNBHOJJB.QQJNBIBMKNJ == HICQBQLOLNH && IKBQNBHOJJB.HBIMFKBBCMM + 0.1f > moglgjgfndm)
		{
			return null;
		}
		IKBQNBHOJJB.QQJNBIBMKNJ = HICQBQLOLNH;
		IKBQNBHOJJB.HBIMFKBBCMM = moglgjgfndm;
		KKKLPHMOKBP *= IKBQNBHOJJB.PMFCIBGFNJL;
		if (HICQBQLOLNH != null && KKKLPHMOKBP > 0.01f)
		{
			if (IKBQNBHOJJB.GCIGECOQLJD == null || !IKBQNBHOJJB.PBBDNDMELHQ(IKBQNBHOJJB.GCIGECOQLJD))
			{
				AudioListener[] array = UnityEngine.Object.FindObjectsOfType(typeof(AudioListener)) as AudioListener[];
				if (array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (IKBQNBHOJJB.PBBDNDMELHQ(array[i]))
						{
							IKBQNBHOJJB.GCIGECOQLJD = array[i];
							break;
						}
					}
				}
				if (IKBQNBHOJJB.GCIGECOQLJD == null)
				{
					Camera camera = Camera.main;
					if (camera == null)
					{
						camera = (UnityEngine.Object.FindObjectOfType(typeof(Camera)) as Camera);
					}
					if (camera != null)
					{
						IKBQNBHOJJB.GCIGECOQLJD = camera.gameObject.AddComponent<AudioListener>();
					}
				}
			}
			if (IKBQNBHOJJB.GCIGECOQLJD != null && IKBQNBHOJJB.GCIGECOQLJD.enabled && IKBQNBHOJJB.PBBDNDMELHQ(IKBQNBHOJJB.GCIGECOQLJD.gameObject))
			{
				AudioSource audioSource = IKBQNBHOJJB.GCIGECOQLJD.GetComponent<AudioSource>();
				if (audioSource == null)
				{
					audioSource = IKBQNBHOJJB.GCIGECOQLJD.gameObject.AddComponent<AudioSource>();
				}
				audioSource.priority = 50;
				audioSource.pitch = EPFDOOIODDN;
				audioSource.PlayOneShot(HICQBQLOLNH, KKKLPHMOKBP);
				return audioSource;
			}
		}
		return null;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x0000B6A5 File Offset: 0x000098A5
	public static int CQKQFPNHPGE(int LCELGLKMPFN, int MJGGCLOGKFL)
	{
		if (LCELGLKMPFN == MJGGCLOGKFL)
		{
			return LCELGLKMPFN;
		}
		return UnityEngine.Random.Range(LCELGLKMPFN, MJGGCLOGKFL + 1);
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x0009F3A0 File Offset: 0x0009D5A0
	public static string IHLEQHINJKK(GameObject NJBFOQDJBON)
	{
		if (NJBFOQDJBON == null)
		{
			return string.Empty;
		}
		string text = NJBFOQDJBON.name;
		while (NJBFOQDJBON.transform.parent != null)
		{
			NJBFOQDJBON = NJBFOQDJBON.transform.parent.gameObject;
			text = NJBFOQDJBON.name + "\\" + text;
		}
		return text;
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x0000B6B6 File Offset: 0x000098B6
	public static T[] NGNKCHMBKFB<T>() where T : Component
	{
		return UnityEngine.Object.FindObjectsOfType(typeof(T)) as T[];
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x0009F400 File Offset: 0x0009D600
	public static Camera FINJNKFMLMO(int MKFMCLIQNKG)
	{
		int num = 1 << MKFMCLIQNKG;
		Camera camera;
		for (int i = 0; i < EMENMKHBPQE.NGDBDCQFDHI.BJGMIBBEGDQ; i++)
		{
			camera = EMENMKHBPQE.NGDBDCQFDHI.KLCIGFMQNFH[i].EQOOPGKHOFB;
			if (camera && (camera.cullingMask & num) != 0)
			{
				return camera;
			}
		}
		camera = Camera.main;
		if (camera && (camera.cullingMask & num) != 0)
		{
			return camera;
		}
		Camera[] array = new Camera[Camera.allCamerasCount];
		int allCameras = Camera.GetAllCameras(array);
		for (int j = 0; j < allCameras; j++)
		{
			camera = array[j];
			if (camera && camera.enabled && (camera.cullingMask & num) != 0)
			{
				return camera;
			}
		}
		return null;
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x0000B6CC File Offset: 0x000098CC
	public static void KPMILMIFJDL(GameObject CGHIENBIHCO)
	{
		IKBQNBHOJJB.KPMILMIFJDL(CGHIENBIHCO, false);
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x0009F4B0 File Offset: 0x0009D6B0
	public static void KPMILMIFJDL(GameObject CGHIENBIHCO, bool LOCNFMJIOQQ)
	{
		if (CGHIENBIHCO != null)
		{
			Collider component = CGHIENBIHCO.GetComponent<Collider>();
			BoxCollider boxCollider = component as BoxCollider;
			if (boxCollider != null)
			{
				IKBQNBHOJJB.DDHFKDFHCQB(boxCollider, LOCNFMJIOQQ);
				return;
			}
			if (component != null)
			{
				return;
			}
			BoxCollider2D boxCollider2D = CGHIENBIHCO.GetComponent<BoxCollider2D>();
			if (boxCollider2D != null)
			{
				IKBQNBHOJJB.DDHFKDFHCQB(boxCollider2D, LOCNFMJIOQQ);
				return;
			}
			EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.FINJNKFMLMO(CGHIENBIHCO.layer);
			if (emenmkhbpqe != null && (emenmkhbpqe.QPMOPMBNBBN == EMENMKHBPQE.CPNJJKJGKNP.World_2D || emenmkhbpqe.QPMOPMBNBBN == EMENMKHBPQE.CPNJJKJGKNP.UI_2D))
			{
				boxCollider2D = CGHIENBIHCO.AddComponent<BoxCollider2D>();
				boxCollider2D.isTrigger = true;
				ENFMCDNLEQQ component2 = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
				if (component2 != null)
				{
					component2.DENNQPBGNNH = true;
				}
				IKBQNBHOJJB.DDHFKDFHCQB(boxCollider2D, LOCNFMJIOQQ);
				return;
			}
			boxCollider = CGHIENBIHCO.AddComponent<BoxCollider>();
			boxCollider.isTrigger = true;
			ENFMCDNLEQQ component3 = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
			if (component3 != null)
			{
				component3.DENNQPBGNNH = true;
			}
			IKBQNBHOJJB.DDHFKDFHCQB(boxCollider, LOCNFMJIOQQ);
		}
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x0000B6D5 File Offset: 0x000098D5
	public static void DDHFKDFHCQB(GameObject CGHIENBIHCO)
	{
		IKBQNBHOJJB.DDHFKDFHCQB(CGHIENBIHCO, false);
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x0009F590 File Offset: 0x0009D790
	public static void DDHFKDFHCQB(GameObject CGHIENBIHCO, bool LOCNFMJIOQQ)
	{
		if (CGHIENBIHCO != null)
		{
			BoxCollider component = CGHIENBIHCO.GetComponent<BoxCollider>();
			if (component != null)
			{
				IKBQNBHOJJB.DDHFKDFHCQB(component, LOCNFMJIOQQ);
				return;
			}
			BoxCollider2D component2 = CGHIENBIHCO.GetComponent<BoxCollider2D>();
			if (component2 != null)
			{
				IKBQNBHOJJB.DDHFKDFHCQB(component2, LOCNFMJIOQQ);
			}
		}
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x0009F5D8 File Offset: 0x0009D7D8
	public static void DDHFKDFHCQB(BoxCollider PDGEFBCMJCH, bool LOCNFMJIOQQ)
	{
		if (PDGEFBCMJCH != null)
		{
			GameObject gameObject = PDGEFBCMJCH.gameObject;
			ENFMCDNLEQQ component = gameObject.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				Vector4 eimqboichop = component.EIMQBOICHOP;
				if (eimqboichop.x == 0f && eimqboichop.y == 0f && eimqboichop.z == 1f)
				{
					if (eimqboichop.w == 1f)
					{
						Vector3[] pigmlpngmno = component.PIGMLPNGMNO;
						PDGEFBCMJCH.center = Vector3.Lerp(pigmlpngmno[0], pigmlpngmno[2], 0.5f);
						PDGEFBCMJCH.size = pigmlpngmno[2] - pigmlpngmno[0];
						return;
					}
				}
				Vector4 bceppkgmnfe = component.BCEPPKGMNFE;
				PDGEFBCMJCH.center = new Vector3((bceppkgmnfe.x + bceppkgmnfe.z) * 0.5f, (bceppkgmnfe.y + bceppkgmnfe.w) * 0.5f);
				PDGEFBCMJCH.size = new Vector3(bceppkgmnfe.z - bceppkgmnfe.x, bceppkgmnfe.w - bceppkgmnfe.y);
			}
			else
			{
				Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(gameObject.transform, LOCNFMJIOQQ);
				PDGEFBCMJCH.center = bounds.center;
				PDGEFBCMJCH.size = new Vector3(bounds.size.x, bounds.size.y, 0f);
			}
		}
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x0009F760 File Offset: 0x0009D960
	public static void DDHFKDFHCQB(BoxCollider2D PDGEFBCMJCH, bool LOCNFMJIOQQ)
	{
		if (PDGEFBCMJCH != null)
		{
			GameObject gameObject = PDGEFBCMJCH.gameObject;
			ENFMCDNLEQQ component = gameObject.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				Vector3[] pigmlpngmno = component.PIGMLPNGMNO;
				PDGEFBCMJCH.offset = Vector3.Lerp(pigmlpngmno[0], pigmlpngmno[2], 0.5f);
				PDGEFBCMJCH.size = pigmlpngmno[2] - pigmlpngmno[0];
			}
			else
			{
				Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(gameObject.transform, LOCNFMJIOQQ);
				PDGEFBCMJCH.offset = bounds.center;
				PDGEFBCMJCH.size = new Vector2(bounds.size.x, bounds.size.y);
			}
		}
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x0009F838 File Offset: 0x0009DA38
	public static string CGEQMLJOFQF<T>()
	{
		string text = typeof(T).ToString();
		if (text.StartsWith("UI"))
		{
			text = text.Substring(2);
		}
		else if (text.StartsWith("UnityEngine."))
		{
			text = text.Substring(12);
		}
		return text;
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x0009F884 File Offset: 0x0009DA84
	public static string CGEQMLJOFQF(UnityEngine.Object NJBFOQDJBON)
	{
		if (NJBFOQDJBON == null)
		{
			return "Null";
		}
		string text = NJBFOQDJBON.GetType().ToString();
		if (text.StartsWith("UI"))
		{
			text = text.Substring(2);
		}
		else if (text.StartsWith("UnityEngine."))
		{
			text = text.Substring(12);
		}
		return text;
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00002300 File Offset: 0x00000500
	public static void JCIOJOBNCHQ(UnityEngine.Object NJBFOQDJBON, string IHIHHCCEDHQ)
	{
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x00002300 File Offset: 0x00000500
	public static void OCPCPKCLCOI(UnityEngine.Object NJBFOQDJBON)
	{
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x0000B6DE File Offset: 0x000098DE
	public static GameObject BFCKNMFEBDM(this GameObject KJIHDMEHLIH)
	{
		return KJIHDMEHLIH.BFCKNMFEBDM(true, -1);
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x0000B6E8 File Offset: 0x000098E8
	public static GameObject BFCKNMFEBDM(this GameObject KJIHDMEHLIH, int MKFMCLIQNKG)
	{
		return KJIHDMEHLIH.BFCKNMFEBDM(true, MKFMCLIQNKG);
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x0000B6F2 File Offset: 0x000098F2
	public static GameObject BFCKNMFEBDM(this GameObject KJIHDMEHLIH, bool BKBMDKQQEFQ)
	{
		return KJIHDMEHLIH.BFCKNMFEBDM(BKBMDKQQEFQ, -1);
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x0009F8DC File Offset: 0x0009DADC
	public static GameObject BFCKNMFEBDM(this GameObject KJIHDMEHLIH, bool BKBMDKQQEFQ, int MKFMCLIQNKG)
	{
		GameObject gameObject = new GameObject();
		if (KJIHDMEHLIH != null)
		{
			Transform transform = gameObject.transform;
			transform.parent = KJIHDMEHLIH.transform;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			if (MKFMCLIQNKG == -1)
			{
				gameObject.layer = KJIHDMEHLIH.layer;
			}
			else if (MKFMCLIQNKG > -1 && MKFMCLIQNKG < 32)
			{
				gameObject.layer = MKFMCLIQNKG;
			}
		}
		return gameObject;
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x0000B6FC File Offset: 0x000098FC
	public static GameObject BFCKNMFEBDM(this GameObject KJIHDMEHLIH, GameObject GKOFPLQPJCH)
	{
		return KJIHDMEHLIH.BFCKNMFEBDM(GKOFPLQPJCH, -1);
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x0009F950 File Offset: 0x0009DB50
	public static GameObject BFCKNMFEBDM(this GameObject KJIHDMEHLIH, GameObject GKOFPLQPJCH, int MKFMCLIQNKG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(GKOFPLQPJCH);
		if (gameObject != null && KJIHDMEHLIH != null)
		{
			Transform transform = gameObject.transform;
			transform.parent = KJIHDMEHLIH.transform;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			if (MKFMCLIQNKG == -1)
			{
				gameObject.layer = KJIHDMEHLIH.layer;
			}
			else if (MKFMCLIQNKG > -1 && MKFMCLIQNKG < 32)
			{
				gameObject.layer = MKFMCLIQNKG;
			}
		}
		return gameObject;
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x0009F9D0 File Offset: 0x0009DBD0
	public static int LCOELQQNPJH(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		if (component != null)
		{
			return component.KJJJFEQLMDN;
		}
		ENFMCDNLEQQ[] componentsInChildren = CGHIENBIHCO.GetComponentsInChildren<ENFMCDNLEQQ>();
		if (componentsInChildren.Length == 0)
		{
			return 0;
		}
		int num = int.MaxValue;
		int i = 0;
		int num2 = componentsInChildren.Length;
		while (i < num2)
		{
			if (componentsInChildren[i].enabled)
			{
				num = Mathf.Min(num, componentsInChildren[i].KJJJFEQLMDN);
			}
			i++;
		}
		return num;
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x0009FA34 File Offset: 0x0009DC34
	public static int MMMCGPIHIMH(GameObject CGHIENBIHCO)
	{
		if (CGHIENBIHCO)
		{
			int num = -1;
			ENFMCDNLEQQ[] componentsInChildren = CGHIENBIHCO.GetComponentsInChildren<ENFMCDNLEQQ>();
			int i = 0;
			int num2 = componentsInChildren.Length;
			while (i < num2)
			{
				num = Mathf.Max(num, componentsInChildren[i].LGCLGHDGNPM);
				i++;
			}
			return num + 1;
		}
		return 0;
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x0009FA78 File Offset: 0x0009DC78
	public static int MMMCGPIHIMH(GameObject CGHIENBIHCO, bool CGNENQBKOGL)
	{
		if (CGHIENBIHCO && CGNENQBKOGL)
		{
			int num = -1;
			ENFMCDNLEQQ[] componentsInChildren = CGHIENBIHCO.GetComponentsInChildren<ENFMCDNLEQQ>();
			int i = 0;
			int num2 = componentsInChildren.Length;
			while (i < num2)
			{
				ENFMCDNLEQQ enfmcdnleqq = componentsInChildren[i];
				if (!(enfmcdnleqq.LMOECGCMJKK != CGHIENBIHCO) || (!(enfmcdnleqq.GetComponent<Collider>() != null) && !(enfmcdnleqq.GetComponent<Collider2D>() != null)))
				{
					num = Mathf.Max(num, enfmcdnleqq.LGCLGHDGNPM);
				}
				i++;
			}
			return num + 1;
		}
		return IKBQNBHOJJB.MMMCGPIHIMH(CGHIENBIHCO);
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x0009FAF4 File Offset: 0x0009DCF4
	public static int OHBMNEDNFEO(GameObject CGHIENBIHCO, int QDBGIBFIHOC)
	{
		if (!(CGHIENBIHCO != null))
		{
			return 0;
		}
		KQHJOLQLQBJ kqhjolqlqbj = CGHIENBIHCO.GetComponent<KQHJOLQLQBJ>();
		if (kqhjolqlqbj != null)
		{
			foreach (KQHJOLQLQBJ kqhjolqlqbj2 in CGHIENBIHCO.GetComponentsInChildren<KQHJOLQLQBJ>(true))
			{
				kqhjolqlqbj2.LGCLGHDGNPM += QDBGIBFIHOC;
			}
			return 1;
		}
		kqhjolqlqbj = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(CGHIENBIHCO);
		if (kqhjolqlqbj == null)
		{
			return 0;
		}
		ENFMCDNLEQQ[] componentsInChildren2 = CGHIENBIHCO.GetComponentsInChildren<ENFMCDNLEQQ>(true);
		int j = 0;
		int num = componentsInChildren2.Length;
		while (j < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = componentsInChildren2[j];
			if (!(enfmcdnleqq.BCHNDNICINJ != kqhjolqlqbj))
			{
				enfmcdnleqq.LGCLGHDGNPM += QDBGIBFIHOC;
			}
			j++;
		}
		return 2;
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x0009FBA4 File Offset: 0x0009DDA4
	public static void MGGOBDQQMBE(GameObject CGHIENBIHCO)
	{
		int num = IKBQNBHOJJB.OHBMNEDNFEO(CGHIENBIHCO, 1000);
		if (num == 1)
		{
			IKBQNBHOJJB.DQHKLEENDMJ();
		}
		else if (num == 2)
		{
			IKBQNBHOJJB.MOEBPOBNCBG();
		}
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x0009FBD4 File Offset: 0x0009DDD4
	public static void QGGLFDCGCDM(GameObject CGHIENBIHCO)
	{
		int num = IKBQNBHOJJB.OHBMNEDNFEO(CGHIENBIHCO, -1000);
		if (num == 1)
		{
			IKBQNBHOJJB.DQHKLEENDMJ();
		}
		else if (num == 2)
		{
			IKBQNBHOJJB.MOEBPOBNCBG();
		}
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x0000B706 File Offset: 0x00009906
	public static void JBBBJDBIIML()
	{
		IKBQNBHOJJB.MOEBPOBNCBG();
		IKBQNBHOJJB.DQHKLEENDMJ();
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x0000B712 File Offset: 0x00009912
	public static void MOEBPOBNCBG()
	{
		IKBQNBHOJJB.MOEBPOBNCBG(IKBQNBHOJJB.NGNKCHMBKFB<ENFMCDNLEQQ>());
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x0000B71E File Offset: 0x0000991E
	public static void MOEBPOBNCBG(GameObject CGHIENBIHCO)
	{
		IKBQNBHOJJB.MOEBPOBNCBG(CGHIENBIHCO.GetComponentsInChildren<ENFMCDNLEQQ>());
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x0009FC04 File Offset: 0x0009DE04
	public static void MOEBPOBNCBG(ENFMCDNLEQQ[] NGDBDCQFDHI)
	{
		int num = NGDBDCQFDHI.Length;
		if (num > 0)
		{
			if (IKBQNBHOJJB.BQIOGOCBKKB == null)
			{
				IKBQNBHOJJB.BQIOGOCBKKB = new Comparison<ENFMCDNLEQQ>(ENFMCDNLEQQ.FKLCFGQBLPH);
			}
			Array.Sort<ENFMCDNLEQQ>(NGDBDCQFDHI, IKBQNBHOJJB.BQIOGOCBKKB);
			int num2 = 0;
			int lgclghdgnpm = NGDBDCQFDHI[0].LGCLGHDGNPM;
			for (int i = 0; i < num; i++)
			{
				ENFMCDNLEQQ enfmcdnleqq = NGDBDCQFDHI[i];
				if (enfmcdnleqq.LGCLGHDGNPM == lgclghdgnpm)
				{
					enfmcdnleqq.LGCLGHDGNPM = num2;
				}
				else
				{
					lgclghdgnpm = enfmcdnleqq.LGCLGHDGNPM;
					num2 = (enfmcdnleqq.LGCLGHDGNPM = num2 + 1);
				}
			}
		}
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x0009FC80 File Offset: 0x0009DE80
	public static void DQHKLEENDMJ()
	{
		KQHJOLQLQBJ[] array = IKBQNBHOJJB.NGNKCHMBKFB<KQHJOLQLQBJ>();
		int num = array.Length;
		if (num > 0)
		{
			KQHJOLQLQBJ[] array2 = array;
			if (IKBQNBHOJJB.OMPIQDIBPKI == null)
			{
				IKBQNBHOJJB.OMPIQDIBPKI = new Comparison<KQHJOLQLQBJ>(KQHJOLQLQBJ.PIEDJOEFGEQ);
			}
			Array.Sort<KQHJOLQLQBJ>(array2, IKBQNBHOJJB.OMPIQDIBPKI);
			int num2 = 0;
			int lgclghdgnpm = array[0].LGCLGHDGNPM;
			for (int i = 0; i < num; i++)
			{
				KQHJOLQLQBJ kqhjolqlqbj = array[i];
				if (kqhjolqlqbj.LGCLGHDGNPM == lgclghdgnpm)
				{
					kqhjolqlqbj.LGCLGHDGNPM = num2;
				}
				else
				{
					lgclghdgnpm = kqhjolqlqbj.LGCLGHDGNPM;
					num2 = (kqhjolqlqbj.LGCLGHDGNPM = num2 + 1);
				}
			}
		}
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x0000B72B File Offset: 0x0000992B
	public static KQHJOLQLQBJ BPHPQEHMKOE(bool PKFNDBLQPDJ)
	{
		return IKBQNBHOJJB.BPHPQEHMKOE(null, PKFNDBLQPDJ, -1);
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x0000B735 File Offset: 0x00009935
	public static KQHJOLQLQBJ BPHPQEHMKOE(bool PKFNDBLQPDJ, int MKFMCLIQNKG)
	{
		return IKBQNBHOJJB.BPHPQEHMKOE(null, PKFNDBLQPDJ, MKFMCLIQNKG);
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x0009FD08 File Offset: 0x0009DF08
	public static KQHJOLQLQBJ BPHPQEHMKOE(Transform HHMCPQQKIKB, bool PKFNDBLQPDJ, int MKFMCLIQNKG)
	{
		GKDCBJPLQLQ gkdcbjplqlq = (!(HHMCPQQKIKB != null)) ? null : IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(HHMCPQQKIKB.gameObject);
		if (gkdcbjplqlq == null && GKDCBJPLQLQ.NGDBDCQFDHI.Count > 0)
		{
			foreach (GKDCBJPLQLQ gkdcbjplqlq2 in GKDCBJPLQLQ.NGDBDCQFDHI)
			{
				if (gkdcbjplqlq2.gameObject.layer == MKFMCLIQNKG)
				{
					gkdcbjplqlq = gkdcbjplqlq2;
					break;
				}
			}
		}
		if (gkdcbjplqlq == null)
		{
			int i = 0;
			int count = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				KQHJOLQLQBJ kqhjolqlqbj = KQHJOLQLQBJ.NGDBDCQFDHI[i];
				GameObject gameObject = kqhjolqlqbj.gameObject;
				if (gameObject.hideFlags == HideFlags.None && gameObject.layer == MKFMCLIQNKG)
				{
					HHMCPQQKIKB.parent = kqhjolqlqbj.transform;
					HHMCPQQKIKB.localScale = Vector3.one;
					return kqhjolqlqbj;
				}
				i++;
			}
		}
		if (gkdcbjplqlq != null)
		{
			EMENMKHBPQE componentInChildren = gkdcbjplqlq.GetComponentInChildren<EMENMKHBPQE>();
			if (componentInChildren != null && componentInChildren.GetComponent<Camera>().orthographic == PKFNDBLQPDJ)
			{
				HHMCPQQKIKB = null;
				gkdcbjplqlq = null;
			}
		}
		if (gkdcbjplqlq == null)
		{
			GameObject gameObject2 = IKBQNBHOJJB.BFCKNMFEBDM((GameObject)null, false);
			gkdcbjplqlq = gameObject2.AddComponent<GKDCBJPLQLQ>();
			if (MKFMCLIQNKG == -1)
			{
				MKFMCLIQNKG = LayerMask.NameToLayer("UI");
			}
			if (MKFMCLIQNKG == -1)
			{
				MKFMCLIQNKG = LayerMask.NameToLayer("2D UI");
			}
			gameObject2.layer = MKFMCLIQNKG;
			if (PKFNDBLQPDJ)
			{
				gameObject2.name = "UI Root (3D)";
				gkdcbjplqlq.KMHNCCLCDDP = GKDCBJPLQLQ.KHMJPIFKCNE.Constrained;
			}
			else
			{
				gameObject2.name = "UI Root";
				gkdcbjplqlq.KMHNCCLCDDP = GKDCBJPLQLQ.KHMJPIFKCNE.Flexible;
			}
			gkdcbjplqlq.KQLOHLEOQIB(true);
		}
		KQHJOLQLQBJ kqhjolqlqbj2 = gkdcbjplqlq.GetComponentInChildren<KQHJOLQLQBJ>();
		if (kqhjolqlqbj2 == null)
		{
			Camera[] array = IKBQNBHOJJB.NGNKCHMBKFB<Camera>();
			float num = -1f;
			bool flag = false;
			int num2 = 1 << gkdcbjplqlq.gameObject.layer;
			foreach (Camera camera in array)
			{
				if (camera.clearFlags == CameraClearFlags.Color || camera.clearFlags == CameraClearFlags.Skybox)
				{
					flag = true;
				}
				num = Mathf.Max(num, camera.depth);
				camera.cullingMask &= ~num2;
			}
			Camera camera2 = gkdcbjplqlq.gameObject.BFCKNMFEBDM(false);
			camera2.gameObject.AddComponent<EMENMKHBPQE>();
			camera2.clearFlags = ((!flag) ? CameraClearFlags.Color : CameraClearFlags.Depth);
			camera2.backgroundColor = Color.grey;
			camera2.cullingMask = num2;
			camera2.depth = num + 1f;
			if (PKFNDBLQPDJ)
			{
				camera2.nearClipPlane = 0.1f;
				camera2.farClipPlane = 4f;
				camera2.transform.localPosition = new Vector3(0f, 0f, -700f);
			}
			else
			{
				camera2.orthographic = true;
				camera2.orthographicSize = 1f;
				camera2.nearClipPlane = -10f;
				camera2.farClipPlane = 10f;
			}
			AudioListener[] array2 = IKBQNBHOJJB.NGNKCHMBKFB<AudioListener>();
			if (array2 == null || array2.Length == 0)
			{
				camera2.gameObject.AddComponent<AudioListener>();
			}
			kqhjolqlqbj2 = gkdcbjplqlq.gameObject.AddComponent<KQHJOLQLQBJ>();
		}
		if (HHMCPQQKIKB != null)
		{
			while (HHMCPQQKIKB.parent != null)
			{
				HHMCPQQKIKB = HHMCPQQKIKB.parent;
			}
			if (IKBQNBHOJJB.MGPLNEFOIFM(HHMCPQQKIKB, kqhjolqlqbj2.transform))
			{
				kqhjolqlqbj2 = HHMCPQQKIKB.gameObject.AddComponent<KQHJOLQLQBJ>();
			}
			else
			{
				HHMCPQQKIKB.parent = kqhjolqlqbj2.transform;
				HHMCPQQKIKB.localScale = Vector3.one;
				HHMCPQQKIKB.localPosition = Vector3.zero;
				kqhjolqlqbj2.CGDFDPHIENG.ONDIKKGKGBN(kqhjolqlqbj2.LMOECGCMJKK.layer);
			}
		}
		return kqhjolqlqbj2;
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x000A0090 File Offset: 0x0009E290
	public static void ONDIKKGKGBN(this Transform OQJFBJQJEFG, int MKFMCLIQNKG)
	{
		for (int i = 0; i < OQJFBJQJEFG.childCount; i++)
		{
			Transform child = OQJFBJQJEFG.GetChild(i);
			child.gameObject.layer = MKFMCLIQNKG;
			child.ONDIKKGKGBN(MKFMCLIQNKG);
		}
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x000A00CC File Offset: 0x0009E2CC
	public static T BFCKNMFEBDM<T>(this GameObject KJIHDMEHLIH) where T : Component
	{
		GameObject gameObject = KJIHDMEHLIH.BFCKNMFEBDM();
		string text;
		if (!IKBQNBHOJJB.HJGHJDNQBBG.TryGetValue(typeof(T), out text) || text == null)
		{
			text = IKBQNBHOJJB.CGEQMLJOFQF<T>();
			IKBQNBHOJJB.HJGHJDNQBBG[typeof(T)] = text;
		}
		gameObject.name = text;
		return gameObject.AddComponent<T>();
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x000A0124 File Offset: 0x0009E324
	public static T BFCKNMFEBDM<T>(this GameObject KJIHDMEHLIH, bool BKBMDKQQEFQ) where T : Component
	{
		GameObject gameObject = KJIHDMEHLIH.BFCKNMFEBDM(BKBMDKQQEFQ);
		string text;
		if (!IKBQNBHOJJB.HJGHJDNQBBG.TryGetValue(typeof(T), out text) || text == null)
		{
			text = IKBQNBHOJJB.CGEQMLJOFQF<T>();
			IKBQNBHOJJB.HJGHJDNQBBG[typeof(T)] = text;
		}
		gameObject.name = text;
		return gameObject.AddComponent<T>();
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x000A017C File Offset: 0x0009E37C
	public static T MFIKGGPKKCD<T>(this GameObject CGHIENBIHCO, int LGCLGHDGNPM = 2147483647) where T : ENFMCDNLEQQ
	{
		if (LGCLGHDGNPM == 2147483647)
		{
			LGCLGHDGNPM = IKBQNBHOJJB.MMMCGPIHIMH(CGHIENBIHCO);
		}
		T result = CGHIENBIHCO.BFCKNMFEBDM<T>();
		result.KJGMGPCEJJD = 100;
		result.DFKQMMIQDOO = 100;
		result.LGCLGHDGNPM = LGCLGHDGNPM;
		return result;
	}

	// Token: 0x060015E8 RID: 5608 RVA: 0x000A01D0 File Offset: 0x0009E3D0
	public static PLQFPBQEPJD MLEMQLCENEC(this GameObject CGHIENBIHCO, BPLKJMJMHFI QKGJDCFCPMO, string KCLBMPFIPNQ, int LGCLGHDGNPM = 2147483647)
	{
		UISpriteData uispriteData = (!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.GMEDHEOGFMB(KCLBMPFIPNQ);
		PLQFPBQEPJD plqfpbqepjd = CGHIENBIHCO.MFIKGGPKKCD(LGCLGHDGNPM);
		plqfpbqepjd.DPQFDCNLLPC = ((uispriteData == null || !uispriteData.hasBorder) ? PHINQNMFEHC.OFPCLCEBHFL.Simple : PHINQNMFEHC.OFPCLCEBHFL.Sliced);
		plqfpbqepjd.QKGJDCFCPMO = QKGJDCFCPMO;
		plqfpbqepjd.KCLBMPFIPNQ = KCLBMPFIPNQ;
		return plqfpbqepjd;
	}

	// Token: 0x060015E9 RID: 5609 RVA: 0x000A0220 File Offset: 0x0009E420
	public static GameObject LFDPHDCELHP(GameObject CGHIENBIHCO)
	{
		Transform transform = CGHIENBIHCO.transform;
		for (;;)
		{
			Transform parent = transform.parent;
			if (parent == null)
			{
				break;
			}
			transform = parent;
		}
		return transform.gameObject;
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x000A0250 File Offset: 0x0009E450
	public static T BBDJCHKMCPI<T>(GameObject CGHIENBIHCO) where T : Component
	{
		if (CGHIENBIHCO == null)
		{
			return (T)((object)null);
		}
		return CGHIENBIHCO.GetComponentInParent<T>();
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x000A0278 File Offset: 0x0009E478
	public static T BBDJCHKMCPI<T>(Transform HHMCPQQKIKB) where T : Component
	{
		if (HHMCPQQKIKB == null)
		{
			return (T)((object)null);
		}
		return HHMCPQQKIKB.GetComponentInParent<T>();
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x000A02A0 File Offset: 0x0009E4A0
	public static void MOPPIIOIIDM(UnityEngine.Object NJBFOQDJBON)
	{
		if (NJBFOQDJBON)
		{
			if (NJBFOQDJBON is Transform)
			{
				Transform transform = NJBFOQDJBON as Transform;
				GameObject gameObject = transform.gameObject;
				if (Application.isPlaying)
				{
					transform.parent = null;
					UnityEngine.Object.Destroy(gameObject);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(gameObject);
				}
			}
			else if (NJBFOQDJBON is GameObject)
			{
				GameObject gameObject2 = NJBFOQDJBON as GameObject;
				Transform transform2 = gameObject2.transform;
				if (Application.isPlaying)
				{
					transform2.parent = null;
					UnityEngine.Object.Destroy(gameObject2);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(gameObject2);
				}
			}
			else if (Application.isPlaying)
			{
				UnityEngine.Object.Destroy(NJBFOQDJBON);
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(NJBFOQDJBON);
			}
		}
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x000A0334 File Offset: 0x0009E534
	public static void NMBPDMIIHJB(this Transform OQJFBJQJEFG)
	{
		bool isPlaying = Application.isPlaying;
		while (OQJFBJQJEFG.childCount != 0)
		{
			Transform child = OQJFBJQJEFG.GetChild(0);
			UnityEngine.Object.DestroyImmediate(child.gameObject);
		}
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x0000B73F File Offset: 0x0000993F
	public static void QOLECCGGDNB(UnityEngine.Object NJBFOQDJBON)
	{
		if (NJBFOQDJBON != null)
		{
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(NJBFOQDJBON);
			}
			else
			{
				UnityEngine.Object.Destroy(NJBFOQDJBON);
			}
		}
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x000A0364 File Offset: 0x0009E564
	public static void OELIBIIBOBC(string OELBCGGGCIP)
	{
		GameObject[] array = UnityEngine.Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		int i = 0;
		int num = array.Length;
		while (i < num)
		{
			array[i].SendMessage(OELBCGGGCIP, SendMessageOptions.DontRequireReceiver);
			i++;
		}
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x000A03A0 File Offset: 0x0009E5A0
	public static void OELIBIIBOBC(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		GameObject[] array = UnityEngine.Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		int i = 0;
		int num = array.Length;
		while (i < num)
		{
			array[i].SendMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.DontRequireReceiver);
			i++;
		}
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x0000B75F File Offset: 0x0000995F
	public static bool MGPLNEFOIFM(Transform KJIHDMEHLIH, Transform BKHOLHHLDGK)
	{
		if (!(KJIHDMEHLIH == null))
		{
			if (!(BKHOLHHLDGK == null))
			{
				while (BKHOLHHLDGK != null)
				{
					if (BKHOLHHLDGK == KJIHDMEHLIH)
					{
						return true;
					}
					BKHOLHHLDGK = BKHOLHHLDGK.parent;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x0000B794 File Offset: 0x00009994
	private static void EKQMEJOIOMQ(Transform OQJFBJQJEFG)
	{
		IKBQNBHOJJB.EKQMEJOIOMQ(OQJFBJQJEFG, false);
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x000A03E0 File Offset: 0x0009E5E0
	private static void EKQMEJOIOMQ(Transform OQJFBJQJEFG, bool BGOJFFJHCQB)
	{
		IKBQNBHOJJB.POOJGJICGMI(OQJFBJQJEFG.gameObject, true);
		if (BGOJFFJHCQB)
		{
			int i = 0;
			int childCount = OQJFBJQJEFG.childCount;
			while (i < childCount)
			{
				Transform child = OQJFBJQJEFG.GetChild(i);
				if (child.gameObject.activeSelf)
				{
					return;
				}
				i++;
			}
			int j = 0;
			int childCount2 = OQJFBJQJEFG.childCount;
			while (j < childCount2)
			{
				Transform child2 = OQJFBJQJEFG.GetChild(j);
				IKBQNBHOJJB.EKQMEJOIOMQ(child2, true);
				j++;
			}
		}
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x0000B79D File Offset: 0x0000999D
	private static void QICONHIPFJI(Transform OQJFBJQJEFG)
	{
		IKBQNBHOJJB.POOJGJICGMI(OQJFBJQJEFG.gameObject, false);
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x0000B7AB File Offset: 0x000099AB
	public static void IFPIGKGKFEQ(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG, true);
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x0000B7B5 File Offset: 0x000099B5
	public static void IFPIGKGKFEQ(GameObject CGHIENBIHCO, bool HHJEFGFNBPG, bool BGOJFFJHCQB)
	{
		if (CGHIENBIHCO)
		{
			if (HHJEFGFNBPG)
			{
				IKBQNBHOJJB.EKQMEJOIOMQ(CGHIENBIHCO.transform, BGOJFFJHCQB);
				IKBQNBHOJJB.CHMLGDKPPMG(CGHIENBIHCO.transform);
			}
			else
			{
				IKBQNBHOJJB.QICONHIPFJI(CGHIENBIHCO.transform);
			}
		}
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x000A0450 File Offset: 0x0009E650
	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void CHMLGDKPPMG(Transform OQJFBJQJEFG)
	{
		ENFMCDNLEQQ component = OQJFBJQJEFG.GetComponent<ENFMCDNLEQQ>();
		if (component != null)
		{
			component.KJPQKFEBFDJ();
		}
		int i = 0;
		int childCount = OQJFBJQJEFG.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.CHMLGDKPPMG(OQJFBJQJEFG.GetChild(i));
			i++;
		}
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x000A0494 File Offset: 0x0009E694
	public static void JBDJMLKDKND(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		Transform transform = CGHIENBIHCO.transform;
		if (HHJEFGFNBPG)
		{
			int i = 0;
			int childCount = transform.childCount;
			while (i < childCount)
			{
				Transform child = transform.GetChild(i);
				IKBQNBHOJJB.EKQMEJOIOMQ(child);
				i++;
			}
		}
		else
		{
			int j = 0;
			int childCount2 = transform.childCount;
			while (j < childCount2)
			{
				Transform child2 = transform.GetChild(j);
				IKBQNBHOJJB.QICONHIPFJI(child2);
				j++;
			}
		}
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x0000B7E6 File Offset: 0x000099E6
	[Obsolete("Use NGUITools.GetActive instead")]
	public static bool HGMHFLEQMNN(Behaviour GQNELIBDDMP)
	{
		return GQNELIBDDMP != null && GQNELIBDDMP.enabled && GQNELIBDDMP.gameObject.activeInHierarchy;
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x0000B807 File Offset: 0x00009A07
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool PBBDNDMELHQ(Behaviour GQNELIBDDMP)
	{
		return GQNELIBDDMP && GQNELIBDDMP.enabled && GQNELIBDDMP.gameObject.activeInHierarchy;
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x0000B827 File Offset: 0x00009A27
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool PBBDNDMELHQ(GameObject CGHIENBIHCO)
	{
		return CGHIENBIHCO && CGHIENBIHCO.activeInHierarchy;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x0000B83A File Offset: 0x00009A3A
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static void POOJGJICGMI(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		CGHIENBIHCO.SetActive(HHJEFGFNBPG);
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x000A04F8 File Offset: 0x0009E6F8
	public static void JKFJELMEDPP(GameObject CGHIENBIHCO, int MKFMCLIQNKG)
	{
		CGHIENBIHCO.layer = MKFMCLIQNKG;
		Transform transform = CGHIENBIHCO.transform;
		int i = 0;
		int childCount = transform.childCount;
		while (i < childCount)
		{
			Transform child = transform.GetChild(i);
			IKBQNBHOJJB.JKFJELMEDPP(child.gameObject, MKFMCLIQNKG);
			i++;
		}
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x0000B843 File Offset: 0x00009A43
	public static Vector3 KHKIBCFOIFB(Vector3 ECFKEFOFQGB)
	{
		ECFKEFOFQGB.x = Mathf.Round(ECFKEFOFQGB.x);
		ECFKEFOFQGB.y = Mathf.Round(ECFKEFOFQGB.y);
		ECFKEFOFQGB.z = Mathf.Round(ECFKEFOFQGB.z);
		return ECFKEFOFQGB;
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x000A053C File Offset: 0x0009E73C
	public static void IQFQEOFBQKM(Transform OQJFBJQJEFG)
	{
		ENFMCDNLEQQ component = OQJFBJQJEFG.GetComponent<ENFMCDNLEQQ>();
		if (component != null)
		{
			component.IQFQEOFBQKM();
		}
		if (OQJFBJQJEFG.GetComponent<KQECKBOKHHE>() == null && OQJFBJQJEFG.GetComponent<GKDCBJPLQLQ>() == null)
		{
			OQJFBJQJEFG.localPosition = IKBQNBHOJJB.KHKIBCFOIFB(OQJFBJQJEFG.localPosition);
			OQJFBJQJEFG.localScale = IKBQNBHOJJB.KHKIBCFOIFB(OQJFBJQJEFG.localScale);
		}
		int i = 0;
		int childCount = OQJFBJQJEFG.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IQFQEOFBQKM(OQJFBJQJEFG.GetChild(i));
			i++;
		}
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x000A05BC File Offset: 0x0009E7BC
	public static void HLOHQMLQPCD(Transform OQJFBJQJEFG)
	{
		ENFMCDNLEQQ component = OQJFBJQJEFG.GetComponent<ENFMCDNLEQQ>();
		if (component != null)
		{
			component.IQFQEOFBQKM();
		}
		if (OQJFBJQJEFG.GetComponent<KQECKBOKHHE>() == null && OQJFBJQJEFG.GetComponent<GKDCBJPLQLQ>() == null)
		{
			OQJFBJQJEFG.localPosition = IKBQNBHOJJB.KHKIBCFOIFB(OQJFBJQJEFG.localPosition);
			OQJFBJQJEFG.localScale = IKBQNBHOJJB.KHKIBCFOIFB(OQJFBJQJEFG.localScale);
		}
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x000A0620 File Offset: 0x0009E820
	public static void FNNJPNQCDOL(this Camera EBINQJLDHPM, Transform OQJFBJQJEFG)
	{
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(OQJFBJQJEFG, OQJFBJQJEFG);
		Vector3 a = EBINQJLDHPM.WorldToScreenPoint(OQJFBJQJEFG.position);
		Vector3 vector = a + bounds.min;
		Vector3 vector2 = a + bounds.max;
		int width = Screen.width;
		int height = Screen.height;
		Vector2 zero = Vector2.zero;
		if (vector.x < 0f)
		{
			zero.x = -vector.x;
		}
		else if (vector2.x > (float)width)
		{
			zero.x = (float)width - vector2.x;
		}
		if (vector.y < 0f)
		{
			zero.y = -vector.y;
		}
		else if (vector2.y > (float)height)
		{
			zero.y = (float)height - vector2.y;
		}
		if (zero.sqrMagnitude > 0f)
		{
			OQJFBJQJEFG.localPosition += new Vector3(zero.x, zero.y, 0f);
		}
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x0000B87F File Offset: 0x00009A7F
	public static void FNNJPNQCDOL(this Camera EBINQJLDHPM, Transform NPKDOHINPHI, Vector3 NKKGPNPGDEM)
	{
		EBINQJLDHPM.FNNJPNQCDOL(NPKDOHINPHI, NPKDOHINPHI, NKKGPNPGDEM);
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x000A0724 File Offset: 0x0009E924
	public static void FNNJPNQCDOL(this Camera EBINQJLDHPM, Transform NPKDOHINPHI, Transform COPDMKMJGEJ, Vector3 NKKGPNPGDEM)
	{
		Bounds bounds;
		EBINQJLDHPM.FNNJPNQCDOL(NPKDOHINPHI, COPDMKMJGEJ, NKKGPNPGDEM, out bounds);
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x000A073C File Offset: 0x0009E93C
	public static void FNNJPNQCDOL(this Camera EBINQJLDHPM, Transform NPKDOHINPHI, Transform COPDMKMJGEJ, Vector3 NKKGPNPGDEM, out Bounds GBMNPQIEMQI)
	{
		GBMNPQIEMQI = JNNGOIIKENH.HFMJNILQCMK(NPKDOHINPHI, COPDMKMJGEJ);
		Vector3 min = GBMNPQIEMQI.min;
		Vector3 vector = GBMNPQIEMQI.max;
		Vector3 size = GBMNPQIEMQI.size;
		size.x += min.x;
		size.y -= vector.y;
		if (EBINQJLDHPM != null)
		{
			NKKGPNPGDEM.x = Mathf.Clamp01(NKKGPNPGDEM.x / (float)Screen.width);
			NKKGPNPGDEM.y = Mathf.Clamp01(NKKGPNPGDEM.y / (float)Screen.height);
			float num = EBINQJLDHPM.orthographicSize / NPKDOHINPHI.parent.lossyScale.y;
			float num2 = (float)Screen.height * 0.5f / num;
			vector = new Vector2(num2 * size.x / (float)Screen.width, num2 * size.y / (float)Screen.height);
			NKKGPNPGDEM.x = Mathf.Min(NKKGPNPGDEM.x, 1f - vector.x);
			NKKGPNPGDEM.y = Mathf.Max(NKKGPNPGDEM.y, vector.y);
			NPKDOHINPHI.position = EBINQJLDHPM.ViewportToWorldPoint(NKKGPNPGDEM);
			NKKGPNPGDEM = NPKDOHINPHI.localPosition;
			NKKGPNPGDEM.x = Mathf.Round(NKKGPNPGDEM.x);
			NKKGPNPGDEM.y = Mathf.Round(NKKGPNPGDEM.y);
		}
		else
		{
			if (NKKGPNPGDEM.x + size.x > (float)Screen.width)
			{
				NKKGPNPGDEM.x = (float)Screen.width - size.x;
			}
			if (NKKGPNPGDEM.y - size.y < 0f)
			{
				NKKGPNPGDEM.y = size.y;
			}
			NKKGPNPGDEM.x -= (float)Screen.width * 0.5f;
			NKKGPNPGDEM.y -= (float)Screen.height * 0.5f;
		}
		NPKDOHINPHI.localPosition = NKKGPNPGDEM;
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x000A0938 File Offset: 0x0009EB38
	public static bool CPMMKIODFLM(string GCLJKDHDILM, byte[] BLJJPLEBHGQ)
	{
		if (!IKBQNBHOJJB.OKELBOEPHFB)
		{
			return false;
		}
		string path = Application.persistentDataPath + "/" + GCLJKDHDILM;
		if (BLJJPLEBHGQ == null)
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			return true;
		}
		FileStream fileStream = null;
		bool result;
		try
		{
			fileStream = File.Create(path);
			goto IL_4A;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError(ex.Message);
			result = false;
		}
		return result;
		IL_4A:
		fileStream.Write(BLJJPLEBHGQ, 0, BLJJPLEBHGQ.Length);
		fileStream.Close();
		return true;
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x000A09B4 File Offset: 0x0009EBB4
	public static byte[] BJNHBGHBHII(string GCLJKDHDILM)
	{
		if (!IKBQNBHOJJB.OKELBOEPHFB)
		{
			return null;
		}
		string path = Application.persistentDataPath + "/" + GCLJKDHDILM;
		if (File.Exists(path))
		{
			return File.ReadAllBytes(path);
		}
		return null;
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x000A09EC File Offset: 0x0009EBEC
	public static Color BQCGKIDLIOC(Color KQFEHQEBJQB)
	{
		if (KQFEHQEBJQB.a != 1f)
		{
			KQFEHQEBJQB.r *= KQFEHQEBJQB.a;
			KQFEHQEBJQB.g *= KQFEHQEBJQB.a;
			KQFEHQEBJQB.b *= KQFEHQEBJQB.a;
		}
		return KQFEHQEBJQB;
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x000A0A48 File Offset: 0x0009EC48
	public static void OKLNNGPNIEO(GameObject CGHIENBIHCO)
	{
		BLMNBILNMOE[] componentsInChildren = CGHIENBIHCO.GetComponentsInChildren<BLMNBILNMOE>();
		int i = 0;
		int num = componentsInChildren.Length;
		while (i < num)
		{
			componentsInChildren[i].HGBNNJQOKLO();
			i++;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06001609 RID: 5641 RVA: 0x000A0A74 File Offset: 0x0009EC74
	// (set) Token: 0x0600160A RID: 5642 RVA: 0x000A0A94 File Offset: 0x0009EC94
	public static string LKOKCPHPDNF
	{
		get
		{
			TextEditor textEditor = new TextEditor();
			textEditor.Paste();
			return textEditor.text;
		}
		set
		{
			TextEditor textEditor = new TextEditor();
			textEditor.text = value;
			textEditor.OnFocus();
			textEditor.Copy();
		}
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x0000B598 File Offset: 0x00009798
	[Obsolete("Use NGUIText.EncodeColor instead")]
	public static string JPHIJCIGHPQ(Color KQFEHQEBJQB)
	{
		return JGDHIPBGCFP.PHICOHINGQE(KQFEHQEBJQB);
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x0000B58F File Offset: 0x0000978F
	[Obsolete("Use NGUIText.ParseColor instead")]
	public static Color GEBCEQHNMPC(string PIDLOFMIEFQ, int LCMMCNFNHMF)
	{
		return JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, LCMMCNFNHMF);
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x0000B88A File Offset: 0x00009A8A
	[Obsolete("Use NGUIText.StripSymbols instead")]
	public static string IMOMGBNIENN(string PIDLOFMIEFQ)
	{
		return JGDHIPBGCFP.IMOMGBNIENN(PIDLOFMIEFQ);
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x000A0ABC File Offset: 0x0009ECBC
	public static T KCOCMECCHIP<T>(this GameObject CGHIENBIHCO) where T : Component
	{
		T t = CGHIENBIHCO.GetComponent<T>();
		if (t == null)
		{
			t = CGHIENBIHCO.AddComponent<T>();
		}
		return t;
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x0000B892 File Offset: 0x00009A92
	public static Vector3[] MKFNGPBMOKP(this Camera EBINQJLDHPM)
	{
		return EBINQJLDHPM.MKFNGPBMOKP(Mathf.Lerp(EBINQJLDHPM.nearClipPlane, EBINQJLDHPM.farClipPlane, 0.5f), null);
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x0000B8B1 File Offset: 0x00009AB1
	public static Vector3[] MKFNGPBMOKP(this Camera EBINQJLDHPM, float LGCLGHDGNPM)
	{
		return EBINQJLDHPM.MKFNGPBMOKP(LGCLGHDGNPM, null);
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x0000B8BB File Offset: 0x00009ABB
	public static Vector3[] MKFNGPBMOKP(this Camera EBINQJLDHPM, Transform ENOQKGBPJKQ)
	{
		return EBINQJLDHPM.MKFNGPBMOKP(Mathf.Lerp(EBINQJLDHPM.nearClipPlane, EBINQJLDHPM.farClipPlane, 0.5f), ENOQKGBPJKQ);
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x000A0AE8 File Offset: 0x0009ECE8
	public static Vector3[] MKFNGPBMOKP(this Camera EBINQJLDHPM, float LGCLGHDGNPM, Transform ENOQKGBPJKQ)
	{
		if (EBINQJLDHPM.orthographic)
		{
			float orthographicSize = EBINQJLDHPM.orthographicSize;
			float num = -orthographicSize;
			float num2 = orthographicSize;
			float y = -orthographicSize;
			float y2 = orthographicSize;
			Rect rect = EBINQJLDHPM.rect;
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num3 = fmdddqopbei.x / fmdddqopbei.y;
			num3 *= rect.width / rect.height;
			num *= num3;
			num2 *= num3;
			Transform transform = EBINQJLDHPM.transform;
			Quaternion rotation = transform.rotation;
			Vector3 position = transform.position;
			int num4 = Mathf.RoundToInt(fmdddqopbei.x);
			int num5 = Mathf.RoundToInt(fmdddqopbei.y);
			if ((num4 & 1) == 1)
			{
				position.x -= 1f / fmdddqopbei.x;
			}
			if ((num5 & 1) == 1)
			{
				position.y += 1f / fmdddqopbei.y;
			}
			IKBQNBHOJJB.BGCNPFKJPFD[0] = rotation * new Vector3(num, 0f, LGCLGHDGNPM) + position;
			IKBQNBHOJJB.BGCNPFKJPFD[1] = rotation * new Vector3(0f, y2, LGCLGHDGNPM) + position;
			IKBQNBHOJJB.BGCNPFKJPFD[2] = rotation * new Vector3(num2, 0f, LGCLGHDGNPM) + position;
			IKBQNBHOJJB.BGCNPFKJPFD[3] = rotation * new Vector3(0f, y, LGCLGHDGNPM) + position;
		}
		else
		{
			IKBQNBHOJJB.BGCNPFKJPFD[0] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(0f, 0.5f, LGCLGHDGNPM));
			IKBQNBHOJJB.BGCNPFKJPFD[1] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(0.5f, 1f, LGCLGHDGNPM));
			IKBQNBHOJJB.BGCNPFKJPFD[2] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(1f, 0.5f, LGCLGHDGNPM));
			IKBQNBHOJJB.BGCNPFKJPFD[3] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(0.5f, 0f, LGCLGHDGNPM));
		}
		if (ENOQKGBPJKQ != null)
		{
			for (int i = 0; i < 4; i++)
			{
				IKBQNBHOJJB.BGCNPFKJPFD[i] = ENOQKGBPJKQ.InverseTransformPoint(IKBQNBHOJJB.BGCNPFKJPFD[i]);
			}
		}
		return IKBQNBHOJJB.BGCNPFKJPFD;
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x000A0D58 File Offset: 0x0009EF58
	public static Vector3[] QKGEPQNOCQE(this Camera EBINQJLDHPM)
	{
		float lgclghdgnpm = Mathf.Lerp(EBINQJLDHPM.nearClipPlane, EBINQJLDHPM.farClipPlane, 0.5f);
		return EBINQJLDHPM.QKGEPQNOCQE(lgclghdgnpm, null);
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x0000B8DA File Offset: 0x00009ADA
	public static Vector3[] QKGEPQNOCQE(this Camera EBINQJLDHPM, float LGCLGHDGNPM)
	{
		return EBINQJLDHPM.QKGEPQNOCQE(LGCLGHDGNPM, null);
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x0000B8E4 File Offset: 0x00009AE4
	public static Vector3[] QKGEPQNOCQE(this Camera EBINQJLDHPM, Transform ENOQKGBPJKQ)
	{
		return EBINQJLDHPM.QKGEPQNOCQE(Mathf.Lerp(EBINQJLDHPM.nearClipPlane, EBINQJLDHPM.farClipPlane, 0.5f), ENOQKGBPJKQ);
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x000A0D84 File Offset: 0x0009EF84
	public static Vector3[] QKGEPQNOCQE(this Camera EBINQJLDHPM, float LGCLGHDGNPM, Transform ENOQKGBPJKQ)
	{
		if (EBINQJLDHPM.orthographic)
		{
			float orthographicSize = EBINQJLDHPM.orthographicSize;
			float num = -orthographicSize;
			float num2 = orthographicSize;
			float y = -orthographicSize;
			float y2 = orthographicSize;
			Rect rect = EBINQJLDHPM.rect;
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num3 = fmdddqopbei.x / fmdddqopbei.y;
			num3 *= rect.width / rect.height;
			num *= num3;
			num2 *= num3;
			Transform transform = EBINQJLDHPM.transform;
			Quaternion rotation = transform.rotation;
			Vector3 position = transform.position;
			IKBQNBHOJJB.BGCNPFKJPFD[0] = rotation * new Vector3(num, y, LGCLGHDGNPM) + position;
			IKBQNBHOJJB.BGCNPFKJPFD[1] = rotation * new Vector3(num, y2, LGCLGHDGNPM) + position;
			IKBQNBHOJJB.BGCNPFKJPFD[2] = rotation * new Vector3(num2, y2, LGCLGHDGNPM) + position;
			IKBQNBHOJJB.BGCNPFKJPFD[3] = rotation * new Vector3(num2, y, LGCLGHDGNPM) + position;
		}
		else
		{
			IKBQNBHOJJB.BGCNPFKJPFD[0] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(0f, 0f, LGCLGHDGNPM));
			IKBQNBHOJJB.BGCNPFKJPFD[1] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(0f, 1f, LGCLGHDGNPM));
			IKBQNBHOJJB.BGCNPFKJPFD[2] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(1f, 1f, LGCLGHDGNPM));
			IKBQNBHOJJB.BGCNPFKJPFD[3] = EBINQJLDHPM.ViewportToWorldPoint(new Vector3(1f, 0f, LGCLGHDGNPM));
		}
		if (ENOQKGBPJKQ != null)
		{
			for (int i = 0; i < 4; i++)
			{
				IKBQNBHOJJB.BGCNPFKJPFD[i] = ENOQKGBPJKQ.InverseTransformPoint(IKBQNBHOJJB.BGCNPFKJPFD[i]);
			}
		}
		return IKBQNBHOJJB.BGCNPFKJPFD;
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x000A0F84 File Offset: 0x0009F184
	public static string NQNJPIEJJHM(object NJBFOQDJBON, string ECINLODLGQD)
	{
		if (NJBFOQDJBON == null)
		{
			return "<null>";
		}
		string text = NJBFOQDJBON.GetType().ToString();
		int num = text.LastIndexOf('/');
		if (num > 0)
		{
			text = text.Substring(num + 1);
		}
		return (!string.IsNullOrEmpty(ECINLODLGQD)) ? (text + "/" + ECINLODLGQD) : text;
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
	public static void CPGBBDIDOID<T>(GameObject CGHIENBIHCO, string OELBCGGGCIP) where T : Component
	{
		T[] components = CGHIENBIHCO.GetComponents<T>();
		foreach (T t in components)
		{
			MethodInfo method = t.GetType().GetMethod(OELBCGGGCIP, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (method != null)
			{
				method.Invoke(t, null);
			}
		}
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x000A1030 File Offset: 0x0009F230
	public static void QBDHMIQGJKE<T>(GameObject QOBPIJDBNGL, string OELBCGGGCIP) where T : Component
	{
		IKBQNBHOJJB.CPGBBDIDOID<T>(QOBPIJDBNGL, OELBCGGGCIP);
		Transform transform = QOBPIJDBNGL.transform;
		int i = 0;
		int childCount = transform.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.QBDHMIQGJKE<T>(transform.GetChild(i).gameObject, OELBCGGGCIP);
			i++;
		}
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x0000B903 File Offset: 0x00009B03
	public static void HKDGBGGNCOI(GameObject QOBPIJDBNGL)
	{
		IKBQNBHOJJB.QBDHMIQGJKE<ENFMCDNLEQQ>(QOBPIJDBNGL, "Start");
		IKBQNBHOJJB.QBDHMIQGJKE<KQHJOLQLQBJ>(QOBPIJDBNGL, "Start");
		IKBQNBHOJJB.QBDHMIQGJKE<ENFMCDNLEQQ>(QOBPIJDBNGL, "Update");
		IKBQNBHOJJB.QBDHMIQGJKE<KQHJOLQLQBJ>(QOBPIJDBNGL, "Update");
		IKBQNBHOJJB.QBDHMIQGJKE<KQHJOLQLQBJ>(QOBPIJDBNGL, "LateUpdate");
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x0600161B RID: 5659 RVA: 0x0000B93C File Offset: 0x00009B3C
	public static Vector2 FMDDDQOPBEI
	{
		get
		{
			return new Vector2((float)Screen.width, (float)Screen.height);
		}
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x000A1070 File Offset: 0x0009F270
	public static string PDFOGHMHNIK(KeyCode LOHECPFGPGO)
	{
		switch (LOHECPFGPGO)
		{
		case KeyCode.Keypad0:
			return "K0";
		case KeyCode.Keypad1:
			return "K1";
		case KeyCode.Keypad2:
			return "K2";
		case KeyCode.Keypad3:
			return "K3";
		case KeyCode.Keypad4:
			return "K4";
		case KeyCode.Keypad5:
			return "K5";
		case KeyCode.Keypad6:
			return "K6";
		case KeyCode.Keypad7:
			return "K7";
		case KeyCode.Keypad8:
			return "K8";
		case KeyCode.Keypad9:
			return "K9";
		case KeyCode.KeypadPeriod:
			return ".";
		case KeyCode.KeypadDivide:
			return "/";
		case KeyCode.KeypadMultiply:
			return "*";
		case KeyCode.KeypadMinus:
			return "-";
		case KeyCode.KeypadPlus:
			return "+";
		case KeyCode.KeypadEnter:
			return "NT";
		case KeyCode.KeypadEquals:
			return "=";
		case KeyCode.UpArrow:
			return "UP";
		case KeyCode.DownArrow:
			return "DN";
		case KeyCode.RightArrow:
			return "LT";
		case KeyCode.LeftArrow:
			return "RT";
		case KeyCode.Insert:
			return "Ins";
		case KeyCode.Home:
			return "Home";
		case KeyCode.End:
			return "End";
		case KeyCode.PageUp:
			return "PU";
		case KeyCode.PageDown:
			return "PD";
		case KeyCode.F1:
			return "F1";
		case KeyCode.F2:
			return "F2";
		case KeyCode.F3:
			return "F3";
		case KeyCode.F4:
			return "F4";
		case KeyCode.F5:
			return "F5";
		case KeyCode.F6:
			return "F6";
		case KeyCode.F7:
			return "F7";
		case KeyCode.F8:
			return "F8";
		case KeyCode.F9:
			return "F9";
		case KeyCode.F10:
			return "F10";
		case KeyCode.F11:
			return "F11";
		case KeyCode.F12:
			return "F12";
		case KeyCode.F13:
			return "F13";
		case KeyCode.F14:
			return "F14";
		case KeyCode.F15:
			return "F15";
		case KeyCode.Numlock:
			return "Num";
		case KeyCode.CapsLock:
			return "Cap";
		case KeyCode.ScrollLock:
			return "Scr";
		case KeyCode.RightShift:
			return "RS";
		case KeyCode.LeftShift:
			return "LS";
		case KeyCode.RightControl:
			return "RC";
		case KeyCode.LeftControl:
			return "LC";
		case KeyCode.RightAlt:
			return "RA";
		case KeyCode.LeftAlt:
			return "LA";
		case KeyCode.Mouse0:
			return "M0";
		case KeyCode.Mouse1:
			return "M1";
		case KeyCode.Mouse2:
			return "M2";
		case KeyCode.Mouse3:
			return "M3";
		case KeyCode.Mouse4:
			return "M4";
		case KeyCode.Mouse5:
			return "M5";
		case KeyCode.Mouse6:
			return "M6";
		case KeyCode.JoystickButton0:
			return "(A)";
		case KeyCode.JoystickButton1:
			return "(B)";
		case KeyCode.JoystickButton2:
			return "(X)";
		case KeyCode.JoystickButton3:
			return "(Y)";
		case KeyCode.JoystickButton4:
			return "(RB)";
		case KeyCode.JoystickButton5:
			return "(LB)";
		case KeyCode.JoystickButton6:
			return "(Back)";
		case KeyCode.JoystickButton7:
			return "(Start)";
		case KeyCode.JoystickButton8:
			return "(LS)";
		case KeyCode.JoystickButton9:
			return "(RS)";
		case KeyCode.JoystickButton10:
			return "J10";
		case KeyCode.JoystickButton11:
			return "J11";
		case KeyCode.JoystickButton12:
			return "J12";
		case KeyCode.JoystickButton13:
			return "J13";
		case KeyCode.JoystickButton14:
			return "J14";
		case KeyCode.JoystickButton15:
			return "J15";
		case KeyCode.JoystickButton16:
			return "J16";
		case KeyCode.JoystickButton17:
			return "J17";
		case KeyCode.JoystickButton18:
			return "J18";
		case KeyCode.JoystickButton19:
			return "J19";
		}
		switch (LOHECPFGPGO)
		{
		case KeyCode.Space:
			return "SP";
		case KeyCode.Exclaim:
			return "!";
		case KeyCode.DoubleQuote:
			return "\"";
		case KeyCode.Hash:
			return "#";
		case KeyCode.Dollar:
			return "$";
		case KeyCode.Ampersand:
			return "&";
		case KeyCode.Quote:
			return "'";
		case KeyCode.LeftParen:
			return "(";
		case KeyCode.RightParen:
			return ")";
		case KeyCode.Asterisk:
			return "*";
		case KeyCode.Plus:
			return "+";
		case KeyCode.Comma:
			return ",";
		case KeyCode.Minus:
			return "-";
		case KeyCode.Period:
			return ".";
		case KeyCode.Slash:
			return "/";
		case KeyCode.Alpha0:
			return "0";
		case KeyCode.Alpha1:
			return "1";
		case KeyCode.Alpha2:
			return "2";
		case KeyCode.Alpha3:
			return "3";
		case KeyCode.Alpha4:
			return "4";
		case KeyCode.Alpha5:
			return "5";
		case KeyCode.Alpha6:
			return "6";
		case KeyCode.Alpha7:
			return "7";
		case KeyCode.Alpha8:
			return "8";
		case KeyCode.Alpha9:
			return "9";
		case KeyCode.Colon:
			return ":";
		case KeyCode.Semicolon:
			return ";";
		case KeyCode.Less:
			return "<";
		case KeyCode.Equals:
			return "=";
		case KeyCode.Greater:
			return ">";
		case KeyCode.Question:
			return "?";
		case KeyCode.At:
			return "@";
		case KeyCode.LeftBracket:
			return "[";
		case KeyCode.Backslash:
			return "\\";
		case KeyCode.RightBracket:
			return "]";
		case KeyCode.Caret:
			return "^";
		case KeyCode.Underscore:
			return "_";
		case KeyCode.BackQuote:
			return "`";
		case KeyCode.A:
			return "A";
		case KeyCode.B:
			return "B";
		case KeyCode.C:
			return "C";
		case KeyCode.D:
			return "D";
		case KeyCode.E:
			return "E";
		case KeyCode.F:
			return "F";
		case KeyCode.G:
			return "G";
		case KeyCode.H:
			return "H";
		case KeyCode.I:
			return "I";
		case KeyCode.J:
			return "J";
		case KeyCode.K:
			return "K";
		case KeyCode.L:
			return "L";
		case KeyCode.M:
			return "M";
		case KeyCode.N:
			return "N0";
		case KeyCode.O:
			return "O";
		case KeyCode.P:
			return "P";
		case KeyCode.Q:
			return "Q";
		case KeyCode.R:
			return "R";
		case KeyCode.S:
			return "S";
		case KeyCode.T:
			return "T";
		case KeyCode.U:
			return "U";
		case KeyCode.V:
			return "V";
		case KeyCode.W:
			return "W";
		case KeyCode.X:
			return "X";
		case KeyCode.Y:
			return "Y";
		case KeyCode.Z:
			return "Z";
		case KeyCode.Delete:
			return "Del";
		}
		switch (LOHECPFGPGO)
		{
		case KeyCode.Backspace:
			return "BS";
		case KeyCode.Tab:
			return "Tab";
		case KeyCode.Clear:
			return "Clr";
		case KeyCode.Return:
			return "NT";
		}
		if (LOHECPFGPGO == KeyCode.None)
		{
			return null;
		}
		if (LOHECPFGPGO == KeyCode.Pause)
		{
			return "PS";
		}
		if (LOHECPFGPGO != KeyCode.Escape)
		{
			return null;
		}
		return "Esc";
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x000A1740 File Offset: 0x0009F940
	public static T MMGKEILQCJN<T>(string CIQFCJGQEMH, IKBQNBHOJJB<T>.BFCMKGOGOCN KECBLLGNKDQ = null) where T : ENFMCDNLEQQ
	{
		ENFMCDNLEQQ enfmcdnleqq;
		if (IKBQNBHOJJB.QJNJKLEMMLD.TryGetValue(CIQFCJGQEMH, out enfmcdnleqq) && enfmcdnleqq)
		{
			return (T)((object)enfmcdnleqq);
		}
		if (IKBQNBHOJJB.KLLHOMMGBLK == null)
		{
			EMENMKHBPQE x = null;
			GKDCBJPLQLQ gkdcbjplqlq = null;
			for (int i = 0; i < GKDCBJPLQLQ.NGDBDCQFDHI.Count; i++)
			{
				GKDCBJPLQLQ gkdcbjplqlq2 = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq2)
				{
					EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.FINJNKFMLMO(gkdcbjplqlq2.gameObject.layer);
					if (emenmkhbpqe && emenmkhbpqe.EQOOPGKHOFB.orthographic)
					{
						x = emenmkhbpqe;
						gkdcbjplqlq = gkdcbjplqlq2;
						IL_8F:
						if (x == null)
						{
							IKBQNBHOJJB.KLLHOMMGBLK = IKBQNBHOJJB.BPHPQEHMKOE(false, LayerMask.NameToLayer("UI"));
						}
						else
						{
							IKBQNBHOJJB.KLLHOMMGBLK = gkdcbjplqlq.gameObject.BFCKNMFEBDM<KQHJOLQLQBJ>();
						}
						IKBQNBHOJJB.KLLHOMMGBLK.LGCLGHDGNPM = 100000;
						IKBQNBHOJJB.DMNLFJLKGHJ = IKBQNBHOJJB.KLLHOMMGBLK.gameObject;
						IKBQNBHOJJB.DMNLFJLKGHJ.name = "Immediate Mode GUI";
						goto IL_EC;
					}
				}
			}
			goto IL_8F;
		}
		IL_EC:
		enfmcdnleqq = IKBQNBHOJJB.DMNLFJLKGHJ.MFIKGGPKKCD(int.MaxValue);
		enfmcdnleqq.name = CIQFCJGQEMH;
		IKBQNBHOJJB.QJNJKLEMMLD[CIQFCJGQEMH] = enfmcdnleqq;
		if (KECBLLGNKDQ != null)
		{
			KECBLLGNKDQ((T)((object)enfmcdnleqq));
		}
		return (T)((object)enfmcdnleqq);
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x000A1878 File Offset: 0x0009FA78
	public static Color CFLMGMLGPDO(this Color KQFEHQEBJQB)
	{
		if (IKBQNBHOJJB.HILLHGIEBFE == ColorSpace.Uninitialized)
		{
			IKBQNBHOJJB.HILLHGIEBFE = QualitySettings.activeColorSpace;
		}
		if (IKBQNBHOJJB.HILLHGIEBFE == ColorSpace.Linear)
		{
			return new Color(Mathf.GammaToLinearSpace(KQFEHQEBJQB.r), Mathf.GammaToLinearSpace(KQFEHQEBJQB.g), Mathf.GammaToLinearSpace(KQFEHQEBJQB.b), Mathf.GammaToLinearSpace(KQFEHQEBJQB.a));
		}
		return KQFEHQEBJQB;
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x000A18D8 File Offset: 0x0009FAD8
	// Note: this type is marked as 'beforefieldinit'.
	static IKBQNBHOJJB()
	{
		KeyCode[] array = new KeyCode[145];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-7FB9790B49277F6151D3EB5D555CCF105904DB43).FieldHandle);
		IKBQNBHOJJB.DCKGJEGBHME = array;
		IKBQNBHOJJB.QJNJKLEMMLD = new Dictionary<string, ENFMCDNLEQQ>();
		IKBQNBHOJJB.HILLHGIEBFE = ColorSpace.Uninitialized;
	}

	// Token: 0x0400040E RID: 1038
	private static AudioListener GCIGECOQLJD;

	// Token: 0x0400040F RID: 1039
	private static bool NPPOMNGEQPE = false;

	// Token: 0x04000410 RID: 1040
	private static float LEIQKCELCMG = 1f;

	// Token: 0x04000411 RID: 1041
	private static float HBIMFKBBCMM = 0f;

	// Token: 0x04000412 RID: 1042
	private static AudioClip QQJNBIBMKNJ;

	// Token: 0x04000413 RID: 1043
	private static Dictionary<Type, string> HJGHJDNQBBG = new Dictionary<Type, string>();

	// Token: 0x04000414 RID: 1044
	private static Vector3[] BGCNPFKJPFD = new Vector3[4];

	// Token: 0x04000415 RID: 1045
	public static KeyCode[] DCKGJEGBHME;

	// Token: 0x04000416 RID: 1046
	private static Dictionary<string, ENFMCDNLEQQ> QJNJKLEMMLD;

	// Token: 0x04000417 RID: 1047
	private static KQHJOLQLQBJ KLLHOMMGBLK;

	// Token: 0x04000418 RID: 1048
	private static GameObject DMNLFJLKGHJ;

	// Token: 0x04000419 RID: 1049
	private static ColorSpace HILLHGIEBFE;

	// Token: 0x0400041A RID: 1050
	[CompilerGenerated]
	private static Comparison<ENFMCDNLEQQ> BQIOGOCBKKB;

	// Token: 0x0400041B RID: 1051
	[CompilerGenerated]
	private static Comparison<KQHJOLQLQBJ> OMPIQDIBPKI;

	// Token: 0x020000A9 RID: 169
	// (Invoke) Token: 0x06001621 RID: 5665
	public delegate void BFCMKGOGOCN<T>(T OKQHFQFJGCH) where T : ENFMCDNLEQQ;
}
