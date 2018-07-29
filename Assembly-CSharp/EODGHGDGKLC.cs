using System;
using UnityEngine;

// Token: 0x020001C2 RID: 450
public class EODGHGDGKLC : MonoBehaviour
{
	// Token: 0x06003921 RID: 14625 RVA: 0x0001895C File Offset: 0x00016B5C
	public void HCNPIJLODQE(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.PIDLOFMIEFQ = DBEPQKEMJOP;
	}

	// Token: 0x06003922 RID: 14626 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void QPFQFPPGING(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003923 RID: 14627 RVA: 0x001B195C File Offset: 0x001AFB5C
	private void CIJOENOQKCI()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = true;
		}
	}

	// Token: 0x06003924 RID: 14628 RVA: 0x001B195C File Offset: 0x001AFB5C
	private void MJPQJHEEPMD()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = true;
		}
	}

	// Token: 0x06003925 RID: 14629 RVA: 0x001B195C File Offset: 0x001AFB5C
	private void LMMGEGJCBJP()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = true;
		}
	}

	// Token: 0x06003926 RID: 14630 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void KEBEJMQCIPD(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003927 RID: 14631 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void OOKDMLIMCCI(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003928 RID: 14632 RVA: 0x001B19E0 File Offset: 0x001AFBE0
	private void LQFEFNKLPBG()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(81f, 480f, 1130f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x06003929 RID: 14633 RVA: 0x001B1A74 File Offset: 0x001AFC74
	private void FOPKBNIOGCP()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = false;
		}
	}

	// Token: 0x0600392A RID: 14634 RVA: 0x001B1AF8 File Offset: 0x001AFCF8
	private void DFNNNMDQEPH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 736f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.OICQJKBHFFP(false);
	}

	// Token: 0x0600392B RID: 14635 RVA: 0x0001895C File Offset: 0x00016B5C
	public void LKPMIMNCNBD(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.PIDLOFMIEFQ = DBEPQKEMJOP;
	}

	// Token: 0x0600392C RID: 14636 RVA: 0x001B1A74 File Offset: 0x001AFC74
	private void GBGEGKHDQKB()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = false;
		}
	}

	// Token: 0x0600392D RID: 14637 RVA: 0x0001896A File Offset: 0x00016B6A
	public void NFQQKDKMKNG(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.LKPOBCBOFIC(DBEPQKEMJOP);
	}

	// Token: 0x0600392E RID: 14638 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void DKBPNMEGMQM(bool DEJBMFBECJG)
	{
	}

	// Token: 0x0600392F RID: 14639 RVA: 0x0001896A File Offset: 0x00016B6A
	public void NQBKFDJFBKG(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.LKPOBCBOFIC(DBEPQKEMJOP);
	}

	// Token: 0x06003930 RID: 14640 RVA: 0x001B1BF8 File Offset: 0x001AFDF8
	private void PDHLMMEBECL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 105f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.DPCGJCMJFND(false);
	}

	// Token: 0x06003931 RID: 14641 RVA: 0x001B1CF8 File Offset: 0x001AFEF8
	private void KQECLIPLJNM()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1064f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.DKBPNMEGMQM(false);
	}

	// Token: 0x06003932 RID: 14642 RVA: 0x001B1DF8 File Offset: 0x001AFFF8
	private void KQPHQNNDCNP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1980f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BOOENOMOJBO(false);
	}

	// Token: 0x06003933 RID: 14643 RVA: 0x001B1EF8 File Offset: 0x001B00F8
	private void MHDGGOODPGB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 188f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.KEBEJMQCIPD(false);
	}

	// Token: 0x06003934 RID: 14644 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BOOENOMOJBO(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003935 RID: 14645 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void OICQJKBHFFP(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003936 RID: 14646 RVA: 0x001B1FF8 File Offset: 0x001B01F8
	private void IPKCDQONLBJ()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(790f, 1792f, 859f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x06003937 RID: 14647 RVA: 0x001B208C File Offset: 0x001B028C
	private void LBIJFCFPKNM()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(849f, 264f, 1968f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x06003938 RID: 14648 RVA: 0x001B2120 File Offset: 0x001B0320
	private void JENKEGOEEHO()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1608f, 10f, 1978f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x0600393A RID: 14650 RVA: 0x001B195C File Offset: 0x001AFB5C
	private void DHLGDLOKLKN()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = true;
		}
	}

	// Token: 0x0600393B RID: 14651 RVA: 0x0001895C File Offset: 0x00016B5C
	public void BJHKMOOFKQM(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.PIDLOFMIEFQ = DBEPQKEMJOP;
	}

	// Token: 0x0600393C RID: 14652 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BHEIGFIPNKN(bool DEJBMFBECJG)
	{
	}

	// Token: 0x0600393D RID: 14653 RVA: 0x001B21B4 File Offset: 0x001B03B4
	private void ILMKLDICQKK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 482f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BHEIGFIPNKN(false);
	}

	// Token: 0x0600393E RID: 14654 RVA: 0x001B22B4 File Offset: 0x001B04B4
	private void DFBJNPDMPHE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 924f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BOIOGNMBEGD(false);
	}

	// Token: 0x0600393F RID: 14655 RVA: 0x001B195C File Offset: 0x001AFB5C
	private void DFNFEDMJKGK()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = true;
		}
	}

	// Token: 0x06003940 RID: 14656 RVA: 0x0001895C File Offset: 0x00016B5C
	public void PHMFLFMPLJF(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.PIDLOFMIEFQ = DBEPQKEMJOP;
	}

	// Token: 0x06003941 RID: 14657 RVA: 0x001B1A74 File Offset: 0x001AFC74
	private void HBOFMLLODDM()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = false;
		}
	}

	// Token: 0x06003942 RID: 14658 RVA: 0x0001895C File Offset: 0x00016B5C
	public void NJFKDIBLGPO(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.PIDLOFMIEFQ = DBEPQKEMJOP;
	}

	// Token: 0x06003943 RID: 14659 RVA: 0x001B23B4 File Offset: 0x001B05B4
	private void KMNECEKIKIH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1424f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BOIOGNMBEGD(false);
	}

	// Token: 0x06003944 RID: 14660 RVA: 0x001B24B4 File Offset: 0x001B06B4
	private void IMIQKINDQIP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 927f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.OICQJKBHFFP(true);
	}

	// Token: 0x06003945 RID: 14661 RVA: 0x001B25B4 File Offset: 0x001B07B4
	private void PKKKQBOGGPK()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(55f, 1960f, 401f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x06003946 RID: 14662 RVA: 0x0001895C File Offset: 0x00016B5C
	public void EQPKPPMDGGD(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.PIDLOFMIEFQ = DBEPQKEMJOP;
	}

	// Token: 0x06003947 RID: 14663 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BOIOGNMBEGD(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003948 RID: 14664 RVA: 0x001B2648 File Offset: 0x001B0848
	private void PCHJHFGCOCK()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(830f, 853f, 574f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x06003949 RID: 14665 RVA: 0x001B26DC File Offset: 0x001B08DC
	private void BCEKGNDIIOE()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(623f, 1737f, 278f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x0600394A RID: 14666 RVA: 0x001B2770 File Offset: 0x001B0970
	private void JIMBLQBBDKO()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(144f, 268f, 633f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x0600394B RID: 14667 RVA: 0x001B2804 File Offset: 0x001B0A04
	private void HMQOONLDOLQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 929f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.KEBEJMQCIPD(false);
	}

	// Token: 0x0600394C RID: 14668 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void ODNPFCOPBON(bool DEJBMFBECJG)
	{
	}

	// Token: 0x0600394D RID: 14669 RVA: 0x0001895C File Offset: 0x00016B5C
	public void NONQODKMGNM(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.PIDLOFMIEFQ = DBEPQKEMJOP;
	}

	// Token: 0x0600394E RID: 14670 RVA: 0x001B2904 File Offset: 0x001B0B04
	private void BDBFHKHJOIG()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 597f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BOOENOMOJBO(true);
	}

	// Token: 0x0600394F RID: 14671 RVA: 0x001B2A04 File Offset: 0x001B0C04
	private void LateUpdate()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 0f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BOIOGNMBEGD(true);
	}

	// Token: 0x06003950 RID: 14672 RVA: 0x001B2B04 File Offset: 0x001B0D04
	private void QDPMFNCLPGH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 146f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BOOENOMOJBO(false);
	}

	// Token: 0x06003951 RID: 14673 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void NMDIEPKDOHC(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003952 RID: 14674 RVA: 0x001B2C04 File Offset: 0x001B0E04
	private void KHEJGQPPFOC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 905f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.KEBEJMQCIPD(true);
	}

	// Token: 0x06003953 RID: 14675 RVA: 0x001B2D04 File Offset: 0x001B0F04
	private void PKPBBHDPBBC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 515f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.KEBEJMQCIPD(false);
	}

	// Token: 0x06003954 RID: 14676 RVA: 0x001B2E04 File Offset: 0x001B1004
	private void Awake()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(-1000f, 1000f, 0f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
	}

	// Token: 0x06003955 RID: 14677 RVA: 0x001B2E98 File Offset: 0x001B1098
	private void NMLIGFLNGNF()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 477f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BHEIGFIPNKN(true);
	}

	// Token: 0x06003956 RID: 14678 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void DPCGJCMJFND(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003957 RID: 14679 RVA: 0x001B2F98 File Offset: 0x001B1198
	private void DGDOHDIPPOK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = false;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1460f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.ODNPFCOPBON(true);
	}

	// Token: 0x06003958 RID: 14680 RVA: 0x001B1A74 File Offset: 0x001AFC74
	private void Start()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			base.enabled = false;
		}
	}

	// Token: 0x06003959 RID: 14681 RVA: 0x0001896A File Offset: 0x00016B6A
	public void LJIFBJFLEJH(string DBEPQKEMJOP)
	{
		this.DGENOHPIECM.LKPOBCBOFIC(DBEPQKEMJOP);
	}

	// Token: 0x0600395A RID: 14682 RVA: 0x001B3098 File Offset: 0x001B1298
	private void MHIHPBPGELB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.MKGLBOOCIEM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.JCGOHGILCFB && !this.IINIOEQDNMI)
		{
			this.IINIOEQDNMI = true;
			if (this.ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBGPKBQEEN == 0)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1153f;
		this.BLLEFKOLKLP.localPosition = vector;
		this.BOOENOMOJBO(false);
	}

	// Token: 0x04000D35 RID: 3381
	public Vector3 LCMMCNFNHMF = Vector3.zero;

	// Token: 0x04000D36 RID: 3382
	public Transform ILBCCCBJNCL;

	// Token: 0x04000D37 RID: 3383
	public Camera KCOMMGMLLEE;

	// Token: 0x04000D38 RID: 3384
	public Camera CODFIINNNPG;

	// Token: 0x04000D39 RID: 3385
	public BKKHLBCLPJM DGENOHPIECM;

	// Token: 0x04000D3A RID: 3386
	private Transform BLLEFKOLKLP;

	// Token: 0x04000D3B RID: 3387
	public bool JCGOHGILCFB;

	// Token: 0x04000D3C RID: 3388
	private bool IINIOEQDNMI;

	// Token: 0x04000D3D RID: 3389
	public bool MKGLBOOCIEM;
}
