using System;
using DynamicFogAndMist;
using UnityEngine;

// Token: 0x02000396 RID: 918
public class HKJFNMFPCMB : MonoBehaviour
{
	// Token: 0x06007B96 RID: 31638 RVA: 0x003AB6F8 File Offset: 0x003A98F8
	private void GEPPHKBENON(Collider JICGHJGIQKH)
	{
		if (!this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.KENQFJNMGDL)
			{
				this.NDBINJFPHNP = true;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.ONNIJPKFOLH(this.GOFFLIBLOEO, this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.LCHHLOCMEFC(this.LPNBHOHIEMM, this.GLCNGDEIDHM, this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.OGQBDFFDMOP(this.ECCBJFEDHOO, this.EPBQLBQLGOF, this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("Shop" + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007B97 RID: 31639 RVA: 0x003AB7F0 File Offset: 0x003A99F0
	private void FGKEBIEOPFP(Collider JICGHJGIQKH)
	{
		if (!this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.EEMLGKOOGJB())
			{
				this.NDBINJFPHNP = true;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.ONNIJPKFOLH(this.GOFFLIBLOEO, this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.BQOGNMGPIHN(this.LPNBHOHIEMM, this.GLCNGDEIDHM, this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.CHFPDGBKGOD(this.ECCBJFEDHOO, this.EPBQLBQLGOF, this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("The Pokémon can't use any held items." + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007B98 RID: 31640 RVA: 0x003AB8E8 File Offset: 0x003A9AE8
	private void DENDDIEILBC(Collider JICGHJGIQKH)
	{
		if (this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.EEMLGKOOGJB())
			{
				this.NDBINJFPHNP = true;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.IHLPOMDLEED(this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.NPOEFIKEMOM(this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.QGHOEPGGHIP(this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("blank" + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007B99 RID: 31641 RVA: 0x003AB9C0 File Offset: 0x003A9BC0
	private void OnTriggerExit(Collider JICGHJGIQKH)
	{
		if (this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.KENQFJNMGDL)
			{
				this.NDBINJFPHNP = false;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.IHLPOMDLEED(this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.EIOLECFDCPK(this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.ELEFGKBOLCD(this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("Fog Volume exited by " + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007B9A RID: 31642 RVA: 0x0002BB0D File Offset: 0x00029D0D
	private void QBGOGFJCLEP()
	{
		if (this.IFJJIENMNGD == null)
		{
			this.IFJJIENMNGD = HICINJKHLNP.HBFFCJHOCPE;
		}
		if (this.IFJJIENMNGD != null)
		{
			this.IFJJIENMNGD.LIJNQCKKGKK = false;
		}
	}

	// Token: 0x06007B9B RID: 31643 RVA: 0x0002BB0D File Offset: 0x00029D0D
	private void IKHIQQKHILB()
	{
		if (this.IFJJIENMNGD == null)
		{
			this.IFJJIENMNGD = HICINJKHLNP.HBFFCJHOCPE;
		}
		if (this.IFJJIENMNGD != null)
		{
			this.IFJJIENMNGD.LIJNQCKKGKK = false;
		}
	}

	// Token: 0x06007B9C RID: 31644 RVA: 0x003ABA98 File Offset: 0x003A9C98
	private void OnTriggerEnter(Collider JICGHJGIQKH)
	{
		if (!this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.KENQFJNMGDL)
			{
				this.NDBINJFPHNP = true;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.DNLMKPMOOEH(this.GOFFLIBLOEO, this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.LCHHLOCMEFC(this.LPNBHOHIEMM, this.GLCNGDEIDHM, this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.CHFPDGBKGOD(this.ECCBJFEDHOO, this.EPBQLBQLGOF, this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("Fog Volume entered by " + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007B9D RID: 31645 RVA: 0x003ABB90 File Offset: 0x003A9D90
	private void NOCJLJFKJEJ(Collider JICGHJGIQKH)
	{
		if (this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.KENQFJNMGDL)
			{
				this.NDBINJFPHNP = false;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.IHLPOMDLEED(this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.NPOEFIKEMOM(this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.CELJNHFKEJF(this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("substitute" + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007B9E RID: 31646 RVA: 0x0002BB0D File Offset: 0x00029D0D
	private void CIJOENOQKCI()
	{
		if (this.IFJJIENMNGD == null)
		{
			this.IFJJIENMNGD = HICINJKHLNP.HBFFCJHOCPE;
		}
		if (this.IFJJIENMNGD != null)
		{
			this.IFJJIENMNGD.LIJNQCKKGKK = false;
		}
	}

	// Token: 0x06007BA0 RID: 31648 RVA: 0x0002BB42 File Offset: 0x00029D42
	private void Start()
	{
		if (this.IFJJIENMNGD == null)
		{
			this.IFJJIENMNGD = HICINJKHLNP.HBFFCJHOCPE;
		}
		if (this.IFJJIENMNGD != null)
		{
			this.IFJJIENMNGD.LIJNQCKKGKK = true;
		}
	}

	// Token: 0x06007BA1 RID: 31649 RVA: 0x003ABCD0 File Offset: 0x003A9ED0
	private void QJHFGFMOOGP(Collider JICGHJGIQKH)
	{
		if (this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.KENQFJNMGDL)
			{
				this.NDBINJFPHNP = true;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.IHLPOMDLEED(this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.NPOEFIKEMOM(this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.ELEFGKBOLCD(this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("Prevents itself and ally Pokémon from falling asleep." + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007BA2 RID: 31650 RVA: 0x003ABDA8 File Offset: 0x003A9FA8
	private void QHKJFQONKDJ(Collider JICGHJGIQKH)
	{
		if (!this.NDBINJFPHNP && !(this.IFJJIENMNGD == null))
		{
			if (JICGHJGIQKH == this.HDOHBQLHLDK || JICGHJGIQKH.gameObject.transform.GetComponentInChildren<Camera>() == this.IFJJIENMNGD.KENQFJNMGDL)
			{
				this.NDBINJFPHNP = true;
				if (this.DPJEDMLNOCL && this.GOFFLIBLOEO != null)
				{
					this.IFJJIENMNGD.ONNIJPKFOLH(this.GOFFLIBLOEO, this.FQCECBMJCDB);
				}
				if (this.FIIDFEQQFFB)
				{
					this.IFJJIENMNGD.LCHHLOCMEFC(this.LPNBHOHIEMM, this.GLCNGDEIDHM, this.FQCECBMJCDB);
				}
				if (this.MDKNCNPNNGH)
				{
					this.IFJJIENMNGD.CHFPDGBKGOD(this.ECCBJFEDHOO, this.EPBQLBQLGOF, this.FQCECBMJCDB);
				}
				if (this.BQGGEGODCND)
				{
					Debug.Log("(S)" + JICGHJGIQKH.name);
				}
			}
			return;
		}
	}

	// Token: 0x06007BA3 RID: 31651 RVA: 0x0002BB0D File Offset: 0x00029D0D
	private void GBGEGKHDQKB()
	{
		if (this.IFJJIENMNGD == null)
		{
			this.IFJJIENMNGD = HICINJKHLNP.HBFFCJHOCPE;
		}
		if (this.IFJJIENMNGD != null)
		{
			this.IFJJIENMNGD.LIJNQCKKGKK = false;
		}
	}

	// Token: 0x04001AA7 RID: 6823
	private const float NPDMLCBDDDJ = 0.8901961f;

	// Token: 0x04001AA8 RID: 6824
	[Tooltip("Enables transition to a given profile.")]
	public bool DPJEDMLNOCL;

	// Token: 0x04001AA9 RID: 6825
	[Tooltip("Assign the transition profile.")]
	public DynamicFogProfile GOFFLIBLOEO;

	// Token: 0x04001AAA RID: 6826
	[Tooltip("Enables alpha transition.")]
	public bool FIIDFEQQFFB;

	// Token: 0x04001AAB RID: 6827
	[Range(0f, 1f)]
	[Tooltip("Target alpha for fog when camera enters this fog volume")]
	public float LPNBHOHIEMM = 0.5f;

	// Token: 0x04001AAC RID: 6828
	[Tooltip("Target alpha for sky haze when camera enters this fog volume")]
	[Range(0f, 1f)]
	public float GLCNGDEIDHM = 0.5f;

	// Token: 0x04001AAD RID: 6829
	[Tooltip("Enables fog color transition.")]
	public bool MDKNCNPNNGH;

	// Token: 0x04001AAE RID: 6830
	[Tooltip("Target fog color 1 when gamera enters this fog folume")]
	public Color ECCBJFEDHOO = new Color(0.8901961f, 0.8901961f, 0.8901961f);

	// Token: 0x04001AAF RID: 6831
	[Tooltip("Target fog color 2 when gamera enters this fog folume")]
	public Color EPBQLBQLGOF = new Color(0.8901961f, 0.8901961f, 0.8901961f);

	// Token: 0x04001AB0 RID: 6832
	[Tooltip("Set this to zero for changing fog alpha immediately upon enter/exit fog volume.")]
	public float FQCECBMJCDB = 3f;

	// Token: 0x04001AB1 RID: 6833
	[Tooltip("Set collider that will trigger this fog volume. If not set, this fog volume will react to any collider which has the main camera. If you use a third person controller, assign the character collider here.")]
	public Collider HDOHBQLHLDK;

	// Token: 0x04001AB2 RID: 6834
	[Tooltip("When enabled, a console message will be printed whenever this fog volume is entered or exited.")]
	public bool BQGGEGODCND;

	// Token: 0x04001AB3 RID: 6835
	[Tooltip("Assign target Dynamic Fog component that will be affected by this volume.")]
	public OCPDQGMMEMQ IFJJIENMNGD;

	// Token: 0x04001AB4 RID: 6836
	private bool NDBINJFPHNP;
}
