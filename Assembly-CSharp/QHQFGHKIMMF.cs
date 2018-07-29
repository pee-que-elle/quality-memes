using System;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[AddComponentMenu("NGUI/Tween/Spring Position")]
public class QHQFGHKIMMF : MonoBehaviour
{
	// Token: 0x060018C6 RID: 6342 RVA: 0x000AB060 File Offset: 0x000A9260
	private void QDIKKLMCIJK()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.KFJQLEKKMOD();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 130f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 526f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.HMFGPLMJEKI();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1005f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1514f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.BOOGCEPDKQQ();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(true);
		}
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x000AB1F8 File Offset: 0x000A93F8
	public static QHQFGHKIMMF CNJQCOLFHNK(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 1414f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x000AB24C File Offset: 0x000A944C
	private void DLBNQMKQILC()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.QMLMHDJFJOP();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 246f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 360f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.BOOGCEPDKQQ();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1260f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 853f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.PNNBJFPBFBK();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.IEQQJNLJCKP(true);
		}
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x000AB3E4 File Offset: 0x000A95E4
	private void GCEDFPKOEMN()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.HLMOIFMQOGH();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1956f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 1027f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.ECCNMLIBQDB();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1191f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 814f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.GFFNMGPNMCB();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.IEQQJNLJCKP(true);
		}
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x000AB57C File Offset: 0x000A977C
	public static QHQFGHKIMMF KJJQQBDHLJE(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 805f;
			qhqfghkimmf.enabled = false;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x000AB5D0 File Offset: 0x000A97D0
	private void LIPJEKLNFJI()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.JHEKKFKJCKK();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 1233f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.IIQINDJQCIQ();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1755f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1761f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.HMFGPLMJEKI();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.FCGMFIPGCHH(false);
		}
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x000AB768 File Offset: 0x000A9968
	private void QDHNIMPGNOO()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.GPFIDEJEMEG;
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1365f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 1083f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.KNQBIIGPHIK();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1479f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1378f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.HMFGPLMJEKI();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.IEQQJNLJCKP(true);
		}
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x000AB900 File Offset: 0x000A9B00
	public static QHQFGHKIMMF FEBFHOPOJQN(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 691f;
			qhqfghkimmf.enabled = false;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x000AB954 File Offset: 0x000A9B54
	private void EGFFPGCMFOO()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.MEJKCDOLEIK();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 172f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 389f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.KNQBIIGPHIK();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1828f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 791f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.HMFGPLMJEKI();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.FCGMFIPGCHH(false);
		}
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x000ABAEC File Offset: 0x000A9CEC
	private void EPKGNIPJOEF()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCJDLIPPELL();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1356f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 543f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.IIQINDJQCIQ();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 78f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 644f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.FPFLFCNFGMH();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.FCGMFIPGCHH(false);
		}
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x000ABC84 File Offset: 0x000A9E84
	private void QFFJMIOJENJ()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCPBKHJFGJO();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1013f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 86f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.IKLIOQPCGJQ();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 676f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 374f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.ECCNMLIBQDB();
				base.enabled = true;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(true);
		}
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x0000D552 File Offset: 0x0000B752
	private void EKIFLKDPKNM()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x000ABE1C File Offset: 0x000AA01C
	private void EJCHKLBMECH()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.QMLMHDJFJOP();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 498f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 127f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.JNCGKGNNFHF();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 999f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1837f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.GPGQPBNOCCK();
				base.enabled = true;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(true);
		}
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x0000D552 File Offset: 0x0000B752
	private void DGMPMICDCIO()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x0000D552 File Offset: 0x0000B752
	private void KHFDJHFJMDK()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
	private void ECCNMLIBQDB()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x000AC010 File Offset: 0x000AA210
	private void Update()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.GPFIDEJEMEG;
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 0f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 0.001f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.IGPPCCBBIBP();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 0f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1E-05f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.IGPPCCBBIBP();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(true);
		}
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x0000D552 File Offset: 0x0000B752
	private void JDLQNCEDMPI()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x000AC1A8 File Offset: 0x000AA3A8
	public static QHQFGHKIMMF OBCNHPELFJK(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 1165f;
			qhqfghkimmf.enabled = false;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x000AC1FC File Offset: 0x000AA3FC
	public static QHQFGHKIMMF CLPJPDDOCHC(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 105f;
			qhqfghkimmf.enabled = false;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x000AC250 File Offset: 0x000AA450
	public static QHQFGHKIMMF PPMFEQFJLNB(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 1464f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x000AC2A4 File Offset: 0x000AA4A4
	public static QHQFGHKIMMF BJLDIGIKGLB(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 59f;
			qhqfghkimmf.enabled = false;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
	private void KNQBIIGPHIK()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x000AC354 File Offset: 0x000AA554
	private void EEQKLHDKBCQ()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.MEJKCDOLEIK();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 957f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 188f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.IGPPCCBBIBP();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 419f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1543f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.GPGQPBNOCCK();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(true);
		}
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x000AC4EC File Offset: 0x000AA6EC
	public static QHQFGHKIMMF BHNPPCIDQMD(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 513f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x000AC540 File Offset: 0x000AA740
	private void NIIPIECJPOL()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCHGFPDIGLN();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 610f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 1952f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.JNCGKGNNFHF();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 677f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 647f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.FPFLFCNFGMH();
				base.enabled = true;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(false);
		}
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
	private void IKLIOQPCGJQ()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x0000D552 File Offset: 0x0000B752
	private void QBGOGFJCLEP()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
	private void FPFLFCNFGMH()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x000AC6D8 File Offset: 0x000AA8D8
	public static QHQFGHKIMMF FJCEGFKJLCL(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 0f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018E4 RID: 6372 RVA: 0x0000D552 File Offset: 0x0000B752
	private void PEJKGQEGPMM()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x000AC72C File Offset: 0x000AA92C
	private void QIHJCOLPLBQ()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.GPFIDEJEMEG;
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 879f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 1732f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.JNCGKGNNFHF();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1518f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 175f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.IGPPCCBBIBP();
				base.enabled = true;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.IEQQJNLJCKP(false);
		}
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
	private void BOOGCEPDKQQ()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
	private void JNCGKGNNFHF()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x000AC8C4 File Offset: 0x000AAAC4
	public static QHQFGHKIMMF IOELIBBIPGB(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 262f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x0000D552 File Offset: 0x0000B752
	private void CPJJKJLFOEN()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
	private void GPGQPBNOCCK()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x000AC918 File Offset: 0x000AAB18
	public static QHQFGHKIMMF HONHPLNBHJQ(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 624f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
	private void HEELLEJEKKB()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x000AC96C File Offset: 0x000AAB6C
	private void KMFJINCMCJC()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.JHJKPJLOEIN();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1893f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 1931f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.GPGQPBNOCCK();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 50f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 640f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.BOOGCEPDKQQ();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.FCGMFIPGCHH(false);
		}
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x000ACB04 File Offset: 0x000AAD04
	public static QHQFGHKIMMF CMHPQIICIBL(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 1196f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018EF RID: 6383 RVA: 0x000ACB58 File Offset: 0x000AAD58
	private void QOKHPFKDGDO()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.DEHFGOQHJCP();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 376f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 394f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.PNNBJFPBFBK();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 434f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 129f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.HMFGPLMJEKI();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.IEQQJNLJCKP(false);
		}
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x000ACCF0 File Offset: 0x000AAEF0
	private void KHQIGBMDOGP()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCHGFPDIGLN();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1641f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 248f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.KNQBIIGPHIK();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1748f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1631f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.IKLIOQPCGJQ();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.FCGMFIPGCHH(false);
		}
	}

	// Token: 0x060018F2 RID: 6386 RVA: 0x000ACE88 File Offset: 0x000AB088
	public static QHQFGHKIMMF MONBDFEFCGB(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 1739f;
			qhqfghkimmf.enabled = true;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
	private void BCJPKNHINEQ()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x000ACEDC File Offset: 0x000AB0DC
	private void OODKHHIPKFC()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCPBKHJFGJO();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1051f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 807f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.IGPPCCBBIBP();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1960f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 807f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.GFFNMGPNMCB();
				base.enabled = true;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(true);
		}
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x000AD074 File Offset: 0x000AB274
	private void JOMCJOMCOIQ()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.DFLFHGFHJMN();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 425f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 279f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.GFFNMGPNMCB();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 953f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1370f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.BCJPKNHINEQ();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.GCHMLEJKKJB(false);
		}
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x000AD20C File Offset: 0x000AB40C
	private void IENJNCIDFNK()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.DFLFHGFHJMN();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1847f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 615f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.BCJPKNHINEQ();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1807f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1080f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.JNCGKGNNFHF();
				base.enabled = true;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.IEQQJNLJCKP(true);
		}
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x0000D552 File Offset: 0x0000B752
	private void MHOKPDFOEDP()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
	private void GFFNMGPNMCB()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
	private void PNNBJFPBFBK()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x0000D552 File Offset: 0x0000B752
	private void PGFHJKDGEMJ()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
	private void IIQINDJQCIQ()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x000AD3A4 File Offset: 0x000AB5A4
	private void BLEHFIJGOHG()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FOPBGFNNLMJ();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 1528f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 574f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.BCJPKNHINEQ();
				base.enabled = true;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 1053f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1878f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.IIQINDJQCIQ();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.FCGMFIPGCHH(true);
		}
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
	private void IGPPCCBBIBP()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x000AD53C File Offset: 0x000AB73C
	public static QHQFGHKIMMF KKOFKCHPCID(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 532f;
			qhqfghkimmf.enabled = false;
		}
		return qhqfghkimmf;
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x000AD590 File Offset: 0x000AB790
	public static QHQFGHKIMMF PCNQDPHGDFJ(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		QHQFGHKIMMF qhqfghkimmf = CGHIENBIHCO.GetComponent<QHQFGHKIMMF>();
		if (qhqfghkimmf == null)
		{
			qhqfghkimmf = CGHIENBIHCO.AddComponent<QHQFGHKIMMF>();
		}
		qhqfghkimmf.ILBCCCBJNCL = NKKGPNPGDEM;
		qhqfghkimmf.IEMGQKFCEHM = IEMGQKFCEHM;
		qhqfghkimmf.KCQKMKOQLQL = null;
		if (!qhqfghkimmf.enabled)
		{
			qhqfghkimmf.IQINEBDILIQ = 585f;
			qhqfghkimmf.enabled = false;
		}
		return qhqfghkimmf;
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x0000D552 File Offset: 0x0000B752
	private void IJNCFJMGKDE()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x0000D552 File Offset: 0x0000B752
	private void GJLLCMLLEQF()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x0000D552 File Offset: 0x0000B752
	private void JPNMOLDKPQP()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x0000D552 File Offset: 0x0000B752
	private void OLLNOFNEEIL()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x0000D552 File Offset: 0x0000B752
	private void Start()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.LMNHONNKGHI)
		{
			this.GCIKKOGGDMF = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
		}
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
	private void HMFGPLMJEKI()
	{
		QHQFGHKIMMF.OMQCQCBLQGJ = this;
		if (this.KCQKMKOQLQL != null)
		{
			this.KCQKMKOQLQL();
		}
		if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
		{
			this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		QHQFGHKIMMF.OMQCQCBLQGJ = null;
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x000AD5E4 File Offset: 0x000AB7E4
	private void JIHOGMQPHDF()
	{
		float gpfidejemeg = (!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCHGFPDIGLN();
		if (this.MKCNEHFFGKB)
		{
			if (this.IQINEBDILIQ == 403f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude * 1537f;
			}
			this.BLLEFKOLKLP.position = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.position, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.position).sqrMagnitude)
			{
				this.BLLEFKOLKLP.position = this.ILBCCCBJNCL;
				this.ECCNMLIBQDB();
				base.enabled = false;
			}
		}
		else
		{
			if (this.IQINEBDILIQ == 650f)
			{
				this.IQINEBDILIQ = (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude * 1244f;
			}
			this.BLLEFKOLKLP.localPosition = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
			if (this.IQINEBDILIQ >= (this.ILBCCCBJNCL - this.BLLEFKOLKLP.localPosition).sqrMagnitude)
			{
				this.BLLEFKOLKLP.localPosition = this.ILBCCCBJNCL;
				this.KNQBIIGPHIK();
				base.enabled = false;
			}
		}
		if (this.GCIKKOGGDMF != null)
		{
			this.GCIKKOGGDMF.IEQQJNLJCKP(true);
		}
	}

	// Token: 0x04000501 RID: 1281
	public static QHQFGHKIMMF OMQCQCBLQGJ;

	// Token: 0x04000502 RID: 1282
	public Vector3 ILBCCCBJNCL = Vector3.zero;

	// Token: 0x04000503 RID: 1283
	public float IEMGQKFCEHM = 10f;

	// Token: 0x04000504 RID: 1284
	public bool MKCNEHFFGKB;

	// Token: 0x04000505 RID: 1285
	public bool FNKBLEMDHKL;

	// Token: 0x04000506 RID: 1286
	public bool LMNHONNKGHI;

	// Token: 0x04000507 RID: 1287
	public QHQFGHKIMMF.OOFOFDJMGEM KCQKMKOQLQL;

	// Token: 0x04000508 RID: 1288
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	// Token: 0x04000509 RID: 1289
	[SerializeField]
	[HideInInspector]
	public string callWhenFinished;

	// Token: 0x0400050A RID: 1290
	private Transform BLLEFKOLKLP;

	// Token: 0x0400050B RID: 1291
	private float IQINEBDILIQ;

	// Token: 0x0400050C RID: 1292
	private FKBFPICKJQG GCIKKOGGDMF;

	// Token: 0x020000D2 RID: 210
	// (Invoke) Token: 0x06001908 RID: 6408
	public delegate void OOFOFDJMGEM();
}
