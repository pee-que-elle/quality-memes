using System;
using UnityEngine;

// Token: 0x0200005A RID: 90
[AddComponentMenu("NGUI/Interaction/Draggable Camera")]
[RequireComponent(typeof(Camera))]
public class DCKCEQMMONE : MonoBehaviour
{
	// Token: 0x06000C42 RID: 3138 RVA: 0x000690E4 File Offset: 0x000672E4
	public void QEFICOPJJFM(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 1572f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x0006913C File Offset: 0x0006733C
	public void HKDMFHQBIOC(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = false;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.JCGLMKGEJQG();
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (392f * this.ILKGGGEDGOE), 1706f);
		if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.Momentum && this.JNCOQFQJPJI(false))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 1923f;
		}
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00069218 File Offset: 0x00067418
	public void JBKCHGQLENL(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = false;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 1687f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = true;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring)
			{
				this.EKNKHIOBDIJ(true);
			}
		}
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00069298 File Offset: 0x00067498
	private void KEGBCBGIHHJ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "[urn=", this);
			base.enabled = true;
		}
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00069300 File Offset: 0x00067500
	public void HBOMONFOKNH(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = false;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 133f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum)
			{
				this.LBQOHFLCCBE(false);
			}
		}
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00069380 File Offset: 0x00067580
	public void MFQPOKHILEH(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = true;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 868f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else if (this.NNFKGOHBEHF == (CGINEOGDPGP.DHDOBNJKEPM)5)
			{
				this.KDLNMFDOHMC(true);
			}
		}
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00069400 File Offset: 0x00067600
	public void GLKGPMJDDPL(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = true;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 544f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = true;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None)
			{
				this.EKNKHIOBDIJ(false);
			}
		}
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void NPLPEKDFKPP(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00069480 File Offset: 0x00067680
	public void MNLKJCONMCO(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = false;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.PNBFQDLQENI;
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (660f * this.ILKGGGEDGOE), 111f);
		if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)3 && this.EKNKHIOBDIJ(true))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 933f;
		}
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x0006955C File Offset: 0x0006775C
	private void CPJJKJLFOEN()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Player/Clothe", this);
			base.enabled = true;
		}
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x000695C4 File Offset: 0x000677C4
	private void HGKPKMMIPLG()
	{
		float gpfidejemeg = JMIOBJFFGBN.PPIKCLHKEIH();
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = true;
			}
			this.HCLBPEMQFBO = 1027f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 1275f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 595f, 1508f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 1698f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1185f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.KDLNMFDOHMC(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 242f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1991f, gpfidejemeg);
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x000696E0 File Offset: 0x000678E0
	public bool EKNKHIOBDIJ(bool OGFDJFCDCLJ)
	{
		if (this.BLLEFKOLKLP != null && this.IHKLDMFDFKE != null)
		{
			Vector3 b = this.DOOOFEPEOQG();
			if (b.sqrMagnitude > 327f)
			{
				if (OGFDJFCDCLJ)
				{
					this.BLLEFKOLKLP.position -= b;
				}
				else
				{
					QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.PCNQDPHGDFJ(base.gameObject, this.BLLEFKOLKLP.position - b, 1656f);
					qhqfghkimmf.FNKBLEMDHKL = true;
					qhqfghkimmf.MKCNEHFFGKB = true;
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00006FD2 File Offset: 0x000051D2
	public Vector2 KKJFCIGOQQL()
	{
		return this.CCHQQHIFDBO;
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00069770 File Offset: 0x00067970
	private void HMJOBKGICKD()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "sweetveil", this);
			base.enabled = true;
		}
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x000697D8 File Offset: 0x000679D8
	private void HHLNMNBLHFM()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Pointer Influence", this);
			base.enabled = true;
		}
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00069840 File Offset: 0x00067A40
	private Vector3 CFHNMJNNCEO()
	{
		if (!(this.IHKLDMFDFKE == null) && this.IHKLDMFDFKE.childCount != 0)
		{
			Vector3 vector = new Vector3(this.OJIDBLEKBBO.rect.xMin * (float)Screen.width, this.OJIDBLEKBBO.rect.yMin * (float)Screen.height, 1332f);
			Vector3 vector2 = new Vector3(this.OJIDBLEKBBO.rect.xMax * (float)Screen.width, this.OJIDBLEKBBO.rect.yMax * (float)Screen.height, 543f);
			vector = this.OJIDBLEKBBO.ScreenToWorldPoint(vector);
			vector2 = this.OJIDBLEKBBO.ScreenToWorldPoint(vector2);
			Vector2 lcpifekbcdq = new Vector2(this.FKKNDHFECQL.min.x, this.FKKNDHFECQL.min.y);
			Vector2 qlhckchlcin = new Vector2(this.FKKNDHFECQL.max.x, this.FKKNDHFECQL.max.y);
			return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, vector, vector2);
		}
		return Vector3.zero;
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00069988 File Offset: 0x00067B88
	public void NHNGLFKPQQB(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = true;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 222f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else if (this.NNFKGOHBEHF == (CGINEOGDPGP.DHDOBNJKEPM)5)
			{
				this.LBQOHFLCCBE(true);
			}
		}
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00069A08 File Offset: 0x00067C08
	public void LQELEIDPPKD(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 1168f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00069A60 File Offset: 0x00067C60
	public void LCDPODIHDPF(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 79f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00006FD2 File Offset: 0x000051D2
	// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00006FC9 File Offset: 0x000051C9
	public Vector2 CJNJKJBPBPE
	{
		get
		{
			return this.CCHQQHIFDBO;
		}
		set
		{
			this.CCHQQHIFDBO = value;
		}
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00069AB8 File Offset: 0x00067CB8
	public void BKKDFFPQPKI(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = false;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 517f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else if (this.NNFKGOHBEHF == (CGINEOGDPGP.DHDOBNJKEPM)4)
			{
				this.KDLNMFDOHMC(false);
			}
		}
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x00069B38 File Offset: 0x00067D38
	private void EQIMMIBMQGP()
	{
		float gpfidejemeg = JMIOBJFFGBN.KQPPFINIJDG();
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = true;
			}
			this.HCLBPEMQFBO = 1632f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 45f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 1099f, 1527f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 1097f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1729f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.KLMBHEMEODB(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = true;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 1661f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1416f, gpfidejemeg);
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x00069C54 File Offset: 0x00067E54
	public bool EEQMPLGLHLE(bool OGFDJFCDCLJ)
	{
		if (this.BLLEFKOLKLP != null && this.IHKLDMFDFKE != null)
		{
			Vector3 b = this.CHBIDKCNPHK();
			if (b.sqrMagnitude > 1345f)
			{
				if (OGFDJFCDCLJ)
				{
					this.BLLEFKOLKLP.position -= b;
				}
				else
				{
					QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.IOELIBBIPGB(base.gameObject, this.BLLEFKOLKLP.position - b, 819f);
					qhqfghkimmf.FNKBLEMDHKL = true;
					qhqfghkimmf.MKCNEHFFGKB = false;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void QGHBOBCIOJD(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void EPPMJKLNPQE(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00069CE4 File Offset: 0x00067EE4
	private void IPFJMEFKGGM()
	{
		float gpfidejemeg = JMIOBJFFGBN.QMLMHDJFJOP();
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = true;
			}
			this.HCLBPEMQFBO = 955f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 79f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 1232f, 1628f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 1051f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 999f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.LBQOHFLCCBE(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 679f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 933f, gpfidejemeg);
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x00069E00 File Offset: 0x00068000
	private Vector3 DOOOFEPEOQG()
	{
		if (!(this.IHKLDMFDFKE == null) && this.IHKLDMFDFKE.childCount != 0)
		{
			Vector3 vector = new Vector3(this.OJIDBLEKBBO.rect.xMin * (float)Screen.width, this.OJIDBLEKBBO.rect.yMin * (float)Screen.height, 569f);
			Vector3 vector2 = new Vector3(this.OJIDBLEKBBO.rect.xMax * (float)Screen.width, this.OJIDBLEKBBO.rect.yMax * (float)Screen.height, 1899f);
			vector = this.OJIDBLEKBBO.ScreenToWorldPoint(vector);
			vector2 = this.OJIDBLEKBBO.ScreenToWorldPoint(vector2);
			Vector2 lcpifekbcdq = new Vector2(this.FKKNDHFECQL.min.x, this.FKKNDHFECQL.min.y);
			Vector2 qlhckchlcin = new Vector2(this.FKKNDHFECQL.max.x, this.FKKNDHFECQL.max.y);
			return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, vector, vector2);
		}
		return Vector3.zero;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00069F48 File Offset: 0x00068148
	public void BGMMOKOCKIG(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = true;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)4;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.JCGLMKGEJQG();
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (481f * this.ILKGGGEDGOE), 1227f);
		if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)3 && this.KDLNMFDOHMC(true))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 1570f;
		}
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x0006A024 File Offset: 0x00068224
	private Vector3 GKCICPLNPJJ()
	{
		if (!(this.IHKLDMFDFKE == null) && this.IHKLDMFDFKE.childCount != 0)
		{
			Vector3 vector = new Vector3(this.OJIDBLEKBBO.rect.xMin * (float)Screen.width, this.OJIDBLEKBBO.rect.yMin * (float)Screen.height, 0f);
			Vector3 vector2 = new Vector3(this.OJIDBLEKBBO.rect.xMax * (float)Screen.width, this.OJIDBLEKBBO.rect.yMax * (float)Screen.height, 0f);
			vector = this.OJIDBLEKBBO.ScreenToWorldPoint(vector);
			vector2 = this.OJIDBLEKBBO.ScreenToWorldPoint(vector2);
			Vector2 lcpifekbcdq = new Vector2(this.FKKNDHFECQL.min.x, this.FKKNDHFECQL.min.y);
			Vector2 qlhckchlcin = new Vector2(this.FKKNDHFECQL.max.x, this.FKKNDHFECQL.max.y);
			return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, vector, vector2);
		}
		return Vector3.zero;
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00006FD2 File Offset: 0x000051D2
	public Vector2 LJCOFPHIPGJ()
	{
		return this.CCHQQHIFDBO;
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x0006A16C File Offset: 0x0006836C
	private Vector3 LQKHKCCJCBK()
	{
		if (!(this.IHKLDMFDFKE == null) && this.IHKLDMFDFKE.childCount != 0)
		{
			Vector3 vector = new Vector3(this.OJIDBLEKBBO.rect.xMin * (float)Screen.width, this.OJIDBLEKBBO.rect.yMin * (float)Screen.height, 380f);
			Vector3 vector2 = new Vector3(this.OJIDBLEKBBO.rect.xMax * (float)Screen.width, this.OJIDBLEKBBO.rect.yMax * (float)Screen.height, 926f);
			vector = this.OJIDBLEKBBO.ScreenToWorldPoint(vector);
			vector2 = this.OJIDBLEKBBO.ScreenToWorldPoint(vector2);
			Vector2 lcpifekbcdq = new Vector2(this.FKKNDHFECQL.min.x, this.FKKNDHFECQL.min.y);
			Vector2 qlhckchlcin = new Vector2(this.FKKNDHFECQL.max.x, this.FKKNDHFECQL.max.y);
			return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, vector, vector2);
		}
		return Vector3.zero;
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void CCFKLCEBLPM(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x0006A2B4 File Offset: 0x000684B4
	public bool LBQOHFLCCBE(bool OGFDJFCDCLJ)
	{
		if (this.BLLEFKOLKLP != null && this.IHKLDMFDFKE != null)
		{
			Vector3 b = this.DOOOFEPEOQG();
			if (b.sqrMagnitude > 39f)
			{
				if (OGFDJFCDCLJ)
				{
					this.BLLEFKOLKLP.position -= b;
				}
				else
				{
					QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.BJLDIGIKGLB(base.gameObject, this.BLLEFKOLKLP.position - b, 872f);
					qhqfghkimmf.FNKBLEMDHKL = false;
					qhqfghkimmf.MKCNEHFFGKB = false;
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x0006A344 File Offset: 0x00068544
	public void BLNJLPBHLJC(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = true;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 1657f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum)
			{
				this.KLMBHEMEODB(true);
			}
		}
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x0006A3C4 File Offset: 0x000685C4
	public bool KLMBHEMEODB(bool OGFDJFCDCLJ)
	{
		if (this.BLLEFKOLKLP != null && this.IHKLDMFDFKE != null)
		{
			Vector3 b = this.MDKNJHCHGJQ();
			if (b.sqrMagnitude > 415f)
			{
				if (OGFDJFCDCLJ)
				{
					this.BLLEFKOLKLP.position -= b;
				}
				else
				{
					QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.FEBFHOPOJQN(base.gameObject, this.BLLEFKOLKLP.position - b, 1259f);
					qhqfghkimmf.FNKBLEMDHKL = true;
					qhqfghkimmf.MKCNEHFFGKB = true;
				}
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x0006A454 File Offset: 0x00068654
	public bool KDLNMFDOHMC(bool OGFDJFCDCLJ)
	{
		if (this.BLLEFKOLKLP != null && this.IHKLDMFDFKE != null)
		{
			Vector3 b = this.GKCICPLNPJJ();
			if (b.sqrMagnitude > 0f)
			{
				if (OGFDJFCDCLJ)
				{
					this.BLLEFKOLKLP.position -= b;
				}
				else
				{
					QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.FJCEGFKJLCL(base.gameObject, this.BLLEFKOLKLP.position - b, 13f);
					qhqfghkimmf.FNKBLEMDHKL = true;
					qhqfghkimmf.MKCNEHFFGKB = true;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0006A4E4 File Offset: 0x000686E4
	public void NKBFKGKCNGE(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = false;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.KFLGCIPQMGJ();
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (837f * this.ILKGGGEDGOE), 500f);
		if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.Momentum && this.EEQMPLGLHLE(false))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 391f;
		}
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void GLBHKBNPMLP(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void LPKQPFIFKQB(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x0006A5C0 File Offset: 0x000687C0
	public void MHENIHCQQJN(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 1826f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x0006A618 File Offset: 0x00068818
	private void JENGGFLPCDQ()
	{
		float gpfidejemeg = JMIOBJFFGBN.FOPBGFNNLMJ();
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = true;
			}
			this.HCLBPEMQFBO = 1878f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 1709f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 230f, 1097f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 1890f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1859f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.LBQOHFLCCBE(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 976f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 869f, gpfidejemeg);
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x0006A734 File Offset: 0x00068934
	private void HBOFMLLODDM()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "magnetrise", this);
			base.enabled = true;
		}
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00006FD2 File Offset: 0x000051D2
	public Vector2 DGDJKPJMKBG()
	{
		return this.CCHQQHIFDBO;
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x0006A79C File Offset: 0x0006899C
	private Vector3 BNJFLEHFQGI()
	{
		if (!(this.IHKLDMFDFKE == null) && this.IHKLDMFDFKE.childCount != 0)
		{
			Vector3 vector = new Vector3(this.OJIDBLEKBBO.rect.xMin * (float)Screen.width, this.OJIDBLEKBBO.rect.yMin * (float)Screen.height, 1518f);
			Vector3 vector2 = new Vector3(this.OJIDBLEKBBO.rect.xMax * (float)Screen.width, this.OJIDBLEKBBO.rect.yMax * (float)Screen.height, 1637f);
			vector = this.OJIDBLEKBBO.ScreenToWorldPoint(vector);
			vector2 = this.OJIDBLEKBBO.ScreenToWorldPoint(vector2);
			Vector2 lcpifekbcdq = new Vector2(this.FKKNDHFECQL.min.x, this.FKKNDHFECQL.min.y);
			Vector2 qlhckchlcin = new Vector2(this.FKKNDHFECQL.max.x, this.FKKNDHFECQL.max.y);
			return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, vector, vector2);
		}
		return Vector3.zero;
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x0006A8E4 File Offset: 0x00068AE4
	private Vector3 CHBIDKCNPHK()
	{
		if (!(this.IHKLDMFDFKE == null) && this.IHKLDMFDFKE.childCount != 0)
		{
			Vector3 vector = new Vector3(this.OJIDBLEKBBO.rect.xMin * (float)Screen.width, this.OJIDBLEKBBO.rect.yMin * (float)Screen.height, 753f);
			Vector3 vector2 = new Vector3(this.OJIDBLEKBBO.rect.xMax * (float)Screen.width, this.OJIDBLEKBBO.rect.yMax * (float)Screen.height, 150f);
			vector = this.OJIDBLEKBBO.ScreenToWorldPoint(vector);
			vector2 = this.OJIDBLEKBBO.ScreenToWorldPoint(vector2);
			Vector2 lcpifekbcdq = new Vector2(this.FKKNDHFECQL.min.x, this.FKKNDHFECQL.min.y);
			Vector2 qlhckchlcin = new Vector2(this.FKKNDHFECQL.max.x, this.FKKNDHFECQL.max.y);
			return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, vector, vector2);
		}
		return Vector3.zero;
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x0006AA2C File Offset: 0x00068C2C
	private void Start()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + " needs the 'Root For Bounds' parameter to be set", this);
			base.enabled = false;
		}
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x0006AA94 File Offset: 0x00068C94
	private void FKFEDINPBFF()
	{
		float gpfidejemeg = JMIOBJFFGBN.FCJDLIPPELL();
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = false;
			}
			this.HCLBPEMQFBO = 632f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 1375f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 78f, 1871f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 723f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1054f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.EEQMPLGLHLE(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = true;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 848f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1182f, gpfidejemeg);
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x0006ABB0 File Offset: 0x00068DB0
	public void FQKNBDFPOEO(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 885f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x0006AC08 File Offset: 0x00068E08
	private void IJNCFJMGKDE()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "[epic]", this);
			base.enabled = true;
		}
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void JMPJIKEIOFM(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x0006AC70 File Offset: 0x00068E70
	public void DCEIPHDCIGC(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = true;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)7;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.KFLGCIPQMGJ();
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (555f * this.ILKGGGEDGOE), 832f);
		if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring && this.JNCOQFQJPJI(false))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 1648f;
		}
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x0006AD4C File Offset: 0x00068F4C
	public void EODHILDCPNH(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 0f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x0006ADA4 File Offset: 0x00068FA4
	public void GBCKBGHDLKP(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = true;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.PNBFQDLQENI;
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (0.01f * this.ILKGGGEDGOE), 0.67f);
		if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring && this.KDLNMFDOHMC(true))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 0f;
		}
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void EPEFQGGHIEG(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x0006AE80 File Offset: 0x00069080
	private void EBCOLLDGMOQ()
	{
		float gpfidejemeg = JMIOBJFFGBN.MEJKCDOLEIK();
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = false;
			}
			this.HCLBPEMQFBO = 704f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 1962f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 211f, 825f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 216f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1622f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.EEQMPLGLHLE(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = true;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 1592f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1530f, gpfidejemeg);
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x0006AF9C File Offset: 0x0006919C
	private void QDHNIMPGNOO()
	{
		float gpfidejemeg = JMIOBJFFGBN.KQPPFINIJDG();
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = true;
			}
			this.HCLBPEMQFBO = 643f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 1846f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 1722f, 1785f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 1839f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 836f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.EKNKHIOBDIJ(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 818f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 383f, gpfidejemeg);
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x0006B0B8 File Offset: 0x000692B8
	public void PGQKDFHGKKH(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 1893f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void FOFEFOQDFPH(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x0006B110 File Offset: 0x00069310
	public void PBDEHKKHILD(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = false;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.Always;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.JCGLMKGEJQG();
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (729f * this.ILKGGGEDGOE), 1530f);
		if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)5 && this.JNCOQFQJPJI(false))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 450f;
		}
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x0006B1EC File Offset: 0x000693EC
	public void QMFNHOBKFLH(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 221f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void DFOKPHLJHIC(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x0006B244 File Offset: 0x00069444
	public void BFPGQNMFCBC(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = false;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)5;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.JCGLMKGEJQG();
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (149f * this.ILKGGGEDGOE), 191f);
		if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)5 && this.LBQOHFLCCBE(false))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 1705f;
		}
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00006FD2 File Offset: 0x000051D2
	public Vector2 KJPEOMOIILH()
	{
		return this.CCHQQHIFDBO;
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x0006B320 File Offset: 0x00069520
	private void Update()
	{
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		if (this.EIQLEKDFMMC)
		{
			QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
			if (component != null)
			{
				component.enabled = false;
			}
			this.HCLBPEMQFBO = 0f;
		}
		else
		{
			this.CCHQQHIFDBO += this.LCHODFNJNBH * (this.HCLBPEMQFBO * 20f);
			this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 0f, 20f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude > 0.01f)
			{
				this.BLLEFKOLKLP.localPosition += JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 9f, gpfidejemeg);
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				if (!this.KDLNMFDOHMC(this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
			this.HCLBPEMQFBO = 0f;
		}
		JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 9f, gpfidejemeg);
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0006B43C File Offset: 0x0006963C
	public void NEPEJJDKNPM(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = true;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 463f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = true;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum)
			{
				this.LBQOHFLCCBE(false);
			}
		}
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0006B4BC File Offset: 0x000696BC
	public bool JNCOQFQJPJI(bool OGFDJFCDCLJ)
	{
		if (this.BLLEFKOLKLP != null && this.IHKLDMFDFKE != null)
		{
			Vector3 b = this.CHBIDKCNPHK();
			if (b.sqrMagnitude > 1394f)
			{
				if (OGFDJFCDCLJ)
				{
					this.BLLEFKOLKLP.position -= b;
				}
				else
				{
					QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.PPMFEQFJLNB(base.gameObject, this.BLLEFKOLKLP.position - b, 410f);
					qhqfghkimmf.FNKBLEMDHKL = false;
					qhqfghkimmf.MKCNEHFFGKB = true;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x0006B54C File Offset: 0x0006974C
	public void MBFHQBCCJBQ(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = true;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 436f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = true;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum)
			{
				this.KLMBHEMEODB(true);
			}
		}
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x0006B5CC File Offset: 0x000697CC
	public void CDOFMMLDLHJ(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 200f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0006B624 File Offset: 0x00069824
	public void KDIPJIGFQDP(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = true;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 1309f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = true;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum)
			{
				this.JNCOQFQJPJI(true);
			}
		}
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00006FD2 File Offset: 0x000051D2
	public Vector2 BOOKDEJJJML()
	{
		return this.CCHQQHIFDBO;
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0006B6A4 File Offset: 0x000698A4
	private void DHLGDLOKLKN()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.IHKLDMFDFKE == null)
		{
			Debug.LogError(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Items held by the Pokémon are stuck fast and cannot be removed by other Pokémon.", this);
			base.enabled = false;
		}
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x0006B70C File Offset: 0x0006990C
	private Vector3 MDKNJHCHGJQ()
	{
		if (!(this.IHKLDMFDFKE == null) && this.IHKLDMFDFKE.childCount != 0)
		{
			Vector3 vector = new Vector3(this.OJIDBLEKBBO.rect.xMin * (float)Screen.width, this.OJIDBLEKBBO.rect.yMin * (float)Screen.height, 1386f);
			Vector3 vector2 = new Vector3(this.OJIDBLEKBBO.rect.xMax * (float)Screen.width, this.OJIDBLEKBBO.rect.yMax * (float)Screen.height, 1840f);
			vector = this.OJIDBLEKBBO.ScreenToWorldPoint(vector);
			vector2 = this.OJIDBLEKBBO.ScreenToWorldPoint(vector2);
			Vector2 lcpifekbcdq = new Vector2(this.FKKNDHFECQL.min.x, this.FKKNDHFECQL.min.y);
			Vector2 qlhckchlcin = new Vector2(this.FKKNDHFECQL.max.x, this.FKKNDHFECQL.max.y);
			return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, vector, vector2);
		}
		return Vector3.zero;
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x0006B854 File Offset: 0x00069A54
	public void KQJIDHDCJOK(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 331f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * this.EBFOBLQELOJ;
		}
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00006FC9 File Offset: 0x000051C9
	public void QHLBLPIOFKO(Vector2 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x00006FD2 File Offset: 0x000051D2
	public Vector2 EMPHQBNLFGN()
	{
		return this.CCHQQHIFDBO;
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x0006B8AC File Offset: 0x00069AAC
	public void POIENHJBEDI(Vector2 JDOGIQGGLKM)
	{
		if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
		{
			this.DEDCMDKLLCE = true;
			return;
		}
		EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
		if (this.KLLHOMMGBLK != null)
		{
			JDOGIQGGLKM *= this.KLLHOMMGBLK.KFLGCIPQMGJ();
		}
		Vector2 vector = Vector2.Scale(JDOGIQGGLKM, -this.LCHODFNJNBH);
		this.BLLEFKOLKLP.localPosition += vector;
		this.CCHQQHIFDBO = Vector2.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1085f * this.ILKGGGEDGOE), 1553f);
		if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring && this.JNCOQFQJPJI(false))
		{
			this.CCHQQHIFDBO = Vector2.zero;
			this.HCLBPEMQFBO = 1363f;
		}
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0006B988 File Offset: 0x00069B88
	public void EQGPDOCPPQQ(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.DEDCMDKLLCE = false;
		}
		if (this.IHKLDMFDFKE != null)
		{
			this.EIQLEKDFMMC = FJOEKDCLKIO;
			if (FJOEKDCLKIO)
			{
				this.FKKNDHFECQL = JNNGOIIKENH.LPPOONFLLOC(this.IHKLDMFDFKE);
				this.CCHQQHIFDBO = Vector2.zero;
				this.HCLBPEMQFBO = 0f;
				QHQFGHKIMMF component = base.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else if (this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring)
			{
				this.KDLNMFDOHMC(false);
			}
		}
	}

	// Token: 0x040001BF RID: 447
	public Transform IHKLDMFDFKE;

	// Token: 0x040001C0 RID: 448
	public Vector2 LCHODFNJNBH = Vector2.one;

	// Token: 0x040001C1 RID: 449
	public float EBFOBLQELOJ;

	// Token: 0x040001C2 RID: 450
	public CGINEOGDPGP.DHDOBNJKEPM NNFKGOHBEHF = CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring;

	// Token: 0x040001C3 RID: 451
	public bool JLLKLQGCLMM = true;

	// Token: 0x040001C4 RID: 452
	public float ILKGGGEDGOE = 35f;

	// Token: 0x040001C5 RID: 453
	private Camera OJIDBLEKBBO;

	// Token: 0x040001C6 RID: 454
	private Transform BLLEFKOLKLP;

	// Token: 0x040001C7 RID: 455
	private bool EIQLEKDFMMC;

	// Token: 0x040001C8 RID: 456
	private Vector2 CCHQQHIFDBO = Vector2.zero;

	// Token: 0x040001C9 RID: 457
	private Bounds FKKNDHFECQL;

	// Token: 0x040001CA RID: 458
	private float HCLBPEMQFBO;

	// Token: 0x040001CB RID: 459
	private GKDCBJPLQLQ KLLHOMMGBLK;

	// Token: 0x040001CC RID: 460
	private bool DEDCMDKLLCE;
}
