using System;
using UnityEngine;

// Token: 0x020000AF RID: 175
[AddComponentMenu("NGUI/Internal/Spring Panel")]
[RequireComponent(typeof(KQHJOLQLQBJ))]
public class OKCMKCMQOGD : MonoBehaviour
{
	// Token: 0x060016A5 RID: 5797 RVA: 0x000A2C00 File Offset: 0x000A0E00
	protected virtual void JQCKQHIHHDJ()
	{
		float gpfidejemeg = JMIOBJFFGBN.FCJDLIPPELL();
		bool flag = true;
		Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
		Vector3 vector = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
		if ((vector - this.ILBCCCBJNCL).sqrMagnitude < 1384f)
		{
			vector = this.ILBCCCBJNCL;
			base.enabled = false;
			flag = true;
		}
		this.BLLEFKOLKLP.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.PIJJJMKLMIO;
		pijjjmklmio.x -= vector2.x;
		pijjjmklmio.y -= vector2.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		if (this.FCGOLKPMQLF != null)
		{
			this.FCGOLKPMQLF.IEQQJNLJCKP(true);
		}
		if (flag && this.KCQKMKOQLQL != null)
		{
			OKCMKCMQOGD.OMQCQCBLQGJ = this;
			this.KCQKMKOQLQL();
			OKCMKCMQOGD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x000A2D00 File Offset: 0x000A0F00
	public static OKCMKCMQOGD KJJQQBDHLJE(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		OKCMKCMQOGD okcmkcmqogd = CGHIENBIHCO.GetComponent<OKCMKCMQOGD>();
		if (okcmkcmqogd == null)
		{
			okcmkcmqogd = CGHIENBIHCO.AddComponent<OKCMKCMQOGD>();
		}
		okcmkcmqogd.ILBCCCBJNCL = NKKGPNPGDEM;
		okcmkcmqogd.IEMGQKFCEHM = IEMGQKFCEHM;
		okcmkcmqogd.KCQKMKOQLQL = null;
		okcmkcmqogd.enabled = false;
		return okcmkcmqogd;
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x000A2D44 File Offset: 0x000A0F44
	protected virtual void GEJLMENIQJM()
	{
		float gpfidejemeg = JMIOBJFFGBN.FOPBGFNNLMJ();
		bool flag = false;
		Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
		Vector3 vector = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
		if ((vector - this.ILBCCCBJNCL).sqrMagnitude < 875f)
		{
			vector = this.ILBCCCBJNCL;
			base.enabled = false;
			flag = false;
		}
		this.BLLEFKOLKLP.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.CJLPKHNPDID();
		pijjjmklmio.x -= vector2.x;
		pijjjmklmio.y -= vector2.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		if (this.FCGOLKPMQLF != null)
		{
			this.FCGOLKPMQLF.FCGMFIPGCHH(true);
		}
		if (flag && this.KCQKMKOQLQL != null)
		{
			OKCMKCMQOGD.OMQCQCBLQGJ = this;
			this.KCQKMKOQLQL();
			OKCMKCMQOGD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x000A2E44 File Offset: 0x000A1044
	public static OKCMKCMQOGD PCNQDPHGDFJ(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		OKCMKCMQOGD okcmkcmqogd = CGHIENBIHCO.GetComponent<OKCMKCMQOGD>();
		if (okcmkcmqogd == null)
		{
			okcmkcmqogd = CGHIENBIHCO.AddComponent<OKCMKCMQOGD>();
		}
		okcmkcmqogd.ILBCCCBJNCL = NKKGPNPGDEM;
		okcmkcmqogd.IEMGQKFCEHM = IEMGQKFCEHM;
		okcmkcmqogd.KCQKMKOQLQL = null;
		okcmkcmqogd.enabled = true;
		return okcmkcmqogd;
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x0000BC3E File Offset: 0x00009E3E
	private void Start()
	{
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		this.FCGOLKPMQLF = base.GetComponent<FKBFPICKJQG>();
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x0000BC64 File Offset: 0x00009E64
	private void JBJBPIBCBQO()
	{
		this.BPCCIMJPJDK();
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x0000BC6C File Offset: 0x00009E6C
	private void DLBNQMKQILC()
	{
		this.DGDDGKFKICM();
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x0000BC3E File Offset: 0x00009E3E
	private void BBGHCDGEDEJ()
	{
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		this.FCGOLKPMQLF = base.GetComponent<FKBFPICKJQG>();
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x000A2E88 File Offset: 0x000A1088
	protected virtual void OIBHFCHCQDQ()
	{
		float gpfidejemeg = JMIOBJFFGBN.CIPLINIEDED();
		bool flag = false;
		Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
		Vector3 vector = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
		if ((vector - this.ILBCCCBJNCL).sqrMagnitude < 297f)
		{
			vector = this.ILBCCCBJNCL;
			base.enabled = false;
			flag = false;
		}
		this.BLLEFKOLKLP.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.BNIINQIELIC();
		pijjjmklmio.x -= vector2.x;
		pijjjmklmio.y -= vector2.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		if (this.FCGOLKPMQLF != null)
		{
			this.FCGOLKPMQLF.FCGMFIPGCHH(false);
		}
		if (flag && this.KCQKMKOQLQL != null)
		{
			OKCMKCMQOGD.OMQCQCBLQGJ = this;
			this.KCQKMKOQLQL();
			OKCMKCMQOGD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x000A2F88 File Offset: 0x000A1188
	protected virtual void DGDDGKFKICM()
	{
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		bool flag = false;
		Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
		Vector3 vector = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
		if ((vector - this.ILBCCCBJNCL).sqrMagnitude < 0.01f)
		{
			vector = this.ILBCCCBJNCL;
			base.enabled = false;
			flag = true;
		}
		this.BLLEFKOLKLP.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.PIJJJMKLMIO;
		pijjjmklmio.x -= vector2.x;
		pijjjmklmio.y -= vector2.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		if (this.FCGOLKPMQLF != null)
		{
			this.FCGOLKPMQLF.GCHMLEJKKJB(false);
		}
		if (flag && this.KCQKMKOQLQL != null)
		{
			OKCMKCMQOGD.OMQCQCBLQGJ = this;
			this.KCQKMKOQLQL();
			OKCMKCMQOGD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x0000BC6C File Offset: 0x00009E6C
	private void BJFCILIPEMI()
	{
		this.DGDDGKFKICM();
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x0000BC6C File Offset: 0x00009E6C
	private void QFFJMIOJENJ()
	{
		this.DGDDGKFKICM();
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x000A2D00 File Offset: 0x000A0F00
	public static OKCMKCMQOGD LKOEFCKMEQD(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		OKCMKCMQOGD okcmkcmqogd = CGHIENBIHCO.GetComponent<OKCMKCMQOGD>();
		if (okcmkcmqogd == null)
		{
			okcmkcmqogd = CGHIENBIHCO.AddComponent<OKCMKCMQOGD>();
		}
		okcmkcmqogd.ILBCCCBJNCL = NKKGPNPGDEM;
		okcmkcmqogd.IEMGQKFCEHM = IEMGQKFCEHM;
		okcmkcmqogd.KCQKMKOQLQL = null;
		okcmkcmqogd.enabled = false;
		return okcmkcmqogd;
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x0000BC3E File Offset: 0x00009E3E
	private void QBGOGFJCLEP()
	{
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		this.FCGOLKPMQLF = base.GetComponent<FKBFPICKJQG>();
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x0000BC3E File Offset: 0x00009E3E
	private void DBFJHIHLQHO()
	{
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		this.FCGOLKPMQLF = base.GetComponent<FKBFPICKJQG>();
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x000A2E44 File Offset: 0x000A1044
	public static OKCMKCMQOGD FJCEGFKJLCL(GameObject CGHIENBIHCO, Vector3 NKKGPNPGDEM, float IEMGQKFCEHM)
	{
		OKCMKCMQOGD okcmkcmqogd = CGHIENBIHCO.GetComponent<OKCMKCMQOGD>();
		if (okcmkcmqogd == null)
		{
			okcmkcmqogd = CGHIENBIHCO.AddComponent<OKCMKCMQOGD>();
		}
		okcmkcmqogd.ILBCCCBJNCL = NKKGPNPGDEM;
		okcmkcmqogd.IEMGQKFCEHM = IEMGQKFCEHM;
		okcmkcmqogd.KCQKMKOQLQL = null;
		okcmkcmqogd.enabled = true;
		return okcmkcmqogd;
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x000A3088 File Offset: 0x000A1288
	protected virtual void BPCCIMJPJDK()
	{
		float gpfidejemeg = JMIOBJFFGBN.JHEKKFKJCKK();
		bool flag = false;
		Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
		Vector3 vector = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
		if ((vector - this.ILBCCCBJNCL).sqrMagnitude < 371f)
		{
			vector = this.ILBCCCBJNCL;
			base.enabled = false;
			flag = false;
		}
		this.BLLEFKOLKLP.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.BNIINQIELIC();
		pijjjmklmio.x -= vector2.x;
		pijjjmklmio.y -= vector2.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		if (this.FCGOLKPMQLF != null)
		{
			this.FCGOLKPMQLF.IEQQJNLJCKP(false);
		}
		if (flag && this.KCQKMKOQLQL != null)
		{
			OKCMKCMQOGD.OMQCQCBLQGJ = this;
			this.KCQKMKOQLQL();
			OKCMKCMQOGD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x0000BC92 File Offset: 0x00009E92
	private void EGFFPGCMFOO()
	{
		this.NGHLQMCBMQF();
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x000A3188 File Offset: 0x000A1388
	protected virtual void NGHLQMCBMQF()
	{
		float gpfidejemeg = JMIOBJFFGBN.QMLMHDJFJOP();
		bool flag = false;
		Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
		Vector3 vector = JNNGOIIKENH.IKCQOQFIENL(this.BLLEFKOLKLP.localPosition, this.ILBCCCBJNCL, this.IEMGQKFCEHM, gpfidejemeg);
		if ((vector - this.ILBCCCBJNCL).sqrMagnitude < 802f)
		{
			vector = this.ILBCCCBJNCL;
			base.enabled = false;
			flag = true;
		}
		this.BLLEFKOLKLP.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.BNIINQIELIC();
		pijjjmklmio.x -= vector2.x;
		pijjjmklmio.y -= vector2.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		if (this.FCGOLKPMQLF != null)
		{
			this.FCGOLKPMQLF.IEQQJNLJCKP(false);
		}
		if (flag && this.KCQKMKOQLQL != null)
		{
			OKCMKCMQOGD.OMQCQCBLQGJ = this;
			this.KCQKMKOQLQL();
			OKCMKCMQOGD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x0000BC64 File Offset: 0x00009E64
	private void HGKPKMMIPLG()
	{
		this.BPCCIMJPJDK();
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x0000BC6C File Offset: 0x00009E6C
	private void Update()
	{
		this.DGDDGKFKICM();
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x0000BC3E File Offset: 0x00009E3E
	private void EKIFLKDPKNM()
	{
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		this.FCGOLKPMQLF = base.GetComponent<FKBFPICKJQG>();
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x0000BC9A File Offset: 0x00009E9A
	private void OEFEKHJBGPN()
	{
		this.JQCKQHIHHDJ();
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x0000BC3E File Offset: 0x00009E3E
	private void LMMGEGJCBJP()
	{
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		this.FCGOLKPMQLF = base.GetComponent<FKBFPICKJQG>();
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x0000BC3E File Offset: 0x00009E3E
	private void IMGNEDCFBLL()
	{
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		this.FCGOLKPMQLF = base.GetComponent<FKBFPICKJQG>();
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x0000BC92 File Offset: 0x00009E92
	private void HFEGBJEPMPQ()
	{
		this.NGHLQMCBMQF();
	}

	// Token: 0x04000430 RID: 1072
	public static OKCMKCMQOGD OMQCQCBLQGJ;

	// Token: 0x04000431 RID: 1073
	public Vector3 ILBCCCBJNCL = Vector3.zero;

	// Token: 0x04000432 RID: 1074
	public float IEMGQKFCEHM = 10f;

	// Token: 0x04000433 RID: 1075
	public OKCMKCMQOGD.MQQDILIBBJE KCQKMKOQLQL;

	// Token: 0x04000434 RID: 1076
	private KQHJOLQLQBJ CNJGKKDHPOG;

	// Token: 0x04000435 RID: 1077
	private Transform BLLEFKOLKLP;

	// Token: 0x04000436 RID: 1078
	private FKBFPICKJQG FCGOLKPMQLF;

	// Token: 0x020000B0 RID: 176
	// (Invoke) Token: 0x060016C1 RID: 5825
	public delegate void MQQDILIBBJE();
}
