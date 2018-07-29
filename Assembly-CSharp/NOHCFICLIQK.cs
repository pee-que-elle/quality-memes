using System;
using UnityEngine;

// Token: 0x020001F4 RID: 500
public class NOHCFICLIQK : MonoBehaviour
{
	// Token: 0x0600417D RID: 16765 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BOIOGNMBEGD(bool DEJBMFBECJG)
	{
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x0001BECA File Offset: 0x0001A0CA
	private void FPDFPHQPJIH()
	{
		this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
		this.GJCJDPCPNHM = false;
	}

	// Token: 0x0600417F RID: 16767 RVA: 0x001FCC20 File Offset: 0x001FAE20
	public void PDEFMHJIKMO()
	{
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = CNCJKLNHQBH.QOQONHOOLNE.HNGFCMGOBBG;
		}
		if (this.IEICJDEDICD == null)
		{
			return;
		}
		if (this.DFMCFGLQLNL != null && this.DFMCFGLQLNL != string.Empty)
		{
			Texture2D texture2D = this.IEICJDEDICD.CILNDLMBNHI(this.DFMCFGLQLNL, this.EBDMBIIOKFJ);
			if (texture2D != null)
			{
				this.HKLENFFCEEQ.GOIHJQNMMJD = texture2D;
			}
			if (!(this.HKLENFFCEEQ.GOIHJQNMMJD == null) && !(this.HKLENFFCEEQ.GOIHJQNMMJD == this.IEICJDEDICD.GIOGJMFFEEE))
			{
				if (!this.HKLENFFCEEQ.gameObject.activeSelf)
				{
					this.HKLENFFCEEQ.gameObject.SetActive(true);
					this.DDBEHDDEPHI();
					if (this.KCOMMGMLLEE != null)
					{
						Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
						base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
						vector = this.BLLEFKOLKLP.localPosition;
						vector.x = (float)Mathf.FloorToInt(vector.x);
						vector.y = (float)Mathf.FloorToInt(vector.y);
						vector.z = 1496f;
						this.BLLEFKOLKLP.localPosition = vector;
					}
				}
			}
			else if (this.HKLENFFCEEQ.gameObject.activeSelf)
			{
				this.HKLENFFCEEQ.gameObject.SetActive(false);
				this.DDBEHDDEPHI();
			}
			return;
		}
		this.HKLENFFCEEQ.gameObject.SetActive(false);
		this.DDBEHDDEPHI();
	}

	// Token: 0x06004180 RID: 16768 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void EHDIJEHKFFH(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06004181 RID: 16769 RVA: 0x001FCDE4 File Offset: 0x001FAFE4
	public void QKKQCHQHHPH()
	{
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = CNCJKLNHQBH.QOQONHOOLNE.HNGFCMGOBBG;
		}
		if (this.IEICJDEDICD == null)
		{
			return;
		}
		if (this.DFMCFGLQLNL != null && this.DFMCFGLQLNL != string.Empty)
		{
			Texture2D texture2D = this.IEICJDEDICD.CILNDLMBNHI(this.DFMCFGLQLNL, this.EBDMBIIOKFJ);
			if (texture2D != null)
			{
				this.HKLENFFCEEQ.GOIHJQNMMJD = texture2D;
			}
			if (!(this.HKLENFFCEEQ.GOIHJQNMMJD == null) && !(this.HKLENFFCEEQ.GOIHJQNMMJD == this.IEICJDEDICD.GIOGJMFFEEE))
			{
				if (!this.HKLENFFCEEQ.gameObject.activeSelf)
				{
					this.HKLENFFCEEQ.gameObject.SetActive(false);
					this.JJMDLPEJOCK();
					if (this.KCOMMGMLLEE != null)
					{
						Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
						base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
						vector = this.BLLEFKOLKLP.localPosition;
						vector.x = (float)Mathf.FloorToInt(vector.x);
						vector.y = (float)Mathf.FloorToInt(vector.y);
						vector.z = 147f;
						this.BLLEFKOLKLP.localPosition = vector;
					}
				}
			}
			else if (this.HKLENFFCEEQ.gameObject.activeSelf)
			{
				this.HKLENFFCEEQ.gameObject.SetActive(false);
				this.DDBEHDDEPHI();
			}
			return;
		}
		this.HKLENFFCEEQ.gameObject.SetActive(false);
		this.JJMDLPEJOCK();
	}

	// Token: 0x06004182 RID: 16770 RVA: 0x001FCFA8 File Offset: 0x001FB1A8
	private void PGIDCBGCGMP(bool QJFQOMOIOOI)
	{
		bool flag = QJFQOMOIOOI;
		if (!this.JCCOEDFNKFP)
		{
			QJFQOMOIOOI = false;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			if (this.BLLEFKOLKLP.GetChild(i).gameObject != this.LIQFBHNQCID.gameObject)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			}
			else if (!this.JCCOEDFNKFP)
			{
				if (!flag)
				{
					IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, flag);
				}
			}
			else if (!this.DIEMCOMFBIN)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			}
			i++;
		}
		if (QJFQOMOIOOI)
		{
			this.JJMDLPEJOCK();
		}
	}

	// Token: 0x06004183 RID: 16771 RVA: 0x001FD070 File Offset: 0x001FB270
	private void BPKIFMDEDLL(bool QJFQOMOIOOI)
	{
		bool flag = QJFQOMOIOOI;
		if (!this.JCCOEDFNKFP)
		{
			QJFQOMOIOOI = true;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			if (this.BLLEFKOLKLP.GetChild(i).gameObject != this.LIQFBHNQCID.gameObject)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			}
			else if (!this.JCCOEDFNKFP)
			{
				if (!flag)
				{
					IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, flag);
				}
			}
			else if (!this.DIEMCOMFBIN)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			}
			i += 0;
		}
		if (QJFQOMOIOOI)
		{
			this.QHEHOGIGNKH();
		}
	}

	// Token: 0x06004184 RID: 16772 RVA: 0x0001BECA File Offset: 0x0001A0CA
	private void FindGameCamera()
	{
		this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
		this.GJCJDPCPNHM = false;
	}

	// Token: 0x06004185 RID: 16773 RVA: 0x001FD138 File Offset: 0x001FB338
	public void GMFNGEPKPME()
	{
		this.FFCCCEFBQKG.LGCLGHDGNPM = this.DOHBLEJJIQO;
		this.HKLENFFCEEQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 2;
		this.BIPQGMJJNOF.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
		this.LGJMJDIQCFC.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.KIEMMQDMIIO.LGCLGHDGNPM = this.DOHBLEJJIQO;
	}

	// Token: 0x06004186 RID: 16774 RVA: 0x0001BEEE File Offset: 0x0001A0EE
	public void GPDOFLIGFFO(string DBEPQKEMJOP, string NPBLFIMGOPL = "")
	{
		this.LGJMJDIQCFC.PIDLOFMIEFQ = NPBLFIMGOPL;
		this.BIPQGMJJNOF.LKPOBCBOFIC(DBEPQKEMJOP);
		this.QHEHOGIGNKH();
	}

	// Token: 0x06004187 RID: 16775 RVA: 0x0001BF0E File Offset: 0x0001A10E
	public void LLFFGNKFKJB(string DBEPQKEMJOP, string NPBLFIMGOPL = "")
	{
		this.LGJMJDIQCFC.LKPOBCBOFIC(NPBLFIMGOPL);
		this.BIPQGMJJNOF.LKPOBCBOFIC(DBEPQKEMJOP);
		this.DDBEHDDEPHI();
	}

	// Token: 0x06004188 RID: 16776 RVA: 0x001FD1B4 File Offset: 0x001FB3B4
	public void ONOOKCBOPEF(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < 31)
		{
			base.CancelInvoke("HideEmote");
			this.LIQFBHNQCID.KCLBMPFIPNQ = CIQFCJGQEMH.ToString();
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.GEMEQGBOLIP().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.GEMEQGBOLIP().height;
			this.LIQFBHNQCID.gameObject.SetActive(true);
			base.Invoke("HideEmote", MOGLGJGFNDM);
			if (this.KCOMMGMLLEE != null)
			{
				Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
				base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
				vector = this.BLLEFKOLKLP.localPosition;
				vector.x = (float)Mathf.FloorToInt(vector.x);
				vector.y = (float)Mathf.FloorToInt(vector.y);
				vector.z = 0f;
				this.BLLEFKOLKLP.localPosition = vector;
			}
		}
	}

	// Token: 0x06004189 RID: 16777 RVA: 0x001FD2E8 File Offset: 0x001FB4E8
	private void LateUpdate()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.FLHBMIMMJOK)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			if (!this.QHGBCGLGCJH)
			{
				if (!this.GJCJDPCPNHM)
				{
					this.GJCJDPCPNHM = true;
					base.Invoke("FindGameCamera", 1f);
				}
				return;
			}
			this.KCOMMGMLLEE = JQOIHHDIHBN.QOQONHOOLNE.ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (this.KCOMMGMLLEE.orthographic || vector.z > 0f) && (!this.EELFHGNCLKO || (vector.x > 0f && vector.x < 1f && vector.y > 0f && vector.y < 1f));
		if (this.DIEMCOMFBIN != flag)
		{
			this.PGIDCBGCGMP(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 0f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.BOIOGNMBEGD(true);
	}

	// Token: 0x0600418A RID: 16778 RVA: 0x001FD464 File Offset: 0x001FB664
	public void QHEHOGIGNKH()
	{
		int num = 0;
		if (this.LGJMJDIQCFC.PIDLOFMIEFQ != string.Empty)
		{
			this.LGJMJDIQCFC.gameObject.SetActive(true);
			num += this.LGJMJDIQCFC.KJGMGPCEJJD;
			this.BMQQQBEQFQB.transform.localPosition = Vector3.zero;
		}
		else
		{
			this.LGJMJDIQCFC.gameObject.SetActive(false);
			this.BMQQQBEQFQB.GLPQKBOKFDG.x = 157f;
			this.BMQQQBEQFQB.transform.localPosition = Vector3.zero;
		}
		num += this.BIPQGMJJNOF.KJGMGPCEJJD + 3;
		this.BMQQQBEQFQB.EQEDOQJJGLM();
		this.FFCCCEFBQKG.KJGMGPCEJJD = num;
	}

	// Token: 0x0600418B RID: 16779 RVA: 0x0001BF2E File Offset: 0x0001A12E
	private void LPIIDDCPLQI()
	{
		this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
		this.GJCJDPCPNHM = true;
	}

	// Token: 0x0600418C RID: 16780 RVA: 0x001FD524 File Offset: 0x001FB724
	public void POHBDNPCEFH()
	{
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = CNCJKLNHQBH.QOQONHOOLNE.HNGFCMGOBBG;
		}
		if (this.IEICJDEDICD == null)
		{
			return;
		}
		if (this.DFMCFGLQLNL != null && this.DFMCFGLQLNL != string.Empty)
		{
			Texture2D texture2D = this.IEICJDEDICD.IOCCGFNLFOB(this.DFMCFGLQLNL, this.EBDMBIIOKFJ);
			if (texture2D != null)
			{
				this.HKLENFFCEEQ.GOIHJQNMMJD = texture2D;
			}
			if (!(this.HKLENFFCEEQ.GOIHJQNMMJD == null) && !(this.HKLENFFCEEQ.GOIHJQNMMJD == this.IEICJDEDICD.GIOGJMFFEEE))
			{
				if (!this.HKLENFFCEEQ.gameObject.activeSelf)
				{
					this.HKLENFFCEEQ.gameObject.SetActive(false);
					this.QHEHOGIGNKH();
					if (this.KCOMMGMLLEE != null)
					{
						Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
						base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
						vector = this.BLLEFKOLKLP.localPosition;
						vector.x = (float)Mathf.FloorToInt(vector.x);
						vector.y = (float)Mathf.FloorToInt(vector.y);
						vector.z = 251f;
						this.BLLEFKOLKLP.localPosition = vector;
					}
				}
			}
			else if (this.HKLENFFCEEQ.gameObject.activeSelf)
			{
				this.HKLENFFCEEQ.gameObject.SetActive(false);
				this.JJMDLPEJOCK();
			}
			return;
		}
		this.HKLENFFCEEQ.gameObject.SetActive(false);
		this.QHEHOGIGNKH();
	}

	// Token: 0x0600418D RID: 16781 RVA: 0x001FD6E8 File Offset: 0x001FB8E8
	public void GPJHOFPFCJD()
	{
		this.FFCCCEFBQKG.LGCLGHDGNPM = this.DOHBLEJJIQO;
		this.HKLENFFCEEQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 8;
		this.BIPQGMJJNOF.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
		this.LGJMJDIQCFC.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.KIEMMQDMIIO.LGCLGHDGNPM = this.DOHBLEJJIQO;
	}

	// Token: 0x0600418F RID: 16783 RVA: 0x0001BF7A File Offset: 0x0001A17A
	public void HCNPIJLODQE(string DBEPQKEMJOP, string NPBLFIMGOPL = "")
	{
		this.LGJMJDIQCFC.PIDLOFMIEFQ = NPBLFIMGOPL;
		this.BIPQGMJJNOF.PIDLOFMIEFQ = DBEPQKEMJOP;
		this.JJMDLPEJOCK();
	}

	// Token: 0x06004190 RID: 16784 RVA: 0x001FD764 File Offset: 0x001FB964
	public void DLNCPGGNBGJ()
	{
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = CNCJKLNHQBH.MOGQNGEPCEO().HNGFCMGOBBG;
		}
		if (this.IEICJDEDICD == null)
		{
			return;
		}
		if (this.DFMCFGLQLNL != null && this.DFMCFGLQLNL != string.Empty)
		{
			Texture2D texture2D = this.IEICJDEDICD.ELDCDCOLJJE(this.DFMCFGLQLNL, this.EBDMBIIOKFJ);
			if (texture2D != null)
			{
				this.HKLENFFCEEQ.GOIHJQNMMJD = texture2D;
			}
			if (!(this.HKLENFFCEEQ.GOIHJQNMMJD == null) && !(this.HKLENFFCEEQ.GOIHJQNMMJD == this.IEICJDEDICD.GIOGJMFFEEE))
			{
				if (!this.HKLENFFCEEQ.gameObject.activeSelf)
				{
					this.HKLENFFCEEQ.gameObject.SetActive(true);
					this.QHEHOGIGNKH();
					if (this.KCOMMGMLLEE != null)
					{
						Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
						base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
						vector = this.BLLEFKOLKLP.localPosition;
						vector.x = (float)Mathf.FloorToInt(vector.x);
						vector.y = (float)Mathf.FloorToInt(vector.y);
						vector.z = 977f;
						this.BLLEFKOLKLP.localPosition = vector;
					}
				}
			}
			else if (this.HKLENFFCEEQ.gameObject.activeSelf)
			{
				this.HKLENFFCEEQ.gameObject.SetActive(false);
				this.JJMDLPEJOCK();
			}
			return;
		}
		this.HKLENFFCEEQ.gameObject.SetActive(false);
		this.DDBEHDDEPHI();
	}

	// Token: 0x06004191 RID: 16785 RVA: 0x001FD928 File Offset: 0x001FBB28
	private void CPNQCCCNPMM()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.FLHBMIMMJOK)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			if (!this.QHGBCGLGCJH)
			{
				if (!this.GJCJDPCPNHM)
				{
					this.GJCJDPCPNHM = true;
					base.Invoke("heartswap", 275f);
				}
				return;
			}
			this.KCOMMGMLLEE = JQOIHHDIHBN.GFJGPNOPEPC().ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (!this.KCOMMGMLLEE.orthographic && vector.z <= 1684f) || !this.EELFHGNCLKO || (vector.x > 1866f && vector.x < 1355f && vector.y > 1768f && vector.y < 447f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.LINNPNNOQKP(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 961f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.BOIOGNMBEGD(false);
	}

	// Token: 0x06004192 RID: 16786 RVA: 0x0001BF9A File Offset: 0x0001A19A
	private void HideEmote()
	{
		this.LIQFBHNQCID.gameObject.SetActive(false);
	}

	// Token: 0x06004193 RID: 16787 RVA: 0x0001BFAD File Offset: 0x0001A1AD
	public void OOCFKMHHFQJ()
	{
		this.JCCOEDFNKFP = true;
	}

	// Token: 0x06004194 RID: 16788 RVA: 0x0001BFAD File Offset: 0x0001A1AD
	public void KOFODQHILKG()
	{
		this.JCCOEDFNKFP = true;
	}

	// Token: 0x06004195 RID: 16789 RVA: 0x0001BFB6 File Offset: 0x0001A1B6
	public void QHQKHCHLEMJ()
	{
		this.JCCOEDFNKFP = false;
	}

	// Token: 0x06004196 RID: 16790 RVA: 0x001FDAA4 File Offset: 0x001FBCA4
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
			this.PGIDCBGCGMP(false);
		}
		else
		{
			Debug.LogError("Expected to have 'target' set to a valid transform", this);
			base.enabled = false;
		}
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 4;
		this.GMFNGEPKPME();
	}

	// Token: 0x06004197 RID: 16791 RVA: 0x0001BFAD File Offset: 0x0001A1AD
	public void GCPMQMCCCEG()
	{
		this.JCCOEDFNKFP = true;
	}

	// Token: 0x06004198 RID: 16792 RVA: 0x001FDB48 File Offset: 0x001FBD48
	public void HLQDJGEGDKJ()
	{
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = CNCJKLNHQBH.QOQONHOOLNE.HNGFCMGOBBG;
		}
		if (this.IEICJDEDICD == null)
		{
			return;
		}
		if (this.DFMCFGLQLNL != null && this.DFMCFGLQLNL != string.Empty)
		{
			Texture2D texture2D = this.IEICJDEDICD.QEHBPIBLFQJ(this.DFMCFGLQLNL, this.EBDMBIIOKFJ);
			if (texture2D != null)
			{
				this.HKLENFFCEEQ.GOIHJQNMMJD = texture2D;
			}
			if (!(this.HKLENFFCEEQ.GOIHJQNMMJD == null) && !(this.HKLENFFCEEQ.GOIHJQNMMJD == this.IEICJDEDICD.GIOGJMFFEEE))
			{
				if (!this.HKLENFFCEEQ.gameObject.activeSelf)
				{
					this.HKLENFFCEEQ.gameObject.SetActive(true);
					this.JJMDLPEJOCK();
					if (this.KCOMMGMLLEE != null)
					{
						Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
						base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
						vector = this.BLLEFKOLKLP.localPosition;
						vector.x = (float)Mathf.FloorToInt(vector.x);
						vector.y = (float)Mathf.FloorToInt(vector.y);
						vector.z = 389f;
						this.BLLEFKOLKLP.localPosition = vector;
					}
				}
			}
			else if (this.HKLENFFCEEQ.gameObject.activeSelf)
			{
				this.HKLENFFCEEQ.gameObject.SetActive(true);
				this.DDBEHDDEPHI();
			}
			return;
		}
		this.HKLENFFCEEQ.gameObject.SetActive(false);
		this.QHEHOGIGNKH();
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x001FDD0C File Offset: 0x001FBF0C
	public void GFDLGLIGQDE()
	{
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = CNCJKLNHQBH.MOGQNGEPCEO().HNGFCMGOBBG;
		}
		if (this.IEICJDEDICD == null)
		{
			return;
		}
		if (this.DFMCFGLQLNL != null && this.DFMCFGLQLNL != string.Empty)
		{
			Texture2D texture2D = this.IEICJDEDICD.CLHBLLFPJMN(this.DFMCFGLQLNL, this.EBDMBIIOKFJ);
			if (texture2D != null)
			{
				this.HKLENFFCEEQ.GOIHJQNMMJD = texture2D;
			}
			if (!(this.HKLENFFCEEQ.GOIHJQNMMJD == null) && !(this.HKLENFFCEEQ.GOIHJQNMMJD == this.IEICJDEDICD.GIOGJMFFEEE))
			{
				if (!this.HKLENFFCEEQ.gameObject.activeSelf)
				{
					this.HKLENFFCEEQ.gameObject.SetActive(true);
					this.QHEHOGIGNKH();
					if (this.KCOMMGMLLEE != null)
					{
						Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
						base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
						vector = this.BLLEFKOLKLP.localPosition;
						vector.x = (float)Mathf.FloorToInt(vector.x);
						vector.y = (float)Mathf.FloorToInt(vector.y);
						vector.z = 1814f;
						this.BLLEFKOLKLP.localPosition = vector;
					}
				}
			}
			else if (this.HKLENFFCEEQ.gameObject.activeSelf)
			{
				this.HKLENFFCEEQ.gameObject.SetActive(false);
				this.DDBEHDDEPHI();
			}
			return;
		}
		this.HKLENFFCEEQ.gameObject.SetActive(true);
		this.QHEHOGIGNKH();
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x001FDED0 File Offset: 0x001FC0D0
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
			this.PGIDCBGCGMP(false);
		}
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x001FDF6C File Offset: 0x001FC16C
	public void JJMDLPEJOCK()
	{
		int num = 0;
		if (this.LGJMJDIQCFC.PIDLOFMIEFQ != string.Empty)
		{
			this.LGJMJDIQCFC.gameObject.SetActive(true);
			num += this.LGJMJDIQCFC.KJGMGPCEJJD;
			this.BMQQQBEQFQB.transform.localPosition = Vector3.zero;
		}
		else
		{
			this.LGJMJDIQCFC.gameObject.SetActive(false);
			this.BMQQQBEQFQB.GLPQKBOKFDG.x = 0f;
			this.BMQQQBEQFQB.transform.localPosition = Vector3.zero;
		}
		num += this.BIPQGMJJNOF.KJGMGPCEJJD + 8;
		this.BMQQQBEQFQB.Reposition();
		this.FFCCCEFBQKG.KJGMGPCEJJD = num;
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x001FE02C File Offset: 0x001FC22C
	private void LINNPNNOQKP(bool QJFQOMOIOOI)
	{
		bool flag = QJFQOMOIOOI;
		if (!this.JCCOEDFNKFP)
		{
			QJFQOMOIOOI = false;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			if (this.BLLEFKOLKLP.GetChild(i).gameObject != this.LIQFBHNQCID.gameObject)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			}
			else if (!this.JCCOEDFNKFP)
			{
				if (!flag)
				{
					IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, flag);
				}
			}
			else if (!this.DIEMCOMFBIN)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			}
			i++;
		}
		if (QJFQOMOIOOI)
		{
			this.JJMDLPEJOCK();
		}
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x0001BFAD File Offset: 0x0001A1AD
	public void FHQDPGIGFOI()
	{
		this.JCCOEDFNKFP = true;
	}

	// Token: 0x0600419E RID: 16798 RVA: 0x001FE0F4 File Offset: 0x001FC2F4
	public void EIOMPOHLEMC()
	{
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = CNCJKLNHQBH.QOQONHOOLNE.HNGFCMGOBBG;
		}
		if (this.IEICJDEDICD == null)
		{
			return;
		}
		if (this.DFMCFGLQLNL != null && this.DFMCFGLQLNL != string.Empty)
		{
			Texture2D texture2D = this.IEICJDEDICD.CLHBLLFPJMN(this.DFMCFGLQLNL, this.EBDMBIIOKFJ);
			if (texture2D != null)
			{
				this.HKLENFFCEEQ.GOIHJQNMMJD = texture2D;
			}
			if (!(this.HKLENFFCEEQ.GOIHJQNMMJD == null) && !(this.HKLENFFCEEQ.GOIHJQNMMJD == this.IEICJDEDICD.GIOGJMFFEEE))
			{
				if (!this.HKLENFFCEEQ.gameObject.activeSelf)
				{
					this.HKLENFFCEEQ.gameObject.SetActive(true);
					this.JJMDLPEJOCK();
					if (this.KCOMMGMLLEE != null)
					{
						Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
						base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
						vector = this.BLLEFKOLKLP.localPosition;
						vector.x = (float)Mathf.FloorToInt(vector.x);
						vector.y = (float)Mathf.FloorToInt(vector.y);
						vector.z = 0f;
						this.BLLEFKOLKLP.localPosition = vector;
					}
				}
			}
			else if (this.HKLENFFCEEQ.gameObject.activeSelf)
			{
				this.HKLENFFCEEQ.gameObject.SetActive(false);
				this.JJMDLPEJOCK();
			}
			return;
		}
		this.HKLENFFCEEQ.gameObject.SetActive(false);
		this.JJMDLPEJOCK();
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x001FE2B8 File Offset: 0x001FC4B8
	private void KPKQNOCFGIB()
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
			this.LINNPNNOQKP(false);
		}
		else
		{
			Debug.LogError("Battle", this);
			base.enabled = true;
		}
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 8;
		this.GPJHOFPFCJD();
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x001FE35C File Offset: 0x001FC55C
	public void DDBEHDDEPHI()
	{
		int num = 0;
		if (this.LGJMJDIQCFC.PIDLOFMIEFQ != string.Empty)
		{
			this.LGJMJDIQCFC.gameObject.SetActive(true);
			num += this.LGJMJDIQCFC.KJGMGPCEJJD;
			this.BMQQQBEQFQB.transform.localPosition = Vector3.zero;
		}
		else
		{
			this.LGJMJDIQCFC.gameObject.SetActive(true);
			this.BMQQQBEQFQB.GLPQKBOKFDG.x = 1526f;
			this.BMQQQBEQFQB.transform.localPosition = Vector3.zero;
		}
		num += this.BIPQGMJJNOF.KJGMGPCEJJD + 8;
		this.BMQQQBEQFQB.EQEDOQJJGLM();
		this.FFCCCEFBQKG.KJGMGPCEJJD = num;
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x0001BFBF File Offset: 0x0001A1BF
	public void LEKHHDCQQOM(string DBEPQKEMJOP, string NPBLFIMGOPL = "")
	{
		this.LGJMJDIQCFC.LKPOBCBOFIC(NPBLFIMGOPL);
		this.BIPQGMJJNOF.PIDLOFMIEFQ = DBEPQKEMJOP;
		this.QHEHOGIGNKH();
	}

	// Token: 0x04000E3E RID: 3646
	public Vector3 LCMMCNFNHMF = Vector3.zero;

	// Token: 0x04000E3F RID: 3647
	public Transform ILBCCCBJNCL;

	// Token: 0x04000E40 RID: 3648
	public Camera KCOMMGMLLEE;

	// Token: 0x04000E41 RID: 3649
	public Camera CODFIINNNPG;

	// Token: 0x04000E42 RID: 3650
	public bool EELFHGNCLKO = true;

	// Token: 0x04000E43 RID: 3651
	private Transform BLLEFKOLKLP;

	// Token: 0x04000E44 RID: 3652
	private bool DIEMCOMFBIN;

	// Token: 0x04000E45 RID: 3653
	public JFDJLDBQQKC BMQQQBEQFQB;

	// Token: 0x04000E46 RID: 3654
	public string DFMCFGLQLNL;

	// Token: 0x04000E47 RID: 3655
	public int EBDMBIIOKFJ;

	// Token: 0x04000E48 RID: 3656
	private NOHEMGHONKK IEICJDEDICD;

	// Token: 0x04000E49 RID: 3657
	public PLQFPBQEPJD LIQFBHNQCID;

	// Token: 0x04000E4A RID: 3658
	public ENFMCDNLEQQ FFCCCEFBQKG;

	// Token: 0x04000E4B RID: 3659
	public JLMPBLMOICG HKLENFFCEEQ;

	// Token: 0x04000E4C RID: 3660
	public BKKHLBCLPJM BIPQGMJJNOF;

	// Token: 0x04000E4D RID: 3661
	public BKKHLBCLPJM LGJMJDIQCFC;

	// Token: 0x04000E4E RID: 3662
	public PLQFPBQEPJD KIEMMQDMIIO;

	// Token: 0x04000E4F RID: 3663
	public int DOHBLEJJIQO;

	// Token: 0x04000E50 RID: 3664
	private bool JCCOEDFNKFP = true;

	// Token: 0x04000E51 RID: 3665
	public bool FLHBMIMMJOK = true;

	// Token: 0x04000E52 RID: 3666
	private bool GJCJDPCPNHM;

	// Token: 0x04000E53 RID: 3667
	public bool QHGBCGLGCJH;
}
