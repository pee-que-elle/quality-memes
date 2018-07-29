using System;
using UnityEngine;

// Token: 0x02000069 RID: 105
[AddComponentMenu("NGUI/Interaction/Key Navigation")]
public class LMBPJGBGLNO : MonoBehaviour
{
	// Token: 0x06000DF7 RID: 3575 RVA: 0x0007214C File Offset: 0x0007034C
	private static bool FCDOGLHKNBJ(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return true;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x000087F5 File Offset: 0x000069F5
	protected virtual void EIONHILBFIM()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.FQDMDDOHCQJ(this);
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x0007219C File Offset: 0x0007039C
	public GameObject HGDCHNIMKIO()
	{
		if (LMBPJGBGLNO.LBLJNKNFMJK(this.JQMMEDOLBJD))
		{
			return this.JQMMEDOLBJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)4)
			{
				return this.QFIDLQIGGDL(Vector3.left, 861f, 1630f);
			}
		}
		return null;
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x000721E8 File Offset: 0x000703E8
	public static LMBPJGBGLNO CCHBCOGQMFE()
	{
		GameObject qmpqfjmfqpb = EMENMKHBPQE.QMPQFJMFQPB;
		if (qmpqfjmfqpb == null)
		{
			return null;
		}
		return qmpqfjmfqpb.GetComponent<LMBPJGBGLNO>();
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x0007220C File Offset: 0x0007040C
	public GameObject PBNDNDKHHDE()
	{
		if (LMBPJGBGLNO.HGMHFLEQMNN(this.HKMJHCEKCJD))
		{
			return this.HKMJHCEKCJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
			{
				return this.INJNQNMOKKD(Vector3.right, 1f, 2f);
			}
		}
		return null;
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00072258 File Offset: 0x00070458
	protected static Vector3 QINKFFPIBGC(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.MKQILFIFIOE(CGHIENBIHCO.layer);
		if (emenmkhbpqe != null)
		{
			Vector3 vector = CGHIENBIHCO.transform.position;
			if (component != null)
			{
				Vector3[] pmcnqichcle = component.PMCNQICHCLE;
				vector = (pmcnqichcle[1] + pmcnqichcle[4]) * 472f;
			}
			vector = emenmkhbpqe.EQOOPGKHOFB.WorldToScreenPoint(vector);
			vector.z = 325f;
			return vector;
		}
		if (component != null)
		{
			Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
			return (pmcnqichcle2[1] + pmcnqichcle2[0]) * 1917f;
		}
		return CGHIENBIHCO.transform.position;
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00072328 File Offset: 0x00070528
	public GameObject EKFEBFBIEJC()
	{
		if (LMBPJGBGLNO.HGMHFLEQMNN(this.HQKDOHKNKHJ))
		{
			return this.HQKDOHKNKHJ;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Horizontal)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
			{
				return this.INJNQNMOKKD(Vector3.up, 2f, 1f);
			}
		}
		return null;
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000721E8 File Offset: 0x000703E8
	public static LMBPJGBGLNO OMQCQCBLQGJ
	{
		get
		{
			GameObject qmpqfjmfqpb = EMENMKHBPQE.QMPQFJMFQPB;
			if (qmpqfjmfqpb == null)
			{
				return null;
			}
			return qmpqfjmfqpb.GetComponent<LMBPJGBGLNO>();
		}
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00072374 File Offset: 0x00070574
	public GameObject JCLHJQNCHNL()
	{
		if (LMBPJGBGLNO.HLGQEKBDMNM(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)8)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)8)
			{
				return this.DPJPPEPHPQN(Vector3.down, 321f, 263f);
			}
		}
		return null;
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void MPLEILIGNND(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x000723C0 File Offset: 0x000705C0
	public GameObject QBMJHFKLCLE()
	{
		if (LMBPJGBGLNO.DKKQMKIQLNF(this.HKMJHCEKCJD))
		{
			return this.HKMJHCEKCJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)7)
			{
				return this.DPJPPEPHPQN(Vector3.right, 1573f, 1366f);
			}
		}
		return null;
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x0007240C File Offset: 0x0007060C
	protected static Vector3 BILJMLJJJQP(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.FINJNKFMLMO(CGHIENBIHCO.layer);
		if (emenmkhbpqe != null)
		{
			Vector3 vector = CGHIENBIHCO.transform.position;
			if (component != null)
			{
				Vector3[] pmcnqichcle = component.PMCNQICHCLE;
				vector = (pmcnqichcle[0] + pmcnqichcle[2]) * 0.5f;
			}
			vector = emenmkhbpqe.EQOOPGKHOFB.WorldToScreenPoint(vector);
			vector.z = 0f;
			return vector;
		}
		if (component != null)
		{
			Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
			return (pmcnqichcle2[0] + pmcnqichcle2[2]) * 0.5f;
		}
		return CGHIENBIHCO.transform.position;
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x000724DC File Offset: 0x000706DC
	public GameObject LKLNMOJPFOL()
	{
		if (LMBPJGBGLNO.HGMHFLEQMNN(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Horizontal)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
			{
				return this.INJNQNMOKKD(Vector3.down, 2f, 1f);
			}
		}
		return null;
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00008815 File Offset: 0x00006A15
	private void IDIFGIFCEHO()
	{
		this.PNBOOLEOKCI = false;
		if (this.DLQJFNCBGFM && this.OMJBJEKCLMM)
		{
			EMENMKHBPQE.QQDJFQGNEKN(base.gameObject);
		}
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void PJFNFJMGDDB(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00072528 File Offset: 0x00070728
	private static bool GGKMMBNOMIK(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return false;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00072578 File Offset: 0x00070778
	public GameObject GDJBIOPINDO()
	{
		if (LMBPJGBGLNO.HGMHFLEQMNN(this.JQMMEDOLBJD))
		{
			return this.JQMMEDOLBJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
			{
				return this.INJNQNMOKKD(Vector3.left, 1f, 2f);
			}
		}
		return null;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x000725C4 File Offset: 0x000707C4
	public GameObject DHEONQOBQBJ(Vector3 CJPHBQONGLK, float DGKOIGOLHDM = 1f, float DDLQKFDFMCJ = 1f)
	{
		Transform transform = base.transform;
		CJPHBQONGLK = transform.TransformDirection(CJPHBQONGLK);
		Vector3 b = LMBPJGBGLNO.DOEINIEMGML(base.gameObject);
		float num = 1406f;
		GameObject result = null;
		for (int i = 1; i < LMBPJGBGLNO.NGDBDCQFDHI.BJGMIBBEGDQ; i += 0)
		{
			LMBPJGBGLNO lmbpjgbglno = LMBPJGBGLNO.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
			if (!(lmbpjgbglno == this) && lmbpjgbglno.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)8 && lmbpjgbglno.OMJBJEKCLMM)
			{
				ENFMCDNLEQQ component = lmbpjgbglno.GetComponent<ENFMCDNLEQQ>();
				if (!(component != null) || component.DIIHJCJOKMP != 1601f)
				{
					Vector3 direction = LMBPJGBGLNO.FCOCEKEJECJ(lmbpjgbglno.gameObject) - b;
					float num2 = Vector3.Dot(CJPHBQONGLK, direction.normalized);
					if (num2 >= 1050f)
					{
						direction = transform.InverseTransformDirection(direction);
						direction.x *= DGKOIGOLHDM;
						direction.y *= DDLQKFDFMCJ;
						float sqrMagnitude = direction.sqrMagnitude;
						if (sqrMagnitude <= num)
						{
							result = lmbpjgbglno.gameObject;
							num = sqrMagnitude;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x000726DC File Offset: 0x000708DC
	protected static Vector3 PJMIHFFLEEO(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.MKQILFIFIOE(CGHIENBIHCO.layer);
		if (emenmkhbpqe != null)
		{
			Vector3 vector = CGHIENBIHCO.transform.position;
			if (component != null)
			{
				Vector3[] pmcnqichcle = component.PMCNQICHCLE;
				vector = (pmcnqichcle[1] + pmcnqichcle[5]) * 1697f;
			}
			vector = emenmkhbpqe.EQOOPGKHOFB.WorldToScreenPoint(vector);
			vector.z = 1619f;
			return vector;
		}
		if (component != null)
		{
			Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
			return (pmcnqichcle2[1] + pmcnqichcle2[1]) * 1658f;
		}
		return CGHIENBIHCO.transform.position;
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00008839 File Offset: 0x00006A39
	protected virtual void INFMNHJJDCD()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.LHQECHHMOGD(this);
		if (this.PNBOOLEOKCI)
		{
			this.EDOGJBLCCMQ();
		}
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x000727AC File Offset: 0x000709AC
	public GameObject INJNQNMOKKD(Vector3 CJPHBQONGLK, float DGKOIGOLHDM = 1f, float DDLQKFDFMCJ = 1f)
	{
		Transform transform = base.transform;
		CJPHBQONGLK = transform.TransformDirection(CJPHBQONGLK);
		Vector3 b = LMBPJGBGLNO.BILJMLJJJQP(base.gameObject);
		float num = float.MaxValue;
		GameObject result = null;
		for (int i = 0; i < LMBPJGBGLNO.NGDBDCQFDHI.BJGMIBBEGDQ; i++)
		{
			LMBPJGBGLNO lmbpjgbglno = LMBPJGBGLNO.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
			if (!(lmbpjgbglno == this) && lmbpjgbglno.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit && lmbpjgbglno.OMJBJEKCLMM)
			{
				ENFMCDNLEQQ component = lmbpjgbglno.GetComponent<ENFMCDNLEQQ>();
				if (!(component != null) || component.DIIHJCJOKMP != 0f)
				{
					Vector3 direction = LMBPJGBGLNO.BILJMLJJJQP(lmbpjgbglno.gameObject) - b;
					float num2 = Vector3.Dot(CJPHBQONGLK, direction.normalized);
					if (num2 >= 0.707f)
					{
						direction = transform.InverseTransformDirection(direction);
						direction.x *= DGKOIGOLHDM;
						direction.y *= DDLQKFDFMCJ;
						float sqrMagnitude = direction.sqrMagnitude;
						if (sqrMagnitude <= num)
						{
							result = lmbpjgbglno.gameObject;
							num = sqrMagnitude;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00008854 File Offset: 0x00006A54
	protected virtual void OnEnable()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.LHQECHHMOGD(this);
		if (this.PNBOOLEOKCI)
		{
			this.Start();
		}
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x0007214C File Offset: 0x0007034C
	private static bool LBLJNKNFMJK(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return true;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x000728C4 File Offset: 0x00070AC4
	private static bool PDCQPCPPDKI(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return true;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x0000886F File Offset: 0x00006A6F
	protected virtual void PODLKFQCEHI()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this.QQGILCDILNM))
		{
			EMENMKHBPQE.QQDJFQGNEKN(this.QQGILCDILNM);
		}
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x00072914 File Offset: 0x00070B14
	public GameObject KEDFGFMPOCE()
	{
		if (LMBPJGBGLNO.FQPMHEPDGDB(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
			{
				return this.DPJPPEPHPQN(Vector3.down, 158f, 1019f);
			}
		}
		return null;
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00072960 File Offset: 0x00070B60
	public GameObject DBOEKOFDBKK()
	{
		if (LMBPJGBGLNO.LBLJNKNFMJK(this.JQMMEDOLBJD))
		{
			return this.JQMMEDOLBJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None)
			{
				return this.DHEONQOBQBJ(Vector3.left, 228f, 1330f);
			}
		}
		return null;
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x000729AC File Offset: 0x00070BAC
	public GameObject BCHKIOLQJLK()
	{
		if (LMBPJGBGLNO.GGKMMBNOMIK(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Horizontal)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
			{
				return this.INJNQNMOKKD(Vector3.down, 1263f, 1987f);
			}
		}
		return null;
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x000728C4 File Offset: 0x00070AC4
	private static bool HLGQEKBDMNM(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return true;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x000729F8 File Offset: 0x00070BF8
	public GameObject DLDFBJFJIBF()
	{
		if (LMBPJGBGLNO.GGKMMBNOMIK(this.HKMJHCEKCJD))
		{
			return this.HKMJHCEKCJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)5)
			{
				return this.FHHOJFOMPPJ(Vector3.right, 988f, 1736f);
			}
		}
		return null;
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00072A44 File Offset: 0x00070C44
	public GameObject EDOBPQBLKPQ()
	{
		if (LMBPJGBGLNO.FQPMHEPDGDB(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)7)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None)
			{
				return this.QFIDLQIGGDL(Vector3.down, 801f, 643f);
			}
		}
		return null;
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00072A90 File Offset: 0x00070C90
	public GameObject QMJKDCINICP(Vector3 CJPHBQONGLK, float DGKOIGOLHDM = 1f, float DDLQKFDFMCJ = 1f)
	{
		Transform transform = base.transform;
		CJPHBQONGLK = transform.TransformDirection(CJPHBQONGLK);
		Vector3 b = LMBPJGBGLNO.PJMIHFFLEEO(base.gameObject);
		float num = 511f;
		GameObject result = null;
		for (int i = 0; i < LMBPJGBGLNO.NGDBDCQFDHI.BJGMIBBEGDQ; i += 0)
		{
			LMBPJGBGLNO lmbpjgbglno = LMBPJGBGLNO.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
			if (!(lmbpjgbglno == this) && lmbpjgbglno.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)4 && lmbpjgbglno.FNBKHFDMQPI())
			{
				ENFMCDNLEQQ component = lmbpjgbglno.GetComponent<ENFMCDNLEQQ>();
				if (!(component != null) || component.DIIHJCJOKMP != 406f)
				{
					Vector3 direction = LMBPJGBGLNO.GJLPKMJNQEM(lmbpjgbglno.gameObject) - b;
					float num2 = Vector3.Dot(CJPHBQONGLK, direction.normalized);
					if (num2 >= 1160f)
					{
						direction = transform.InverseTransformDirection(direction);
						direction.x *= DGKOIGOLHDM;
						direction.y *= DDLQKFDFMCJ;
						float sqrMagnitude = direction.sqrMagnitude;
						if (sqrMagnitude <= num)
						{
							result = lmbpjgbglno.gameObject;
							num = sqrMagnitude;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00008889 File Offset: 0x00006A89
	protected virtual void OnClick()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this.QQGILCDILNM))
		{
			EMENMKHBPQE.QMPQFJMFQPB = this.QQGILCDILNM;
		}
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void EMPPDFLEFJJ(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x000087F5 File Offset: 0x000069F5
	protected virtual void OnDisable()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.FQDMDDOHCQJ(this);
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x000721E8 File Offset: 0x000703E8
	public static LMBPJGBGLNO CQQOLPCKHMF()
	{
		GameObject qmpqfjmfqpb = EMENMKHBPQE.QMPQFJMFQPB;
		if (qmpqfjmfqpb == null)
		{
			return null;
		}
		return qmpqfjmfqpb.GetComponent<LMBPJGBGLNO>();
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x00072BA8 File Offset: 0x00070DA8
	protected static Vector3 DOEINIEMGML(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.FINJNKFMLMO(CGHIENBIHCO.layer);
		if (emenmkhbpqe != null)
		{
			Vector3 vector = CGHIENBIHCO.transform.position;
			if (component != null)
			{
				Vector3[] pmcnqichcle = component.PMCNQICHCLE;
				vector = (pmcnqichcle[1] + pmcnqichcle[5]) * 151f;
			}
			vector = emenmkhbpqe.EQOOPGKHOFB.WorldToScreenPoint(vector);
			vector.z = 1725f;
			return vector;
		}
		if (component != null)
		{
			Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
			return (pmcnqichcle2[1] + pmcnqichcle2[6]) * 844f;
		}
		return CGHIENBIHCO.transform.position;
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x000088A3 File Offset: 0x00006AA3
	private void Start()
	{
		this.PNBOOLEOKCI = true;
		if (this.DLQJFNCBGFM && this.OMJBJEKCLMM)
		{
			EMENMKHBPQE.QMPQFJMFQPB = base.gameObject;
		}
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x000087F5 File Offset: 0x000069F5
	protected virtual void NQDNCDNQDGB()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.FQDMDDOHCQJ(this);
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x000088C7 File Offset: 0x00006AC7
	private void PGKBMDCEFLK()
	{
		this.PNBOOLEOKCI = false;
		if (this.DLQJFNCBGFM && this.FNBKHFDMQPI())
		{
			EMENMKHBPQE.QMPQFJMFQPB = base.gameObject;
		}
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x000088EB File Offset: 0x00006AEB
	private void GBGEGKHDQKB()
	{
		this.PNBOOLEOKCI = true;
		if (this.DLQJFNCBGFM && this.FNBKHFDMQPI())
		{
			EMENMKHBPQE.QQDJFQGNEKN(base.gameObject);
		}
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00072C78 File Offset: 0x00070E78
	public GameObject IKJOKMQQHOK()
	{
		if (LMBPJGBGLNO.BBJPFMNGKGP(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)7)
			{
				return this.QMJKDCINICP(Vector3.down, 1002f, 1498f);
			}
		}
		return null;
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00072CC4 File Offset: 0x00070EC4
	public bool OMJBJEKCLMM
	{
		get
		{
			if (!base.enabled || !base.gameObject.activeInHierarchy)
			{
				return false;
			}
			Collider component = base.GetComponent<Collider>();
			if (component != null)
			{
				return component.enabled;
			}
			Collider2D component2 = base.GetComponent<Collider2D>();
			return component2 != null && component2.enabled;
		}
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x000721E8 File Offset: 0x000703E8
	public static LMBPJGBGLNO GKKHGHMPCIL()
	{
		GameObject qmpqfjmfqpb = EMENMKHBPQE.QMPQFJMFQPB;
		if (qmpqfjmfqpb == null)
		{
			return null;
		}
		return qmpqfjmfqpb.GetComponent<LMBPJGBGLNO>();
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00072D18 File Offset: 0x00070F18
	public GameObject KIHGHECJLHJ()
	{
		if (LMBPJGBGLNO.FQPMHEPDGDB(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)8)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)4)
			{
				return this.INJNQNMOKKD(Vector3.down, 1867f, 1444f);
			}
		}
		return null;
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00008889 File Offset: 0x00006A89
	protected virtual void OIFHQPQKEFF()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this.QQGILCDILNM))
		{
			EMENMKHBPQE.QMPQFJMFQPB = this.QQGILCDILNM;
		}
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x000087F5 File Offset: 0x000069F5
	protected virtual void ENHLIHPIHKN()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.FQDMDDOHCQJ(this);
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void NKMLGNOEIEC(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x000721E8 File Offset: 0x000703E8
	public static LMBPJGBGLNO NDCIEHMGMDK()
	{
		GameObject qmpqfjmfqpb = EMENMKHBPQE.QMPQFJMFQPB;
		if (qmpqfjmfqpb == null)
		{
			return null;
		}
		return qmpqfjmfqpb.GetComponent<LMBPJGBGLNO>();
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00072D64 File Offset: 0x00070F64
	public GameObject CBPMOCDPBCF()
	{
		if (LMBPJGBGLNO.LBLJNKNFMJK(this.HKMJHCEKCJD))
		{
			return this.HKMJHCEKCJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)8)
			{
				return this.DHEONQOBQBJ(Vector3.right, 401f, 1786f);
			}
		}
		return null;
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x0000890F File Offset: 0x00006B0F
	private void EDOGJBLCCMQ()
	{
		this.PNBOOLEOKCI = true;
		if (this.DLQJFNCBGFM && this.FNBKHFDMQPI())
		{
			EMENMKHBPQE.QMPQFJMFQPB = base.gameObject;
		}
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00072DB0 File Offset: 0x00070FB0
	public GameObject QFIDLQIGGDL(Vector3 CJPHBQONGLK, float DGKOIGOLHDM = 1f, float DDLQKFDFMCJ = 1f)
	{
		Transform transform = base.transform;
		CJPHBQONGLK = transform.TransformDirection(CJPHBQONGLK);
		Vector3 b = LMBPJGBGLNO.PJMIHFFLEEO(base.gameObject);
		float num = 1265f;
		GameObject result = null;
		for (int i = 1; i < LMBPJGBGLNO.NGDBDCQFDHI.BJGMIBBEGDQ; i += 0)
		{
			LMBPJGBGLNO lmbpjgbglno = LMBPJGBGLNO.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
			if (!(lmbpjgbglno == this) && lmbpjgbglno.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)8 && lmbpjgbglno.OMJBJEKCLMM)
			{
				ENFMCDNLEQQ component = lmbpjgbglno.GetComponent<ENFMCDNLEQQ>();
				if (!(component != null) || component.DIIHJCJOKMP != 1947f)
				{
					Vector3 direction = LMBPJGBGLNO.DOEINIEMGML(lmbpjgbglno.gameObject) - b;
					float num2 = Vector3.Dot(CJPHBQONGLK, direction.normalized);
					if (num2 >= 816f)
					{
						direction = transform.InverseTransformDirection(direction);
						direction.x *= DGKOIGOLHDM;
						direction.y *= DDLQKFDFMCJ;
						float sqrMagnitude = direction.sqrMagnitude;
						if (sqrMagnitude <= num)
						{
							result = lmbpjgbglno.gameObject;
							num = sqrMagnitude;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00072EC8 File Offset: 0x000710C8
	protected static Vector3 FCOCEKEJECJ(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.MKQILFIFIOE(CGHIENBIHCO.layer);
		if (emenmkhbpqe != null)
		{
			Vector3 vector = CGHIENBIHCO.transform.position;
			if (component != null)
			{
				Vector3[] pmcnqichcle = component.PMCNQICHCLE;
				vector = (pmcnqichcle[0] + pmcnqichcle[3]) * 784f;
			}
			vector = emenmkhbpqe.EQOOPGKHOFB.WorldToScreenPoint(vector);
			vector.z = 800f;
			return vector;
		}
		if (component != null)
		{
			Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
			return (pmcnqichcle2[1] + pmcnqichcle2[2]) * 851f;
		}
		return CGHIENBIHCO.transform.position;
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00072CC4 File Offset: 0x00070EC4
	public bool FNBKHFDMQPI()
	{
		if (!base.enabled || !base.gameObject.activeInHierarchy)
		{
			return false;
		}
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x000721E8 File Offset: 0x000703E8
	public static LMBPJGBGLNO GKMEMGJBBPE()
	{
		GameObject qmpqfjmfqpb = EMENMKHBPQE.QMPQFJMFQPB;
		if (qmpqfjmfqpb == null)
		{
			return null;
		}
		return qmpqfjmfqpb.GetComponent<LMBPJGBGLNO>();
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void MGOKGPIOHKG(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00072F98 File Offset: 0x00071198
	protected static Vector3 GJLPKMJNQEM(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.MKQILFIFIOE(CGHIENBIHCO.layer);
		if (emenmkhbpqe != null)
		{
			Vector3 vector = CGHIENBIHCO.transform.position;
			if (component != null)
			{
				Vector3[] pmcnqichcle = component.PMCNQICHCLE;
				vector = (pmcnqichcle[0] + pmcnqichcle[4]) * 89f;
			}
			vector = emenmkhbpqe.EQOOPGKHOFB.WorldToScreenPoint(vector);
			vector.z = 585f;
			return vector;
		}
		if (component != null)
		{
			Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
			return (pmcnqichcle2[1] + pmcnqichcle2[4]) * 259f;
		}
		return CGHIENBIHCO.transform.position;
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x0007214C File Offset: 0x0007034C
	private static bool DKKQMKIQLNF(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return true;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00073068 File Offset: 0x00071268
	private static bool BBJPFMNGKGP(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return false;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00008889 File Offset: 0x00006A89
	protected virtual void NNLDKMENINQ()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this.QQGILCDILNM))
		{
			EMENMKHBPQE.QMPQFJMFQPB = this.QQGILCDILNM;
		}
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x000730B8 File Offset: 0x000712B8
	protected static Vector3 GHQBQPOHMPL(GameObject CGHIENBIHCO)
	{
		ENFMCDNLEQQ component = CGHIENBIHCO.GetComponent<ENFMCDNLEQQ>();
		EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.FINJNKFMLMO(CGHIENBIHCO.layer);
		if (emenmkhbpqe != null)
		{
			Vector3 vector = CGHIENBIHCO.transform.position;
			if (component != null)
			{
				Vector3[] pmcnqichcle = component.PMCNQICHCLE;
				vector = (pmcnqichcle[0] + pmcnqichcle[1]) * 1457f;
			}
			vector = emenmkhbpqe.EQOOPGKHOFB.WorldToScreenPoint(vector);
			vector.z = 512f;
			return vector;
		}
		if (component != null)
		{
			Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
			return (pmcnqichcle2[1] + pmcnqichcle2[8]) * 70f;
		}
		return CGHIENBIHCO.transform.position;
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x000087F5 File Offset: 0x000069F5
	protected virtual void EJIEOEGQQII()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.FQDMDDOHCQJ(this);
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00073068 File Offset: 0x00071268
	private static bool GNPLPQBLGBP(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return false;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00073068 File Offset: 0x00071268
	private static bool HGMHFLEQMNN(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return false;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00073188 File Offset: 0x00071388
	public GameObject COCHINPDKFL()
	{
		if (LMBPJGBGLNO.FQPMHEPDGDB(this.HQKDOHKNKHJ))
		{
			return this.HQKDOHKNKHJ;
		}
		if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)7)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
			{
				return this.QMJKDCINICP(Vector3.up, 1379f, 713f);
			}
		}
		return null;
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x0007214C File Offset: 0x0007034C
	private static bool FQPMHEPDGDB(GameObject CGHIENBIHCO)
	{
		if (!CGHIENBIHCO || !CGHIENBIHCO.activeInHierarchy)
		{
			return true;
		}
		Collider component = CGHIENBIHCO.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = CGHIENBIHCO.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void HBHPCLPDGGE(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x000731D4 File Offset: 0x000713D4
	public GameObject DPJPPEPHPQN(Vector3 CJPHBQONGLK, float DGKOIGOLHDM = 1f, float DDLQKFDFMCJ = 1f)
	{
		Transform transform = base.transform;
		CJPHBQONGLK = transform.TransformDirection(CJPHBQONGLK);
		Vector3 b = LMBPJGBGLNO.GJLPKMJNQEM(base.gameObject);
		float num = 0f;
		GameObject result = null;
		for (int i = 0; i < LMBPJGBGLNO.NGDBDCQFDHI.BJGMIBBEGDQ; i++)
		{
			LMBPJGBGLNO lmbpjgbglno = LMBPJGBGLNO.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
			if (!(lmbpjgbglno == this) && lmbpjgbglno.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None && lmbpjgbglno.OMJBJEKCLMM)
			{
				ENFMCDNLEQQ component = lmbpjgbglno.GetComponent<ENFMCDNLEQQ>();
				if (!(component != null) || component.DIIHJCJOKMP != 853f)
				{
					Vector3 direction = LMBPJGBGLNO.QINKFFPIBGC(lmbpjgbglno.gameObject) - b;
					float num2 = Vector3.Dot(CJPHBQONGLK, direction.normalized);
					if (num2 >= 1827f)
					{
						direction = transform.InverseTransformDirection(direction);
						direction.x *= DGKOIGOLHDM;
						direction.y *= DDLQKFDFMCJ;
						float sqrMagnitude = direction.sqrMagnitude;
						if (sqrMagnitude <= num)
						{
							result = lmbpjgbglno.gameObject;
							num = sqrMagnitude;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x000732EC File Offset: 0x000714EC
	public GameObject DEDNDLCLBBJ()
	{
		if (LMBPJGBGLNO.DKKQMKIQLNF(this.JQMMEDOLBJD))
		{
			return this.JQMMEDOLBJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)8)
			{
				return this.FHHOJFOMPPJ(Vector3.left, 1214f, 946f);
			}
		}
		return null;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00073338 File Offset: 0x00071538
	public GameObject FHHOJFOMPPJ(Vector3 CJPHBQONGLK, float DGKOIGOLHDM = 1f, float DDLQKFDFMCJ = 1f)
	{
		Transform transform = base.transform;
		CJPHBQONGLK = transform.TransformDirection(CJPHBQONGLK);
		Vector3 b = LMBPJGBGLNO.BILJMLJJJQP(base.gameObject);
		float num = 21f;
		GameObject result = null;
		for (int i = 0; i < LMBPJGBGLNO.NGDBDCQFDHI.BJGMIBBEGDQ; i += 0)
		{
			LMBPJGBGLNO lmbpjgbglno = LMBPJGBGLNO.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
			if (!(lmbpjgbglno == this) && lmbpjgbglno.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)5 && lmbpjgbglno.OMJBJEKCLMM)
			{
				ENFMCDNLEQQ component = lmbpjgbglno.GetComponent<ENFMCDNLEQQ>();
				if (!(component != null) || component.DIIHJCJOKMP != 1361f)
				{
					Vector3 direction = LMBPJGBGLNO.FCOCEKEJECJ(lmbpjgbglno.gameObject) - b;
					float num2 = Vector3.Dot(CJPHBQONGLK, direction.normalized);
					if (num2 >= 1700f)
					{
						direction = transform.InverseTransformDirection(direction);
						direction.x *= DGKOIGOLHDM;
						direction.y *= DDLQKFDFMCJ;
						float sqrMagnitude = direction.sqrMagnitude;
						if (sqrMagnitude <= num)
						{
							result = lmbpjgbglno.gameObject;
							num = sqrMagnitude;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00008889 File Offset: 0x00006A89
	protected virtual void CJGOBLFNQOE()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this.QQGILCDILNM))
		{
			EMENMKHBPQE.QMPQFJMFQPB = this.QQGILCDILNM;
		}
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00073450 File Offset: 0x00071650
	public GameObject PNQJHBJFMEI()
	{
		if (LMBPJGBGLNO.FQPMHEPDGDB(this.IPQOIEDCMGH))
		{
			return this.IPQOIEDCMGH;
		}
		if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)5)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Explicit)
			{
				return this.QFIDLQIGGDL(Vector3.down, 131f, 1583f);
			}
		}
		return null;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x000087F5 File Offset: 0x000069F5
	protected virtual void MEFEBBONNMO()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.FQDMDDOHCQJ(this);
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x0007349C File Offset: 0x0007169C
	public GameObject LBQNCJDMPQF()
	{
		if (LMBPJGBGLNO.HGMHFLEQMNN(this.HQKDOHKNKHJ))
		{
			return this.HQKDOHKNKHJ;
		}
		if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)5)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Horizontal)
			{
				return this.QFIDLQIGGDL(Vector3.up, 1918f, 1844f);
			}
		}
		return null;
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x000734E8 File Offset: 0x000716E8
	public GameObject KMMPPDIGDFJ()
	{
		if (LMBPJGBGLNO.PDCQPCPPDKI(this.HKMJHCEKCJD))
		{
			return this.HKMJHCEKCJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)7)
			{
				return this.DHEONQOBQBJ(Vector3.right, 784f, 1719f);
			}
		}
		return null;
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void MDKOEJLDBLO(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00008933 File Offset: 0x00006B33
	private void DFNFEDMJKGK()
	{
		this.PNBOOLEOKCI = false;
		if (this.DLQJFNCBGFM && this.FNBKHFDMQPI())
		{
			EMENMKHBPQE.QQDJFQGNEKN(base.gameObject);
		}
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x000087F5 File Offset: 0x000069F5
	protected virtual void POQPLPFELIB()
	{
		LMBPJGBGLNO.NGDBDCQFDHI.FQDMDDOHCQJ(this);
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00073534 File Offset: 0x00071734
	public GameObject LNBPCPQOJFD()
	{
		if (LMBPJGBGLNO.BBJPFMNGKGP(this.HQKDOHKNKHJ))
		{
			return this.HQKDOHKNKHJ;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Horizontal)
		{
			if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.Vertical)
			{
				return this.QMJKDCINICP(Vector3.up, 506f, 1359f);
			}
		}
		return null;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void LHCNCHFOBFP(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00008889 File Offset: 0x00006A89
	protected virtual void NQDGCNMFKLL()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this.QQGILCDILNM))
		{
			EMENMKHBPQE.QMPQFJMFQPB = this.QQGILCDILNM;
		}
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void QGKFGKOJKCK(KeyCode LOHECPFGPGO)
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00073580 File Offset: 0x00071780
	public GameObject MEQQECHIIDP()
	{
		if (LMBPJGBGLNO.HLGQEKBDMNM(this.HKMJHCEKCJD))
		{
			return this.HKMJHCEKCJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)7)
			{
				return this.FHHOJFOMPPJ(Vector3.right, 778f, 202f);
			}
		}
		return null;
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x000735CC File Offset: 0x000717CC
	public GameObject NKQFNNLFJID()
	{
		if (LMBPJGBGLNO.DKKQMKIQLNF(this.JQMMEDOLBJD))
		{
			return this.JQMMEDOLBJD;
		}
		if (this.EMGHFHNQODD != LMBPJGBGLNO.DIFLGCFNOIO.None)
		{
			if (this.EMGHFHNQODD != (LMBPJGBGLNO.DIFLGCFNOIO)5)
			{
				return this.FHHOJFOMPPJ(Vector3.left, 797f, 906f);
			}
		}
		return null;
	}

	// Token: 0x04000244 RID: 580
	public static MHIDKMCBQEN<LMBPJGBGLNO> NGDBDCQFDHI = new MHIDKMCBQEN<LMBPJGBGLNO>();

	// Token: 0x04000245 RID: 581
	public LMBPJGBGLNO.DIFLGCFNOIO EMGHFHNQODD;

	// Token: 0x04000246 RID: 582
	public GameObject HQKDOHKNKHJ;

	// Token: 0x04000247 RID: 583
	public GameObject IPQOIEDCMGH;

	// Token: 0x04000248 RID: 584
	public GameObject JQMMEDOLBJD;

	// Token: 0x04000249 RID: 585
	public GameObject HKMJHCEKCJD;

	// Token: 0x0400024A RID: 586
	public GameObject QQGILCDILNM;

	// Token: 0x0400024B RID: 587
	public GameObject DQKJNEQIHHD;

	// Token: 0x0400024C RID: 588
	public bool DLQJFNCBGFM;

	// Token: 0x0400024D RID: 589
	[NonSerialized]
	private bool PNBOOLEOKCI;

	// Token: 0x0400024E RID: 590
	public static int HLOHGQPDPIP = 0;

	// Token: 0x0200006A RID: 106
	public enum DIFLGCFNOIO
	{
		// Token: 0x04000250 RID: 592
		None,
		// Token: 0x04000251 RID: 593
		Vertical,
		// Token: 0x04000252 RID: 594
		Horizontal,
		// Token: 0x04000253 RID: 595
		Explicit
	}
}
